using System;
using System.Collections.Generic;
using System.Linq;

namespace SAF {
/// <summary> Enum con los posibles permisos. </summary>
    public enum Permissions {
        NewBill = 1,
        Bills = 2,
        Users = 4,
        Settings = 8
    }

    public class Permission {
//      -- Atributos de instancia --
///     <summary> Permissions con los permisos. </summary>
        private Permissions nPerms;
///     <summary> Permissions convertidos en IEnumerable. </summary>
        private IEnumerable<Enum> rPerms;

//      -- Propiedades --
///     <summary> true si puede acceder a Nueva Factura. </summary>
        public bool CanAccessNewBill => GetEach(nPerms).Contains(Permissions.NewBill);

///     <summary> true si puede acceder a Facturas. </summary>
        public bool CanAccessBills => GetEach(nPerms).Contains(Permissions.Bills);

///     <summary> true si puede acceder a Usarios. </summary>
        public bool CanAccessUsers => GetEach(nPerms).Contains(Permissions.Users);

///     <summary> true si puede acceder a Ajustes - Negocio. </summary>
        public bool CanAccessSettings => GetEach(nPerms).Contains(Permissions.Settings);

///     <summary> true si los permisos son absolutos (15 = todos los permisos). </summary>
        public bool IsAbsolute { get; private set; }

///     <summary> Cantidad de zonas a las que puede acceder. </summary>
        public int AccessCount => rPerms.Count();

//      -- Constructores --
///     <summary>
///         Inicializa una nueva instancia de Permission.
///     </summary>
///     <param name="nPerms"> Permissions con los permisos. </param>
        public Permission(Permissions nPerms) {
            this.nPerms = nPerms;
            this.rPerms = GetEach(nPerms);

            IsAbsolute = nPerms == (Permissions.NewBill | Permissions.Bills | Permissions.Users | Permissions.Settings);
        }

///     <summary>
///         Inicializa una nueva instancia de Permission.
///     </summary>
///     <param name="iPerms"> int convertible a Permissions con los permisos. </param>
        public Permission(int iPerms) : this(
            (Permissions)iPerms
        ) { }

//      -- Metodos publicos --
///     <summary>
///         Comprueba si unos permisos son mayores que otros.
///     </summary>
///     <param name="oPerms"> Permission a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son mayores a los recibidos por parametro.
///     </returns>
        public bool IsAbove(Permission oPerms) => IsAbove(oPerms.nPerms);
///     <summary>
///         Comprueba si unos permisos son mayores que otros.
///     </summary>
///     <param name="iPerms"> int convertible a Permissions a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son mayores a los recibidos por parametro.
///     </returns>
        public bool IsAbove(int iPerms) => IsAbove((Permissions)iPerms);
///     <summary>
///         Comprueba si unos permisos son mayores que otros.
///     </summary>
///     <param name="nPerms"> Permissions a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son mayores a los recibidos por parametro.
///     </returns>
        public bool IsAbove(Permissions nPerms) {
            IEnumerable<Enum> rPerms = GetEach(nPerms);
            foreach (Permissions nPerm in this.rPerms)
                if (!rPerms.Contains(nPerm))
                    return true;

            return false;
        }

///     <summary>
///         Comprueba si unos permisos son iguales que otros.
///     </summary>
///     <param name="oPerms"> Permission a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son iguales a los recibidos por parametro.
///     </returns>
        public bool IsEqual(Permission oPerms) => IsEqual(oPerms.nPerms);
///     <summary>
///         Comprueba si unos permisos son iguales que otros.
///     </summary>
///     <param name="iPerms"> int convertible a Permissions a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son iguales a los recibidos por parametro.
///     </returns>
        public bool IsEqual(int iPerms) => IsEqual((Permissions)iPerms);
///     <summary>
///         Comprueba si unos permisos son iguales que otros.
///     </summary>
///     <param name="nPerms"> Permissions a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son iguales a los recibidos por parametro.
///     </returns>
        public bool IsEqual(Permissions nPerms) {
            return this.nPerms == nPerms;
        }

///     <summary>
///         Comprueba si unos permisos son menores que otros.
///     </summary>
///     <param name="oPerms"> Permission a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son menores a los recibidos por parametro.
///     </returns>
        public bool IsBelow(Permission oPerms) => IsBelow(oPerms.nPerms);
///     <summary>
///         Comprueba si unos permisos son menores que otros.
///     </summary>
///     <param name="iPerms"> int convertible a Permissions a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son menores a los recibidos por parametro.
///     </returns>
        public bool IsBelow(int iPerms) => IsBelow((Permissions)iPerms);
///     <summary>
///         Comprueba si unos permisos son menores que otros.
///     </summary>
///     <param name="nPerms"> Permissions a evaluar. </param>
///     <returns>
///         true si los permisos de esta instancia son menores a los recibidos por parametro.
///     </returns>
        public bool IsBelow(Permissions nPerms) {
            foreach (Permissions nPerm in GetEach(nPerms))
                if (!this.rPerms.Contains(nPerm))
                    return true;

            return false;
        }

//      -- Metodos privados --
///     <summary>
///         Convierte un Enum en IEnumerable&lt;Enum&gt;
///     </summary>
///     <param name="oEnum"> Enum a convertir. </param>
///     <returns>
///         IEnumerable&lt;Enum&gt; con los valores de oEnum.
///     </returns>
        private IEnumerable<Enum> GetEach(Enum oEnum) {
            return Enum.GetValues(oEnum.GetType()).Cast<Enum>().Where(oEnum.HasFlag);
        }
    }
}
