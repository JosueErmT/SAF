using MaterialSkin.Controls;
using SAF.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SAF.Vista {
    public partial class fSignUp : MaterialForm {
//      -- Atributos de instancia --
///     <summary> Formulario principal. </summary>
        private fMain oMain;
///     <summary> Instancia de Settings de la App. </summary>
        private Settings oSets = Settings.Default;

///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con los Usuarios. </summary>
        private ControlUsuarios CU;
///     <summary> Instancia de ControlTipoUsuario para las operaciones relacionadas con los tipos de usuario. </summary>
        private ControlTipoUsuario CTU = new ControlTipoUsuario();

///     <summary> Overlay Form para la sombra sobre la ventana principal. </summary>
        private Form oOverlay;

///     <summary> Mantiene el valor del texto de telefono por defecto. </summary>
        private string sDefPhoneText = "";

///     <summary> true hasta luego de que la ventana sea mostrada. </summary>
        private bool bFirstShown = true;
///     <summary> true si el mouse esta sobre el boton de Registrar. </summary>
        private bool bHoverBtn = false;

//      -- Propiedades privadas --
///     <summary> Instancia de Usuario del formulario principal. </summary>
        private Usuario User => oMain.User;

///     <summary> Instancia de Permission del formulario principal. </summary>
        private Permission Perms => oMain.Perms;

//      -- Propiedades publicas --
///     <summary> UsuarioResult con el resultado del ingreso. </summary>
        public UsuarioResult ExitCode { get; private set; } = UsuarioResult.Error;

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de fSignUp.
///     </summary>
        public fSignUp(fMain oMain) {
            this.oMain = oMain;
            this.Owner = oMain;

            oOverlay = new Form() {
                BackColor = Color.Black,
                Opacity = 0.01,
                MinimizeBox = false,
                MaximizeBox = false,
                Text = "",
                ShowIcon = false,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                Owner = this.Owner,
                Enabled = false,
                Visible = true,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
            };

            InitializeComponent();

            this.Opacity = 0.01;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                this.Owner.Location.X + (this.Owner.Width - this.Width) / 2,
                this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2
            );

            CU = new ControlUsuarios(User);

            InitControls();
        }

//      -- Metodos privados --
///     <summary>
///         Inicializa los controles.
///     </summary>
        private void InitControls() {
            if (CTU.GetAll(out DataTable oTypes) == Result.Success) {
                cbType.DataSource = oTypes;
                cbType.DisplayMember = "Nombre";
                foreach (DataRow oType in oTypes.Rows)
                    if (Perms.IsBelow(Convert.ToInt32(oType["permisos"])))
                        cbType.DisabledItems.Add(oTypes.Rows.IndexOf(oType));
                cbType.SelectedIndex = -1;
                cbType.SelectedIndex = 0;
            }

            InitInput();
        }
        
///     <summary>
///         Inicializa la entrada.
///     </summary>
        private void InitInput() {
            txDNI.Clear();
            txName.Clear();
            txLastName.Clear();
            txPass.Clear();
            txRepPass.Clear();
            txEmail.Clear();
            txPhone.Text = "54291";
            txDetails.Clear();

            this.sDefPhoneText = txPhone.Text;
            ExitCode = UsuarioResult.Error;
            this.ActiveControl = null;
        }

///     <summary>
///         Comprueba la entrada.
///     </summary>
        private bool CheckInput() {
            if (!this.bHoverBtn)
                lbError.Visible = false;
            string sError = "";

//          Comprueba txRepPass
            if (txRepPass.ErrorState = string.IsNullOrEmpty(txRepPass.Text))
                txRepPass.Hint = sError = "Contraseña incompleta";
            else if (txRepPass.ErrorState = txPass.Text != txRepPass.Text)
                txRepPass.Hint = sError = "Las contraseñas no coinciden";
            else
                txRepPass.Hint = "Repita la contraseña";
            
//          Comprueba txPass
            if (txPass.ErrorState = string.IsNullOrEmpty(txPass.Text))
                txPass.Hint = sError = "Contraseña incompleta";
            else if (txPass.ErrorState = txPass.Text.Length < 8)
                txPass.Hint = sError = "La contraseña debe tener al menos 8 digitos";
            else if (txPass.ErrorState = !txPass.Text.Any(char.IsLower))
                txPass.Hint = sError = "La contraseña debe contener al menos una minúscula";
            else if (txPass.ErrorState = !txPass.Text.Any(char.IsUpper))
                txPass.Hint = sError = "La contraseña debe contener al menos una mayúscula";
            else if (txPass.ErrorState = !txPass.Text.Any(char.IsNumber))
                txPass.Hint = sError = "La contraseña debe contener al menos un número";
            else
                txPass.Hint = "Contraseña";

//          Comprueba txEmail
            if (txEmail.ErrorState = !string.IsNullOrEmpty(txEmail.Text) && 
                                     !Regex.IsMatch(txEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                txEmail.Hint = sError = "Email formato incorrecto";
            else
                txEmail.Hint = "Email";

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
///         Evento KeyPress de txPhone para mantener el formato de numero telefonico.
///     </summary>
        private void txPhone_KeyPress(object sender, KeyPressEventArgs e) {
            MaskedTextBox oCtrl = sender as MaskedTextBox;
            if (oCtrl != null) {
                int iSel = oCtrl.SelectionStart;
                string sText = oCtrl.Text;
                bool bIsNum = char.IsDigit(e.KeyChar);

                int iNCount = oCtrl.Text.Count(char.IsDigit) + (bIsNum ? 1 : 0);

                if (iNCount <= 12)
                    oCtrl.Mask = "+00 000 000-0000";
                else if (iNCount <= 13)
                    oCtrl.Mask = "+00 000 0000-0000";
                else if (iNCount == 14)
                    oCtrl.Mask = "+00 0000 0000-0000";
                else
                    oCtrl.Mask = "+000 0000 0000-0000";

                oCtrl.SelectionStart = iSel;
                oCtrl.Text = sText;
            }
        }

///     <summary>
///         Evento KeyUp de txPhone para mantener el formato de numero telefonico.
///     </summary>
        private void txPhone_KeyUp(object sender, KeyEventArgs e) {
            MaskedTextBox oCtrl = sender as MaskedTextBox;
            if (oCtrl != null && e.KeyCode == Keys.Back) {
                int iSel = oCtrl.SelectionStart;
                string sText = oCtrl.Text;

                int iNCount = oCtrl.Text.Count(char.IsDigit);

                if (iNCount <= 12)
                    oCtrl.Mask = "+00 000 000-0000";
                else if (iNCount <= 13)
                    oCtrl.Mask = "+00 000 0000-0000";
                else if (iNCount == 14)
                    oCtrl.Mask = "+00 0000 0000-0000";
                else
                    oCtrl.Mask = "+000 0000 0000-0000";

                oCtrl.SelectionStart = iSel;
                oCtrl.Text = sText;
            }
        }

///     <summary>
///         Evento (Focus)Enter de txPhone para corregir la seleccion dentro del formato de numero telefonico.
///     </summary>
        private void txPhone_Enter(object sender, EventArgs e) {
            MaskedTextBox oCtrl = sender as MaskedTextBox;
            if (oCtrl != null)
                oCtrl.SelectionStart = Regex.Match(oCtrl.Text, @"\d$").Index + 1;
        }

///     <summary>
///         Evento Click de bnClose para cambiar el ExitCode a UsuarioResult.Canceled y cerrar el formulario.
///     </summary>
        private void bnClose_Click(object sender, EventArgs e) {
            ExitCode = UsuarioResult.Canceled;
            this.Close();
        }
        
///     <summary>
///         Evento Click para bnSignUp para ingresar el usuario al sistema.
///     </summary>
        private void bnSignUp_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                if (!CheckInput()) {
                    lbError.Visible = true;
                    return;
                }

                int iN;
                CU.SignUp(new Usuario() {
                    DNI = int.TryParse(txDNI.Text, out iN) ? (int?)iN : null,
                    Pass = txPass.Text,
                    Nombre = txName.Text,
                    Apellido = txLastName.Text,
                    Email = txEmail.Text,
                    Telefono = txPhone.Text != this.sDefPhoneText ? txPhone.Text : null,
                    Detalles = txDetails.Text,
                    TipoID = int.TryParse(((DataRowView)cbType.SelectedItem)["ID"].ToString(), out iN) ? (int?)iN : null,
                    NegocioID = User.NegocioID
                },
                (nResult) => {
                    ExitCode = nResult;
                    if (ExitCode == UsuarioResult.Success)
                        this.Close();
                    else if (ExitCode == UsuarioResult.IncorrectInput)
                        CheckInput();
                    else if (ExitCode == UsuarioResult.UserExists) {
                        lbError.Text = $"El usuario con DNI {txDNI.Text} ya se encuentra registrado";
                        lbError.Visible = true;
                    }
                    else if (ExitCode == UsuarioResult.ConnError) {
                        Log.HandledException("ControlUsuarios.SignUp", CU.LastError);
                        lbError.Text = "Error: no se ha podido conectar a la base de datos";
                        lbError.Visible = true;
                    }
                    else if (ExitCode == UsuarioResult.Error) {
                        Log.HandledException("ControlUsuarios.SignUp", CU.LastError);
                        lbError.Text = "Error: " + CU.LastError.Message;
                        lbError.Visible = true;
                    }
                });
            }
        }
        
///     <summary>
///         Evento MouseEnter de pnSignUp para mostrar la Label de error (lbError).
///         Este evento no fue añadido directamente al boton de Ingresar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnSignUp_MouseEnter(object sender, EventArgs e) {
            this.bHoverBtn =
            this.lbError.Visible = true;
        }

///     <summary>
///         Evento MouseEnter para pnSignUp para ocultar la Label de error (lbError).
///         Este evento no fue añadido directamente al boton de Ingresar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnSignUp_MouseLeave(object sender, EventArgs e) {
            this.bHoverBtn =
            this.lbError.Visible = false;
        }

