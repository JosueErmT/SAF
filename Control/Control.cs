using System;
using System.Collections.Generic;
using System.Data;

namespace SAF {
/// <summary> Enum con los posibles resultados de las operaciones del Control. </summary>
    public enum Result {
        ConnError = -1,
        Error = 0,
        Failed = 1,
        Success = 2,
        Canceled = 3,
        IncorrectInput = 4
    }

    public class Control {
//      -- Propiedades --
///     <summary> Instancia del Modelo usado para acceder a la base de datos. </summary>
        protected Modelo Modelo { get; set; }

///     <summary> Contiene la ultima excepcion controlada. </summary>
        public Exception LastError { get; protected set; }

///     <summary> String de la clausula WHERE para filtrar las busquedas. </summary>
        public string Where { get; set; }
        
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de Control.
///     </summary>
        public Control(Modelo oModelo) {
            this.Modelo = oModelo;
        }

///     <summary>
///         Obtiene multiples registros de la tabla del Modelo.
///     </summary>
///     <param name="oTable"> out DataTable con los registros obtenidos. </param>
///     <param name="iOffset"> Cantidad de registros a omitir. </param>
///     <param name="iLimit"> Cantidad de registros maximos a obtener. </param>
///     <param name="sGroupBy"> Valor de agrupacion. </param>
///     <param name="sOrderBy"> Valor de ordenamiento. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public virtual Result GetAll(out DataTable oTable, int iOffset = 0, int iLimit = -1, 
                                     string sGroupBy = "", string sOrderBy = "") {
            oTable = null;
            try {
                return (oTable = Modelo.GetAll(iOffset, iLimit, Where, sGroupBy, sOrderBy)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Agrega un registro en la tabla del Modelo.
///     </summary>
///     <param name="oRecord"> Objecto a agregar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public virtual Result Add(object oRecord) {
            try {
                return Modelo.Add(oRecord) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene las columnas de la tabla del Modelo.
///     </summary>
///     <param name="oColumns"> out List&lt;string&gt; con las columnas obtenidas. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public virtual Result GetColumns(out List<string> oColumns) {
            oColumns = null;
            try {
                return (oColumns = Modelo.GetColumns()) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Devuelve el numero de registros en la tabla del Modelo.
///     </summary>
///     <param name="iCount"> out int con el numero de registros. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public virtual Result GetCount(out int iCount) {
            iCount = -1;
            try {
                iCount = Modelo.GetCount(Where);
                return Result.Success;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Devuelve el valor del AUTO_INCREMENT de la tabla del Modelo.
///     </summary>
///     <param name="iAI"> out int con el valor del AUTO_INCREMENT. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public virtual Result GetAI(out int iAI) {
            iAI = -1;
            try {
                return (iAI = Modelo.GetAI()) != -1 ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene una string utilizable como filtro de futuras consultas SQL para la clausula WHERE.
///         Filtra por contenido en una o todas las columnas de la tabla.
///     </summary>
///     <param name="iSearchCol"> Indice de la columna en donde buscar (-1 = todas). </param>
///     <param name="sSearchFor"> Valor a buscar en las columnas. </param>
///     <returns>
///         Una string para una clausula WHERE.
///     </returns>
        public virtual void SetWhereFilter(int iSearchCol = -1, string sSearchFor = "") {
            string sWhere = "";
            
//          Filtrado por contenido
            if (!string.IsNullOrEmpty(sSearchFor) && this.GetColumns(out List<string> rCols) == Result.Success) {
                if (iSearchCol > -1)    // -1 = Buscar en todas la columnas
                    sWhere = $"`{rCols[iSearchCol]}` LIKE '%{Modelo.SqlEscape(sSearchFor)}%'";
                else {                  // Buscar en una columna especifica
                    sWhere = $"(";
                    foreach (string sCol in rCols)
                        sWhere += $"`{sCol}` LIKE '%{Modelo.SqlEscape(sSearchFor)}%' OR ";
                    sWhere = sWhere.Substring(0, sWhere.Length - 4) + ")";
                }
            }

            Where = sWhere;
        }
    }
}
