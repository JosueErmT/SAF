using System;
using System.Data;
using System.Security.Cryptography;

namespace SAF {
    public class ControlFacturas : Control {
//      -- Atributos de instancia --
///     <summary> Instancia del ModeloFacturas usado para acceder a la base de datos. </summary>
        protected new ModeloFacturas Modelo;

//      -- Propiedades --
///     <summary> Instancia del Negocio del modelo. </summary>
        public int? Shop {
            get => Modelo.Shop;
            set => Modelo.Shop = value;
        }

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ControlFacturas.
///     </summary>
        public ControlFacturas(Usuario oUser = null) : base(
            new ModeloFacturas(oUser?.NegocioID ?? null)
        ) { Modelo = (ModeloFacturas)base.Modelo; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene una Factura identificada por su ID, comprobando la entrada y controlando excepciones.
///     </summary>
///     <param name="oBill"> out Factura con los valores obtenidos. </param>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Get(out Factura oBill, int iID) {
            oBill = null;
            if (iID <= 0)       // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return (oBill = Modelo.Get(iID)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Agrega una nueva Factura al sistema, comprobando la entrada y controlando excepciones.
///     </summary>
///     <param name="oBill"> Factura a insertar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Add(Factura oBill) { 
            if (oBill == null || oBill.UsuarioDNI == null || oBill.UsuarioDNI <= 0)     // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return Modelo.Add(oBill) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Modifica los datos de una Factura identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="oBill"> Factura con los nuevos datos. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Update(int iID, Factura oBill) {
            if (iID <= 0 || oBill == null)     // Comprueba la entrada
                return Result.IncorrectInput;
            
            try {
                return Modelo.Update(iID, oBill) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Elimina una Factura del sistema por un ID, comprobando la entrada y controlando excepciones.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Delete(int iID) {
            if (iID <= 0)       // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return Modelo.Delete(iID) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Elimina una Factura del sistema, comprobando la entrada y controlando excepciones.
///     </summary>
///     <param name="oBill"> Factura con el ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Delete(Factura oBill) {
            if (oBill == null || oBill.ID == null)      // Comprueba la entrada
                return Result.IncorrectInput;
            return this.Delete((int)oBill.ID);
        }

///     <summary>
///         Obtiene la suma de todos los montos de las Facturas.
///     </summary>
///     <param name="mN"> out decimal con la suma. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result SumPrice(out decimal mN) {
            mN = 0;
            try {
                mN = Modelo.SumPrice(Where);
                return Result.Success;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene la cantidad de facturas con cada tipo de pago.
///     </summary>
///     <param name="oTable"> out DataTable con una columna 'Tipo de pago' con los tipos, y otra llamada 'Count' con la cantidad. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result CountPayTypes(out DataTable oTable) {
            oTable = null;
            try {
                return (oTable = Modelo.CountPayTypes(Where)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }
        
///     <summary>
///         Realiza una consulta personalizada en el Modelo usando GROUP BY.
///     </summary>
///     <param name="oTable"> out DataTable con los registros obtenidos. </param>
///     <param name="iSelect"> Valor para la clausula SELECT. </param>
///     <param name="sGroupBy"> Valor para la clausula GROUP BY. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public virtual Result GroupBy(out DataTable oTable, string iSelect, string sGroupBy = "") {
            oTable = null;
            try {
                return (oTable = Modelo.GroupBy(iSelect, Where, sGroupBy)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError :
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene la fecha mas vieja en la de la Factura mas vieja.
///     </summary>
///     <param name="oDate"> out DateTime con la fecha. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result GetEarliestDate(out DateTime? oDate) {
            oDate = null;
            try {
                return (oDate = Modelo.GetEarliestDate()) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene una string utilizable como filtro de futuras consultas SQL para la clausula WHERE.
///         Filtra por contenido en una o todas las columnas de la tabla, y por rango de fecha.
///     </summary>
///     <param name="iSearchCol">
///         Indice de la columna en donde buscar (-1 = todas).
///     </param>
///     <param name="sSearchFor">
///         Valor a buscar en las columnas.
///     </param>
///     <param name="oStart">
///         Fecha mas antigua por la cual filtrar.
///     </param>
///     <param name="oEnd">
///         Fecha mas reciente por la cual filtrar.
///     </param>
///     <returns>
///         Una string para una clausula WHERE.
///     </returns>
        public void SetWhereFilter(int iSearchCol = -1, string sSearchFor = "", DateTime? oStart = null, DateTime? oEnd = null) {
            if (iSearchCol == -1) {
                if (DateTime.TryParse(sSearchFor, out DateTime oSearchForDate))
                    sSearchFor = oSearchForDate.ToString("yyyy-MM-dd");
            }
            else if (iSearchCol == 1) {
                if (DateTime.TryParse(sSearchFor, out DateTime oSearchForDate))
                    sSearchFor = oSearchForDate.ToString("yyyy-MM-dd");
                else
                    sSearchFor = sSearchFor.Replace("/", "-");
            }

//          Filtado por contenido
            base.SetWhereFilter(iSearchCol, sSearchFor);

//          Filtado por fecha
            if (oStart.HasValue) {
                string sStart = ((DateTime)oStart).ToString("yyyy-MM-dd");  // Formato de fecha de MySQL
                if (!oEnd.HasValue)     // Solo fecha de inicio:
                    Where += $"{(Where == "" ? "" : " AND")} `Fecha` >= '{sStart}'";
                else {                  // Fecha de inicio y fecha de fin:
                    string sEnd = ((DateTime)oEnd).ToString("yyyy-MM-dd");  // Formato de fecha de MySQL
                    Where += $"{(Where == "" ? "" : " AND")} `Fecha` BETWEEN '{sStart}' AND '{sEnd}'";
                }
            }
            else if (oEnd.HasValue) {   // Solo fecha de fin:
                string sEnd = ((DateTime)oEnd).ToString("yyyy-MM-dd");      // Formato de fecha de MySQL
                Where += $"{(Where == "" ? "" : " AND")} `Fecha` <= '{sEnd}'";
            }
        }
    }
}
