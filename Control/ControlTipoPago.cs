using System;

namespace SAF {
    public class ControlTipoPago : Control {
//      -- Atributos de instancia --
///     <summary> Instancia del ModeloTipoPago usado para acceder a la base de datos. </summary>
        protected new ModeloTipoPago Modelo;
        
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ControlTipoPago.
///     </summary>
        public ControlTipoPago() : base(
            new ModeloTipoPago()
        ) { Modelo = (ModeloTipoPago)base.Modelo; }

//      -- Metodos publicos --
///     <summary>
///         Actualiza el nombre de un tipo de pago identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="sName"> Nuevo nombre. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Update(int iID, string sName) {
            if (iID <= 0)               // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return Modelo.Update(iID, sName) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return Result.Error;
            }
        }

///     <summary>
///         Borra un tipo de pago identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Delete(int iID) {
            if (iID <= 0)               // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return Modelo.Delete(iID) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return Result.Error;
            }
        }
    }
}
