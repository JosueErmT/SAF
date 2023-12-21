using MySql.Data.MySqlClient;
using System;
using System.Timers;

namespace SAF {
    public class Connection {
//      -- Atributos de instancia --
///     <summary> Timer para rehabilitar 'bool Open()' luego de 5 segundos de haber fallado. </summary>
        private Timer oReEnable = new Timer();

///     <summary> true para dehabilitar 'bool Open()'. </summary>
        private bool bDisabled = false;

//      -- Propiedades publicas --
///     <summary> Instancia de MySqlConnection para mantener la conexion. </summary>
        public MySqlConnection Conn { get; set; }

///     <summary> Fuente de la conexion. </summary>
        public string Source { get; set; }

///     <summary> Puerto de la conexion. </summary>
        public string Port { get; set; }

///     <summary> Usuario para el inicio de sesion. </summary>
        public string User { get; set; }

///     <summary> Contraseña para el inicio de sesion. </summary>
        public string Pass { get; set; }

///     <summary> Base de datos a consultar. </summary>
        public string Database { get; set; }

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de Connection.
///     </summary>
///     <param name="sSource"> Fuente de la conexion. </param>
///     <param name="sPort"> Puerto de la conexion. </param>
///     <param name="sUser"> Usuario para el inicio de sesion. </param>
///     <param name="sPass"> Contraseña para el inicio de sesion. </param>
///     <param name="sDatabase"> Base de datos a consultar. </param>
        public Connection(string sSource = "localhost",
                          string sPort = "3306", 
                          string sUser = "root", 
                          string sPass = "jr1t029r0reas9f780a92uq9d90auq", 
                          string sDatabase = "db") {
            this.Source = sSource;
            this.Port = sPort;
            this.User = sUser;
            this.Pass = sPass;
            this.Database = sDatabase;

            oReEnable.Interval = 5000;
            oReEnable.Elapsed += (source, e) => {
                bDisabled = false;
                oReEnable.Stop();
            };

            this.Conn = this.ConnGet();
        }

//      -- Metodos publicos --
///     <summary>
///         Abre la conexion con control de excepciones.
///     </summary>
///     <returns>
///         true si no hubo errores.
///     </returns>
        public bool Open() {
            if (bDisabled)
                throw new Exception("Unable to connect to any of the specified MySQL hosts.");

            try {
                Conn.Open();
                return true;
            }
            catch (Exception oEx) {
                if (oEx is InvalidOperationException && oEx.Message.StartsWith("The connection is already open."))
                    return true;
                else {
                    if (oEx is MySqlException && oEx.Message.StartsWith("Unable to connect to any of the specified MySQL hosts.")) {
                        bDisabled = true;
                        oReEnable.Start();
                    }

                    throw oEx;
                }
            }
        }

///     <summary>
///         Cierra la conexion con control de excepciones
///     </summary>
///     <returns>
///         true si no hubo errores.
///     </returns>
        public bool Close() {
            try {
                Conn.Close();
                return true;
            }
            catch {
                return false;
            }
        }

///     <summary>
///         Ejecuta MySqlCommand sobre la conexion.
///     </summary>
///     <param name="sCmd"> Comando SQL a ejecutar. </param>
///     <returns>
///         Un objecto MySqlCommand.
///     </returns>
        public MySqlCommand Command(string sCmd) {
            return new MySqlCommand(sCmd, Conn);
        }

///     <summary>
///         Obtiene la conexion a la base de datos.
///     </summary>
///     <returns>
///         MySqlConnection.
///     </returns>
        public MySqlConnection ConnGet() => new MySqlConnection($@"
            datasource={this.Source};
            port={this.Port};
            username={this.User};
            password={this.Pass};
            database={this.Database}
        ");
    }
}
