using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using SAF.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SAF.Vista {
    public partial class fMain : MaterialForm {
//      -- Funciones externas --
///     <summary> Determina si el sistema usa o no Dark mode </summary>
///     <returns>
///         true si es Dark.
///     </returns>
        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")] 
        private static extern bool ShouldSystemUseDarkMode();

//      -- Atributos de instancia --
///     <summary> Instancia de Settings de la App. </summary>
        private Settings oSets = Properties.Settings.Default;

///     <summary> Instancia de Statistics para obtener las estadisticas. </summary>
        private Statistics oStats;
        
///     <summary> Instancia de fLogIn. </summary>
        private fLogIn oLogIn;
///     <summary> Instancia de fSignUp. </summary>
        private fSignUp oSignUp;
///     <summary> Instancia de fModifyBills. </summary>
        private fModifyBills oModifyBills;
///     <summary> Overlay Form para la animacion al cambiar de tab. </summary>
        private Form oOverlay;
///     <summary> Thread para separar el thread de la animacion del Overlay y no interrumpir el thread principal. </summary>
        private Thread oOverlayThread;
///     <summary> Bitmap para mantener la ultima imagen del sistema y realizar la animacion. </summary>
        private Bitmap oOverlayBitmap;
///     <summary> true si la animacion esta siendo realizada. </summary>
        private bool bOverlayAnimating = false;

///     <summary> true si el mouse esta sobre el boton de de Agregar en Nueva Factura. </summary>
        private bool bNewBillsHoverBtn = false;
///     <summary> true si el mouse esta sobre el boton de de Modificar en Ajustes - Cuenta. </summary>
        private bool bSettingsAccountHoverBtn = false;
        
///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con los Usuarios. </summary>
        private ControlUsuarios CU;
///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con las Facturas. </summary>
        private ControlFacturas CF;
///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con los Negocios. </summary>
        private ControlNegocios CN = new ControlNegocios();
///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con los tipo de usuario. </summary>
        private ControlTipoUsuario CTU = new ControlTipoUsuario();
///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con los tipo de pago. </summary>
        private ControlTipoPago CTP = new ControlTipoPago();
///     <summary> Instancia de ControlUsuarios para las operaciones relacionadas con las categorias. </summary>
        private ControlCategorias CC = new ControlCategorias();

//      -- Propiedades --
        private Usuario oUser;
///     <summary> Usuario registrado en el sistema. </summary>
        public Usuario User => oUser;
        
        private Permission oPerms;
///     <summary> Permisos del Usuario registrado en el sistema. </summary>
        public Permission Perms => oPerms;

        private Negocio oShop;
///     <summary> Negocio al que pertenece el Usuario registrado en el sistema. </summary>
        public Negocio Shop => oShop;

//      -- Constructor --
///     <summary>
///         Inicializa una nueva instancia de fMain.
///     </summary>
        public fMain() {
            AppDomain.CurrentDomain.UnhandledException += (sender, e) => {
                OnUnhandledException(sender, (Exception)e.ExceptionObject);
            };
            Application.ThreadException += (sender, e) => {
                OnUnhandledException(sender, e.Exception);
            };

            oLogIn = new fLogIn(this);

            SkinManager.AddFormToManage(this);
            SkinManager.AddFormToManage(oLogIn);

            InitializeComponent();
            this.Opacity = 0;
            this.drawerForm.Opacity = 0;
            this.MinimumSize = new Size(oSets.MinAppW, oSets.MinAppH);

            SetTheme(oSets.Theme, oSets.Primary, oSets.Dark, oSets.Light, oSets.Accent, oSets.TextShade);
            InitPos();

            if (oSets.LogedUser != 0)
                oUser = new ModeloUsuarios().Get(oSets.LogedUser);
            else {
                if (oLogIn.ShowDialog(this) != UsuarioResult.Success)
                    Environment.Exit(0);
                oUser = oLogIn.User;
                oSets.LogedUser = (int)oUser.DNI;
            }

            CN.Get(out oShop, (int)oUser.NegocioID);
            CTU.GetPermissions(out oPerms, (int)oUser.TipoID);

            oStats = new Statistics(this);
            oStats.HandledException += (oResult) => {
                OnHandledException(oResult, "oStats", oStats.LastError);
            };
            
            CU = new ControlUsuarios(oUser);
            CF = new ControlFacturas(oUser);

            InitControls();

            mcSShop.Size = new Size(730, 500);
            tlpSAccount.Size = new Size(750, 526);
            mcSCustom.Size = new Size(320, 384);
            mcSAbout.Size = new Size(620, 424);

            HelpButtonClicked += OpenManual;
            AppDomain.CurrentDomain.ProcessExit += (sender, e) => oSets.Save();

//          Inicializacion del Overlay Form
            oOverlay = new Form() {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = SkinManager.BackdropColor,
                ControlBox = false,
                Enabled = false,
                FormBorderStyle = FormBorderStyle.None,
                MinimizeBox = false,
                MaximizeBox = false,
                Opacity = 0,
                Owner = this,
                ShowIcon = false,
                ShowInTaskbar = false,
                Visible = true
            };

//          Eventos Paint
            oOverlay.Paint += (sender, e) => {
                if (oOverlayBitmap != null) {
                    e.Graphics.CompositingQuality = CompositingQuality.GammaCorrected;
                    e.Graphics.DrawImage(oOverlayBitmap, 0, 0);
                }
            };

            pnBDateArrow.Paint += (sender, e) => {
                System.Windows.Forms.Control oCtrl = sender as System.Windows.Forms.Control;
                if (oCtrl != null) {
                    int iLineW = 14;
                    int iNotchW = 10;
                    PointF oLastPoint;
                    
                    Font oFont = SkinManager.getFontByType(MaterialSkinManager.fontType.Body1);
                    SizeF oTextSize = e.Graphics.MeasureString(oCtrl.Text, oFont);
                    Point oTextPoint = new Point(
                        (oCtrl.Width - (int)oTextSize.Width) / 2,
                        (oCtrl.Height - (int)oTextSize.Height) / 2 - (iLineW - iNotchW)
                    );

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    GraphicsPath oPath = new GraphicsPath();
                    oPath.AddLine(
                        new Point(oCtrl.Margin.Left + bnBPrevMonth.Width / 2, (oCtrl.Height - iLineW) / 2),
                        new Point(oTextPoint.X - iNotchW * 2, (oCtrl.Height - iLineW) / 2)
                    );
                    oLastPoint = oPath.GetLastPoint();
                    oPath.AddArc(
                        oLastPoint.X, oLastPoint.Y,
                        iNotchW, iNotchW,
                        270, 90
                    );
                    oLastPoint = oPath.GetLastPoint();
                    oPath.AddArc(
                        oLastPoint.X, (oCtrl.Height - iLineW) / 2,
                        iNotchW, iNotchW,
                        180, -90
                    );
                    oLastPoint = oPath.GetLastPoint();
                    oPath.AddArc(
                        oLastPoint.X + oTextSize.Width, (oCtrl.Height - iLineW) / 2,
                        iNotchW, iNotchW,
                        90, -90
                    );
                    oLastPoint = oPath.GetLastPoint();
                    oPath.AddArc(
                        oLastPoint.X, (oCtrl.Height - iLineW) / 2,
                        iNotchW, iNotchW,
                        180, 90
                    );
                    oLastPoint = oPath.GetLastPoint();
                    oPath.AddLine(
                        oLastPoint,
                        new PointF(oCtrl.Width - (oCtrl.Margin.Right + bnBNextMonth.Width / 2), oLastPoint.Y)
                    );
                    oLastPoint = oPath.GetLastPoint();
                    oPath.AddLine(
                        new PointF(oLastPoint.X, oLastPoint.Y + iLineW),
                        new PointF(oCtrl.Margin.Left + bnBPrevMonth.Width / 2, oLastPoint.Y + iLineW)
                    );
                    oPath.CloseAllFigures();

                    DrawHelper.DrawSquareShadow(e.Graphics, new Rectangle(
                        oCtrl.Margin.Left + bnBPrevMonth.Width / 2,
                        (oCtrl.Height - iLineW) / 2,
                        oCtrl.Width - (oCtrl.Margin.Left + oCtrl.Margin.Right + (bnBPrevMonth.Width + bnBNextMonth.Width) / 2),
                        iLineW
                    ));
                    e.Graphics.FillPath(new SolidBrush(ColorHelper.RemoveAlpha(SkinManager.BackgroundDisabledColor, oCtrl.Parent.BackColor)), oPath);
                    e.Graphics.DrawString(oCtrl.Text, oFont, SkinManager.TextHighEmphasisBrush, oTextPoint);
                }
            };

            bnBPrevMonth.Paint += (sender, e) => {
                Button oCtrl = sender as Button;
                if (oCtrl != null) {
                    int iMargin = 5;

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPolygon(SkinManager.BackgroundDisabledBrush, new Point[] {
                        new Point(oCtrl.Width, iMargin),
                        new Point(oCtrl.Width, oCtrl.Height - iMargin),
                        new Point(iMargin, oCtrl.Height / 2)
                    });
                }
            };

            bnBNextMonth.Paint += (sender, e) => {
                Button oCtrl = sender as Button;
                if (oCtrl != null) {
                    int iMargin = 5;

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPolygon(SkinManager.BackgroundDisabledBrush, new Point[] {
                        new Point(0, iMargin),
                        new Point(0, oCtrl.Height - iMargin),
                        new Point(oCtrl.Width - iMargin, oCtrl.Height / 2)
                    });
                }
            };
        }

//      -- Metodos privados --
///     <summary>
///         Ejecutada cuando ocurre una excepcion controlada, guarda el error en el Log, y agrega una Alerta.
///     </summary>
///     <param name="oResult"> Result con el tipo de error (Result.Error o Result.ConnError). </param>
///     <param name="sender"> Que produjo el error. </param>
///     <param name="oEx"> Excepcion. </param>
        private void OnHandledException(Result oResult, object sender, Exception oEx) {
            Log.HandledException(sender, oEx);

            if (oResult == Result.ConnError)
                AddAlert("ERROR: " + "ConnError", "No se ha podido conectar a la base de datos, el sistema no funcionara correctamente.");
            else
                AddAlert("ERROR: 0x" + oEx.HResult.ToString("X"), "Si el error persiste, contacte con el mantenimiento.");
        }

///     <summary>
///         Ejecutada cuando ocurre una excepcion controlada, guarda el error en el Log, y agrega una Alerta.
///     </summary>
///     <param name="oResult"> UsuarioResult con el tipo de error (UsuarioResult.Error o UsuarioResult.ConnError). </param>
///     <param name="sender"> Que produjo el error. </param>
///     <param name="oEx"> Excepcion. </param>
        private void OnHandledException(UsuarioResult oResult, object sender, Exception oEx) {
            Log.HandledException(sender, oEx);

            if (oResult == UsuarioResult.ConnError)
                AddAlert("ERROR: " + "ConnError", "No se ha podido conectar a la base de datos, el sistema no funcionara correctamente.");
            else
                AddAlert("ERROR: 0x" + oEx.HResult.ToString("X"), "Si el error persiste, contacte con el mantenimiento.");
        }

///     <summary>
///         Ejecutada cuando ocurre una excepcion no controlada, guarda el error en el Log, muestra el error al usuario, y reinicia la aplicacion.
///     </summary>
///     <param name="sender"> Que produjo el error. </param>
///     <param name="oEx"> Excepcion. </param>
        private void OnUnhandledException(object sender, Exception oEx) {
            try {
                Log.UnhandledException(sender, oEx);
            }
            catch { }

            try {
                MaterialMessageBox.Show(this,
                    "Error no controlado, por favor, contacte con el manteniemiento.\n" +
                    "El sistema ya no es estable y sera reiniciado.\n\n" +
                    oEx.ToString(), "SAF",
                    MessageBoxButtons.OK, Resources.Error32, MessageBoxDefaultButton.Button1, false, iMaxWidth: 530
                );
            }
            catch {
                MessageBox.Show(this,
                    "Error no controlado, por favor, contacte con el manteniemiento.\n" +
                    "El sistema ya no es estable y sera reiniciado.\n\n" +
                    oEx.ToString(), "SAF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                );
            }

            Application.Restart();
        }

///     <summary>
///         Evento para los botones para abrir el manual.
///     </summary>
        private void OpenManual(object sender, EventArgs e) {
            string oUserManual = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Docs\UserManualSAF.pdf");
            try {
                File.WriteAllBytes(oUserManual, Properties.Resources.UserManualSAF);
            }
            catch { }
            Process.Start(oUserManual);
        }

///     <summary>
///         Establece la posicion inicial de la app.
///         Si Settings.LastRect esta vacio, ubicarada la app en relacion a la pantalla.
///     </summary>
        private void InitPos() {
            Rectangle oScreen = Screen.FromControl(this).WorkingArea;   // Obtiene el area de trabajo de la pantalla en la que se esta la app 

            if (oSets.SaveLastRect && oSets["LastRect"] != null) {
                this.Bounds = (Rectangle)oSets.LastRect;
                Rectangle oBounds = new Rectangle(this.Location, this.DisplayRectangle.Size);

                this.Left += Math.Min(0, oScreen.Left + oScreen.Width - this.Left - this.Width);
                this.Left -= Math.Min(0, this.Left - oScreen.Left);
                this.Top += Math.Min(0, oScreen.Top + oScreen.Height - this.Top - this.Height);
                this.Top -= Math.Min(0, this.Top - oScreen.Top);
                return;
            }

            double dRatio = (double)oSets.MinInitW / (double)oSets.MinInitH;    // Relacion de aspecto

            Size oNewSize = new Size();
            if (oScreen.Width > oScreen.Height) {
                oNewSize.Height = (int)Math.Min(oSets.MinInitH + (oScreen.Height - oSets.MinInitH) * (oSets.InitMul / 100D)
                                                , oScreen.Height);      // Height minimo + % del Height restante de la pantalla
                oNewSize.Width = (int)(dRatio * oNewSize.Height);       // Width basado en el Height, mantieniedo el Ratio de los valores minimos
            }
            else {
                oNewSize.Width = (int)Math.Min(oSets.MinInitW + (oScreen.Width - oSets.MinInitW) * (oSets.InitMul / 100D)
                                               , oScreen.Width);        // Width minimo + % del Width restante de la pantalla
                oNewSize.Height = (int)(oNewSize.Width / dRatio);       // Height basado en el Width, mantieniedo el Ratio de los valores minimos
            }

            this.Size = oNewSize;                                       // Asignacion del nuevo tamaño
            this.Location = new Point(                                  // Asignacion de una nueva posicion:
                oScreen.Left + (oScreen.Width - oNewSize.Width) / 2,    //   - Centrado horizontal en la pantalla actual
                oScreen.Top + (oScreen.Height - oNewSize.Height) / 2    //   - Centrado vertical en la pantalla actual
            );
            oSets.LastRect = this.Bounds;
        }

///     <summary>
///         Establece el tema de la App.
///     </summary>
///     <param name="iDarkMode"> 0 = Tema del sistema; 1 = Tema claro; 2 = Tema oscuro. </param>
///     <param name="oPrimary"> Color primario. </param>
///     <param name="oDark"> Color primario oscuro. </param>
///     <param name="oLight"> Color primario claro. </param>
///     <param name="oAccent"> Color de acento. </param>
///     <param name="oTextShade"> Color de texto. </param>
        private void SetTheme(int iDarkMode, Primary oPrimary, Primary oDark, Primary oLight, Accent oAccent, TextShade oTextShade) {
            SkinManager.Theme = iDarkMode == 0 && ShouldSystemUseDarkMode() || iDarkMode == 2 ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(oPrimary, oDark, oLight, oAccent, oTextShade);

            oSets.Theme = iDarkMode;
            oSets.Primary = oPrimary;
            oSets.Dark = oDark;
            oSets.Light = oLight;
            oSets.Accent = oAccent;
            oSets.TextShade = oTextShade;
        }

///     <summary>
///         Esconde la App haciendo una animacion de desvanecer.
///     </summary>
        private void FadeHide() {
            this.Refresh();
            double dOpHop = 1D / oSets.AnimaHide;
            for (int i = 1; i <= oSets.AnimaHide; i++) {
                this.Opacity =
                this.drawerForm.Opacity = 1 - dOpHop * i;
                Thread.Sleep(1);
            }
            this.Hide();
        }

///     <summary>
///         Crea una animacion sobre la App: 
///         saca una captura del estado actual de esta, y la coloca por encima de la App,
///         luego ejecuta la funcion pasada por parametros, y desvanece la captura.
///         Esta funcion es usada para hacer la animacion de cambio de pestaña de los TabControls.
///     </summary>
///     <param name="oCallback"> Funcion a la que llamar. </param>
        private void Animate(Action oCallback) {
            if (oOverlayThread != null && oOverlayThread.ThreadState != System.Threading.ThreadState.Stopped)
                oOverlayThread.Abort();

            oOverlayThread = new Thread(() => {
                try {
                    this.Invoke((Action)delegate {
                        oOverlayBitmap = new Bitmap(tcMain.Width, tcMain.Height);
                        tcMain.DrawToBitmap(oOverlayBitmap, new Rectangle(0, 0, oOverlayBitmap.Width, oOverlayBitmap.Height));

                        oOverlay.Location = new Point(this.Location.X + tcMain.Location.X, this.Location.Y + tcMain.Location.Y);
                        oOverlay.Size = new Size(tcMain.Width, tcMain.Height);

                        oOverlay.Refresh();
                        oOverlay.Opacity = 0.99999999;

                        bOverlayAnimating = true;
                        oCallback();
                        bOverlayAnimating = false;
                        tcMain.Refresh();
                    });

                    double dOpHop = 1D / oSets.AnimaChngTab;
                    for (int i = 1; i <= oSets.AnimaChngTab; i++) {
                        this.Invoke((Action)delegate {
                            oOverlay.Opacity = 1 - dOpHop * i;
                        });
                        Thread.Sleep(1);
                    }
                }
                catch { }
            });

            oOverlayThread.Start();
        }
        
///     <summary>
///         Inicializa los controles, comprobando los permisos del usuario y mostrando las pestañas a las que tiene acceso.
///     </summary>
        private void InitControls() {
            tlpHome.ColumnStyles[1].Width = oSets.RightPanelW;
            tlpNewBill.ColumnStyles[1].Width = oSets.RightPanelW;
            tlpBills.ColumnStyles[1].Width = oSets.RightPanelW;
            tlpUsers.ColumnStyles[1].Width = oSets.RightPanelW;

            HomeRefresh();

            int iAccessCount = oPerms.AccessCount - (oPerms.CanAccessSettings ? 1 : 0);
            tlpHBtns.ColumnStyles.Clear();
            tlpHBtns.RowStyles.Clear();
            if (iAccessCount == 0) {
                tlpHBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                tlpHBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            else if (iAccessCount == 1) {
                tlpHBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tlpHBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tlpHBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            else {
                tlpHBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tlpHBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tlpHBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                tlpHBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }

            tlpHBtns.Controls.Remove(bnHNewBill);
            tlpHBtns.Controls.Remove(bnHBills);
            tlpHBtns.Controls.Remove(bnHUsers);
            tlpHBtns.Controls.Remove(bnHSettings);
            tcMain.TabPages.Remove(tpNewBill);
            tcMain.TabPages.Remove(tpBills);
            tcMain.TabPages.Remove(tpUsers);
            tcMain.TabPages.Remove(tpSettings);

            int iCount = 0; string sBinary;
            if (oPerms.CanAccessNewBill) {
                sBinary = Convert.ToString(iCount, 2).PadLeft(2, '0');
                tlpHBtns.Controls.Add(bnHNewBill, Convert.ToInt32(sBinary.Substring(1, 1)), Convert.ToInt32(sBinary.Substring(0, 1)));
                iCount++;

                tcMain.TabPages.Add(tpNewBill);

                NewBillsInit();
            }

            if (oPerms.CanAccessBills) {
                sBinary = Convert.ToString(iCount, 2).PadLeft(2, '0');
                tlpHBtns.Controls.Add(bnHBills, Convert.ToInt32(sBinary.Substring(1, 1)), Convert.ToInt32(sBinary.Substring(0, 1)));
                iCount++;

                tcMain.TabPages.Add(tpBills);

                BillsInit();
            }

            if (oPerms.CanAccessUsers) {
                sBinary = Convert.ToString(iCount, 2).PadLeft(2, '0');
                tlpHBtns.Controls.Add(bnHUsers, Convert.ToInt32(sBinary.Substring(1, 1)), Convert.ToInt32(sBinary.Substring(0, 1)));
                iCount++;

                tcMain.TabPages.Add(tpUsers);

                UsersInit();
            }

            sBinary = Convert.ToString(iCount, 2).PadLeft(2, '0');
            tlpHBtns.Controls.Add(bnHSettings, Convert.ToInt32(sBinary.Substring(1, 1)), Convert.ToInt32(sBinary.Substring(0, 1)));
            tlpHBtns.SetColumnSpan(bnHSettings, iAccessCount == 2 ? 2 : 1);

            tcMain.TabPages.Add(tpSettings);

            SettingsInit();
            SetBlockSize();
        }

///     <summary>
///         Evento Selecting para capturar el cambio de pestaña de los TabControls y hacer la animacion.
///     </summary>
        private void tcsAnimation_Selecting(object sender, TabControlCancelEventArgs e) {
            TabControl oCtrl = sender as TabControl;
            if (oCtrl != null && !this.bOverlayAnimating) {
                Animate(() => oCtrl.SelectedIndex = e.TabPageIndex);
                e.Cancel = true;
            }
        }

///     <summary>
///         Evento SelectedIndexChanged de tcMain, para actualizar la pestaña a la que se cambio.
///     </summary>
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e) {
            if (tcMain.SelectedTab == tpHome) {             // Cuando se entra en la tab Inicio
                HomeRefresh();
                this.AcceptButton = null;
                this.Text = "Inicio - SAF";
            }
            else if (tcMain.SelectedTab == tpNewBill) {     // Cuando se entra en la tab Nueva Factura
                NewBillsRefresh();
                this.AcceptButton = bnNAdd;
                this.Text = "Nueva Factura - SAF";
            }
            else if (tcMain.SelectedTab == tpBills) {       // Cuando se entra en la tab Facturas
                BillsRefresh();
                this.AcceptButton = null;
                this.Text = "Facturas - SAF";
            }
            else if (tcMain.SelectedTab == tpUsers) {       // Cuando se entra en la tab Usuarios
                UsersRefresh();
                this.AcceptButton = null;
                this.Text = "Usuarios - SAF";
            }
            else if (tcMain.SelectedTab == tpSettings) {    // Cuando se entra en la tab Ajustes
                SettingsRefresh(tcSSettings.SelectedTab);
            }
        }

//      - Inicio -
///     <summary>
///         Actualiza los controles de Inicio.
///     </summary>
        private void HomeRefresh() {
            lbHSession.Text = oUser.ToString();
        }

///     <summary>
///         Establece el tamaño del bloque central en el Inicio.
///     </summary>
        private void SetBlockSize() {
            int xWidth = (int)(oSets.BaseBlockSz + Math.Min(tlpHome.Width - oSets.RightPanelW, tlpHome.Height) * oSets.BlockMul / 100) * tlpHBtns.ColumnStyles.Count;
            int xHeight = (int)(oSets.BaseBlockSz + Math.Min(tlpHome.Width - oSets.RightPanelW, tlpHome.Height) * oSets.BlockMul / 100) * tlpHBtns.RowStyles.Count;
            this.mcHBtns.Size = new Size(xWidth, xHeight);
        }
        
///     <summary>
///         Agrega una alerta en el apartado de alertas.
///     </summary>
///     <param name="sTitle"> Titulo. </param>
///     <param name="sText"> Texto. </param>
        private void AddAlert(string sTitle, string sText) {
            lsHAAlerts.InsertItem(0, new MaterialListBoxItem(sTitle, sText));
        }

///     <summary>
///         Evento Click de los botones del bloque central de Inicio.
///     </summary>
        private void bnHsClick(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null)
                Animate(() => tcMain.SelectedIndex = oCtrl.Parent.Controls.IndexOf(oCtrl) + 1);
        }

///     <summary>
///         Evento Click del boton bnHSLogOut.
///     </summary>
        private void bnHSLogOut_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                oSets.LogedUser = 0;
                this.FadeHide();

                if (oLogIn.ShowDialog(this) != UsuarioResult.Success)
                    Environment.Exit(0);
                oUser = oLogIn.User;
                oSets.LogedUser = (int)oUser.DNI;

                CN.Get(out oShop, (int)oUser.NegocioID);
                CTU.GetPermissions(out oPerms, (int)oUser.TipoID);

                oStats = new Statistics(this);
                oStats.HandledException += (oResult) => {
                    OnHandledException(oResult, "oStats", oStats.LastError);
                };

                InitControls();

                this.Show();
            }
        }

///     <summary>
///         Evento Click del boton bnHSSettings.
///     </summary>
        private void bnHSSettings_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                tcMain.SelectTab("tpSettings");
                tcSSettings.SelectTab("tpSAccount");
            }
        }

