using MySqlX.XDevAPI.Common;
using System;
using System.Data;

namespace SAF {
    public class ControlNegocios : Control {
//      -- Atributos de instancia --
///     <summary> Instancia del ModeloNegocios usado para acceder a la base de datos. </summary>
        protected new ModeloNegocios Modelo;
        
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ControlNegocios.
///     </summary>
        public ControlNegocios() : base(
            new ModeloNegocios()
        ) { Modelo = (ModeloNegocios)base.Modelo; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene un Negocio identificado por un ID.
///     </summary>
///     <param name="oShop"> out Negocio con los datos obtenidos </param>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Get(out Negocio oShop, int iID) {
            oShop = null;
            if (iID <= 0)       // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return (oShop = Modelo.Get(iID)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Modifica los datos de un Negocio identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="oShop"> Negocio con los nuevos datos. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Update(int iID, Negocio oShop) {
            if (iID <= 0 || oShop == null)      // Comprueba la entrada
                return Result.IncorrectInput;
            
            try {
                return Modelo.Update(iID, oShop) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;           // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene multiples registros de `negociovacaciones`, que pertenezcan a un negocio identificado por un ID.
///     </summary>
///     <param name="oHolidays"> out DataTable con los registros obtenidos. </param>
///     <param name="iNegocioID"> ID del Negocio. </param>
///     <param name="iOffset"> Cantidad de registros a omitir. </param>
///     <param name="iLimit"> Cantidad de registros maximos a obtener. </param>
///     <param name="sOrderBy"> Valor de ordenamiento. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result GetHolidays(out DataTable oHolidays, int iNegocioID, int iOffset = 0, int iLimit = -1, string sOrderBy = "") {
            oHolidays = null;
            if (iNegocioID <= 0)        // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return (oHolidays = Modelo.GetHolidays(iNegocioID, iOffset, iLimit, sOrderBy)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Agrega un registro a `negociovacaciones`.
///     </summary>
///     <param name="oStartDate"> Fecha de inicio del periodo de vacaciones. </param>
///     <param name="oEndDate"> Fecha de fin del periodo de vacaciones. </param>
///     <param name="iNegocioID"> ID del Negocio. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result AddHoliday(DateTime oStartDate, DateTime oEndDate, int iNegocioID) {
            if (iNegocioID <= 0)        // Comprueba la entrada
                return Result.IncorrectInput;
            
            try {
                return Modelo.AddHoliday(oStartDate, oEndDate, iNegocioID) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Modifica los datos de un registro en la tabla `negociovacaciones` identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="oStartDate"> Nueva fecha de inicio del periodo de vacaciones. </param>
///     <param name="oEndDate"> Nueva fecha de fin del periodo de vacaciones. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result UpdateHoliday(int iID, DateTime oStartDate, DateTime oEndDate) {
            if (iID <= 0)               // Comprueba la entrada
                return Result.IncorrectInput;
            
            try {
                return Modelo.UpdateHoliday(iID, oStartDate, oEndDate) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Borra un registro de `negociovacaciones` identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result DeleteHoliday(int iID) {
            if (iID <= 0)               // Comprueba la entrada
                return Result.IncorrectInput;
            
            try {
                return Modelo.DeleteHoliday(iID) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Obtiene el numero de registros en la tabla `negociovacaciones`.
///     </summary>
///     <param name="iCount"> out int con el numero de registros. </param>
///     <param name="iNegocioID"> ID del Negocio. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result CountHolidays(out int iCount, int iNegocioID) {
            iCount = -1;
            if (iNegocioID <= 0)        // Comprueba la entrada
                return Result.IncorrectInput;
            
            try {
                iCount = Modelo.GetHolidaysCount(iNegocioID);
                return Result.Success;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }
    }
}
