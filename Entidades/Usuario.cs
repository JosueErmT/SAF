using System;

namespace SAF {
    public class Usuario {
        public int? DNI { get; set; }

        public string Pass { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Detalles { get; set; }

        public int? TipoID { get; set; }

        public int? NegocioID { get; set; }

        public override string ToString() {
            return DNI + ": " + Nombre + " " + Apellido;
        }
    }
}