//      - Nueva Factura -
///     <summary>
///         Inicializa los controles de Nueva Factura.
///     </summary>
        private void NewBillsInit() {
            if (CU.GetAll(out DataTable oUsers) == Result.Success) {
                oUsers.Columns.Add(
                    "DNI:Nombre", 
                    typeof(string),
                    "DNI + ': ' + Nombre"
                );
                cbNDNI.DataSource = oUsers;
                cbNDNI.DisplayMember = "DNI:Nombre";
                cbNDNI.SelectedIndex = oUsers.Rows.IndexOf(oUsers.Rows.Cast<DataRow>().FirstOrDefault(
                    (oDataRow) => Convert.ToInt32(oDataRow["DNI"]) == oUser.DNI
                ));
            }

            if (CTP.GetAll(out DataTable oTypes) == Result.Success) {
                cbNPayType.DataSource = oTypes;
                cbNPayType.DisplayMember = "Nombre";
            }

            dtpNDate.Value = DateTime.Today;

            swNAInner.Enabled = oPerms.IsAbsolute;

            chtBNC.LabelFormatter = i => "";
            chtBNC.From = 0;
            chtBNC.To = 100;
        }

///     <summary>
///         Actualiza los controles de Nueva Factura.
///     </summary>
        private void NewBillsRefresh() {
            dgvUsers.Fill();
            txNBillID.Text = (CF.GetAI(out int iN) == Result.Success ? iN : 0).ToString();
            txNPrice.Clear();
            txNDesc.Clear();

            NewBillsFillMPrice();
            NewBillsFillDailyGoal();
            NewBillsFillNC();
        }

