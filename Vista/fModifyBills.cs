using MaterialSkin.Controls;
using SAF.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SAF.Vista {
    public partial class fModifyBills : MaterialForm {
//      -- Atributos de instancia --
///     <summary> Formulario principal. </summary>
        private fMain oMain;
///     <summary> Instancia de Settings de la App. </summary>
        private Settings oSets = Settings.Default;

///     <summary> Instancia de ControlFacturas para las operaciones relacionadas con las Facturas. </summary>
        private ControlFacturas CF;
///     <summary> Instancia de ControlTipoPago para las operaciones relacionadas con los tipos de pago. </summary>
        private ControlTipoPago CTP = new ControlTipoPago();

///     <summary> Overlay Form para la sombra sobre la ventana principal. </summary>
        private Form oOverlay;

///     <summary> true hasta luego de que la ventana sea mostrada. </summary>
        private bool bFirstShown = true;
///     <summary> true hasta luego de que los controles sean inicializados. </summary>
        private bool bInitialized = false;
///     <summary> true si el mouse esta sobre el boton de Actualizar. </summary>
        private bool bHoverBtn = false;

//      -- Propiedades privadas --
///     <summary> Instancia de Usuario del formulario principal. </summary>
        private Usuario User => oMain.User;

///     <summary> Instancia de Permission del formulario principal. </summary>
        private Permission Perms => oMain.Perms;

//      -- Propiedades publicas --
///     <summary> Result con el resultado de la actualizacion. </summary>
        public Result ExitCode { get; private set; } = Result.Error;

///     <summary> Factura que sera actualizada. </summary>
        public Factura Bill { get; set; } = null;

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de fModifyBills.
///     </summary>
        public fModifyBills(fMain oMain) {
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

            CF = new ControlFacturas(User);

            InitControls();
        }

//      -- Metodos privados --
///     <summary>
///         Inicializa los controles.
///     </summary>
        private void InitControls() {
            txID.Enabled =
            dtpDate.Enabled = Perms.IsAbsolute;

            if (CTP.GetAll(out DataTable oTypes) == Result.Success) {
                cbPayType.DataSource = oTypes;
                cbPayType.DisplayMember = "Nombre";
            }
        }
        
///     <summary>
///         Inicializa la entrada.
///     </summary>
        private void InitInput() {
            lbTitle.Text = $"Modificando factura ID {Bill.ID}";
            txID.Text = Bill.ID.ToString();
            dtpDate.Value = Bill.Fecha;
            txPrice.Text = Bill.Monto.ToString();

            DataTable oBills = (DataTable)cbPayType.DataSource;
            cbPayType.SelectedIndex = oBills.Rows.IndexOf(oBills.Rows.Cast<DataRow>().FirstOrDefault(
                (oDataRow) => Convert.ToInt32(oDataRow["ID"]) == Bill.TipoPagoID
            ));

            txDesc.Text = Bill.Descripcion;

            ExitCode = Result.Error;
            this.ActiveControl = null;
            CheckInput();
            this.bInitialized = true;
        }
        
///     <summary>
///         Comprueba la entrada.
///     </summary>
        private bool CheckInput() {
            int iID = -1;
            decimal mPrice = -1M;

            if (!this.bHoverBtn)
                lbError.Visible = false;
            string sError = "";

//          Comprueba txPrice
            if (txPrice.ErrorState = string.IsNullOrEmpty(txPrice.Text))
                txPrice.Hint = sError = "Monto incompleto";
            else if (txPrice.ErrorState = !decimal.TryParse(txPrice.Text, out mPrice) || mPrice < 1)
                txPrice.Hint = sError = "Monto inválido";
            else
                txPrice.Hint = "Monto";

//          Comprueba txID
            if (txID.ErrorState = string.IsNullOrEmpty(txID.Text))
                txID.Hint = sError = "ID incompleto";
            else if (txID.ErrorState = !int.TryParse(txID.Text, out iID) || iID < 1)
                txID.Hint = sError = "ID inválido";
            else
                txID.Hint = "ID de la factura";

//          Comprueba si los valores cambiaron
            if (Bill != null && iID == Bill.ID && dtpDate.Value == Bill.Fecha && mPrice == Bill.Monto &&
                Convert.ToInt32(((DataRowView)cbPayType.SelectedItem)["ID"]) == Bill.TipoPagoID && txDesc.Text == Bill.Descripcion)
                sError = "Actualice algun valor";

            lbError.Text = sError;
            return sError == "";
        }

///     <summary>
///         Evento de cambio de valores de los controles.
///     </summary>
        private void CtrlsValueChanged(object sender, EventArgs e) {
            if (this.bInitialized)
                CheckInput();
        }
        
///     <summary>
///         Evento KeyPress de txID para permitir solo la insersion de numeros.
///     </summary>
        private void txID_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox oCtrl = sender as TextBox;
            if (oCtrl != null)
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        
///     <summary>
///         Evento KeyPress de txPrice para permitir solo la insersion del formato decimal.
///     </summary>
        private void txPrice_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox oCtrl = sender as TextBox;
            if (oCtrl != null) {
                int iDot = oCtrl.Text.IndexOf(',');
                if (e.KeyChar == '.')
                    e.KeyChar = ',';

                e.Handled = !char.IsControl(e.KeyChar) && 
                            ((!char.IsDigit(e.KeyChar) || e.KeyChar == '0' && oCtrl.SelectionStart == 0) && 
                             (e.KeyChar != ',' || iDot > -1 || oCtrl.SelectionStart == 0 || oCtrl.Text.Length - oCtrl.SelectionStart > 2) || 
                             iDot > -1 && oCtrl.Text.Length - iDot > 2 && oCtrl.SelectionStart > iDot);
            }
        }
        
///     <summary>
///         Evento Click de bnClose para cambiar el ExitCode a Result.Canceled y cerrar el formulario.
///     </summary>
        private void bnClose_Click(object sender, EventArgs e) {
            ExitCode = Result.Canceled;
            this.Close();
        }
        
///     <summary>
///         Evento Click para bnUpdate para actualizar los valores de la factura.
///     </summary>
        private void bnUpdate_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                if (!CheckInput()) {
                    lbError.Visible = true;
                    return;
                }

                ExitCode = CF.Update((int)Bill.ID, new Factura() {
                    ID = Perms.IsAbsolute ? int.Parse(txID.Text) : Bill.ID,
                    Fecha = Perms.IsAbsolute ? dtpDate.Value : Bill.Fecha,
                    Monto = decimal.Parse(txPrice.Text),
                    TipoPagoID = Convert.ToInt32(((DataRowView)cbPayType.SelectedItem)["ID"]),
                    UsuarioDNI = User.DNI,
                    Descripcion = txDesc.Text
                });

                if (ExitCode == Result.Success)
                    this.Close();
                else if (ExitCode == Result.IncorrectInput)
                    CheckInput();
                else if (ExitCode == Result.ConnError) {
                    Log.HandledException("ControlFacturas.Update", CF.LastError);
                    lbError.Text = "Error: no se ha podido conectar a la base de datos";
                    lbError.Visible = true;
                }
                else if (ExitCode == Result.Error) {
                    Log.HandledException("ControlFacturas.Update", CF.LastError);
                    lbError.Text = CF.LastError.Message;
                    lbError.Visible = true;
                }
            }
        }
        
