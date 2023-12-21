using System;

namespace SAF {
    public class ModeloCategorias : Modelo {
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ModeloCategorias.
///     </summary>
        public ModeloCategorias() : base(
            sTable: "categorias",
            sView: "categoriasview"
        ) { }

//      -- Metodos publicos --
///     <summary>
///         Obtiene el monto de una categoria identificada por una letra.
///     </summary>
///     <param name="cLetter"> Letra a buscar. </param>
///     <returns>
///         El monto de la categoria.
///     </returns>
        public decimal GetPrice(char cLetter) => Query($@"
            SELECT `monto` FROM `{Table}`
            WHERE letra = '{SqlEscape(cLetter.ToString())}'
        ") as decimal? ?? 0;

///     <summary>
///         Modifica el monto de un registro identificado por una letra. 
///     </summary>
///     <param name="cLetter"> Letra a buscar. </param>
///     <param name="mPrice"> Monto a actualizar. </param>
///     <returns>
///         true si el registro fue actualizado satisfactoriamente.
///     </returns>
        public bool Update(char cLetter, decimal mPrice) => (int)Query($@"
            UPDATE `{Table}`
            SET monto = '{mPrice}'
            WHERE letra = '{SqlEscape(cLetter.ToString())}'
        ", false) > 0;
    }
}