///     <summary>
///         Llena el monto del mes.
///     </summary>
        private void NewBillsFillMPrice() {
            decimal.TryParse(txNPrice.Text, out decimal mPrice);
            lbNMPrice.Text = $"${oStats.MonthSumPrice + mPrice:N}";
        }

///     <summary>
///         Llena el monto diario maximo.
///     </summary>
        private void NewBillsFillDailyGoal() {
            decimal.TryParse(txNPrice.Text, out decimal mPrice);
            decimal mDailyMax = oStats.DailyMaxPrice;
            decimal mDaily = oStats.DailySumPrice + mPrice;

            lbBDailyGoalTitle.Text = $"Monto diario maximo dentro de la\r\ncategoría actual: ${mDailyMax:N}";
            pbBDailyGoal.Value = (int)Math.Min(mDaily / mDailyMax * 100, 100);
            lbBDailyGoalPercent.Text = Math.Round(mDaily / mDailyMax * 100, 1) + "%";
            lbBDailyGoalPrice.Text = $"${mDaily:N}";
        }

///     <summary>
///         Llena el grafico de siguiente categoria.
///     </summary>
        private void NewBillsFillNC() {
            decimal.TryParse(txNPrice.Text, out decimal mPrice);

            chtBNC.FromColor = System.Windows.Media.Color.FromRgb(
                SkinManager.ColorScheme.AccentColor.R, SkinManager.ColorScheme.AccentColor.G, SkinManager.ColorScheme.AccentColor.B
            );
            Color oRedColor = DrawHelper.BlendColor(SkinManager.BackgroundHoverRedColor, SkinManager.ColorScheme.AccentColor, 125);
            chtBNC.ToColor = System.Windows.Media.Color.FromRgb(oRedColor.R, oRedColor.G, oRedColor.B);

            chtBNC.Value = oStats.GetNextCategoryDistance(oStats.MonthSumPrice + mPrice) * 100;
            lbBNCValue.Text = (int)chtBNC.Value + "%";
            lbBNCFrom.Text = "Categoría " + oShop.CategoriaLetra;
            lbBNCTo.Text = (oShop.CategoriaLetra < 'K' ? "Categoría " + (char)(oShop.CategoriaLetra + 1) : "");
        }
        