///     <summary>
///         Evento TextChanged de la Label de error (lbError).
///         Habilita o deshabilita el boton de Ingresar dependiendo si hay o no errores.
///     </summary>
        private void lbError_TextChanged(object sender, EventArgs e) {
            Label oCtrl = sender as Label;
            if (oCtrl != null)
                bnSignUp.Enabled = oCtrl.Text == "";
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

                oOverlay.Opacity = 0.01;
                oOverlay.Show();
                oOverlay.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);
                oOverlay.Size = new Size(this.Owner.Width, this.Owner.Height);

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
                            oOverlay.Opacity = dOverOpHop * i;
                            this.Opacity = dThisOpHop * i;
                        });
                        Thread.Sleep(1);
                    }
                    bFirstShown = false;
                }).Start();
            }
        }

///     <summary>
///         Sobreescritura de OnDeactivate para cerrar la ventana cuando se sale de esta.
///     </summary>
        protected override void OnDeactivate(EventArgs e) {
            base.OnDeactivate(e);

            if (this.Visible) {
                ExitCode = UsuarioResult.Canceled;
                this.Close();
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
                    oOverlay.Opacity = 0.5 - dOverOpHop * i;
                    this.Opacity = 1 - dThisOpHop * i;
                    Thread.Sleep(1);
                }

                this.Hide();
                oOverlay.Hide();
            }
        }

///     <summary>
///         Sobreescritura de OnFormClosed para cerrar tambien el Overlay.
///     </summary>
        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            oOverlay.Close();
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
