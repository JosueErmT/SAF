using System;
using System.Diagnostics;

namespace SAF {
    public static class Log {
//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de fMain.
///     </summary>
        static Log() {
            Trace.Listeners.Add(new TextWriterTraceListener("exceptions.log"));
            Trace.AutoFlush = true;
        }

//      -- Metodos publicos --
///     <summary>
///         Guarda en el log una excepcion controlada.
///     </summary>
///     <param name="sender"> Que produjo el error. </param>
///     <param name="oEx"> Excepcion. </param>
        public static void UnhandledException(object sender, Exception oEx) {
            Write("UnhandledException", sender.ToString(),
                $"Source:{oEx.Source};\n" +
                $"Message:{oEx.Message};\n" +
                $"StackTrace:\n{oEx.StackTrace};\n" +
                $"TargetSite:{oEx.TargetSite};\n"
            );
        }

///     <summary>
///         Guarda en el log una excepcion no controlada.
///     </summary>
///     <param name="sender"> Que produjo el error. </param>
///     <param name="oEx"> Excepcion. </param>
        public static void HandledException(object sender, Exception oEx) {
            Write("HandledException", sender.ToString(), 
                $"Source:{oEx.Source};\n" +
                $"Message:{oEx.Message};\n" +
                $"StackTrace:\n{oEx.StackTrace};\n" +
                $"TargetSite:{oEx.TargetSite};\n"
            );
        }

///     <summary>
///         Guarda en el log una advertencia.
///     </summary>
///     <param name="sender"> Que produjo la advertencia. </param>
///     <param name="sMessage"> Mensaje. </param>
        public static void Warning(object sender, string sMessage) {
            Write("Warning", sender.ToString(), sMessage);
        }

///     <summary>
///         Guarda en el log informacion.
///     </summary>
///     <param name="sender"> Que produjo el envio de la informacion. </param>
///     <param name="sMessage"> Mensaje. </param>
        public static void Information(object sender, string sMessage) {
            Write("Information", sender.ToString(), sMessage);
        }

//      -- Metodos privados --
///     <summary>
///         Escribe un mensaje en el log.
///     </summary>
///     <param name="sType"> Tipo de mensaje. </param>
///     <param name="sender"> Que produjo el mensaje. </param>
///     <param name="sMessage"> Mensaje. </param>
        private static void Write(string sType, string sender, string sMessage) {
            try {
                Trace.WriteLine(string.Format(
                    "[{0}] {1}:{2};\n\t{3}",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    sType,
                    sender.Replace("\n", "\n\t").Trim(),
                    sMessage.Replace("\n", "\n\t").Trim()
                ));
            }
            catch { }
        }
    }
}