///     <summary>
///         Comprueba la entrada para el formulario de Nueva Factura.
///     </summary>
        private bool NewBillsCheckInput() {
            if (!this.bNewBillsHoverBtn)
                lbNError.Visible = false;
            string sError = "";

//          Comprueba txNPrice
            if (txNPrice.ErrorState = string.IsNullOrEmpty(txNPrice.Text))
                txNPrice.Hint = sError = "Monto incompleto";
            else if (txNPrice.ErrorState = !decimal.TryParse(txNPrice.Text, out decimal mN) || mN < 1)
                txNPrice.Hint = sError = "Monto inválido";
            else
                txNPrice.Hint = "Monto";

//          Comprueba txNBillID
            if (txNBillID.ErrorState = string.IsNullOrEmpty(txNBillID.Text))
                txNBillID.Hint = sError = "ID incompleto";
            else if (txNBillID.ErrorState = !int.TryParse(txNBillID.Text, out int iN) || iN < 1)
                txNBillID.Hint = sError = "ID inválido";
            else
                txNBillID.Hint = "ID de la factura";

            lbNError.Text = sError;
            return sError == "";
        }
        
///     <summary>
///         Evento de cambio de valores de los controles del formulario de Nueva Factura.
///     </summary>
        private void NewBillsCtrlsValueChanged(object sender, EventArgs e) {
            NewBillsCheckInput();
        }

///     <summary>
///         Evento KeyPress de txNBillID para permitir solo la insersion de numeros.
///     </summary>
        private void txNBillID_KeyPress(object sender, KeyPressEventArgs e) {
            TextBox oCtrl = sender as TextBox;
            if (oCtrl != null)
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

///     <summary>
///         Evento TextChanged de txNPrice para actualizar las estadisticas y graficos.
///     </summary>
        private void txNPrice_TextChanged(object sender, EventArgs e) {
            NewBillsCheckInput();
            NewBillsFillMPrice();
            NewBillsFillDailyGoal();
            NewBillsFillNC();
        }

///     <summary>
///         Evento KeyPress de txNPrice para permitir solo la insersion del formato decimal.
///     </summary>
        private void txNPrice_KeyPress(object sender, KeyPressEventArgs e) {
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
///         Evento CheckedChanged de swNAInner para permitir la modificacion de valores autogenerados.
///     </summary>
        private void swNAInner_CheckedChanged(object sender, EventArgs e) {
            CheckBox oCtrl = sender as CheckBox;
            if (oCtrl != null) {
                tlpNAddInner.MaterialBackColor = oCtrl.Checked ? MaterialSkinManager.Colors.BackgroundColor
                                                               : MaterialSkinManager.Colors.BackdropColor;
                cbNDNI.Enabled =
                txNBillID.Enabled =
                dtpNDate.Enabled = oCtrl.Checked;
            }
        }

///     <summary>
///         Evento Click de bnNAdd en el formulario de Nueva Factura.
///         Añade una nueva factura en el sistema.
///     </summary>
        private void bnNAdd_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                if (!NewBillsCheckInput()) {
                    lbSAError.Visible = true;
                    return;
                }

                Result oResult = CF.Add(new Factura() {
                    ID = oPerms.IsAbsolute ? (int?)int.Parse(txNBillID.Text) : null,
                    Fecha = oPerms.IsAbsolute ? dtpNDate.Value : DateTime.Today,
                    Monto = decimal.Parse(txNPrice.Text),
                    Descripcion = txNDesc.Text,
                    TipoPagoID = Convert.ToInt32(((DataRowView)cbNPayType.SelectedItem)["ID"]),
                    UsuarioDNI = oPerms.IsAbsolute ? Convert.ToInt32(((DataRowView)cbNDNI.SelectedItem)["DNI"]) : oUser.DNI,
                    NegocioID = oShop.ID
                });

                if (oResult == Result.Success) {
                    new MaterialDialog(
                        this, "", "Factura añadida con exito", "Aceptar"
                    ).ShowDialog(this);

                    NewBillsRefresh();
                }
                else if (oResult == Result.IncorrectInput) {
                    NewBillsCheckInput();
                    lbNError.Visible = true;
                }
                else if (oResult == Result.ConnError) {
                    lbNError.Text = "Error: no se ha podido conectar a la base de datos";
                    lbNError.Visible = true;
                }
                else if (oResult == Result.Error) {
                    lbNError.Text = "Error: " + CF.LastError.Message;
                    lbNError.Visible = true;
                }
            }
        }
        
///     <summary>
///         Evento MouseEnter de pnNAdd para mostrar la Label de error (lbNError) en el formulario de Nueva Factura.
///         Este evento no fue añadido directamente al boton de Agregar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnNAdd_MouseEnter(object sender, EventArgs e) {
            this.bNewBillsHoverBtn =
            this.lbNError.Visible = true;
        }

///     <summary>
///         Evento MouseLeave de pnNAdd para ocultar la Label de error (lbNError) en el formulario de Nueva Factura.
///         Este evento no fue añadido directamente al boton de Agregar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnNAdd_MouseLeave(object sender, EventArgs e) {
            this.bNewBillsHoverBtn =
            this.lbNError.Visible = false;
        }
        
///     <summary>
///         Evento TextChanged de lbNError en el formulario de Nueva Factura.
///         Habilita o deshabilita el boton de Agregar dependiendo si hay o no errores.
///     </summary>
        private void lbNError_TextChanged(object sender, EventArgs e) {
            Label oCtrl = sender as Label;
            if (oCtrl != null)
                bnNAdd.Enabled = oCtrl.Text == "";
        }

//      - Facturas -
///     <summary>
///         Inicializa los controles de Facturas.
///     </summary>
        private void BillsInit() {
            dtpBStartDate.Value = DateTime.Now;
            BillsChangeMonth(0);

            if (CF.GetColumns(out List<string> oColumns) == Result.Success) {
                cbBSearchCols.Items.Add("Todos");
                cbBSearchCols.Items.AddRange(oColumns.ToArray());
                cbBSearchCols.SelectedIndex = 0;
            }

            dgvBills.SourceQuery = (int iOffset, int iLimit, string sOrderBy) => {
                Result oResult = CF.GetAll(out DataTable oBills, iOffset, iLimit, sOrderBy: sOrderBy);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvBills.SourceQuery.call", CF.LastError);
                return oBills;
            };

            dgvBills.TotalItemsQuery = () => {
                Result oResult = CF.GetCount(out int iCount);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvBills.TotalItemsQuery.call", CF.LastError);
                return iCount;
            };

            dgvBills.ModifyQuery = (oRow) => {
                if (oModifyBills == null || oModifyBills.IsDisposed) {
                    oModifyBills = new fModifyBills(this);
                    SkinManager.AddFormToManage(oModifyBills);
                    oModifyBills.VisibleChanged += (sender, e) => {
                        if (oModifyBills.ExitCode == Result.Success)
                            BillsRefresh();
                    };
                }

                if (CF.Get(out Factura oBill, Convert.ToInt32(oRow.Cells["ID"].Value)) == Result.Success) {
                    oModifyBills.Bill = oBill;
                    oModifyBills.Show();
                }
            };

            dgvBills.DeleteQuery = (oRows) => {
                if (oRows.Count > 0) {
                    string sRows = "";
                    foreach (DataGridViewRow oRow in oRows) {
                        foreach (DataGridViewCell oCell in oRow.Cells)
                            sRows += oCell.OwningColumn.Name + ": " + oCell.Value + "; ";
                        sRows += "\n";
                    }
                    sRows.Substring(0, sRows.Length - 1);

                    MaterialDialog oDialog = new MaterialDialog(
                        this, "¿Está seguro que desea eliminar las siguientes facturas?", sRows, "Continuar", true, "Cancelar"
                    );

                    if (oDialog.ShowDialog(this) == DialogResult.OK) {
                        foreach (DataGridViewRow oRow in oRows.ToList())
                            if (CF.Delete(Convert.ToInt32(oRow.Cells["ID"].Value)) != Result.Success)
                                oRows.Remove(oRow);

                        return oRows;
                    }
                }
                return new List<DataGridViewRow>();
            };

            chtBPayTypes.LegendLocation = LegendLocation.Bottom;
            chtBPayTypes.ForeColor = SkinManager.TextHighEmphasisColor;
        }

