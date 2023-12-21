using MaterialSkin.Controls;
using SAF.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SAF.Vista {
    public partial class fLogIn : MaterialForm {
//      -- Atributos de instancia --
///     <summary> Instancia de Settings de la App. </summary>
        private Settings oSets = Settings.Default;

///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con los Usuarios. </summary>
        private ControlUsuarios CU = new ControlUsuarios();

///     <summary> true hasta luego de que la ventana sea mostrada. </summary>
        private bool bFirstShown = true;
///     <summary> true si el mouse esta sobre el boton de Iniciar. </summary>
        private bool bHoverBtn = false;

///     <summary> Usuario que inicie sesion. </summary>
        public Usuario User { get; private set; } = null;

//      -- Propiedades --
///     <summary> UsuarioResult con el resultado del inicio de sesion. </summary>
        public UsuarioResult ExitCode { get; private set; } = UsuarioResult.Error;

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de fLogIn.
///     </summary>
        public fLogIn(Form oOwner) {
            this.Owner = oOwner;

            InitializeComponent();

            this.Opacity = 0.01;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                this.Owner.Location.X + (this.Owner.Width - this.Width) / 2,
                this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2
            );

            HelpButtonClicked += (sender, e) => {
                string oUserManual = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Docs\UserManualSAF.pdf");
                try {
                    File.WriteAllBytes(oUserManual, Properties.Resources.UserManualSAF);
                }
                catch { }
                Process.Start(oUserManual);
            };

            InitInput();
        }

//      -- Metodos privados --
///     <summary>
///         Inicializa la entrada.
///     </summary>
        private void InitInput() {
            txDNI.Clear();
            txPass.Clear();

            ExitCode = UsuarioResult.Error;
            this.ActiveControl = null;
        }

///     <summary>
///         Comprueba si las TextBoxes estan vacias y cambia a la Label error.
///     </summary>
///     <returns>
///         true si no hay error.
///     </returns>
        private bool CheckInput() {
            if (!this.bHoverBtn)
                lbError.Visible = false;
            string sError = "";

//          Comprueba txPass
            if (txPass.ErrorState = string.IsNullOrEmpty(txPass.Text))
                txPass.Hint = sError = "Contraseña incompleta";
            else
                txPass.Hint = "Contraseña";

//          Comprueba txDNI
            if (txDNI.ErrorState = string.IsNullOrEmpty(txDNI.Text))
                txDNI.Hint = sError = "DNI incompleto";
            else if (txDNI.ErrorState = !int.TryParse(txDNI.Text, out int iN) || iN < 1)
                txDNI.Hint = sError = "DNI inválido";
            else
                txDNI.Hint = "DNI";

            lbError.Text = sError;
            return sError == "";
        }

///     <summary>
///         Evento de cambio de valores de los controles.
///     </summary>
        private void CtrlsValueChanged(object sender, EventArgs e) {
            CheckInput();
        }

///     <summary>
///         Evento KeyPress de txDNI para permitir solo la insersion de numeros.
///     </summary>
        private void txDNI_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox oCtrl = sender as TextBox;
            if (oCtrl != null)
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

///     <summary>
///         Evento Click de bnLogIn.
///     </summary>
        private void bnLogIn_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                if (!CheckInput()) {
                    lbError.Visible = true;
                    return;
                }

                CU.LogIn(int.Parse(txDNI.Text), txPass.Text, (nResult, oUser) => {
                    ExitCode = nResult;
                    if (ExitCode == UsuarioResult.Success) {
                        User = oUser;
                        this.Close();
                    }
                    else if (ExitCode == UsuarioResult.IncorrectInput) {
                        CheckInput();
                        lbError.Visible = true;
                    }
                    else if (ExitCode == UsuarioResult.IncorrectUserPass) {
                        txDNI.ErrorState = true;
                        txPass.ErrorState = true;
                        lbError.Text = "DNI o contraseña incorrecta";
                        lbError.Visible = true;
                    }
                    else if (ExitCode == UsuarioResult.ConnError) {
                        Log.HandledException("ControlUsuarios.LogIn", CU.LastError);
                        lbError.Text = "Error: no se ha podido conectar a la base de datos";
                        lbError.Visible = true;
                    }
                    else if (ExitCode == UsuarioResult.Error) {
                        Log.HandledException("ControlUsuarios.LogIn", CU.LastError);
                        lbError.Text = "Error: " + CU.LastError.Message;
                        lbError.Visible = true;
                    }
                });
            }
        }

