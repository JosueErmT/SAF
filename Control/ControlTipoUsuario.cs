using System;

namespace SAF {
    public class ControlTipoUsuario : Control {
//      -- Atributos de instancia --
        protected new ModeloTipoUsuario Modelo;
        
//      -- Constructor --
        public ControlTipoUsuario() : base(
            new ModeloTipoUsuario()
        ) { Modelo = (ModeloTipoUsuario)base.Modelo; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene los permisos de un tipo de usuario identificado por un ID.
///     </summary>
///     <param name="oPerms"> out Permission con los permisos obtenidos. </param>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public Result GetPermissions(out Permission oPerms, int iID) {
            oPerms = new Permission(0);
            if (iID <= 0)               // Comprueba la entrada
                return Result.IncorrectInput;

            try {
                return (oPerms = Modelo.GetPermissions(iID)) != null ? Result.Success : Result.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion
                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? Result.ConnError : 
                                                                                                          Result.Error;
            }
        }
    }
}