///     <summary>
///         Actualiza los controles de Facturas.
///     </summary>
        private void BillsRefresh() {
            CF.SetWhereFilter(cbBSearchCols.SelectedIndex - 1, txBSearch.Text, dtpBStartDate.Value, dtpBEndDate.Value);

            pnBDateArrow.Text = "Diferencia de " + ((dtpBEndDate.Value - dtpBStartDate.Value).Days + 1) + " días";
            pnBDateArrow.Refresh();

            dgvBills.Fill();

            BillsFillSumPrices();
            BillsFillPrices();
            BillsFillPayTypes();
        }

///     <summary>
///         Llena la suma de montos de las Facturas.
///     </summary>
        private void BillsFillSumPrices() {
            if (CF.SumPrice(out decimal mN) == Result.Success)
                lbBTPrice.Text = $"${mN:N}";
        }

///     <summary>
///         Llena el grafico de montos de las Facturas.
///     </summary>
        private void BillsFillPrices() {
            if (CF.GroupBy(out DataTable oBills, "fecha, SUM(monto) AS monto", "fecha") == Result.Success) {
                List<DateTime> oDatesList = oBills.Rows.Cast<DataRow>().Select(i => Convert.ToDateTime(i["fecha"])).ToList();
                List<decimal> oPricesList = oBills.Rows.Cast<DataRow>().Select(i => Convert.ToDecimal(i["monto"])).ToList();

                chtBPrices.AxisX.Clear();
                chtBPrices.AxisX.Add(new Axis {
                    Title = "Día",
                    Labels = oDatesList.Select(i => i.ToString(Regex.Replace(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern, @"^y+\W+|\W+y+$", ""))).ToList()
                });
                chtBPrices.AxisY.Clear();
                chtBPrices.AxisY.Add(new Axis {
                    Title = "Monto",
                    LabelFormatter = i => Math.Abs(i) > 999 ? Math.Round((i / 1000), 2).ToString() + "k" : i.ToString()
                });
                chtBPrices.Series.Clear();
                chtBPrices.Series.Add(new LineSeries() {
                    Values = new ChartValues<decimal>(oPricesList)
                });
            }
        }

///     <summary>
///         Llena el grafico de tipos de pago de las facturas.
///     </summary>
        private void BillsFillPayTypes() {
            if (CF.CountPayTypes(out DataTable oTable) == Result.Success) {
                chtBPayTypes.Series.Clear();
                foreach (DataRow oRow in oTable.Rows) {
                    chtBPayTypes.Series.Add(new PieSeries() { 
                        Title = oRow["Tipo de pago"].ToString(),
                        Values = new ChartValues<double> { Convert.ToDouble(oRow["Count"]) }
                    });
                }
                chtBPayTypes.DefaultLegend.Foreground = new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Color.FromRgb(
                        SkinManager.TextHighEmphasisColor.R,
                        SkinManager.TextHighEmphasisColor.G,
                        SkinManager.TextHighEmphasisColor.B
                    )
                );
            }
        }

///     <summary>
///         Evento de cambio de valores de los controles del filtro de busqueda en Facturas.
///     </summary>
        private void BillsCtrlsValueChanged(object sender, EventArgs e) {
            if (sender != cbBSearchCols || txBSearch.Text != "")
                BillsRefresh();
        }
        
///     <summary>
///         Cambia el mes del filtro de busqueda en Facturas.
///     </summary>
///     <param name="iAddSub"> Cuantos meses agregar o restar. </param>
        private void BillsChangeMonth(int iAddSub) {
            dtpBStartDate.ValueChanged -= BillsCtrlsValueChanged;
            dtpBEndDate.ValueChanged -= BillsCtrlsValueChanged;

            DateTime oMinDate = CF.GetEarliestDate(out DateTime? oDate) == Result.Success ? oDate ?? DateTime.MinValue : DateTime.MinValue;
            DateTime oMaxDate = DateTime.Today;

            DateTime oStartDate = dtpBStartDate.Value.AddMonths(iAddSub);
            oStartDate = new DateTime(oStartDate.Year, oStartDate.Month, 1);
            oStartDate = oStartDate > oMaxDate ? new DateTime(oMaxDate.Year, oMaxDate.Month, 1) : oStartDate;
            oStartDate = oStartDate < oMinDate ? oMinDate : oStartDate;

            DateTime oEndDate = new DateTime(oStartDate.Year, oStartDate.Month, DateTime.DaysInMonth(oStartDate.Year, oStartDate.Month));
            oEndDate = oEndDate > oMaxDate ? oMaxDate : oEndDate;

            dtpBStartDate.Value = oStartDate;
            dtpBEndDate.Value = oEndDate;
            
            dtpBStartDate.ValueChanged += BillsCtrlsValueChanged;
            dtpBEndDate.ValueChanged += BillsCtrlsValueChanged;

            BillsRefresh();
        }

///     <summary>
///         Evento Click del boton bnBPrevMonth.
///     </summary>
        private void bnBPrevMonth_Click(object sender, EventArgs e) {
            BillsChangeMonth(-1);
        }

///     <summary>
///         Evento Click del boton bnBNextMonth.
///     </summary>
        private void bnBNextMonth_Click(object sender, EventArgs e) {
            BillsChangeMonth(1);
        }

//      - Usuarios -
///     <summary>
///         Inicializa los controles de Usuarios.
///     </summary>
        private void UsersInit() {
            if (CU.GetColumns(out List<string> oColumns) == Result.Success) {
                cbUSearchCols.Items.Add("Todos");
                cbUSearchCols.Items.AddRange(oColumns.ToArray());
                cbUSearchCols.SelectedIndex = 0;
            }

            dgvUsers.SourceQuery = (int iOffset, int iLimit, string sOrderBy) => {
                Result oResult = CU.GetAll(out DataTable oUsers, iOffset, iLimit, sOrderBy: sOrderBy);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvUsers.SourceQuery.call", CU.LastError);
                return oUsers;
            };

            dgvUsers.TotalItemsQuery = () => {
                Result oResult = CU.GetCount(out int iCount);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvUsers.TotalItemsQuery.call", CU.LastError);
                return iCount;
            };

            dgvUsers.AddQuery = () => {
                if (oSignUp == null || oSignUp.IsDisposed) {
                    oSignUp = new fSignUp(this);
                    SkinManager.AddFormToManage(oSignUp);
                    oSignUp.VisibleChanged += (sender, e) => {
                        if (oSignUp.ExitCode == UsuarioResult.Success)
                            dgvUsers.Fill();
                    };
                }

                oSignUp.Show();
            };

            if (oPerms.IsAbsolute) {
                dgvUsers.DeleteQuery = (oRows) => {
                    if (oRows.Count > 0) {
                        string sRows = "";
                        foreach (DataGridViewRow oRow in oRows) {
                            foreach (DataGridViewCell oCell in oRow.Cells)
                                sRows += oCell.OwningColumn.Name + ": " + oCell.Value + "; ";
                            sRows += "\n";
                        }
                        sRows.Substring(0, sRows.Length - 1);

                        MaterialDialog oDialog = new MaterialDialog(
                            this, "¿Está seguro que desea eliminar los siguientes usuarios?", sRows, "Continuar", true, "Cancelar"
                        );

                        if (oDialog.ShowDialog(this) == DialogResult.OK) {
                            int iDNI;
                            foreach (DataGridViewRow oRow in oRows.ToList()) {
                                iDNI = Convert.ToInt32(oRow.Cells["DNI"].Value);
                                if (iDNI == oUser.DNI || CU.Delete(iDNI) != UsuarioResult.Success)
                                    oRows.Remove(oRow);
                            }

                            return oRows;
                        }
                    }
                    return new List<DataGridViewRow>();
                };
            }

            dgvUsersLogIns.SourceQuery = (int iOffset, int iLimit, string sOrderBy) => {
                UsuarioResult oResult = CU.GetLogIns(out DataTable oLogIns, iOffset, iLimit, sOrderBy);
                if (oResult != UsuarioResult.Success)
                    OnHandledException(oResult, "dgvUsersLogIns.SourceQuery.call", CU.LastError);
                return oLogIns;
            };

            dgvUsersLogIns.TotalItemsQuery = () => {
                UsuarioResult oResult = CU.CountLogIns(out int iCount);
                if (oResult != UsuarioResult.Success)
                    OnHandledException(oResult, "dgvUsersLogIns.TotalItemsQuery.call", CU.LastError);
                return iCount;
            };

            dgvUsersLogIns.OrderBy = "`Ultimo LogIn` DESC";
        }

