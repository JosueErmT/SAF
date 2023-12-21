using MySqlX.XDevAPI.Common;
using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Windows;

namespace SAF {
/// <summary> Enum con los posibles resultados de las operaciones del ControlUsuarios. </summary>
    public enum UsuarioResult {
        ConnError = -1,
        Error = 0,
        Failed = 1,
        Success = 2,
        Canceled = 3,
        UserExists = 4,
        IncorrectUserPass = 5,
        IncorrectInput = 6
    }

    public class ControlUsuarios : Control {
//      -- Atributos de instancia --
///     <summary> Instancia del Modelo usado para acceder a la base de datos. </summary>
        protected new ModeloUsuarios Modelo;

//      -- Propiedades --
///     <summary> Instancia del Negocio del modelo. </summary>
        public int? Shop {
            get => Modelo.Shop;
            set => Modelo.Shop = value;
        }

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de ControlUsuarios.
///     </summary>
        public ControlUsuarios(Usuario oUser = null) : base(
            new ModeloUsuarios(oUser?.NegocioID ?? null)
        ) { Modelo = (ModeloUsuarios)base.Modelo; }

//      -- Metodos publicos --
///     <summary>
///         Obtiene un usuario identificado por un DNI.
///     </summary>
///     <param name="oUser"> out Usuario con los datos obtenidos. </param>
///     <param name="iDNI"> DNI a buscar. </param>
///     <returns>
///         UsuarioResult indicando el resultado.
///     </returns>
        public UsuarioResult Get(out Usuario oUser, int iDNI) {
            oUser = null;
            if (iDNI <= 0)              // Comprueba la entrada
                return UsuarioResult.IncorrectInput;

            try {
                return (oUser = Modelo.Get(iDNI)) != null ? UsuarioResult.Success : UsuarioResult.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;   // Guarda la ultima excepcion

                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                          UsuarioResult.Error;
            }
        }

///     <summary>
///         Inicia la sesion de un usuario, comprobando la entrada y controlando excepciones.
///         A partir del DNI, obtiene el usuario correspondiente si existe, y comprueba que la contraseña especificada sea correcta.
///     </summary>
///     <param name="iDNI"> DNI del usuario. </param>
///     <param name="sPass"> Contraseña del usuario. </param>
///     <param name="oCallback">
///         Funcion a la que llamar una vez resulto el inicio de sesion.
///         Esta funcion debe tener dos paramentos:
///             - UsuarioResult inicando el resultado,
///             - Usuario con los datos obtenidos.
///     </param>
        public void LogIn(int iDNI, string sPass, Action<UsuarioResult, Usuario> oCallback) {
            UsuarioResult nResult = UsuarioResult.Error;
            Usuario oUser = null;

            BackgroundWorker oBW = new BackgroundWorker();
            oBW.DoWork += (sender, e) => {
                if (iDNI <= 0 || string.IsNullOrEmpty(sPass))    // Comprueba la entrada
                    nResult = UsuarioResult.IncorrectInput;
                else {
                    try {
                        oUser = Modelo.Get(iDNI);
                        nResult = oUser != null && Password.Verify(sPass, oUser.Pass) ?
                                  UsuarioResult.Success : UsuarioResult.IncorrectUserPass;
                        if (nResult == UsuarioResult.Success)
                            Modelo.AddLogIn((int)oUser.DNI, DateTime.Now);
                    }
                    catch (Exception oEx) {
                        this.LastError = oEx;     // Guarda la ultima excepcion

                        nResult = oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                                     UsuarioResult.Error;
                    }
                }
            };
            oBW.RunWorkerCompleted += (sender, e) => {
                oCallback(nResult, oUser);
            };
            oBW.RunWorkerAsync();
        }

///     <summary>
///         Inicia la sesion de un usuario, comprobando la entrada y controlando excepciones.
///         A partir del DNI, obtiene el usuario correspondiente si existe, y comprueba que la contraseña especificada sea correcta.
///     </summary>
///     <param name="iDNI"> DNI del usuario. </param>
///     <param name="sPass"> Contraseña del usuario. </param>
///     <param name="oCallback">
///         Funcion a la que llamar una vez resuelto el inicio de sesion.
///         Esta funcion debe tener dos paramentos:
///             - UsuarioResult inicando el resultado,
///     </param>
        public void LogIn(int iDNI, string sPass, Action<UsuarioResult> oCallback) => LogIn(
            iDNI, sPass, (nResult, oUser) => oCallback(nResult)
        );

///     <summary>
///         Registra un nuevo usuario en el sistema, comprobando la entrada y controlando excepciones.
///     </summary>
///     <param name="oUser"> Usuario a registrar. </param>
///     <param name="oCallback">
///         Funcion a la que llamar una vez resuelto el registro.
///         Esta funcion debe tener un paramento:
///             - UsuarioResult inicando el resultado.
///     </param>
        public void SignUp(Usuario oUser, Action<UsuarioResult> oCallback) { 
            UsuarioResult nResult = UsuarioResult.Error;

            BackgroundWorker oBW = new BackgroundWorker();
            oBW.DoWork += (sender, e) => {
                if (oUser == null || oUser.DNI == null || oUser.DNI <= 0 || string.IsNullOrEmpty(oUser.Pass) || oUser.TipoID == null)    // Comprueba la entrada
                    nResult = UsuarioResult.IncorrectInput;
            
                oUser.Pass = Password.Hash(oUser.Pass);

                try {
                    nResult = Modelo.Add(oUser) ? UsuarioResult.Success : UsuarioResult.Error;
                }
                catch (Exception oEx) {
                    this.LastError = oEx;     // Guarda la ultima excepcion

                    nResult = oEx.Message.StartsWith("Duplicate entry") ? UsuarioResult.UserExists :
                              oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                                 UsuarioResult.Error;
                }
            };
            oBW.RunWorkerCompleted += (sender, e) => {
                oCallback(nResult);
            };
            oBW.RunWorkerAsync();
        }

///     <summary>
///         Modifica los datos de un usuario identificado por un DNI.
///     </summary>
///     <param name="iDNI"> DNI a buscar. </param>
///     <param name="oUser"> Usuario con los nuevos datos. </param>
///     <param name="oCallback">
///         Funcion a la que llamar una vez resuelta la actualizacion.
///         Esta funcion debe tener un paramento:
///             - UsuarioResult inicando el resultado.
///     </param>
        public void Update(int iDNI, Usuario oUser, Action<UsuarioResult> oCallback) {
            UsuarioResult nResult = UsuarioResult.Error;

            BackgroundWorker oBW = new BackgroundWorker();
            oBW.DoWork += (sender, e) => {
                if (iDNI <= 0 || oUser == null)     // Comprueba la entrada
                    nResult = UsuarioResult.IncorrectInput;

                if (oUser.Pass != null)
                    oUser.Pass = Password.Hash(oUser.Pass);

                try {
                    nResult = Modelo.Update(iDNI, oUser) ? UsuarioResult.Success : UsuarioResult.Error;
                }
                catch (Exception oEx) {
                    this.LastError = oEx;     // Guarda la ultima excepcion

                    nResult = oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                                 UsuarioResult.Error;
                }
            };
            oBW.RunWorkerCompleted += (sender, e) => {
                oCallback(nResult);
            };
            oBW.RunWorkerAsync();
        }

///     <summary>
///         Elimina un usuario identificado por un DNI.
///     </summary>
///     <param name="iDNI"> DNI a buscar. </param>
///     <returns>
///         UsuarioResult indicando el resultado.
///     </returns>
        public UsuarioResult Delete(int iDNI) {
            if (iDNI <= 0)       // Comprueba la entrada
                return UsuarioResult.IncorrectInput;

            try {
                return Modelo.Delete(iDNI) ? UsuarioResult.Success : UsuarioResult.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion

                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                          UsuarioResult.Error;
            }
        }

///     <summary>
///         Obtiene multiples registros de la tabla `usuariologins`.
///     </summary>
///     <param name="oLogIns"> out DataTable con los registros obtenidos. </param>
///     <param name="iOffset"> Cantidad de registros a omitir. </param>
///     <param name="iLimit"> Cantidad de registros maximos a obtener. </param>
///     <param name="sOrderBy"> Valor de ordenamiento. </param>
///     <returns>
///         UsuarioResult indicando el resultado.
///     </returns>
        public UsuarioResult GetLogIns(out DataTable oLogIns, int iOffset = 0, int iLimit = -1, string sOrderBy = "") {
            oLogIns = null;
            try {
                return (oLogIns = Modelo.GetLogIns(iOffset, iLimit, sOrderBy)) != null ? UsuarioResult.Success : UsuarioResult.Failed;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion

                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                          UsuarioResult.Error;
            }
        }

///     <summary>
///         Obtiene el numero de registros en `usuariologins`.
///     </summary>
///     <param name="iCount"> out int con el numero de registros. </param>
///     <returns>
///         UsuarioResult indicando el resultado.
///     </returns>
        public UsuarioResult CountLogIns(out int iCount) {
            iCount = 0;
            try {
                iCount = Modelo.CountLogIns();
                return UsuarioResult.Success;
            }
            catch (Exception oEx) {
                this.LastError = oEx;     // Guarda la ultima excepcion

                return oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.") ? UsuarioResult.ConnError : 
                                                                                                          UsuarioResult.Error;
            }
        }

//      -- Clases privadas --
        private static class Password {
///         <summary> Cantidad de iteraciones para Rfc2898DeriveBytes </summary>
            public static int Iterations { get; set; } = 35000;

///         <summary>
///             Encripta una string.
///         </summary>
///         <param name="sText"> string a encriptar. </param>
///         <returns>
///             string a encriptado.
///         </returns>
            public static string Hash(string sText) {
                byte[] rSalt = new byte[85];
                new RNGCryptoServiceProvider().GetBytes(rSalt);

                byte[] rHash = new Rfc2898DeriveBytes(sText, rSalt, Password.Iterations).GetBytes(105);

                byte[] rHashBytes = new byte[190];
                Array.Copy(rSalt, 0, rHashBytes, 0, 85);
                Array.Copy(rHash, 0, rHashBytes, 85, 105);

                return Convert.ToBase64String(rHashBytes);
            }

///         <summary>
///             Verifica si una string es igual a otra string encriptada.
///         </summary>
///         <param name="sText"> string para desencriptar. </param>
///         <param name="sHash"> string a encriptada. </param>
///         <returns>
///             true si son iguales.
///         </returns>
            public static bool Verify(string sText, string sHash) {
                byte[] rHashBytes;
                try { rHashBytes = Convert.FromBase64String(sHash); }
                catch { return false; }

                byte[] rSalt = new byte[85];
                Array.Copy(rHashBytes, 0, rSalt, 0, 85);

                byte[] rHash = new Rfc2898DeriveBytes(sText, rSalt, Password.Iterations).GetBytes(105);

                for (int i = 0; i < 105; i++)
                    if (rHashBytes[i + 85] != rHash[i])
                        return false;

                return true;
            }
        }
    }
}
