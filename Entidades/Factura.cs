using System;

namespace SAF {
    public class Factura {
        public int? ID { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public string Descripcion { get; set; }

        public int TipoPagoID { get; set; }

        public int? UsuarioDNI { get; set; }

        public int? NegocioID { get; set; }

        public override string ToString() {
            return "";
        }
    }
}
