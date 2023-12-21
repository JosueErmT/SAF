using System;

namespace SAF {
    public class ModeloTipoUsuario : Modelo {
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ModeloTipoUsuario.
///     </summary>
        public ModeloTipoUsuario() : base(
            sTable: "tipousuario"
        ) { }

///     <summary>
///         Obtiene los permisos de un tipo de usuario identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         Un Permission con los permisos obtenidos.
///     </returns>
        public Permission GetPermissions(int iID) => new Permission(Convert.ToInt32(Query($@"
            SELECT `permisos` FROM `{Table}`
            WHERE `ID` = {iID}
        ")));
    }
}
