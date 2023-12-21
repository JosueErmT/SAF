using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SAF {
    public class ModeloNegocios : Modelo {
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ModeloNegocios.
///     </summary>
        public ModeloNegocios() : base(
            sTable: "negocios"
        ) { }

//      -- Metodos publicos --
///     <summary>
///         Obtiene un Negocio de la tabla identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Un Negocio con los datos obtenidos, null si no hubo concidencia.
///     </returns>
        public Negocio Get(int iID) {
            Negocio oShop = null;

            oCmd = oConn.Command($@"
                SELECT * FROM `{Table}` WHERE `ID` = {iID}
            ");

            if (oConn.Open()) {
                MySqlDataReader oRead = oCmd.ExecuteReader();
                if (oRead.HasRows && oRead.Read()) {
                    oShop = new Negocio() {
                        ID = Convert.ToInt32(oRead["ID"]),
                        DiasSemanales = Convert.ToInt32(oRead["diasSemanales"]),
                        CategoriaLetra = Convert.ToChar(oRead["categoriaLetra"])
                    };
                }
                oConn.Close();
            }

            return oShop;
        }

///     <summary>
///         Modifica los datos de un Negocio en la tabla identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="oShop"> Negocio con los nuevos datos. </param>
///     <returns>
///         true si el registro fue modificado satisfactoriamente. 
///     </returns>
        public bool Update(int iID, Negocio oShop) => (int)Query($@"
            UPDATE `{Table}`
            SET `diasSemanales` = {oShop.DiasSemanales},
                `categoriaLetra` = '{SqlEscape(oShop.CategoriaLetra.ToString())}'
            WHERE `ID` = '{iID}'
        ", false) > 0;

///     <summary>
///         Obtiene multiples registros de la tabla `negociovacaciones`, que pertenezcan a un negocio identificado por un ID,
///         con la posibilidad de especificar OFFSET y LIMIT, y ordenar por ORDER BY.
///     </summary>
///     <param name="iNegocioID"> ID del Negocio. </param>
///     <param name="iOffset"> Valor para la clausula OFFSET. </param>
///     <param name="iLimit"> Valor para la clausula LIMIT. </param>
///     <param name="sOrderBy"> Valor para la clausula ORDER BY. </param>
///     <returns>
///         Un DataTable con los registros obtenidos.
///     </returns>
        public DataTable GetHolidays(int iNegocioID, int iOffset = 0, int iLimit = -1, string sOrderBy = "") {
            if (!string.IsNullOrEmpty(sOrderBy) && !sOrderBy.TrimStart().StartsWith("ORDER BY", StringComparison.InvariantCultureIgnoreCase))
                sOrderBy = $"ORDER BY {sOrderBy}";

            oCmd = oConn.Command($@"
                SELECT 
                    `ID` AS 'ID',
                    `fechaInicio` AS 'Fecha de inicio',
                    `fechaFin` AS 'Fecha de fin'
                FROM `negociovacaciones`
                WHERE `negocioID` = {iNegocioID}
                {sOrderBy}
                {(iLimit > -1 ? $"LIMIT {iOffset}, {iLimit}" : "")}
            ");

            DataTable oDT = new DataTable();
            if (oConn.Open()) {
                new MySqlDataAdapter(oCmd).Fill(oDT);
                oConn.Close();
            }

            return oDT;
        }

///     <summary>
///         Agrega un registro a la tabla `negociovacaciones`.
///     </summary>
///     <param name="oStartDate"> Fecha de inicio del periodo de vacaciones. </param>
///     <param name="oEndDate"> Fecha de fin del periodo de vacaciones. </param>
///     <param name="iNegocioID"> ID del Negocio. </param>
///     <returns>
///         true si el registro fue insertado satisfactoriamente.
///     </returns>
        public bool AddHoliday(DateTime oStartDate, DateTime oEndDate, int iNegocioID) {
            oCmd = oConn.Command($@"
                INSERT INTO `negociovacaciones`
                VALUES(@ID, @FechaInicio, @FechaFin, @NegocioID)
            ");

            oCmd.Parameters.AddWithValue("@ID", null);
            oCmd.Parameters.AddWithValue("@FechaInicio", oStartDate);
            oCmd.Parameters.AddWithValue("@FechaFin", oEndDate);
            oCmd.Parameters.AddWithValue("@NegocioID", iNegocioID);

            int iRt = 0;
            if (oConn.Open()) {
                iRt = oCmd.ExecuteNonQuery();
                oConn.Close();
            }

            return iRt > 0;
        }
        
///     <summary>
///         Modifica los datos de un registro en la tabla `negociovacaciones` identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="oStartDate"> Nueva fecha de inicio del periodo de vacaciones. </param>
///     <param name="oEndDate"> Nueva fecha de fin del periodo de vacaciones. </param>
///     <returns>
///         true si el registro fue modificado satisfactoriamente. 
///     </returns>
        public bool UpdateHoliday(int iID, DateTime oStartDate, DateTime oEndDate) => (int)Query($@"
            UPDATE `negociovacaciones`
            SET `fechaInicio` = '{oStartDate.ToString("yyyy-MM-dd")}',
                `fechaFin` = '{oEndDate.ToString("yyyy-MM-dd")}'
            WHERE `ID` = '{iID}'
        ", false) > 0;

///     <summary>
///         Borra un registro de la tabla `negociovacaciones` identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         true si el registro fue eliminado satisfactoriamente.
///     </returns>
        public bool DeleteHoliday(int iID) => (int)Query($@"
            DELETE FROM `negociovacaciones`
            WHERE `ID` = '{iID}'
        ", false) > 0;

///     <summary>
///         Obtiene el numero de registros en la tabla `negociovacaciones`.
///     </summary>
///     <param name="iNegocioID"> ID del Negocio. </param>
///     <returns>
///         Un int con el numero de registros.
///     </returns>
        public int GetHolidaysCount(int iNegocioID) => Convert.ToInt32(Query($@"
            SELECT COUNT(*) FROM `negociovacaciones`
            WHERE `negocioID` = {iNegocioID}
        "));
    }
}