///     <summary>
///         Evento MouseEnter de pnUpdate para mostrar la Label de error (lbError).
///         Este evento no fue añadido directamente al boton de Actualizar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnUpdate_MouseEnter(object sender, EventArgs e) {
            this.bHoverBtn =
            this.lbError.Visible = true;
        }

///     <summary>
///         Evento MouseEnter para pnLogIn para ocultar la Label de error (lbError).
///         Este evento no fue añadido directamente al boton de Actualizar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnUpdate_MouseLeave(object sender, EventArgs e) {
            this.bHoverBtn =
            this.lbError.Visible = false;
        }
        
///     <summary>
///         Evento TextChanged de la Label de error (lbError).
///         Habilita o deshabilita el boton de Actualizar dependiendo si hay o no errores.
///     </summary>
        private void lbError_TextChanged(object sender, EventArgs e) {
            Label oCtrl = sender as Label;
            if (oCtrl != null)
                bnUpdate.Enabled = oCtrl.Text == "";
        }

//      -- Overrides --
///     <summary>
///         Nuevo ShowDialog con distinto retorno.
///     </summary>
///     <param name="oOwner"> IWin32Window que sera el Owner de esta ventana. </param>
///     <returns>
///         Result indicando el resultado.
///     </returns>
        public new Result ShowDialog(IWin32Window oOwner) {
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
                ExitCode = Result.Canceled;
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
                this.bInitialized = false;
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
