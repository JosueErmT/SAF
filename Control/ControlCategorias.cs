using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SAF {
    public class ControlCategorias : Control {
//      -- Atributos de instancia --
///     <summary> Instancia del ModeloCategorias usado para acceder a la base de datos. </summary>
        protected new ModeloCategorias Modelo;
        
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ControlCategorias.
///     </summary>
        public ControlCategorias() : base(
            new ModeloCategorias()
        ) { Modelo = (ModeloCategorias)base.Modelo; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene el monto de una categoria identificada por una letra.
///     </summary>
///     <param name="mN"> out decimal con el monto de la categoria. </param>
///     <param name="cLetter"> Letra a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result GetPrice(out decimal mN, char cLetter) {
            mN = -1;
            try {
                mN = Modelo.GetPrice(cLetter);
                return Result.Success;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }

///     <summary>
///         Actualiza el monto de una categoria.
///     </summary>
///     <param name="cLetter"> Letra a buscar. </param>
///     <param name="mPrice"> nuevo monto. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result Update(char cLetter, decimal mPrice) {
            if (cLetter < 'A' || cLetter > 'K' || mPrice <= 0)     // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return Modelo.Update(cLetter, mPrice) ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }
    }
}
