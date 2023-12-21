using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace SAF {
    public class ModeloUsuarios : Modelo {
//      -- Propiedades --
///     <summary> ID del negocio al que pertenecen las facturas. </summary>
        public int? Shop { get; set; }

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ModeloUsuarios.
///     </summary>
        public ModeloUsuarios(int? iShop = null) : base(
            sTable: "usuarios",
            sView: "usuariosview"
        ) { Shop = iShop; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene un usuario de la tabla identificado por un DNI.
///     </summary>
///     <param name="iDNI"> DNI a buscar. </param>
///     <returns>
///         Un Usuario con los datos obtenidos, null si no hubo concidencia.
///     </returns>
        public Usuario Get(int iDNI) {
            Usuario oUser = null;

            oCmd = oConn.Command($@"
                SELECT * FROM `{Table}` WHERE `DNI` = {iDNI}
            ");

            if (oConn.Open()) {
                MySqlDataReader oRead = oCmd.ExecuteReader();
                if (oRead.HasRows && oRead.Read()) {
                    oUser = new Usuario() {
                        DNI = Convert.ToInt32(oRead["DNI"]),
                        Pass = Convert.ToString(oRead["pass"]),
                        Nombre = Convert.ToString(oRead["nombre"]),
                        Apellido = Convert.ToString(oRead["apellido"]),
                        Email = Convert.ToString(oRead["email"]),
                        Telefono = Convert.ToString(oRead["telefono"]),
                        Detalles = Convert.ToString(oRead["detalles"]),
                        TipoID = Convert.ToInt32(oRead["tipoID"]),
                        NegocioID = Convert.ToInt32(oRead["negocioID"])
                    };
                }
                oConn.Close();
            }

            return oUser;
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

            DataTable oUsers = base.GetAll(iOffset, iLimit, sWhereFilter, sGroupBy, sOrderBy);
            oUsers.Columns.Remove("negocioID");
            return oUsers;
        }

///     <summary>
///         Modifica los datos de un usuario en la tabla identificado por un DNI.
///     </summary>
///     <param name="iDNI"> DNI a buscar. </param>
///     <param name="oUser"> Usuario con los nuevos datos. </param>
///     <returns>
///         true si el registro fue modificado satisfactoriamente. 
///     </returns>
        public bool Update(int iDNI, Usuario oUser) {
            string s = "";
            if (oUser.DNI != null)
                s += "`DNI` = @DNI";
            if (oUser.Pass != null)
                s += ", `pass` = @Pass";
            if (oUser.Nombre != null)
                s += ", `nombre` = @Nombre";
            if (oUser.Apellido != null)
                s += ", `apellido` = @Apellido";
            if (oUser.Email != null)
                s += ", `email` = @Email";
            if (oUser.Telefono != null)
                s += ", `telefono` = @Telefono";
            if (oUser.Detalles != null)
                s += ", `detalles` = @Detalles";

            oCmd = oConn.Command($@"
                UPDATE `{Table}`
                SET {s}
                WHERE `DNI` = {iDNI} AND `negocioID` = {Shop}
            ");

            oCmd.Parameters.AddWithValue("@DNI", oUser.DNI);
            oCmd.Parameters.AddWithValue("@Pass", oUser.Pass);
            oCmd.Parameters.AddWithValue("@Nombre", oUser.Nombre);
            oCmd.Parameters.AddWithValue("@Apellido", oUser.Apellido);
            oCmd.Parameters.AddWithValue("@Email", oUser.Email);
            oCmd.Parameters.AddWithValue("@Telefono", oUser.Telefono);
            oCmd.Parameters.AddWithValue("@Detalles", oUser.Detalles);

            int iRt = 0;
            if (oConn.Open()) {
                iRt = oCmd.ExecuteNonQuery();
                oConn.Close();
            }

            return iRt > 0;
        }

///     <summary>
///         Elimina un usuario de la tabla identificado por un DNI.
///     </summary>
///     <param name="iDNI"> DNI a buscar. </param>
///     <returns>
///         true si el registro fue eliminado satisfactoriamente.
///     </returns>
        public bool Delete(int iDNI) => (int)Query($@"
            DELETE FROM `{Table}` WHERE `DNI` = '{iDNI}' AND `negocioID` = {Shop}
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
///         Obtiene el numero de registros en la tabla.
///     </summary>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <returns>
///         Un int con el numero de registros.
///     </returns>
        public override int GetCount(string sWhere = "") => base.GetCount($@"
            WHERE `negocioID` = {Shop}{(!string.IsNullOrEmpty(sWhere) ? $" AND ({sWhere})" : "")}
        ");

///     <summary>
///         Obtiene multiples registros de la tabla `usuariologins`, que pertenescan a al negocio identificado por Shop,
///         con la posibilidad de especificar OFFSET y LIMIT, y ordenar por ORDER BY.
///     </summary>
///     <param name="iOffset"> Valor para la clausula OFFSET. </param>
///     <param name="iLimit"> Valor para la clausula LIMIT. </param>
///     <param name="sOrderBy"> Valor para la clausula ORDER BY. </param>
///     <returns>
///         Un DataTable con los registros obtenidos.
///     </returns>
        public DataTable GetLogIns(int iOffset = 0, int iLimit = -1, string sOrderBy = "") {
            if (!string.IsNullOrEmpty(sOrderBy) && !sOrderBy.TrimStart().StartsWith("ORDER BY", StringComparison.InvariantCultureIgnoreCase))
                sOrderBy = $"ORDER BY {sOrderBy}";

            oCmd = oConn.Command($@"
                SELECT
                    CONCAT(
                        `usuarios`.`DNI`, ': ',
                        `usuarios`.`nombre`, ' ',
                        `usuarios`.`apellido`
                    ) AS 'Usuario',
                    `usuariologins`.`fechaHora` AS 'Ultimo LogIn'
                FROM `usuariologins`
                LEFT JOIN `usuarios` ON `usuarios`.`DNI` = `usuariologins`.`usuarioDNI`
                WHERE `usuarios`.`negocioID` = {Shop}
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
///         Agrega un registro a la tabla `usuariologins`.
///     </summary>
///     <param name="iDNI"> DNI del usuario. </param>
///     <param name="oDate"> Fecha de inicio de sesion. </param>
///     <returns>
///         true si el registro fue insertado satisfactoriamente.
///     </returns>
        public bool AddLogIn(int iDNI, DateTime oDate) {
            oCmd = oConn.Command($@"
                INSERT INTO `usuariologins`
                VALUES(@UsuarioDNI, @Fecha)
            ");

            oCmd.Parameters.AddWithValue($"@UsuarioDNI", iDNI);
            oCmd.Parameters.AddWithValue($"@Fecha", oDate);

            int iRt = 0;
            if (oConn.Open()) {
                iRt = oCmd.ExecuteNonQuery();
                oConn.Close();
            }

            return iRt > 0;
        }

///     <summary>
///         Obtiene el numero de registros en la tabla `usuariologins`, que pertenescan a al negocio identificado por Shop.
///     </summary>
///     <returns>
///         Un int con el numero de registros.
///     </returns>
        public int CountLogIns() => Convert.ToInt32(Query($@"
            SELECT COUNT(`usuariologins`.`usuarioDNI`)
            FROM `usuariologins`
            LEFT JOIN `usuarios` ON `usuarios`.`DNI` = `usuariologins`.`usuarioDNI`
            WHERE `usuarios`.`negocioID` = {Shop}   
        ") ?? 0);
    }
}
