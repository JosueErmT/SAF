using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows;

namespace SAF {
    public class Modelo {
//      -- Atributos de instancia --
///     <summary> Instancia de Connection para la conexion con la base de datos. </summary>
        protected Connection oConn = new Connection(sDatabase: "saf");
///     <summary> Instancia de MySqlCommand para guardar el ultimo comando ejecutado. </summary>
        protected MySqlCommand oCmd;

//      -- Propiedades --
///     <summary> Tabla sobre la cual realizar las consultas. </summary>
        public string Table { get; set; }
///     <summary> Vista sobre la cual realizar las consultas. </summary>
        public string View { get; set; }

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de Modelo.
///     </summary>
///     <param name="sTable"> Tabla sobre la cual realizar las consultas. </param>
///     <param name="sView"> Vista sobre la cual realizar las consultas. </param>
        public Modelo(string sTable, string sView = null) {
            this.Table = sTable;
            this.View = sView ?? sTable;
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
        public virtual DataTable GetAll(int iOffset = 0, int iLimit = -1, string sWhere = "", string sGroupBy = "", string sOrderBy = "") {
            if (!string.IsNullOrEmpty(sWhere) && !sWhere.TrimStart().StartsWith("WHERE", StringComparison.InvariantCultureIgnoreCase))
                sWhere = $"WHERE {sWhere}";

            if (!string.IsNullOrEmpty(sGroupBy) && !sGroupBy.TrimStart().StartsWith("GROUP BY", StringComparison.InvariantCultureIgnoreCase))
                sGroupBy = $"GROUP BY {sGroupBy}";

            if (!string.IsNullOrEmpty(sOrderBy) && !sOrderBy.TrimStart().StartsWith("ORDER BY", StringComparison.InvariantCultureIgnoreCase))
                sOrderBy = $"ORDER BY {sOrderBy}";

            oCmd = oConn.Command($@"
                SELECT * FROM `{View}`
                {sWhere}
                {sGroupBy}
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
///         Inserta un registro a la tabla.
///         Obtiene las propiedades en el orden en que fueron declaradas del objeto recibido y inserta sus valores en la tabla en dicho orden.
///     </summary>
///     <param name="oRecord"> El objeto a insertar. </param>
///     <returns>
///         true si el registro fue insertado satisfactoriamente.
///     </returns>
        public virtual bool Add(object oRecord) {
            PropertyInfo[] rProps = oRecord.GetType().GetProperties();

            string sVars = "";
            foreach (PropertyInfo oProp in rProps)
                sVars += $"@{oProp.Name},";
            sVars = sVars.Substring(0, sVars.Length - 1);

            oCmd = oConn.Command($@"
                INSERT INTO `{Table}`
                VALUES({sVars})
            ");

            foreach (PropertyInfo oProp in rProps)
                oCmd.Parameters.AddWithValue($"@{oProp.Name}", oProp.GetValue(oRecord));

            int iRt = 0;
            if (oConn.Open()) {
                iRt = oCmd.ExecuteNonQuery();
                oConn.Close();
            }

            return iRt > 0;
        }

///     <summary>
///         Obtiene todas las columnas en la vista.
///     </summary>
///     <returns>
///         Devuelve una List&lt;string&gt; con las columnas.
///     </returns>
        public virtual List<string> GetColumns() {
            oCmd = oConn.Command($@"
                SELECT `COLUMN_NAME` FROM `INFORMATION_SCHEMA`.`COLUMNS`
                WHERE `TABLE_SCHEMA` = '{oConn.Database}' AND `TABLE_NAME` = '{View}' 
            ");

            List<string> oList = new List<string>();
            if (oConn.Open()) {
                MySqlDataReader oRead = oCmd.ExecuteReader();
                while (oRead.HasRows && oRead.Read())
                    oList.Add(oRead.GetString(0));
                oConn.Close();
            }

            return oList;
        }
        
///     <summary>
///         Devuelve el numero de registros en la tabla.
///     </summary>
///     <param name="sWhere"> Valor para la clausula WHERE. </param>
///     <returns>
///         Un int con el numero de registros.
///     </returns>
        public virtual int GetCount(string sWhere = "") {
            if (!string.IsNullOrEmpty(sWhere) && !sWhere.TrimStart().StartsWith("WHERE", StringComparison.InvariantCultureIgnoreCase))
                sWhere = $"WHERE {sWhere}";

            return Convert.ToInt32(Query($@"
                SELECT COUNT(*) FROM `{View}`
                {sWhere}
            ") ?? 0);
        }

///     <summary>
///         Devuelve el valor del AUTO_INCREMENT de la tabla.
///     </summary>
///     <returns>
///         Un int con el valor del AUTO_INCREMENT.
///     </returns>
        public virtual int GetAI() => Convert.ToInt32(Query($@"
            SELECT `AUTO_INCREMENT` FROM `INFORMATION_SCHEMA`.`TABLES`
            WHERE `TABLE_SCHEMA` = '{oConn.Database}' AND `TABLE_NAME` = '{Table}'
        ") ?? -1);

///     <summary>
///         Devuelve una nueva string apta para ser utilizada como valor para una consulta SQL.
///     </summary>
///     <param name="sStr">
///         La string actual a transformar.
///     </param>
///     <returns>
///         Una string semejante a la enviada pero con distintos caracteres modificados para
///         que no interfiera con los caracteres especiales usados en una consulta SQL.
///     </returns>
        public string SqlEscape(string sStr) {
            return MySqlHelper.EscapeString(sStr)
                              .Replace("%", "\\%")
                              .Replace("_", "\\_");
        }

//      -- Metodos privados --
///     <summary>
///         Realiza una consulta en la base de datos. Este metodo es utilizado internamente.
///     </summary>
///     <param name="sQuery">
///         La consulta a realizar.
///     </param>
///     <param name="bScalar">
///         true para usar ExecuteScalar, false para usar ExecuteNonQuery.
///     </param>
///     <returns>
///         Un object coincidente con la consulta realizada si se utiliza ExecuteScalar;
///         Un int indicado la cantidad de filas afectadas si se utiliza ExecuteNonQuery. 
///     </returns>
        protected virtual object Query(string sQuery, bool bScalar = true) {
            oCmd = oConn.Command(sQuery);

            object oRt = null;
            if (oConn.Open()) {
                oRt = bScalar ? oCmd.ExecuteScalar() : oCmd.ExecuteNonQuery();
                oConn.Close();
            }

            return oRt;
        }
    }
}