///     <summary>
///         Actualiza los controles de Usuarios.
///     </summary>
        private void UsersRefresh() {
            dgvUsers.Fill();
            dgvUsersLogIns.Fill();
        }
        
///     <summary>
///         Evento de cambio de valores de los controles de la barra de busqueda de Usuarios.
///     </summary>
        private void UsersCtrlsValueChanged(object sender, EventArgs e) {
            if (sender != cbUSearchCols || txUSearch.Text != "") {
                CU.SetWhereFilter(cbUSearchCols.SelectedIndex - 1, txUSearch.Text);
                dgvUsers.Fill();
            }
        }

//      - Ajustes -
///     <summary>
///         Inicializa los controles de Ajustes.
///     </summary>
        private void SettingsInit() {
//          Tablas internas
            dgvSITCategories.Dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSITCategories.Dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvSITCategories.Dgv.ReadOnly = false;

            decimal dgvSITCategoriesLastValue = 0m;
            dgvSITCategories.Dgv.CellBeginEdit += (sender, e) => { 
                DataGridView oCtrl = sender as DataGridView;
                if (oCtrl != null) {
                    if (e.ColumnIndex == 0)
                        e.Cancel = true;
                    else if (decimal.TryParse(oCtrl[e.ColumnIndex, e.RowIndex].Value.ToString(), out decimal mPrice))
                        dgvSITCategoriesLastValue = mPrice;
                    else
                        dgvSITCategoriesLastValue = 0m;
                }
            };

            dgvSITCategories.Dgv.CellEndEdit += (sender, e) => { 
                DataGridView oCtrl = sender as DataGridView;
                if (oCtrl != null) {
                    if (decimal.TryParse(oCtrl["Monto", e.RowIndex].Value.ToString(), out decimal mPrice))
                        CC.Update(Convert.ToChar(oCtrl["Letra", e.RowIndex].Value), mPrice);
                    else
                        oCtrl[e.ColumnIndex, e.RowIndex].Value = dgvSITCategoriesLastValue;
                }
            };

            dgvSITCategories.Dgv.DataError += (sender, e) => {
                DataGridView oCtrl = sender as DataGridView;
                if (oCtrl != null) {
                    oCtrl[e.ColumnIndex, e.RowIndex].Value = dgvSITCategoriesLastValue;
                    oCtrl.RefreshEdit();
                }
            };

            dgvSITCategories.SourceQuery = (int iOffset, int iLimit, string sOrderBy) => {
                Result oResult = CC.GetAll(out DataTable oCategories, iOffset, iLimit, sOrderBy: sOrderBy);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvSITCategories.SourceQuery.call", CC.LastError);
                return oCategories;
            };

            dgvSITCategories.TotalItemsQuery = () => {
                Result oResult = CC.GetCount(out int iCount);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvSITCategories.TotalItemsQuery.call", CC.LastError);
                return iCount;
            };

            dgvSITPayTypes.Dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSITPayTypes.Dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvSITPayTypes.Dgv.ReadOnly = false;

            dgvSITPayTypes.Dgv.CellBeginEdit += (sender, e) => { 
                if (e.ColumnIndex == 0)
                    e.Cancel = true;
            };

            dgvSITPayTypes.Dgv.CellEndEdit += (sender, e) => { 
                DataGridView oCtrl = sender as DataGridView;
                if (oCtrl != null) {
                    CTP.Update(
                        Convert.ToInt32(oCtrl["ID", e.RowIndex].Value), 
                        Convert.ToString(oCtrl["Nombre", e.RowIndex].Value)
                    );
                }
            };

            dgvSITPayTypes.SourceQuery = (int iOffset, int iLimit, string sOrderBy) => {
                Result oResult = CTP.GetAll(out DataTable oTypes,iOffset, iLimit, sOrderBy: sOrderBy);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvSITPayTypes.SourceQuery.call", CTP.LastError);
                return oTypes;
            };

            dgvSITPayTypes.TotalItemsQuery = () => {
                Result oResult = CTP.GetCount(out int iCount);
                if (oResult != Result.Success)
                    OnHandledException(oResult, "dgvSITPayTypes.SourceQuery.call", CTP.LastError);
                return iCount;
            };

            dgvSITPayTypes.AddQuery = () => {
                CTP.Add(Tuple.Create<object, string>(null, ""));
                dgvSITPayTypes.Fill();
            };

            dgvSITPayTypes.DeleteQuery = (oRows) => {
                if (oRows.Count > 0) {
                    string sRows = "";
                    foreach (DataGridViewRow oRow in oRows) {
                        foreach (DataGridViewCell oCell in oRow.Cells)
                            sRows += oCell.OwningColumn.Name + ": " + oCell.Value + "; ";
                        sRows += "\n";
                    }
                    sRows.Substring(0, sRows.Length - 1);

                    MaterialDialog oDialog = new MaterialDialog(
                        this, "¿Está seguro que desea eliminar los siguientes tipos de pago?", sRows, "Continuar", true, "Cancelar"
                    );

                    if (oDialog.ShowDialog(this) == DialogResult.OK) {
                        foreach (DataGridViewRow oRow in oRows.ToList())
                            if (CTP.Delete(Convert.ToInt32(oRow.Cells["ID"].Value)) != Result.Success)
                                oRows.Remove(oRow);

                        return oRows;
                    }
                }
                return new List<DataGridViewRow>();
            };

//          Negocio
            if (!oPerms.CanAccessSettings) 
                tcSSettings.TabPages.Remove(tpSShop);
            else {
                if (!tcSSettings.Contains(tpSShop))
                    tcSSettings.TabPages.Insert(2, tpSShop);
                
                lbSSTitle.Text = $"Negocio ID {oShop.ID}";

                txSSCategory.Text = oShop.CategoriaLetra.ToString();
                txSSWeekDays.Text = oShop.DiasSemanales.ToString();

                dgvSSHolidays.Dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvSSHolidays.Dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dgvSSHolidays.Dgv.ReadOnly = false;

                dgvSSHolidays.Dgv.DataSourceChanged += (sender, e) => {
                    dgvSSHolidays.Dgv.Columns["ID"].Visible = false;
                    dgvSSHolidays.Dgv.Columns["Fecha de inicio"].DefaultCellStyle.Format =
                    dgvSSHolidays.Dgv.Columns["Fecha de fin"].DefaultCellStyle.Format =
                        Regex.Replace(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern, @"\/yyyy|yyyy\/", "");
                };

                DateTime dgvSSHolidaysLastValue = DateTime.Today;
                dgvSSHolidays.Dgv.CellBeginEdit += (sender, e) => { 
                    DataGridView oCtrl = sender as DataGridView;
                    if (oCtrl != null) {
                        if (e.ColumnIndex == 0)
                            e.Cancel = true;
                        else if (DateTime.TryParse(oCtrl[e.ColumnIndex, e.RowIndex].Value.ToString(), out DateTime oDate))
                            dgvSSHolidaysLastValue = oDate;
                        else
                            dgvSSHolidaysLastValue = DateTime.Today;
                    }
                };

                dgvSSHolidays.Dgv.CellEndEdit += (sender, e) => { 
                    DataGridView oCtrl = sender as DataGridView;
                    if (oCtrl != null) {
                        if (DateTime.TryParse(oCtrl["Fecha de inicio", e.RowIndex].Value.ToString(), out DateTime oStartDate) &&
                            DateTime.TryParse(oCtrl["Fecha de fin", e.RowIndex].Value.ToString(), out DateTime oEndDate)) {
                            CN.UpdateHoliday(
                                Convert.ToInt32(oCtrl["ID", e.RowIndex].Value),
                                oStartDate,
                                oEndDate
                            );
                            oStats.SetHolidays();
                        }
                    }
                };
                
                dgvSSHolidays.Dgv.DataError += (sender, e) => {
                    DataGridView oCtrl = sender as DataGridView;
                    if (oCtrl != null) {
                        oCtrl[e.ColumnIndex, e.RowIndex].Value = dgvSSHolidaysLastValue;
                        oCtrl.RefreshEdit();
                    }
                };

                dgvSSHolidays.SourceQuery += (int iOffset, int iLimit, string sOrderBy) => {
                    Result oResult = CN.GetHolidays(out DataTable oHolidays, (int)oShop.ID, iOffset, iLimit, sOrderBy);
                    if (oResult != Result.Success)
                        OnHandledException(oResult, "dgvSITPayTypes.SourceQuery.call", CN.LastError);
                    return oHolidays;
                };

                dgvSSHolidays.TotalItemsQuery += () => {
                    Result oResult = CN.CountHolidays(out int iCount, (int)oShop.ID);
                    if (oResult != Result.Success)
                        OnHandledException(oResult, "dgvSITPayTypes.SourceQuery.call", CN.LastError);
                    return iCount;
                };

                dgvSSHolidays.AddQuery += () => {
                    Result oResult = CN.AddHoliday(DateTime.Today.Date, DateTime.Today.Date, (int)oShop.ID);
                    if (oResult != Result.Success)
                        OnHandledException(oResult, "dgvSITPayTypes.AddQuery.call", CN.LastError);

                    dgvSSHolidays.Fill();
                    oStats.SetHolidays();
                };

                dgvSSHolidays.DeleteQuery += (oRows) => {
                    if (oRows.Count > 0) {
                        string sRows = "";
                        foreach (DataGridViewRow oRow in oRows) {
                            foreach (DataGridViewCell oCell in oRow.Cells)
                                sRows += oCell.OwningColumn.Name + ": " + (oCell.Value is DateTime
                                    ? Regex.Replace(((DateTime)oCell.Value).ToShortDateString(), @"\/\d{4}|\d{4}\/", "")
                                    : oCell.Value) + "; ";
                            sRows += "\n";
                        }
                        sRows.Substring(0, sRows.Length - 1);

                        MaterialDialog oDialog = new MaterialDialog(
                            this, "¿Está seguro que desea eliminar los siguientes periodos de vacaciones?", sRows, "Continuar", true, "Cancelar"
                        );

                        if (oDialog.ShowDialog(this) == DialogResult.OK) {
                            foreach (DataGridViewRow oRow in oRows.ToList())
                                if (CN.DeleteHoliday(Convert.ToInt32(oRow.Cells["ID"].Value)) != Result.Success)
                                    oRows.Remove(oRow);

                            return oRows;
                        }
                        oStats.SetHolidays();
                    }
                    return new List<DataGridViewRow>();
                };
            }

            cbSCTheme.SelectedIndexChanged -= CtrlsSettingsCustomValueChanged;
            cbSCPrimary.SelectedIndexChanged -= CtrlsSettingsCustomValueChanged;
            cbSCDark.SelectedIndexChanged -= CtrlsSettingsCustomValueChanged;
            cbSCLight.SelectedIndexChanged -= CtrlsSettingsCustomValueChanged;
            cbSCAccent.SelectedIndexChanged -= CtrlsSettingsCustomValueChanged;
            cbSCTextShade.SelectedIndexChanged -= CtrlsSettingsCustomValueChanged;

            List<Primary> oPrimaries = ((Primary[])Enum.GetValues(typeof(Primary))).OrderBy(i => Regex.Replace(i.ToString(), @"50$", "050")).ToList();
            List<Accent> oAccents = ((Accent[])Enum.GetValues(typeof(Accent))).OrderBy(i => i.ToString()).ToList();
            List<TextShade> oTextShades = ((TextShade[])Enum.GetValues(typeof(TextShade))).OrderBy(i => i.ToString()).ToList();

            cbSCPrimary.DataSource = oPrimaries;
            cbSCDark.DataSource = new List<Primary>(oPrimaries);
            cbSCLight.DataSource = new List<Primary>(oPrimaries);
            cbSCAccent.DataSource = oAccents;
            cbSCTextShade.DataSource = oTextShades;

            cbSCTheme.SelectedIndex = oSets.Theme;
            cbSCPrimary.SelectedIndex = oPrimaries.IndexOf(oSets.Primary);
            cbSCDark.SelectedIndex = oPrimaries.IndexOf(oSets.Dark);
            cbSCLight.SelectedIndex = oPrimaries.IndexOf(oSets.Light);
            cbSCAccent.SelectedIndex = oAccents.IndexOf(oSets.Accent);
            cbSCTextShade.SelectedIndex = oTextShades.IndexOf(oSets.TextShade);
            
            cbSCTheme.SelectedIndexChanged += CtrlsSettingsCustomValueChanged;
            cbSCPrimary.SelectedIndexChanged += CtrlsSettingsCustomValueChanged;
            cbSCDark.SelectedIndexChanged += CtrlsSettingsCustomValueChanged;
            cbSCLight.SelectedIndexChanged += CtrlsSettingsCustomValueChanged;
            cbSCAccent.SelectedIndexChanged += CtrlsSettingsCustomValueChanged;
            cbSCTextShade.SelectedIndexChanged += CtrlsSettingsCustomValueChanged;

            swSCSaveLastRect.Checked = oSets.SaveLastRect;
        }