///     <summary>
///         Evento MouseEnter para pnLogIn para mostrar la Label de error (lbError).
///         Este evento no fue añadido directamente al boton de Iniciar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnLogIn_MouseEnter(object sender, EventArgs e) {
            this.bHoverBtn =
            this.lbError.Visible = true;
        }

///     <summary>
///         Evento MouseEnter para pnLogIn para ocultar la Label de error (lbError).
///         Este evento no fue añadido directamente al boton de Iniciar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnLogIn_MouseLeave(object sender, EventArgs e) {
            this.bHoverBtn =
            this.lbError.Visible = false;
        }

///     <summary>
///         Evento TextChanged de la Label de error (lbError).
///         Habilita o deshabilita el boton de Modificar dependiendo si hay o no errores.
///     </summary>
        private void lbError_TextChanged(object sender, EventArgs e) {
            Label oCtrl = sender as Label;
            if (oCtrl != null)
                bnLogIn.Enabled = oCtrl.Text == "";
        }

//      -- Overrides --
///     <summary>
///         Nuevo ShowDialog con distinto retorno.
///     </summary>
///     <param name="oOwner"> IWin32Window que sera el Owner de esta ventana. </param>
///     <returns>
///         UsuarioResult indicando el resultado.
///     </returns>
        public new UsuarioResult ShowDialog(IWin32Window oOwner) {
            base.ShowDialog(oOwner);
            return ExitCode;
        }

///     <summary>
///         Sobreescritura de OnVisibleChanged para realizar la animacion de apertura.
///     </summary>
        protected override void OnVisibleChanged(EventArgs e) {
            if (!this.Visible)
                base.OnVisibleChanged(e);
            else {
                if (ExitCode == UsuarioResult.Success)
                    InitInput();

                this.Opacity = 0.01;
                base.OnVisibleChanged(e);
                this.Location = new Point(
                    this.Owner.Location.X + (this.Owner.Width - this.Width) / 2,
                    this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2
                );

                new Thread(() => {
                    this.Invoke((Action)delegate {
                        this.Refresh();
                    });
                    if (bFirstShown)
                        Thread.Sleep(30);
                    double dThisOpHop = 1D / (double)oSets.AnimaShow;
                    double dOverOpHop = 0.5D / (double)oSets.AnimaShow;
                    for (int i = 1; i <= oSets.AnimaShow; i++) {
                        this.Invoke((Action)delegate {
                            this.Opacity = dThisOpHop * i;
                        });
                        Thread.Sleep(1);
                    }
                    bFirstShown = false;
                }).Start();
            }
        }

///     <summary>
///         Sobreescritura de OnFormClosing para realizar la animacion de cerrado.
///     </summary>
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;

                this.Refresh();
                double dThisOpHop = 1D / (double)oSets.AnimaHide;
                double dOverOpHop = 0.5D / (double)oSets.AnimaHide;
                for (int i = 1; i <= oSets.AnimaHide; i++) {
                    this.Opacity = 1 - dThisOpHop * i;
                    Thread.Sleep(1);
                }

                this.Hide();
            }
        }

///     <summary>
///         Sobreescritura de WndProc para controlar de mensajes del sistema y evitar maximizar la ventana.
///     </summary>
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x0112 && m.WParam.ToInt32() == 0xF030) {  // WM_SYSCOMMAND = 0x0112; SC_MAXIMIZE = 0xF030
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }
    }
}
