using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAF {
    public class ModeloFacturas : Modelo {
//      -- Propiedades --
///     <summary> ID del negocio al que pertenecen las facturas. </summary>
        public int? Shop { get; set; }

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ModeloFactura.
///     </summary>
        public ModeloFacturas(int? iShop = null) : base(
            sTable: "facturas",
            sView: "facturasview"
        ) { Shop = iShop; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene una factura de la tabla identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Una Factura con los datos obtenidos, null si no hubo concidencia.
///     </returns>
        public Factura Get(int iID) {
            Factura oBill = null;

            oCmd = oConn.Command($@"
                SELECT * FROM `{Table}` WHERE `ID` = @ID AND `negocioID` = {Shop}
            ");
            oCmd.Parameters.AddWithValue("@ID", iID);

            if (oConn.Open()) {
                MySqlDataReader oRead = oCmd.ExecuteReader();
                if (oRead.HasRows && oRead.Read()) {
                    oBill = new Factura() {
                        ID = Convert.ToInt32(oRead["ID"]),
                        Fecha = Convert.ToDateTime(oRead["fecha"]),
                        Monto = Convert.ToDecimal(oRead["monto"]),
                        TipoPagoID = Convert.ToInt32(oRead["tipoPagoID"]),
                        Descripcion = Convert.ToString(oRead["descripcion"]),
                        UsuarioDNI = Convert.ToInt32(oRead["usuarioDNI"]),
                        NegocioID = Convert.ToInt32(oRead["negocioID"])
                    };
                }
                oConn.Close();
            }

            return oBill;
        }

///     <summary>
///         Obtiene multiples registros de la vista, con la posibilidad de especificar OFFSET y LIMIT,
///         filtrar con la clausula WHERE, agrupar mediante GROUP BY, y ordenar por ORDER BY.
///     </summary>
///     <param name="iOffset"> Valor para la clausula OFFSET. </param>
///     <param name="iLimit"> Valor para la clausula LIMIT. </param>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <param name="sGroupBy"> Valor para la clausula GROUP BY. </param>
///     <param name="sOrderBy"> Valor para la clausula ORDER BY. </param>
///     <returns>
///         Un DataTable con los registros obtenidos.
///     </returns>
        public override DataTable GetAll(int iOffset = 0, int iLimit = -1, string sWhere = "", string sGroupBy = "", string sOrderBy = "") {
            string sWhereFilter = $"WHERE `negocioID` = {Shop} ";
            if (!string.IsNullOrEmpty(sWhere) && !sWhere.TrimStart().StartsWith("AND", StringComparison.InvariantCultureIgnoreCase))
                sWhereFilter += $"AND ({sWhere})";
            else
                sWhereFilter += sWhere;

            DataTable oBills = base.GetAll(iOffset, iLimit, sWhereFilter, sGroupBy, sOrderBy);
            oBills.Columns.Remove("negocioID");
            return oBills;
        }

///     <summary>
///         Modifica los datos de una Factura en la tabla identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="oBill"> Factura con los nuevos datos. </param>
///     <returns>
///         true si el registro fue modificado satisfactoriamente. 
///     </returns>
        public bool Update(int iID, Factura oBill) {
            oCmd = oConn.Command($@"
                UPDATE `{Table}`
                SET `ID` = @ID,
                    `fecha` = @Fecha,
                    `monto` = @Monto,
                    `descripcion` = @Descripcion,
                    `tipoPagoID` = @TipoPagoID
                WHERE `ID` = {iID} AND `negocioID` = {Shop}
            ");

            oCmd.Parameters.AddWithValue("@ID", oBill.ID);
            oCmd.Parameters.AddWithValue("@Fecha", oBill.Fecha);
            oCmd.Parameters.AddWithValue("@Monto", oBill.Monto);
            oCmd.Parameters.AddWithValue("@Descripcion", oBill.Descripcion);
            oCmd.Parameters.AddWithValue("@TipoPagoID", oBill.TipoPagoID);

            int iRt = 0;
            if (oConn.Open()) {
                iRt = oCmd.ExecuteNonQuery();
                oConn.Close();
            }

            return iRt > 0;
        }

///     <summary>
///         Borra un registro de la tabla identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         true si el registro fue eliminado satisfactoriamente.
///     </returns>
        public bool Delete(int iID) => (int)Query($@"
            DELETE FROM `{Table}` WHERE `ID` = '{iID}' AND `negocioID` = {Shop}
        ", false) > 0;
        
///     <summary>
///         Obtiene todas las columnas en la vista.
///     </summary>
///     <returns>
///         Devuelve una List<string> con las columnas.
///     </returns>
        public override List<string> GetColumns() {
            List<string> oColumns = base.GetColumns();
            oColumns.Remove("negocioID");
            return oColumns;
        }

///     <summary>
///         Obtiene la suma de todos los montos en la vista.
///     </summary>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <returns>
///         Un numero decimal con el resultado de la suma, 0 si este fue nulo.
///     </returns>
        public decimal SumPrice(string sWhere = "") => Query($@"
            SELECT SUM(`Monto`) FROM `{View}`
            WHERE `negocioID` = {Shop}{(!string.IsNullOrEmpty(sWhere) ? $" AND ({sWhere})" : "")}
        ") as decimal? ?? 0;

///     <summary>
///         Devuelve el numero de registros en la tabla.
///     </summary>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <returns>
///         Un int con el numero de registros.
///     </returns>
        public override int GetCount(string sWhere = "") => base.GetCount($@"
            WHERE `negocioID` = {Shop}{(!string.IsNullOrEmpty(sWhere) ? $" AND ({sWhere})" : "")}
        ");

///     <summary>
///         Obtiene la cantidad de facturas con cada tipo de pago en la vista.
///     </summary>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <returns>
///         Un DataTable con una columna 'Tipo de pago' con los tipos, y otra llamada 'Count' con la cantidad.
///     </returns>
        public DataTable CountPayTypes(string sWhere = "") {
            if (!string.IsNullOrEmpty(sWhere) && !sWhere.TrimStart().StartsWith("AND", StringComparison.InvariantCultureIgnoreCase))
                sWhere = $"AND ({sWhere})";

            oCmd = oConn.Command($@"
                SELECT `Tipo de pago`, COUNT(`Tipo de pago`) AS 'Count' FROM `{View}`
                WHERE `negocioID` = {Shop} {sWhere}
                GROUP BY `Tipo de pago`
            ");

            DataTable oDT = new DataTable();
            if (oConn.Open()) {
                new MySqlDataAdapter(oCmd).Fill(oDT);
                oConn.Close();
            }

            return oDT;
        }

///     <summary>
///         Realiza una consulta personalizada usando GROUP BY.
///     </summary>
///     <param name="sSelect"> Valor para la clausula SELECT. </param>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <param name="sGroupBy"> Valor para la clausula GROUP BY. </param>
///     <returns>
///         Un DataTable con los registros obtenidos.
///     </returns>
        public DataTable GroupBy(string sSelect, string sWhere = "", string sGroupBy = "") {
            if (!string.IsNullOrEmpty(sGroupBy) && !sGroupBy.TrimStart().StartsWith("GROUP BY", StringComparison.InvariantCultureIgnoreCase))
                sGroupBy = $"GROUP BY {sGroupBy}";

            oCmd = oConn.Command($@"
                SELECT {sSelect} FROM `{Table}`
                WHERE `negocioID` = {Shop}{(!string.IsNullOrEmpty(sWhere) ? $" AND ({sWhere})" : "")}
                {sGroupBy}
            ");

            DataTable oDT = new DataTable();
            if (oConn.Open()) {
                new MySqlDataAdapter(oCmd).Fill(oDT);
                oConn.Close();
            }

            return oDT;
        }

///     <summary>
///         Obtiene la fecha mas vieja en los registro de la tabla.
///     </summary>
///     <returns>
///         Un DateTime con la fecha.
///     </returns>
        public DateTime? GetEarliestDate() {
            object oDate = Query($@"
                SELECT MIN(`fecha`) FROM `{Table}`
                WHERE `negocioID` = {Shop}
            ");
            return oDate == null ? null : Convert.ToDateTime(oDate) as DateTime?;
        }
    }
}