///     <summary>
///         Actualiza los controles de una pestaña de Ajustes.
///     </summary>
///     <param name="oTab"> Pestaña a actualizar. </param>
        private void SettingsRefresh(TabPage oTab) {
            if (oTab == tpSInnerTables) {
                dgvSITPayTypes.Fill();
                dgvSITCategories.Fill();
                this.AcceptButton = null;
                this.Text = "Tablas internas - SAF";
            }
            else if (oTab == tpSAccount) {
                SettingsAccountInitInput();
                this.AcceptButton = bnSAUpdate;
                this.Text = "Cuenta - SAF";
            }
            else if (oTab == tpSShop) {
                dgvSSHolidays.Fill();
                this.AcceptButton = null;
                this.Text = "Negocio - SAF";
            }
            else if (oTab == tpSCustom) {
                this.AcceptButton = null;
                this.Text = "Personalización - SAF";
            }
            else if (oTab == tpSAbout) {
                this.AcceptButton = bnSBOpen;
                this.Text = "Acerca de - SAF";
            }
        }

///     <summary>
///         Event SelectedIndexChanged de tcSSettings para actualizar la pestaña seleccionada.
///     </summary>
        private void tcSSettings_SelectedIndexChanged(object sender, EventArgs e) {
            TabControl oCtrl = sender as TabControl;
            if (oCtrl != null && oCtrl.Visible)
                SettingsRefresh(oCtrl.SelectedTab);
        }

///     <summary>
///         Inicializa la entrada en la pestaña Cuenta.
///     </summary>
        private void SettingsAccountInitInput() {
            txSADNI.Text = oUser.DNI.ToString();
            txSAName.Text = oUser.Nombre;
            txSALastName.Text = oUser.Apellido;
            txSAPass.Clear();
            txSANewPass.Clear();
            txSARepNewPass.Clear();
            txSAEmail.Text = oUser.Email;
            txSAPhone.Text = oUser.Telefono;
            txSADetails.Text = oUser.Detalles;
        }

