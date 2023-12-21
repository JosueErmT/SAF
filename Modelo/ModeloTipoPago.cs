using System;

namespace SAF {
    public class ModeloTipoPago : Modelo {
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ModeloTipoPago.
///     </summary>
        public ModeloTipoPago() : base(
            sTable: "tipopago",
            sView: "tipopagoview"
        ) { }

//      -- Metodos publicos --
///     <summary>
///         Actualiza el nombre de un registro identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <param name="sName"> Nombre a actualizar. </param>
///     <returns>
///         true si el registro fue actualizado satisfactoriamente.
///     </returns>
        public bool Update(int iID, string sName) => (int)Query($@"
            UPDATE `{Table}`
            SET `nombre` = '{sName}'
            WHERE `ID` = '{iID}'
        ", false) > 0;

///     <summary>
///         Borra un registro de la tabla identificado por un ID.
///     </summary>
///     <param name="iID"> ID a buscar. </param>
///     <returns>
///         true si el registro fue eliminado satisfactoriamente.
///     </returns>
        public bool Delete(int iID) => (int)Query($@"
            DELETE FROM `{Table}` WHERE `ID` = '{iID}'
        ", false) > 0;
    }
}