///     <summary>
///         Comprueba la entrada en la pestaña Cuenta.
///     </summary>
        private bool SettingsAccountCheckInput() {
            string sError = "";
            int iDNI = -1;
            if (!this.bSettingsAccountHoverBtn)
                lbSAError.Visible = false;
            
//          Comprueba txSARepNewPass
            if (txSARepNewPass.ErrorState = string.IsNullOrEmpty(txSARepNewPass.Text) && !string.IsNullOrEmpty(txSANewPass.Text))
                txSARepNewPass.Hint = sError = "Contraseña incompleta";
            else if (txSARepNewPass.ErrorState = txSANewPass.Text != txSARepNewPass.Text)
                txSARepNewPass.Hint = sError = "Las contraseñas no coinciden";
            else
                txSARepNewPass.Hint = "Repita la contraseña";
            
//          Comprueba txSAPass
            if (txSAPass.ErrorState = string.IsNullOrEmpty(txSAPass.Text) && !string.IsNullOrEmpty(txSANewPass.Text))
                txSAPass.Hint = sError = "Contraseña incompleta";
            else
                txSAPass.Hint = "Contraseña actual";

//          Comprueba txSANewPass
            if (!(txSANewPass.ErrorState = !string.IsNullOrEmpty(txSANewPass.Text)))
                txSANewPass.Hint = "Contraseña";
            else if (txSANewPass.ErrorState = txSANewPass.Text.Length < 8)
                txSANewPass.Hint = sError = "La contraseña debe tener al menos 8 digitos";
            else if (txSANewPass.ErrorState = !txSANewPass.Text.Any(char.IsLower))
                txSANewPass.Hint = sError = "La contraseña debe contener al menos una minúscula";
            else if (txSANewPass.ErrorState = !txSANewPass.Text.Any(char.IsUpper))
                txSANewPass.Hint = sError = "La contraseña debe contener al menos una mayúscula";
            else if (txSANewPass.ErrorState = !txSANewPass.Text.Any(char.IsNumber))
                txSANewPass.Hint = sError = "La contraseña debe contener al menos un número";
            else
                txSANewPass.Hint = "Contraseña";

//          Comprueba txSAEmail
            if (txSAEmail.ErrorState = !string.IsNullOrEmpty(txSAEmail.Text) && 
                                     !Regex.IsMatch(txSAEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                txSAEmail.Hint = sError = "Email formato incorrecto";
            else
                txSAEmail.Hint = "Email";

//          Comprueba txSADNI
            if (txSADNI.ErrorState = string.IsNullOrEmpty(txSADNI.Text))
                txSADNI.Hint = sError = "DNI incompleto";
            else if (txSADNI.ErrorState = !int.TryParse(txSADNI.Text, out iDNI) || iDNI < 1)
                txSADNI.Hint = sError = "DNI inválido";
            else
                txSADNI.Hint = "DNI";

//          Comprueba si los valores cambiaron
            if (iDNI == oUser.DNI && txSAName.Text == (oUser.Nombre ?? "") && txSALastName.Text == (oUser.Apellido ?? "") &&
                txSAEmail.Text == (oUser.Email ?? "") && txSAPhone.Text == (oUser.Telefono ?? "") &&
                txSADetails.Text == (oUser.Detalles ?? "") && txSANewPass.Text == "")
                sError = "Actualice algun valor";

            lbSAError.Text = sError;
            return sError == "";
        }

///     <summary>
///         Evento de cambio de valores de los controles en la pestaña Cuenta.
///     </summary>
        private void CtrlsSettingsAccountValueChanged(object sender, EventArgs e) {
            SettingsAccountCheckInput();
        }

///     <summary>
///         Evento KeyPress de txSAPhone en la pestaña Cuenta para mantener el formato de numero telefonico.
///     </summary>
        private void txSAPhone_KeyPress(object sender, KeyPressEventArgs e) {
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
///         Evento KeyUp de txSAPhone en la pestaña Cuenta para mantener el formato de numero telefonico.
///     </summary>
        private void txSAPhone_KeyUp(object sender, KeyEventArgs e) {
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
///         Evento (Focus)Enter de txSAPhone en la pestaña Cuenta para corregir la seleccion dentro del formato de numero telefonico.
///     </summary>
        private void txSAPhone_Enter(object sender, EventArgs e) {
            MaskedTextBox oCtrl = sender as MaskedTextBox;
            if (oCtrl != null)
                oCtrl.SelectionStart = Regex.Match(oCtrl.Text, @"\d$").Index + 1;
        }

///     <summary>
///         Evento Click de bnSAUpdate en la pestaña Cuenta.
///         Actualiza los datos de la cuenta del usuario actual.
///     </summary>
        private void bnSAUpdate_Click(object sender, EventArgs e) {
            Button oCtrl = sender as Button;
            if (oCtrl != null) {
                if (!SettingsAccountCheckInput()) {
                    lbSAError.Visible = true;
                    return;
                }

                if (string.IsNullOrEmpty(txSANewPass.Text)) 
                    Resolve();
                else {
                    CU.LogIn((int)oUser.DNI, txSAPass.Text, (nResult) => {
                        if (txSAPass.ErrorState = nResult == UsuarioResult.Success)
                            Resolve();
                        else {
                            lbSAError.Visible = true;
                            lbSAError.Text = txSAPass.Hint = "Contraseña incorrecta";
                        }
                    });
                }

                void Resolve() {
                    bool bDNI = false;
                    int iDNI;
                    CU.Update((int)oUser.DNI, new Usuario() {
                        DNI = (bDNI = int.TryParse(txSADNI.Text, out iDNI)) ? (int?)iDNI : null,
                        Pass = txSANewPass.Text != "" ? txSANewPass.Text : null,
                        Nombre = txSAName.Text != oUser.Nombre ? txSAName.Text : null,
                        Apellido = txSALastName.Text != oUser.Apellido ? txSALastName.Text : null,
                        Email = txSAEmail.Text != oUser.Email ? txSAEmail.Text : null,
                        Telefono = txSAPhone.Text != oUser.Telefono ? txSAPhone.Text : null,
                        Detalles = txSADetails.Text != oUser.Detalles ? txSADetails.Text : null,
                    },
                    (nResult) => {
                        if (nResult == UsuarioResult.Success) {
                            new MaterialDialog(
                                this, "", "Cuenta modificada con exito", "Aceptar"
                            ).ShowDialog(this);

                            CU.Get(out oUser, bDNI ? iDNI : (int)oUser.DNI);
                            SettingsRefresh(tpSAccount);
                        }
                        else if (nResult == UsuarioResult.IncorrectInput)
                            SettingsAccountCheckInput();
                        else if (nResult == UsuarioResult.Error) {
                            lbSAError.Text = CU.LastError.Message;
                            lbSAError.Visible = true;
                        }
                    });
                }
            }
        }
        
///     <summary>
///         Evento MouseEnter de pnSAUpdate para mostrar la Label de error (lbSAError).
///         Este evento no fue añadido directamente al boton de Modificar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnSAUpdate_MouseEnter(object sender, EventArgs e) {
            this.bSettingsAccountHoverBtn =
            this.lbSAError.Visible = true;
        }

///     <summary>
///         Evento MouseEnter de pnSAUpdate para ocultar la Label de error (lbSAError).
///         Este evento no fue añadido directamente al boton de Modificar, por que si este esta deshabilitado, ningun evento se ejecuta.
///     </summary>
        private void pnSAUpdate_MouseLeave(object sender, EventArgs e) {
            this.bSettingsAccountHoverBtn =
            this.lbSAError.Visible = false;
        }

///     <summary>
///         Evento TextChanged de la Label de error (lbSAError) en la pestaña Cuenta.
///         Habilita o deshabilita el boton de Modificar dependiendo si hay o no errores.
///     </summary>
        private void lbSAError_TextChanged(object sender, EventArgs e) {
            Label oCtrl = sender as Label;
            if (oCtrl != null)
                bnSAUpdate.Enabled = oCtrl.Text == "";
        }

///     <summary>
///         Evento de cambio de valores para los controles de Negocio.
///     </summary>
        private void CtrlsSettingsShopValueChanged(object sender, EventArgs e) {
            Negocio oNShop = new Negocio();
            oNShop.CategoriaLetra = (char)Math.Max('A', Math.Min(char.TryParse(txSSCategory.Text, out char cC) ? cC : oShop.CategoriaLetra, 'K'));
            oNShop.DiasSemanales = Math.Max(0, Math.Min(int.TryParse(txSSWeekDays.Text, out int iN) ? iN : oShop.DiasSemanales, 7));

            txSSCategory.Text = oNShop.CategoriaLetra.ToString();
            txSSWeekDays.Text = oNShop.DiasSemanales.ToString();
            
            if (cC != oShop.CategoriaLetra || iN != oShop.DiasSemanales) {
                CN.Update((int)oShop.ID, oNShop);
                CN.Get(out oShop, (int)oUser.NegocioID);
                oStats.InitCalcs();
            }
        }
        
///     <summary>
///         Evento KeyPress de txSSCategory en la pestaña Negocio para permitir solo 1 character de 'A' a 'K'.
///     </summary>
        private void txSSCategory_KeyPress(object sender, KeyPressEventArgs e) {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'K'))
                e.Handled = true;
        }

///     <summary>
///         Evento KeyPress de txSSWeekDays en la pestaña Negocio para permitir solo 1 numero de 0 a 7.
///     </summary>
        private void txSSWeekDays_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '0' || e.KeyChar > '7'))
                e.Handled = true;
        }

///     <summary>
///         Evento de cambio de valores para los controles de Acerca de.
///     </summary>
        private void CtrlsSettingsCustomValueChanged(object sender, EventArgs e) {
            SetTheme(
                cbSCTheme.SelectedIndex,
                (Primary)cbSCPrimary.SelectedItem,
                (Primary)cbSCDark.SelectedItem,
                (Primary)cbSCLight.SelectedItem,
                (Accent)cbSCAccent.SelectedItem,
                (TextShade)cbSCTextShade.SelectedItem
            );

            oSets.SaveLastRect = swSCSaveLastRect.Checked;

            this.Refresh();
        }

///     <summary>
///         Evento Click de bnSBWeb en Acercad de
///     </summary>
        private void bnSBWeb_Click(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo("http://saf.ar") {
                UseShellExecute = true
            });
        }

///     <summary>
///         Evento Click de bnSBWhatsApp en Acercad de
///     </summary>
        private void bnSBWhatsApp_Click(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo("https://wa.me/+5492910000000") {
                UseShellExecute = true
            });
        }

///     <summary>
///         Evento Click de bnSBEmail en Acercad de
///     </summary>
        private void bnSBEmail_Click(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo("mailto:help@saf.ar") {
                UseShellExecute = true
            });
        }

///     <summary>
///         Evento Resize de la ventana para actualizar tamaño del bloque central de Inicio.
///     </summary>
        private void this_Resize(object sender, EventArgs e) {
            if (tlpHome != null && mcHBtns != null) {
                this.SuspendLayout();
                SetBlockSize();
                this.ResumeLayout(true);
            }
        }

//      -- Overrides --
///     <summary>
///         Sobreescritura de OnVisibleChanged para agregar la animacion al abrir la ventana.
///     </summary>
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if (this.Visible) {
                new Thread(() => {
                    try {
                        this.Invoke((Action)delegate {
                            this.Refresh();
                        });
                        double dOpHop = 1D / oSets.AnimaShow;
                        for (int i = 1; i <= oSets.AnimaShow; i++) {
                            this.Invoke((Action)delegate {
                                this.Opacity =
                                this.drawerForm.Opacity = dOpHop * i;
                            });
                            Thread.Sleep(1);
                        }
                    }
                    catch { }
                }).Start();
            }
        }

///     <summary>
///         Sobreescritura de OnResizeEnd para guardar la ultima posicion y tamaño.
///     </summary>
        protected override void OnResizeEnd(EventArgs e) {
            base.OnResizeEnd(e);
            oSets.LastRect = this.Bounds;
        }

///     <summary>
///         Sobreescritura de OnFormClosing para realizar la animacion antes de cerrar.
///     </summary>
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                this.FadeHide();
        }
    }
}
