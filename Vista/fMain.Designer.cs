namespace SAF.Vista {
    partial class fMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tlpHome = new System.Windows.Forms.TableLayoutPanel();
            this.mcHBtns = new MaterialSkin.Controls.MaterialCard();
            this.tlpHBtns = new System.Windows.Forms.TableLayoutPanel();
            this.bnHNewBill = new MaterialSkin.Controls.MaterialButton();
            this.bnHBills = new MaterialSkin.Controls.MaterialButton();
            this.bnHUsers = new MaterialSkin.Controls.MaterialButton();
            this.bnHSettings = new MaterialSkin.Controls.MaterialButton();
            this.mcHAlerts = new MaterialSkin.Controls.MaterialCard();
            this.tcHAlerts = new MaterialSkin.Controls.MaterialTabControl();
            this.tpHAAlerts = new System.Windows.Forms.TabPage();
            this.lsHAAlerts = new MaterialSkin.Controls.MaterialListBox();
            this.tsHAlerts = new MaterialSkin.Controls.MaterialTabSelector();
            this.mcHSession = new MaterialSkin.Controls.MaterialCard();
            this.tlpHSession = new System.Windows.Forms.TableLayoutPanel();
            this.bnHSLogOut = new MaterialSkin.Controls.MaterialButton();
            this.bnHSSettings = new MaterialSkin.Controls.MaterialButton();
            this.bnHSession = new MaterialSkin.Controls.MaterialButton();
            this.lbHSession = new MaterialSkin.Controls.MaterialLabel();
            this.tpNewBill = new System.Windows.Forms.TabPage();
            this.tlpNewBill = new System.Windows.Forms.TableLayoutPanel();
            this.mcNAdd = new MaterialSkin.Controls.MaterialCard();
            this.tlpNAdd = new SAF.CustomControls.CustomTLP();
            this.txNDesc = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txNPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbNPayType = new MaterialSkin.Controls.MaterialComboBox();
            this.tlpNAddInner = new SAF.CustomControls.CustomTLP();
            this.txNBillID = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpNDate = new SAF.CustomControls.CustomDTP();
            this.swNAInner = new MaterialSkin.Controls.MaterialSwitch();
            this.cbNDNI = new MaterialSkin.Controls.MaterialComboBox();
            this.pnNAdd = new System.Windows.Forms.Panel();
            this.bnNAdd = new MaterialSkin.Controls.MaterialButton();
            this.lbNError = new MaterialSkin.Controls.MaterialLabel();
            this.mcNIc = new MaterialSkin.Controls.MaterialCard();
            this.pnNMPrice = new System.Windows.Forms.Panel();
            this.lbNMPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lbNMPriceTitle = new MaterialSkin.Controls.MaterialLabel();
            this.mcBNC = new MaterialSkin.Controls.MaterialCard();
            this.tlpBNC = new System.Windows.Forms.TableLayoutPanel();
            this.chtBNC = new LiveCharts.WinForms.SolidGauge();
            this.lbBNCFrom = new MaterialSkin.Controls.MaterialLabel();
            this.lbBNCTo = new MaterialSkin.Controls.MaterialLabel();
            this.lbBNCValue = new MaterialSkin.Controls.MaterialLabel();
            this.lbBNCTitle = new MaterialSkin.Controls.MaterialLabel();
            this.mcBDailyGoal = new MaterialSkin.Controls.MaterialCard();
            this.pnBDailyGoal = new System.Windows.Forms.Panel();
            this.lbBDailyGoalPercent = new MaterialSkin.Controls.MaterialLabel();
            this.pbBDailyGoal = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbBDailyGoalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lbBDailyGoalTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tpBills = new System.Windows.Forms.TabPage();
            this.tlpBills = new System.Windows.Forms.TableLayoutPanel();
            this.mcBPayTypes = new MaterialSkin.Controls.MaterialCard();
            this.chtBPayTypes = new LiveCharts.WinForms.PieChart();
            this.lbBPayTypesTitle = new MaterialSkin.Controls.MaterialLabel();
            this.mcBStats = new MaterialSkin.Controls.MaterialCard();
            this.lbBTPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lbBTPriceTitle = new MaterialSkin.Controls.MaterialLabel();
            this.mcBIc = new MaterialSkin.Controls.MaterialCard();
            this.pnBSumP = new System.Windows.Forms.Panel();
            this.lbBSumPTitle = new MaterialSkin.Controls.MaterialLabel();
            this.chtBPrices = new LiveCharts.WinForms.CartesianChart();
            this.mcBDgv = new MaterialSkin.Controls.MaterialCard();
            this.dgvBills = new SAF.CustomControls.CustomExDGV();
            this.mcBSearch = new MaterialSkin.Controls.MaterialCard();
            this.tlpBSearch = new SAF.CustomControls.CustomTLP();
            this.pnBSearchCols = new System.Windows.Forms.Panel();
            this.cbBSearchCols = new MaterialSkin.Controls.MaterialComboBox();
            this.txBSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpBEndDate = new SAF.CustomControls.CustomDTP();
            this.dtpBStartDate = new SAF.CustomControls.CustomDTP();
            this.pnBDateArrow = new System.Windows.Forms.Panel();
            this.bnBNextMonth = new MaterialSkin.Controls.MaterialButton();
            this.bnBPrevMonth = new MaterialSkin.Controls.MaterialButton();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.tlpUsers = new System.Windows.Forms.TableLayoutPanel();
            this.mcUDgv = new MaterialSkin.Controls.MaterialCard();
            this.dgvUsers = new SAF.CustomControls.CustomExDGV();
            this.mcUStats = new MaterialSkin.Controls.MaterialCard();
            this.dgvUsersLogIns = new SAF.CustomControls.CustomExDGV();
            this.mcUSearch = new MaterialSkin.Controls.MaterialCard();
            this.tlpUSearch = new SAF.CustomControls.CustomTLP();
            this.pnUSearchCols = new System.Windows.Forms.Panel();
            this.cbUSearchCols = new MaterialSkin.Controls.MaterialComboBox();
            this.txUSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tcSSettings = new MaterialSkin.Controls.MaterialTabControl();
            this.tpSInnerTables = new System.Windows.Forms.TabPage();
            this.tlpSInnerTables = new System.Windows.Forms.TableLayoutPanel();
            this.mcSITCategories = new MaterialSkin.Controls.MaterialCard();
            this.dgvSITCategories = new SAF.CustomControls.CustomExDGV();
            this.lbSITCategories = new MaterialSkin.Controls.MaterialLabel();
            this.mcSITPayTypes = new MaterialSkin.Controls.MaterialCard();
            this.dgvSITPayTypes = new SAF.CustomControls.CustomExDGV();
            this.lbSITPayTypes = new MaterialSkin.Controls.MaterialLabel();
            this.tpSAccount = new System.Windows.Forms.TabPage();
            this.tlpSABack = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSAccount = new System.Windows.Forms.TableLayoutPanel();
            this.mcSAData = new MaterialSkin.Controls.MaterialCard();
            this.tlpSAData = new System.Windows.Forms.TableLayoutPanel();
            this.lbSAData = new MaterialSkin.Controls.MaterialLabel();
            this.txSADNI = new MaterialSkin.Controls.MaterialTextBox2();
            this.txSAName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txSALastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txSAEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txSAPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mcSARightPanel = new MaterialSkin.Controls.MaterialCard();
            this.tlpSARightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnSAUpdate = new System.Windows.Forms.Panel();
            this.bnSAUpdate = new MaterialSkin.Controls.MaterialButton();
            this.mcSADetails = new MaterialSkin.Controls.MaterialCard();
            this.tlpSADetails = new System.Windows.Forms.TableLayoutPanel();
            this.lbSADetails = new MaterialSkin.Controls.MaterialLabel();
            this.txSADetails = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbSAError = new MaterialSkin.Controls.MaterialLabel();
            this.mcSAPass = new MaterialSkin.Controls.MaterialCard();
            this.tlpSAPass = new System.Windows.Forms.TableLayoutPanel();
            this.lbSAPass = new MaterialSkin.Controls.MaterialLabel();
            this.txSAPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.txSANewPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.txSARepNewPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.tpSShop = new System.Windows.Forms.TabPage();
            this.tlpSSBack = new System.Windows.Forms.TableLayoutPanel();
            this.mcSShop = new MaterialSkin.Controls.MaterialCard();
            this.tlpSShop = new System.Windows.Forms.TableLayoutPanel();
            this.lbSSTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txSSCategory = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvSSHolidays = new SAF.CustomControls.CustomExDGV();
            this.txSSWeekDays = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbSSHolidaysTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tpSCustom = new System.Windows.Forms.TabPage();
            this.tlpSCBack = new System.Windows.Forms.TableLayoutPanel();
            this.mcSCustom = new MaterialSkin.Controls.MaterialCard();
            this.tlpSCustom = new System.Windows.Forms.TableLayoutPanel();
            this.cbSCPrimary = new MaterialSkin.Controls.MaterialComboBox();
            this.cbSCLight = new MaterialSkin.Controls.MaterialComboBox();
            this.cbSCDark = new MaterialSkin.Controls.MaterialComboBox();
            this.cbSCAccent = new MaterialSkin.Controls.MaterialComboBox();
            this.cbSCTextShade = new MaterialSkin.Controls.MaterialComboBox();
            this.cbSCTheme = new MaterialSkin.Controls.MaterialComboBox();
            this.swSCSaveLastRect = new MaterialSkin.Controls.MaterialSwitch();
            this.tpSAbout = new System.Windows.Forms.TabPage();
            this.tlpSBBack = new System.Windows.Forms.TableLayoutPanel();
            this.mcSAbout = new MaterialSkin.Controls.MaterialCard();
            this.tlpSAbout = new System.Windows.Forms.TableLayoutPanel();
            this.mdSB2 = new MaterialSkin.Controls.MaterialDivider();
            this.lbSBTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lbSBCopyright = new MaterialSkin.Controls.MaterialLabel();
            this.mdSB1 = new MaterialSkin.Controls.MaterialDivider();
            this.bnSBWeb = new MaterialSkin.Controls.MaterialButton();
            this.bnSBWhatsApp = new MaterialSkin.Controls.MaterialButton();
            this.bnSBEmail = new MaterialSkin.Controls.MaterialButton();
            this.mdSB3 = new MaterialSkin.Controls.MaterialDivider();
            this.lbSBContact = new MaterialSkin.Controls.MaterialLabel();
            this.lbSBText = new MaterialSkin.Controls.MaterialLabel();
            this.bnSBOpen = new MaterialSkin.Controls.MaterialButton();
            this.tsSettings = new MaterialSkin.Controls.MaterialTabSelector();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.tcMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tlpHome.SuspendLayout();
            this.mcHBtns.SuspendLayout();
            this.tlpHBtns.SuspendLayout();
            this.mcHAlerts.SuspendLayout();
            this.tcHAlerts.SuspendLayout();
            this.tpHAAlerts.SuspendLayout();
            this.mcHSession.SuspendLayout();
            this.tlpHSession.SuspendLayout();
            this.tpNewBill.SuspendLayout();
            this.tlpNewBill.SuspendLayout();
            this.mcNAdd.SuspendLayout();
            this.tlpNAdd.SuspendLayout();
            this.tlpNAddInner.SuspendLayout();
            this.pnNAdd.SuspendLayout();
            this.mcNIc.SuspendLayout();
            this.pnNMPrice.SuspendLayout();
            this.mcBNC.SuspendLayout();
            this.tlpBNC.SuspendLayout();
            this.mcBDailyGoal.SuspendLayout();
            this.pnBDailyGoal.SuspendLayout();
            this.tpBills.SuspendLayout();
            this.tlpBills.SuspendLayout();
            this.mcBPayTypes.SuspendLayout();
            this.mcBStats.SuspendLayout();
            this.mcBIc.SuspendLayout();
            this.pnBSumP.SuspendLayout();
            this.mcBDgv.SuspendLayout();
            this.mcBSearch.SuspendLayout();
            this.tlpBSearch.SuspendLayout();
            this.pnBSearchCols.SuspendLayout();
            this.pnBDateArrow.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.tlpUsers.SuspendLayout();
            this.mcUDgv.SuspendLayout();
            this.mcUStats.SuspendLayout();
            this.mcUSearch.SuspendLayout();
            this.tlpUSearch.SuspendLayout();
            this.pnUSearchCols.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tcSSettings.SuspendLayout();
            this.tpSInnerTables.SuspendLayout();
            this.tlpSInnerTables.SuspendLayout();
            this.mcSITCategories.SuspendLayout();
            this.mcSITPayTypes.SuspendLayout();
            this.tpSAccount.SuspendLayout();
            this.tlpSABack.SuspendLayout();
            this.tlpSAccount.SuspendLayout();
            this.mcSAData.SuspendLayout();
            this.tlpSAData.SuspendLayout();
            this.mcSARightPanel.SuspendLayout();
            this.tlpSARightPanel.SuspendLayout();
            this.pnSAUpdate.SuspendLayout();
            this.mcSADetails.SuspendLayout();
            this.tlpSADetails.SuspendLayout();
            this.mcSAPass.SuspendLayout();
            this.tlpSAPass.SuspendLayout();
            this.tpSShop.SuspendLayout();
            this.tlpSSBack.SuspendLayout();
            this.mcSShop.SuspendLayout();
            this.tlpSShop.SuspendLayout();
            this.tpSCustom.SuspendLayout();
            this.tlpSCBack.SuspendLayout();
            this.mcSCustom.SuspendLayout();
            this.tlpSCustom.SuspendLayout();
            this.tpSAbout.SuspendLayout();
            this.tlpSBBack.SuspendLayout();
            this.mcSAbout.SuspendLayout();
            this.tlpSAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpHome);
            this.tcMain.Controls.Add(this.tpNewBill);
            this.tcMain.Controls.Add(this.tpBills);
            this.tcMain.Controls.Add(this.tpUsers);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Depth = 0;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ImageList = this.Icons;
            this.tcMain.Location = new System.Drawing.Point(0, 64);
            this.tcMain.Margin = new System.Windows.Forms.Padding(0);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1172, 721);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabStop = false;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            this.tcMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcsAnimation_Selecting);
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.White;
            this.tpHome.Controls.Add(this.tlpHome);
            this.tpHome.ImageKey = "Home24.png";
            this.tpHome.Location = new System.Drawing.Point(4, 31);
            this.tpHome.Margin = new System.Windows.Forms.Padding(0);
            this.tpHome.Name = "tpHome";
            this.tpHome.Size = new System.Drawing.Size(1164, 686);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Inicio";
            // 
            // tlpHome
            // 
            this.tlpHome.ColumnCount = 2;
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpHome.Controls.Add(this.mcHBtns, 0, 0);
            this.tlpHome.Controls.Add(this.mcHAlerts, 1, 0);
            this.tlpHome.Controls.Add(this.mcHSession, 1, 1);
            this.tlpHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHome.Location = new System.Drawing.Point(0, 0);
            this.tlpHome.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpHome.RowCount = 2;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHome.Size = new System.Drawing.Size(1164, 686);
            this.tlpHome.TabIndex = 0;
            // 
            // mcHBtns
            // 
            this.mcHBtns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcHBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcHBtns.Controls.Add(this.tlpHBtns);
            this.mcHBtns.Depth = 0;
            this.mcHBtns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcHBtns.Location = new System.Drawing.Point(239, 149);
            this.mcHBtns.Margin = new System.Windows.Forms.Padding(6, 6, 4, 6);
            this.mcHBtns.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcHBtns.Name = "mcHBtns";
            this.mcHBtns.Padding = new System.Windows.Forms.Padding(6);
            this.tlpHome.SetRowSpan(this.mcHBtns, 2);
            this.mcHBtns.Size = new System.Drawing.Size(389, 389);
            this.mcHBtns.TabIndex = 1;
            // 
            // tlpHBtns
            // 
            this.tlpHBtns.ColumnCount = 2;
            this.tlpHBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHBtns.Controls.Add(this.bnHNewBill, 0, 0);
            this.tlpHBtns.Controls.Add(this.bnHBills, 1, 0);
            this.tlpHBtns.Controls.Add(this.bnHUsers, 0, 1);
            this.tlpHBtns.Controls.Add(this.bnHSettings, 1, 1);
            this.tlpHBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHBtns.Location = new System.Drawing.Point(6, 6);
            this.tlpHBtns.Name = "tlpHBtns";
            this.tlpHBtns.RowCount = 2;
            this.tlpHBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHBtns.Size = new System.Drawing.Size(377, 377);
            this.tlpHBtns.TabIndex = 0;
            // 
            // bnHNewBill
            // 
            this.bnHNewBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHNewBill.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.bnHNewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHNewBill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHNewBill.Depth = 0;
            this.bnHNewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHNewBill.HighEmphasis = true;
            this.bnHNewBill.Icon = global::SAF.Properties.Resources.NewBill120;
            this.bnHNewBill.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnHNewBill.IconAndTextPadding = 0;
            this.bnHNewBill.IconAutoSize = true;
            this.bnHNewBill.IconAutoSizePercentage = 50D;
            this.bnHNewBill.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnHNewBill.IconPadding = 10;
            this.bnHNewBill.IconSize = 90;
            this.bnHNewBill.IconTransparency = 80D;
            this.bnHNewBill.ImageKey = "NewBill120.png";
            this.bnHNewBill.Location = new System.Drawing.Point(4, 4);
            this.bnHNewBill.Margin = new System.Windows.Forms.Padding(4);
            this.bnHNewBill.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHNewBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHNewBill.Name = "bnHNewBill";
            this.bnHNewBill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHNewBill.Size = new System.Drawing.Size(180, 180);
            this.bnHNewBill.TabIndex = 1;
            this.bnHNewBill.Text = "Nueva factura";
            this.bnHNewBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHNewBill.UseAccentColor = false;
            this.bnHNewBill.UseVisualStyleBackColor = true;
            this.bnHNewBill.Click += new System.EventHandler(this.bnHsClick);
            // 
            // bnHBills
            // 
            this.bnHBills.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHBills.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.bnHBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHBills.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHBills.Depth = 0;
            this.bnHBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHBills.HighEmphasis = true;
            this.bnHBills.Icon = global::SAF.Properties.Resources.Bill120;
            this.bnHBills.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnHBills.IconAndTextPadding = 0;
            this.bnHBills.IconAutoSize = true;
            this.bnHBills.IconAutoSizePercentage = 50D;
            this.bnHBills.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnHBills.IconPadding = 10;
            this.bnHBills.IconSize = 90;
            this.bnHBills.IconTransparency = 80D;
            this.bnHBills.Location = new System.Drawing.Point(192, 4);
            this.bnHBills.Margin = new System.Windows.Forms.Padding(4);
            this.bnHBills.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHBills.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHBills.Name = "bnHBills";
            this.bnHBills.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHBills.Size = new System.Drawing.Size(181, 180);
            this.bnHBills.TabIndex = 2;
            this.bnHBills.Text = "Facturas";
            this.bnHBills.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHBills.UseAccentColor = false;
            this.bnHBills.UseVisualStyleBackColor = true;
            this.bnHBills.Click += new System.EventHandler(this.bnHsClick);
            // 
            // bnHUsers
            // 
            this.bnHUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHUsers.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.bnHUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHUsers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHUsers.Depth = 0;
            this.bnHUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHUsers.HighEmphasis = true;
            this.bnHUsers.Icon = global::SAF.Properties.Resources.Users120;
            this.bnHUsers.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnHUsers.IconAndTextPadding = 0;
            this.bnHUsers.IconAutoSize = true;
            this.bnHUsers.IconAutoSizePercentage = 50D;
            this.bnHUsers.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnHUsers.IconPadding = 10;
            this.bnHUsers.IconSize = 90;
            this.bnHUsers.IconTransparency = 80D;
            this.bnHUsers.Location = new System.Drawing.Point(4, 192);
            this.bnHUsers.Margin = new System.Windows.Forms.Padding(4);
            this.bnHUsers.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHUsers.Name = "bnHUsers";
            this.bnHUsers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHUsers.Size = new System.Drawing.Size(180, 181);
            this.bnHUsers.TabIndex = 3;
            this.bnHUsers.Text = "Usuarios";
            this.bnHUsers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHUsers.UseAccentColor = false;
            this.bnHUsers.UseVisualStyleBackColor = true;
            this.bnHUsers.Click += new System.EventHandler(this.bnHsClick);
            // 
            // bnHSettings
            // 
            this.bnHSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHSettings.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.bnHSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHSettings.Depth = 0;
            this.bnHSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHSettings.HighEmphasis = true;
            this.bnHSettings.Icon = global::SAF.Properties.Resources.Settings120;
            this.bnHSettings.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnHSettings.IconAndTextPadding = 0;
            this.bnHSettings.IconAutoSize = true;
            this.bnHSettings.IconAutoSizePercentage = 50D;
            this.bnHSettings.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnHSettings.IconPadding = 10;
            this.bnHSettings.IconSize = 90;
            this.bnHSettings.IconTransparency = 80D;
            this.bnHSettings.Location = new System.Drawing.Point(192, 192);
            this.bnHSettings.Margin = new System.Windows.Forms.Padding(4);
            this.bnHSettings.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHSettings.Name = "bnHSettings";
            this.bnHSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHSettings.Size = new System.Drawing.Size(181, 181);
            this.bnHSettings.TabIndex = 4;
            this.bnHSettings.Text = "Ajustes";
            this.bnHSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHSettings.UseAccentColor = false;
            this.bnHSettings.UseVisualStyleBackColor = true;
            this.bnHSettings.Click += new System.EventHandler(this.bnHsClick);
            // 
            // mcHAlerts
            // 
            this.mcHAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcHAlerts.Controls.Add(this.tcHAlerts);
            this.mcHAlerts.Controls.Add(this.tsHAlerts);
            this.mcHAlerts.Depth = 0;
            this.mcHAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcHAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcHAlerts.Location = new System.Drawing.Point(868, 8);
            this.mcHAlerts.Margin = new System.Windows.Forms.Padding(4, 6, 6, 4);
            this.mcHAlerts.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcHAlerts.Name = "mcHAlerts";
            this.mcHAlerts.Padding = new System.Windows.Forms.Padding(6);
            this.mcHAlerts.Size = new System.Drawing.Size(290, 332);
            this.mcHAlerts.TabIndex = 2;
            // 
            // tcHAlerts
            // 
            this.tcHAlerts.Controls.Add(this.tpHAAlerts);
            this.tcHAlerts.Depth = 0;
            this.tcHAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHAlerts.Location = new System.Drawing.Point(6, 31);
            this.tcHAlerts.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcHAlerts.Multiline = true;
            this.tcHAlerts.Name = "tcHAlerts";
            this.tcHAlerts.SelectedIndex = 0;
            this.tcHAlerts.Size = new System.Drawing.Size(278, 295);
            this.tcHAlerts.TabIndex = 0;
            // 
            // tpHAAlerts
            // 
            this.tpHAAlerts.BackColor = System.Drawing.Color.White;
            this.tpHAAlerts.Controls.Add(this.lsHAAlerts);
            this.tpHAAlerts.Location = new System.Drawing.Point(4, 22);
            this.tpHAAlerts.Name = "tpHAAlerts";
            this.tpHAAlerts.Size = new System.Drawing.Size(270, 269);
            this.tpHAAlerts.TabIndex = 0;
            this.tpHAAlerts.Text = "Alertas";
            // 
            // lsHAAlerts
            // 
            this.lsHAAlerts.BackColor = System.Drawing.Color.White;
            this.lsHAAlerts.BorderColor = System.Drawing.Color.LightGray;
            this.lsHAAlerts.Depth = 0;
            this.lsHAAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsHAAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsHAAlerts.LeftRightPadding = 4;
            this.lsHAAlerts.Location = new System.Drawing.Point(0, 0);
            this.lsHAAlerts.Margin = new System.Windows.Forms.Padding(0);
            this.lsHAAlerts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsHAAlerts.Name = "lsHAAlerts";
            this.lsHAAlerts.SelectedIndex = -1;
            this.lsHAAlerts.SelectedItem = null;
            this.lsHAAlerts.ShowBorder = false;
            this.lsHAAlerts.Size = new System.Drawing.Size(270, 269);
            this.lsHAAlerts.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lsHAAlerts.TabIndex = 0;
            this.lsHAAlerts.UseAccentColor = true;
            // 
            // tsHAlerts
            // 
            this.tsHAlerts.BaseTabControl = this.tcHAlerts;
            this.tsHAlerts.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tsHAlerts.Depth = 0;
            this.tsHAlerts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsHAlerts.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsHAlerts.Location = new System.Drawing.Point(6, 6);
            this.tsHAlerts.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsHAlerts.Name = "tsHAlerts";
            this.tsHAlerts.Size = new System.Drawing.Size(278, 25);
            this.tsHAlerts.TabAutoSize = true;
            this.tsHAlerts.TabIndex = 0;
            this.tsHAlerts.TabIndicatorHeight = 1;
            this.tsHAlerts.TabWidth = 120;
            // 
            // mcHSession
            // 
            this.mcHSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcHSession.Controls.Add(this.tlpHSession);
            this.mcHSession.Depth = 0;
            this.mcHSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcHSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcHSession.Location = new System.Drawing.Point(868, 348);
            this.mcHSession.Margin = new System.Windows.Forms.Padding(4, 4, 6, 6);
            this.mcHSession.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcHSession.Name = "mcHSession";
            this.mcHSession.Padding = new System.Windows.Forms.Padding(6);
            this.mcHSession.Size = new System.Drawing.Size(290, 332);
            this.mcHSession.TabIndex = 3;
            // 
            // tlpHSession
            // 
            this.tlpHSession.ColumnCount = 4;
            this.tlpHSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpHSession.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHSession.Controls.Add(this.bnHSLogOut, 1, 3);
            this.tlpHSession.Controls.Add(this.bnHSSettings, 2, 3);
            this.tlpHSession.Controls.Add(this.bnHSession, 1, 1);
            this.tlpHSession.Controls.Add(this.lbHSession, 0, 2);
            this.tlpHSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHSession.Location = new System.Drawing.Point(6, 6);
            this.tlpHSession.Name = "tlpHSession";
            this.tlpHSession.RowCount = 5;
            this.tlpHSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpHSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpHSession.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHSession.Size = new System.Drawing.Size(278, 320);
            this.tlpHSession.TabIndex = 0;
            // 
            // bnHSLogOut
            // 
            this.bnHSLogOut.AutoSize = false;
            this.bnHSLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHSLogOut.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnHSLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHSLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHSLogOut.Depth = 0;
            this.bnHSLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHSLogOut.HighEmphasis = true;
            this.bnHSLogOut.Icon = null;
            this.bnHSLogOut.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnHSLogOut.IconAndTextPadding = 4;
            this.bnHSLogOut.IconAutoSizePercentage = 20D;
            this.bnHSLogOut.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnHSLogOut.IconTransparency = 70D;
            this.bnHSLogOut.Location = new System.Drawing.Point(44, 227);
            this.bnHSLogOut.Margin = new System.Windows.Forms.Padding(4, 2, 2, 4);
            this.bnHSLogOut.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHSLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHSLogOut.Name = "bnHSLogOut";
            this.bnHSLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHSLogOut.Size = new System.Drawing.Size(150, 36);
            this.bnHSLogOut.TabIndex = 0;
            this.bnHSLogOut.Text = "Log out";
            this.bnHSLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHSLogOut.UseAccentColor = false;
            this.bnHSLogOut.UseVisualStyleBackColor = true;
            this.bnHSLogOut.Click += new System.EventHandler(this.bnHSLogOut_Click);
            // 
            // bnHSSettings
            // 
            this.bnHSSettings.AutoSize = false;
            this.bnHSSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHSSettings.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnHSSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHSSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHSSettings.Depth = 0;
            this.bnHSSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHSSettings.HighEmphasis = true;
            this.bnHSSettings.Icon = global::SAF.Properties.Resources.Settings24;
            this.bnHSSettings.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnHSSettings.IconAndTextPadding = 4;
            this.bnHSSettings.IconAutoSizePercentage = 20D;
            this.bnHSSettings.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnHSSettings.IconTransparency = 85D;
            this.bnHSSettings.Location = new System.Drawing.Point(198, 227);
            this.bnHSSettings.Margin = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.bnHSSettings.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHSSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHSSettings.Name = "bnHSSettings";
            this.bnHSSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHSSettings.Size = new System.Drawing.Size(36, 36);
            this.bnHSSettings.TabIndex = 0;
            this.bnHSSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHSSettings.UseAccentColor = false;
            this.bnHSSettings.UseVisualStyleBackColor = true;
            this.bnHSSettings.Click += new System.EventHandler(this.bnHSSettings_Click);
            // 
            // bnHSession
            // 
            this.bnHSession.AutoSize = false;
            this.bnHSession.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnHSession.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.tlpHSession.SetColumnSpan(this.bnHSession, 2);
            this.bnHSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnHSession.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnHSession.Depth = 0;
            this.bnHSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnHSession.Enabled = false;
            this.bnHSession.HighEmphasis = true;
            this.bnHSession.Icon = global::SAF.Properties.Resources.User120;
            this.bnHSession.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnHSession.IconAndTextPadding = 4;
            this.bnHSession.IconAutoSize = true;
            this.bnHSession.IconAutoSizePercentage = 70D;
            this.bnHSession.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.BackgroundBased;
            this.bnHSession.IconSize = 103;
            this.bnHSession.IconTransparency = 70D;
            this.bnHSession.Location = new System.Drawing.Point(44, 55);
            this.bnHSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.bnHSession.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnHSession.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnHSession.Name = "bnHSession";
            this.bnHSession.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnHSession.Size = new System.Drawing.Size(190, 148);
            this.bnHSession.TabIndex = 1;
            this.bnHSession.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnHSession.UseAccentColor = false;
            this.bnHSession.UseVisualStyleBackColor = true;
            // 
            // lbHSession
            // 
            this.lbHSession.AutoSize = true;
            this.tlpHSession.SetColumnSpan(this.lbHSession, 4);
            this.lbHSession.Depth = 0;
            this.lbHSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHSession.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbHSession.Location = new System.Drawing.Point(3, 205);
            this.lbHSession.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbHSession.Name = "lbHSession";
            this.lbHSession.Size = new System.Drawing.Size(272, 20);
            this.lbHSession.TabIndex = 2;
            this.lbHSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpNewBill
            // 
            this.tpNewBill.BackColor = System.Drawing.Color.White;
            this.tpNewBill.Controls.Add(this.tlpNewBill);
            this.tpNewBill.ImageKey = "NewBill24.png";
            this.tpNewBill.Location = new System.Drawing.Point(4, 31);
            this.tpNewBill.Margin = new System.Windows.Forms.Padding(0);
            this.tpNewBill.Name = "tpNewBill";
            this.tpNewBill.Size = new System.Drawing.Size(1164, 686);
            this.tpNewBill.TabIndex = 1;
            this.tpNewBill.Text = "Nueva factura";
            // 
            // tlpNewBill
            // 
            this.tlpNewBill.ColumnCount = 2;
            this.tlpNewBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNewBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpNewBill.Controls.Add(this.mcNAdd, 0, 0);
            this.tlpNewBill.Controls.Add(this.mcNIc, 1, 0);
            this.tlpNewBill.Controls.Add(this.mcBNC, 1, 2);
            this.tlpNewBill.Controls.Add(this.mcBDailyGoal, 1, 1);
            this.tlpNewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNewBill.Location = new System.Drawing.Point(0, 0);
            this.tlpNewBill.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNewBill.Name = "tlpNewBill";
            this.tlpNewBill.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpNewBill.RowCount = 3;
            this.tlpNewBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpNewBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpNewBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpNewBill.Size = new System.Drawing.Size(1164, 686);
            this.tlpNewBill.TabIndex = 0;
            // 
            // mcNAdd
            // 
            this.mcNAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcNAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcNAdd.Controls.Add(this.tlpNAdd);
            this.mcNAdd.Depth = 0;
            this.mcNAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcNAdd.Location = new System.Drawing.Point(161, 119);
            this.mcNAdd.Margin = new System.Windows.Forms.Padding(6, 6, 4, 6);
            this.mcNAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcNAdd.Name = "mcNAdd";
            this.mcNAdd.Padding = new System.Windows.Forms.Padding(10);
            this.tlpNewBill.SetRowSpan(this.mcNAdd, 3);
            this.mcNAdd.Size = new System.Drawing.Size(546, 450);
            this.mcNAdd.TabIndex = 0;
            // 
            // tlpNAdd
            // 
            this.tlpNAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpNAdd.ColumnCount = 2;
            this.tlpNAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNAdd.Controls.Add(this.txNDesc, 0, 2);
            this.tlpNAdd.Controls.Add(this.txNPrice, 0, 1);
            this.tlpNAdd.Controls.Add(this.cbNPayType, 1, 1);
            this.tlpNAdd.Controls.Add(this.tlpNAddInner, 0, 0);
            this.tlpNAdd.Controls.Add(this.pnNAdd, 1, 4);
            this.tlpNAdd.Controls.Add(this.lbNError, 0, 3);
            this.tlpNAdd.Depth = 0;
            this.tlpNAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNAdd.Location = new System.Drawing.Point(10, 10);
            this.tlpNAdd.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.BackgroundColor;
            this.tlpNAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tlpNAdd.Name = "tlpNAdd";
            this.tlpNAdd.RowCount = 5;
            this.tlpNAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33028F));
            this.tlpNAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67014F));
            this.tlpNAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99958F));
            this.tlpNAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpNAdd.Size = new System.Drawing.Size(526, 430);
            this.tlpNAdd.TabIndex = 10;
            // 
            // txNDesc
            // 
            this.txNDesc.AnimateReadOnly = false;
            this.txNDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txNDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpNAdd.SetColumnSpan(this.txNDesc, 2);
            this.txNDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txNDesc.Depth = 0;
            this.txNDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txNDesc.HideSelection = true;
            this.txNDesc.Hint = "Descripción";
            this.txNDesc.Location = new System.Drawing.Point(5, 184);
            this.txNDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txNDesc.MaxLength = 512;
            this.txNDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txNDesc.Name = "txNDesc";
            this.txNDesc.PasswordChar = '\0';
            this.txNDesc.ReadOnly = false;
            this.txNDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNDesc.SelectedText = "";
            this.txNDesc.SelectionLength = 0;
            this.txNDesc.SelectionStart = 0;
            this.txNDesc.ShortcutsEnabled = true;
            this.txNDesc.Size = new System.Drawing.Size(516, 169);
            this.txNDesc.TabIndex = 9;
            this.txNDesc.TabStop = false;
            this.txNDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNDesc.UseSystemPasswordChar = false;
            // 
            // txNPrice
            // 
            this.txNPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txNPrice.AnimateReadOnly = false;
            this.txNPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txNPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txNPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txNPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txNPrice.Depth = 0;
            this.txNPrice.ErrorState = false;
            this.txNPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txNPrice.HideSelection = true;
            this.txNPrice.Hint = "Monto";
            this.txNPrice.LeadingIcon = null;
            this.txNPrice.Location = new System.Drawing.Point(5, 125);
            this.txNPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txNPrice.MaxLength = 13;
            this.txNPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txNPrice.Name = "txNPrice";
            this.txNPrice.PasswordChar = '\0';
            this.txNPrice.PrefixSuffixText = null;
            this.txNPrice.ReadOnly = false;
            this.txNPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txNPrice.SelectedText = "";
            this.txNPrice.SelectionLength = 0;
            this.txNPrice.SelectionStart = 0;
            this.txNPrice.ShortcutsEnabled = true;
            this.txNPrice.Size = new System.Drawing.Size(253, 48);
            this.txNPrice.TabIndex = 1;
            this.txNPrice.TabStop = false;
            this.txNPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNPrice.TrailingIcon = null;
            this.txNPrice.UseSystemPasswordChar = false;
            this.txNPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNPrice_KeyPress);
            this.txNPrice.TextChanged += new System.EventHandler(this.txNPrice_TextChanged);
            // 
            // cbNPayType
            // 
            this.cbNPayType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNPayType.AutoResize = false;
            this.cbNPayType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNPayType.Depth = 0;
            this.cbNPayType.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbNPayType.DisabledItems")));
            this.cbNPayType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNPayType.DropDownHeight = 170;
            this.cbNPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNPayType.DropDownWidth = 121;
            this.cbNPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNPayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNPayType.FormattingEnabled = true;
            this.cbNPayType.Hint = "Medio de pago";
            this.cbNPayType.IntegralHeight = false;
            this.cbNPayType.ItemHeight = 42;
            this.cbNPayType.Location = new System.Drawing.Point(268, 124);
            this.cbNPayType.Margin = new System.Windows.Forms.Padding(5);
            this.cbNPayType.MaxDropDownItems = 4;
            this.cbNPayType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNPayType.Name = "cbNPayType";
            this.cbNPayType.Size = new System.Drawing.Size(253, 48);
            this.cbNPayType.StartIndex = 0;
            this.cbNPayType.TabIndex = 2;
            // 
            // tlpNAddInner
            // 
            this.tlpNAddInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tlpNAddInner.ColumnCount = 3;
            this.tlpNAdd.SetColumnSpan(this.tlpNAddInner, 2);
            this.tlpNAddInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNAddInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tlpNAddInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpNAddInner.Controls.Add(this.txNBillID, 0, 1);
            this.tlpNAddInner.Controls.Add(this.dtpNDate, 1, 1);
            this.tlpNAddInner.Controls.Add(this.swNAInner, 2, 1);
            this.tlpNAddInner.Controls.Add(this.cbNDNI, 0, 0);
            this.tlpNAddInner.Depth = 0;
            this.tlpNAddInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNAddInner.Location = new System.Drawing.Point(0, 0);
            this.tlpNAddInner.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNAddInner.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.BackdropColor;
            this.tlpNAddInner.MouseState = MaterialSkin.MouseState.HOVER;
            this.tlpNAddInner.Name = "tlpNAddInner";
            this.tlpNAddInner.RowCount = 2;
            this.tlpNAddInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNAddInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNAddInner.Size = new System.Drawing.Size(526, 119);
            this.tlpNAddInner.TabIndex = 10;
            // 
            // txNBillID
            // 
            this.txNBillID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txNBillID.AnimateReadOnly = false;
            this.txNBillID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txNBillID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txNBillID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txNBillID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txNBillID.Depth = 0;
            this.txNBillID.Enabled = false;
            this.txNBillID.ErrorState = false;
            this.txNBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txNBillID.HideSelection = true;
            this.txNBillID.Hint = "ID de la factura";
            this.txNBillID.LeadingIcon = null;
            this.txNBillID.Location = new System.Drawing.Point(5, 65);
            this.txNBillID.Margin = new System.Windows.Forms.Padding(5);
            this.txNBillID.MaxLength = 32767;
            this.txNBillID.MouseState = MaterialSkin.MouseState.OUT;
            this.txNBillID.Name = "txNBillID";
            this.txNBillID.PasswordChar = '\0';
            this.txNBillID.PrefixSuffixText = null;
            this.txNBillID.ReadOnly = false;
            this.txNBillID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txNBillID.SelectedText = "";
            this.txNBillID.SelectionLength = 0;
            this.txNBillID.SelectionStart = 0;
            this.txNBillID.ShortcutsEnabled = true;
            this.txNBillID.Size = new System.Drawing.Size(201, 48);
            this.txNBillID.TabIndex = 8;
            this.txNBillID.TabStop = false;
            this.txNBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNBillID.TrailingIcon = null;
            this.txNBillID.UseSystemPasswordChar = false;
            this.txNBillID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNBillID_KeyPress);
            this.txNBillID.TextChanged += new System.EventHandler(this.NewBillsCtrlsValueChanged);
            // 
            // dtpNDate
            // 
            this.dtpNDate.AllowPromptAsInput = true;
            this.dtpNDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNDate.AnimateReadOnly = false;
            this.dtpNDate.AsciiOnly = false;
            this.dtpNDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dtpNDate.BeepOnError = false;
            this.dtpNDate.CalendarSize = new System.Drawing.Size(1, 1);
            this.dtpNDate.Depth = 0;
            this.dtpNDate.Enabled = false;
            this.dtpNDate.ErrorState = false;
            this.dtpNDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpNDate.HidePromptOnLeave = false;
            this.dtpNDate.HideSelection = true;
            this.dtpNDate.Hint = "Fecha";
            this.dtpNDate.IconPadding = 9;
            this.dtpNDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dtpNDate.LeadingIcon = null;
            this.dtpNDate.Location = new System.Drawing.Point(216, 65);
            this.dtpNDate.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.dtpNDate.MaxLength = 32767;
            this.dtpNDate.MouseState = MaterialSkin.MouseState.OUT;
            this.dtpNDate.Name = "dtpNDate";
            this.dtpNDate.PrefixSuffixText = null;
            this.dtpNDate.RejectInputOnFirstFailure = false;
            this.dtpNDate.ResetOnPrompt = true;
            this.dtpNDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNDate.SelectedText = "";
            this.dtpNDate.SelectionLength = 0;
            this.dtpNDate.SelectionStart = 0;
            this.dtpNDate.ShortcutsEnabled = true;
            this.dtpNDate.Size = new System.Drawing.Size(230, 48);
            this.dtpNDate.TabIndex = 7;
            this.dtpNDate.TabStop = false;
            this.dtpNDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dtpNDate.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("dtpNDate.TrailingIcon")));
            this.dtpNDate.ValidatingType = null;
            this.dtpNDate.Value = new System.DateTime(2023, 9, 9, 0, 0, 0, 0);
            // 
            // swNAInner
            // 
            this.swNAInner.Depth = 0;
            this.swNAInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swNAInner.Enabled = false;
            this.swNAInner.Location = new System.Drawing.Point(446, 59);
            this.swNAInner.Margin = new System.Windows.Forms.Padding(0);
            this.swNAInner.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swNAInner.MouseState = MaterialSkin.MouseState.HOVER;
            this.swNAInner.Name = "swNAInner";
            this.swNAInner.Ripple = true;
            this.swNAInner.Size = new System.Drawing.Size(80, 60);
            this.swNAInner.TabIndex = 3;
            this.swNAInner.UseVisualStyleBackColor = true;
            this.swNAInner.CheckedChanged += new System.EventHandler(this.swNAInner_CheckedChanged);
            // 
            // cbNDNI
            // 
            this.cbNDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNDNI.AutoResize = false;
            this.cbNDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpNAddInner.SetColumnSpan(this.cbNDNI, 3);
            this.cbNDNI.Depth = 0;
            this.cbNDNI.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbNDNI.DisabledItems")));
            this.cbNDNI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNDNI.DropDownHeight = 170;
            this.cbNDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNDNI.DropDownWidth = 121;
            this.cbNDNI.Enabled = false;
            this.cbNDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNDNI.FormattingEnabled = true;
            this.cbNDNI.IntegralHeight = false;
            this.cbNDNI.ItemHeight = 42;
            this.cbNDNI.Location = new System.Drawing.Point(5, 5);
            this.cbNDNI.Margin = new System.Windows.Forms.Padding(5);
            this.cbNDNI.MaxDropDownItems = 4;
            this.cbNDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNDNI.Name = "cbNDNI";
            this.cbNDNI.Size = new System.Drawing.Size(516, 48);
            this.cbNDNI.StartIndex = 0;
            this.cbNDNI.TabIndex = 9;
            // 
            // pnNAdd
            // 
            this.pnNAdd.Controls.Add(this.bnNAdd);
            this.pnNAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNAdd.Location = new System.Drawing.Point(263, 378);
            this.pnNAdd.Margin = new System.Windows.Forms.Padding(0);
            this.pnNAdd.Name = "pnNAdd";
            this.pnNAdd.Padding = new System.Windows.Forms.Padding(5);
            this.pnNAdd.Size = new System.Drawing.Size(263, 52);
            this.pnNAdd.TabIndex = 11;
            this.pnNAdd.MouseEnter += new System.EventHandler(this.pnNAdd_MouseEnter);
            this.pnNAdd.MouseLeave += new System.EventHandler(this.pnNAdd_MouseLeave);
            // 
            // bnNAdd
            // 
            this.bnNAdd.AutoSize = false;
            this.bnNAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnNAdd.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnNAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnNAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnNAdd.Depth = 0;
            this.bnNAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnNAdd.Enabled = false;
            this.bnNAdd.HighEmphasis = true;
            this.bnNAdd.Icon = null;
            this.bnNAdd.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnNAdd.IconAndTextPadding = 4;
            this.bnNAdd.IconAutoSizePercentage = 20D;
            this.bnNAdd.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnNAdd.IconTransparency = 70D;
            this.bnNAdd.Location = new System.Drawing.Point(5, 5);
            this.bnNAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bnNAdd.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnNAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnNAdd.Name = "bnNAdd";
            this.bnNAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnNAdd.Size = new System.Drawing.Size(253, 42);
            this.bnNAdd.TabIndex = 6;
            this.bnNAdd.Text = "Agregar";
            this.bnNAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnNAdd.UseAccentColor = false;
            this.bnNAdd.UseVisualStyleBackColor = true;
            this.bnNAdd.Click += new System.EventHandler(this.bnNAdd_Click);
            // 
            // lbNError
            // 
            this.lbNError.AutoSize = true;
            this.tlpNAdd.SetColumnSpan(this.lbNError, 2);
            this.lbNError.Depth = 0;
            this.lbNError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNError.ErrorState = true;
            this.lbNError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbNError.Location = new System.Drawing.Point(0, 358);
            this.lbNError.Margin = new System.Windows.Forms.Padding(0);
            this.lbNError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNError.Name = "lbNError";
            this.lbNError.Size = new System.Drawing.Size(526, 20);
            this.lbNError.TabIndex = 12;
            this.lbNError.Text = "Monto incompleto";
            this.lbNError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNError.Visible = false;
            this.lbNError.TextChanged += new System.EventHandler(this.lbNError_TextChanged);
            // 
            // mcNIc
            // 
            this.mcNIc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcNIc.Controls.Add(this.pnNMPrice);
            this.mcNIc.Depth = 0;
            this.mcNIc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcNIc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcNIc.Location = new System.Drawing.Point(868, 8);
            this.mcNIc.Margin = new System.Windows.Forms.Padding(4, 6, 6, 4);
            this.mcNIc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcNIc.Name = "mcNIc";
            this.mcNIc.Padding = new System.Windows.Forms.Padding(6);
            this.mcNIc.Size = new System.Drawing.Size(290, 195);
            this.mcNIc.TabIndex = 0;
            // 
            // pnNMPrice
            // 
            this.pnNMPrice.Controls.Add(this.lbNMPrice);
            this.pnNMPrice.Controls.Add(this.lbNMPriceTitle);
            this.pnNMPrice.Location = new System.Drawing.Point(6, 6);
            this.pnNMPrice.Margin = new System.Windows.Forms.Padding(0);
            this.pnNMPrice.Name = "pnNMPrice";
            this.pnNMPrice.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnNMPrice.Size = new System.Drawing.Size(278, 183);
            this.pnNMPrice.TabIndex = 0;
            // 
            // lbNMPrice
            // 
            this.lbNMPrice.Depth = 0;
            this.lbNMPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNMPrice.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbNMPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbNMPrice.Location = new System.Drawing.Point(2, 92);
            this.lbNMPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lbNMPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNMPrice.Name = "lbNMPrice";
            this.lbNMPrice.Size = new System.Drawing.Size(274, 91);
            this.lbNMPrice.TabIndex = 3;
            this.lbNMPrice.Text = "$";
            this.lbNMPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNMPriceTitle
            // 
            this.lbNMPriceTitle.Depth = 0;
            this.lbNMPriceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNMPriceTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbNMPriceTitle.Location = new System.Drawing.Point(2, 0);
            this.lbNMPriceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbNMPriceTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNMPriceTitle.Name = "lbNMPriceTitle";
            this.lbNMPriceTitle.Size = new System.Drawing.Size(274, 91);
            this.lbNMPriceTitle.TabIndex = 2;
            this.lbNMPriceTitle.Text = "Monto del mes luego de insertar esta factura";
            this.lbNMPriceTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mcBNC
            // 
            this.mcBNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBNC.Controls.Add(this.tlpBNC);
            this.mcBNC.Depth = 0;
            this.mcBNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBNC.Location = new System.Drawing.Point(868, 416);
            this.mcBNC.Margin = new System.Windows.Forms.Padding(4, 4, 6, 6);
            this.mcBNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBNC.Name = "mcBNC";
            this.mcBNC.Padding = new System.Windows.Forms.Padding(10);
            this.mcBNC.Size = new System.Drawing.Size(290, 264);
            this.mcBNC.TabIndex = 6;
            // 
            // tlpBNC
            // 
            this.tlpBNC.ColumnCount = 2;
            this.tlpBNC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBNC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBNC.Controls.Add(this.chtBNC, 0, 2);
            this.tlpBNC.Controls.Add(this.lbBNCFrom, 0, 3);
            this.tlpBNC.Controls.Add(this.lbBNCTo, 1, 3);
            this.tlpBNC.Controls.Add(this.lbBNCValue, 0, 1);
            this.tlpBNC.Controls.Add(this.lbBNCTitle, 0, 0);
            this.tlpBNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBNC.Location = new System.Drawing.Point(10, 10);
            this.tlpBNC.Name = "tlpBNC";
            this.tlpBNC.RowCount = 4;
            this.tlpBNC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBNC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBNC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tlpBNC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBNC.Size = new System.Drawing.Size(270, 244);
            this.tlpBNC.TabIndex = 1;
            // 
            // chtBNC
            // 
            this.tlpBNC.SetColumnSpan(this.chtBNC, 2);
            this.chtBNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtBNC.Location = new System.Drawing.Point(20, 79);
            this.chtBNC.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.chtBNC.Name = "chtBNC";
            this.chtBNC.Size = new System.Drawing.Size(230, 116);
            this.chtBNC.TabIndex = 0;
            // 
            // lbBNCFrom
            // 
            this.lbBNCFrom.AutoSize = true;
            this.lbBNCFrom.Depth = 0;
            this.lbBNCFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBNCFrom.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbBNCFrom.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbBNCFrom.Location = new System.Drawing.Point(0, 200);
            this.lbBNCFrom.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbBNCFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBNCFrom.Name = "lbBNCFrom";
            this.lbBNCFrom.Size = new System.Drawing.Size(135, 44);
            this.lbBNCFrom.TabIndex = 1;
            // 
            // lbBNCTo
            // 
            this.lbBNCTo.AutoSize = true;
            this.lbBNCTo.Depth = 0;
            this.lbBNCTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBNCTo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbBNCTo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbBNCTo.Location = new System.Drawing.Point(135, 200);
            this.lbBNCTo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbBNCTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBNCTo.Name = "lbBNCTo";
            this.lbBNCTo.Size = new System.Drawing.Size(135, 44);
            this.lbBNCTo.TabIndex = 1;
            this.lbBNCTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBNCValue
            // 
            this.lbBNCValue.AutoSize = true;
            this.tlpBNC.SetColumnSpan(this.lbBNCValue, 2);
            this.lbBNCValue.Depth = 0;
            this.lbBNCValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBNCValue.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbBNCValue.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbBNCValue.Location = new System.Drawing.Point(3, 30);
            this.lbBNCValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBNCValue.Name = "lbBNCValue";
            this.lbBNCValue.Size = new System.Drawing.Size(264, 49);
            this.lbBNCValue.TabIndex = 2;
            this.lbBNCValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbBNCTitle
            // 
            this.lbBNCTitle.AutoSize = true;
            this.tlpBNC.SetColumnSpan(this.lbBNCTitle, 2);
            this.lbBNCTitle.Depth = 0;
            this.lbBNCTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBNCTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBNCTitle.Location = new System.Drawing.Point(3, 0);
            this.lbBNCTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBNCTitle.Name = "lbBNCTitle";
            this.lbBNCTitle.Size = new System.Drawing.Size(264, 30);
            this.lbBNCTitle.TabIndex = 3;
            this.lbBNCTitle.Text = "Distancia con la siguiente categoría";
            this.lbBNCTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mcBDailyGoal
            // 
            this.mcBDailyGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBDailyGoal.Controls.Add(this.pnBDailyGoal);
            this.mcBDailyGoal.Depth = 0;
            this.mcBDailyGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBDailyGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBDailyGoal.Location = new System.Drawing.Point(868, 211);
            this.mcBDailyGoal.Margin = new System.Windows.Forms.Padding(4, 4, 6, 4);
            this.mcBDailyGoal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBDailyGoal.Name = "mcBDailyGoal";
            this.mcBDailyGoal.Padding = new System.Windows.Forms.Padding(6);
            this.mcBDailyGoal.Size = new System.Drawing.Size(290, 197);
            this.mcBDailyGoal.TabIndex = 7;
            // 
            // pnBDailyGoal
            // 
            this.pnBDailyGoal.Controls.Add(this.lbBDailyGoalPercent);
            this.pnBDailyGoal.Controls.Add(this.pbBDailyGoal);
            this.pnBDailyGoal.Controls.Add(this.lbBDailyGoalPrice);
            this.pnBDailyGoal.Controls.Add(this.lbBDailyGoalTitle);
            this.pnBDailyGoal.Location = new System.Drawing.Point(6, 6);
            this.pnBDailyGoal.Margin = new System.Windows.Forms.Padding(0);
            this.pnBDailyGoal.Name = "pnBDailyGoal";
            this.pnBDailyGoal.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnBDailyGoal.Size = new System.Drawing.Size(278, 185);
            this.pnBDailyGoal.TabIndex = 1;
            // 
            // lbBDailyGoalPercent
            // 
            this.lbBDailyGoalPercent.Depth = 0;
            this.lbBDailyGoalPercent.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbBDailyGoalPercent.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbBDailyGoalPercent.Location = new System.Drawing.Point(2, 76);
            this.lbBDailyGoalPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lbBDailyGoalPercent.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBDailyGoalPercent.Name = "lbBDailyGoalPercent";
            this.lbBDailyGoalPercent.Size = new System.Drawing.Size(273, 26);
            this.lbBDailyGoalPercent.TabIndex = 2;
            this.lbBDailyGoalPercent.Text = "50%";
            this.lbBDailyGoalPercent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbBDailyGoal
            // 
            this.pbBDailyGoal.Depth = 0;
            this.pbBDailyGoal.Location = new System.Drawing.Point(2, 102);
            this.pbBDailyGoal.Margin = new System.Windows.Forms.Padding(0);
            this.pbBDailyGoal.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbBDailyGoal.Name = "pbBDailyGoal";
            this.pbBDailyGoal.Size = new System.Drawing.Size(272, 5);
            this.pbBDailyGoal.TabIndex = 0;
            this.pbBDailyGoal.Value = 50;
            // 
            // lbBDailyGoalPrice
            // 
            this.lbBDailyGoalPrice.Depth = 0;
            this.lbBDailyGoalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbBDailyGoalPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbBDailyGoalPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbBDailyGoalPrice.Location = new System.Drawing.Point(3, 109);
            this.lbBDailyGoalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBDailyGoalPrice.Name = "lbBDailyGoalPrice";
            this.lbBDailyGoalPrice.Size = new System.Drawing.Size(272, 76);
            this.lbBDailyGoalPrice.TabIndex = 1;
            this.lbBDailyGoalPrice.Text = "$0";
            this.lbBDailyGoalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbBDailyGoalTitle
            // 
            this.lbBDailyGoalTitle.Depth = 0;
            this.lbBDailyGoalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBDailyGoalTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBDailyGoalTitle.Location = new System.Drawing.Point(3, 0);
            this.lbBDailyGoalTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbBDailyGoalTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBDailyGoalTitle.Name = "lbBDailyGoalTitle";
            this.lbBDailyGoalTitle.Size = new System.Drawing.Size(272, 76);
            this.lbBDailyGoalTitle.TabIndex = 1;
            this.lbBDailyGoalTitle.Text = "Monto diario maximo dentro de la\ncategoría actual: $0";
            this.lbBDailyGoalTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tpBills
            // 
            this.tpBills.BackColor = System.Drawing.Color.White;
            this.tpBills.Controls.Add(this.tlpBills);
            this.tpBills.ImageKey = "Bills24.png";
            this.tpBills.Location = new System.Drawing.Point(4, 31);
            this.tpBills.Margin = new System.Windows.Forms.Padding(0);
            this.tpBills.Name = "tpBills";
            this.tpBills.Size = new System.Drawing.Size(1164, 686);
            this.tpBills.TabIndex = 2;
            this.tpBills.Text = "Facturas";
            // 
            // tlpBills
            // 
            this.tlpBills.ColumnCount = 2;
            this.tlpBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpBills.Controls.Add(this.mcBPayTypes, 1, 2);
            this.tlpBills.Controls.Add(this.mcBStats, 1, 0);
            this.tlpBills.Controls.Add(this.mcBIc, 1, 1);
            this.tlpBills.Controls.Add(this.mcBDgv, 0, 1);
            this.tlpBills.Controls.Add(this.mcBSearch, 0, 0);
            this.tlpBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBills.Location = new System.Drawing.Point(0, 0);
            this.tlpBills.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBills.Name = "tlpBills";
            this.tlpBills.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpBills.RowCount = 3;
            this.tlpBills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpBills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBills.Size = new System.Drawing.Size(1164, 686);
            this.tlpBills.TabIndex = 0;
            // 
            // mcBPayTypes
            // 
            this.mcBPayTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBPayTypes.Controls.Add(this.chtBPayTypes);
            this.mcBPayTypes.Controls.Add(this.lbBPayTypesTitle);
            this.mcBPayTypes.Depth = 0;
            this.mcBPayTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBPayTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBPayTypes.Location = new System.Drawing.Point(868, 416);
            this.mcBPayTypes.Margin = new System.Windows.Forms.Padding(4, 4, 6, 6);
            this.mcBPayTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBPayTypes.Name = "mcBPayTypes";
            this.mcBPayTypes.Padding = new System.Windows.Forms.Padding(20, 6, 20, 20);
            this.mcBPayTypes.Size = new System.Drawing.Size(290, 264);
            this.mcBPayTypes.TabIndex = 5;
            // 
            // chtBPayTypes
            // 
            this.chtBPayTypes.BackColorTransparent = true;
            this.chtBPayTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtBPayTypes.Location = new System.Drawing.Point(20, 34);
            this.chtBPayTypes.Margin = new System.Windows.Forms.Padding(0);
            this.chtBPayTypes.Name = "chtBPayTypes";
            this.chtBPayTypes.Size = new System.Drawing.Size(250, 210);
            this.chtBPayTypes.TabIndex = 0;
            // 
            // lbBPayTypesTitle
            // 
            this.lbBPayTypesTitle.Depth = 0;
            this.lbBPayTypesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBPayTypesTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBPayTypesTitle.Location = new System.Drawing.Point(20, 6);
            this.lbBPayTypesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBPayTypesTitle.Name = "lbBPayTypesTitle";
            this.lbBPayTypesTitle.Size = new System.Drawing.Size(250, 28);
            this.lbBPayTypesTitle.TabIndex = 1;
            this.lbBPayTypesTitle.Text = "Tipos de pago de las facturas filtradas";
            this.lbBPayTypesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcBStats
            // 
            this.mcBStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBStats.Controls.Add(this.lbBTPrice);
            this.mcBStats.Controls.Add(this.lbBTPriceTitle);
            this.mcBStats.Depth = 0;
            this.mcBStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBStats.Location = new System.Drawing.Point(868, 8);
            this.mcBStats.Margin = new System.Windows.Forms.Padding(4, 6, 6, 4);
            this.mcBStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBStats.Name = "mcBStats";
            this.mcBStats.Padding = new System.Windows.Forms.Padding(6);
            this.mcBStats.Size = new System.Drawing.Size(290, 126);
            this.mcBStats.TabIndex = 3;
            // 
            // lbBTPrice
            // 
            this.lbBTPrice.Depth = 0;
            this.lbBTPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbBTPrice.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbBTPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbBTPrice.Location = new System.Drawing.Point(6, 63);
            this.lbBTPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBTPrice.Name = "lbBTPrice";
            this.lbBTPrice.Size = new System.Drawing.Size(278, 57);
            this.lbBTPrice.TabIndex = 1;
            this.lbBTPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbBTPriceTitle
            // 
            this.lbBTPriceTitle.Depth = 0;
            this.lbBTPriceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBTPriceTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBTPriceTitle.Location = new System.Drawing.Point(6, 6);
            this.lbBTPriceTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBTPriceTitle.Name = "lbBTPriceTitle";
            this.lbBTPriceTitle.Size = new System.Drawing.Size(278, 57);
            this.lbBTPriceTitle.TabIndex = 0;
            this.lbBTPriceTitle.Text = "Monto total de las facturas filtradas";
            this.lbBTPriceTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mcBIc
            // 
            this.mcBIc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBIc.Controls.Add(this.pnBSumP);
            this.mcBIc.Controls.Add(this.chtBPrices);
            this.mcBIc.Depth = 0;
            this.mcBIc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBIc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBIc.Location = new System.Drawing.Point(868, 142);
            this.mcBIc.Margin = new System.Windows.Forms.Padding(4, 4, 6, 4);
            this.mcBIc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBIc.Name = "mcBIc";
            this.mcBIc.Padding = new System.Windows.Forms.Padding(6);
            this.mcBIc.Size = new System.Drawing.Size(290, 266);
            this.mcBIc.TabIndex = 4;
            // 
            // pnBSumP
            // 
            this.pnBSumP.Controls.Add(this.lbBSumPTitle);
            this.pnBSumP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBSumP.Location = new System.Drawing.Point(6, 6);
            this.pnBSumP.Margin = new System.Windows.Forms.Padding(0);
            this.pnBSumP.Name = "pnBSumP";
            this.pnBSumP.Size = new System.Drawing.Size(278, 27);
            this.pnBSumP.TabIndex = 1;
            // 
            // lbBSumPTitle
            // 
            this.lbBSumPTitle.Depth = 0;
            this.lbBSumPTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBSumPTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBSumPTitle.Location = new System.Drawing.Point(0, 0);
            this.lbBSumPTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBSumPTitle.Name = "lbBSumPTitle";
            this.lbBSumPTitle.Size = new System.Drawing.Size(278, 27);
            this.lbBSumPTitle.TabIndex = 0;
            this.lbBSumPTitle.Text = "Montos de las facturas filtradas";
            this.lbBSumPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chtBPrices
            // 
            this.chtBPrices.BackColorTransparent = true;
            this.chtBPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtBPrices.Location = new System.Drawing.Point(6, 6);
            this.chtBPrices.Name = "chtBPrices";
            this.chtBPrices.Size = new System.Drawing.Size(278, 254);
            this.chtBPrices.TabIndex = 0;
            // 
            // mcBDgv
            // 
            this.mcBDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBDgv.Controls.Add(this.dgvBills);
            this.mcBDgv.Depth = 0;
            this.mcBDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBDgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBDgv.Location = new System.Drawing.Point(8, 142);
            this.mcBDgv.Margin = new System.Windows.Forms.Padding(6, 4, 4, 6);
            this.mcBDgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBDgv.Name = "mcBDgv";
            this.mcBDgv.Padding = new System.Windows.Forms.Padding(10);
            this.tlpBills.SetRowSpan(this.mcBDgv, 2);
            this.mcBDgv.Size = new System.Drawing.Size(852, 538);
            this.mcBDgv.TabIndex = 2;
            // 
            // dgvBills
            // 
            this.dgvBills.AddQuery = null;
            this.dgvBills.ColumnCount = 1;
            this.dgvBills.ControlButtonsWidth = 48F;
            this.dgvBills.ControlsHeight = 34F;
            this.dgvBills.CurrentPage = 1;
            this.dgvBills.DeleteQuery = null;
            this.dgvBills.Depth = 0;
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.Location = new System.Drawing.Point(10, 10);
            this.dgvBills.ModifyQuery = null;
            this.dgvBills.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.OrderBy = null;
            this.dgvBills.RowCount = 2;
            this.dgvBills.Size = new System.Drawing.Size(832, 518);
            this.dgvBills.SourceQuery = null;
            this.dgvBills.TabIndex = 0;
            this.dgvBills.TotalItemsQuery = null;
            // 
            // mcBSearch
            // 
            this.mcBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcBSearch.Controls.Add(this.tlpBSearch);
            this.mcBSearch.Depth = 0;
            this.mcBSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcBSearch.Location = new System.Drawing.Point(8, 8);
            this.mcBSearch.Margin = new System.Windows.Forms.Padding(6, 6, 4, 4);
            this.mcBSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcBSearch.Name = "mcBSearch";
            this.mcBSearch.Padding = new System.Windows.Forms.Padding(10);
            this.mcBSearch.Size = new System.Drawing.Size(852, 126);
            this.mcBSearch.TabIndex = 1;
            // 
            // tlpBSearch
            // 
            this.tlpBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpBSearch.ColumnCount = 3;
            this.tlpBSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpBSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpBSearch.Controls.Add(this.pnBSearchCols, 2, 1);
            this.tlpBSearch.Controls.Add(this.txBSearch, 0, 1);
            this.tlpBSearch.Controls.Add(this.dtpBEndDate, 2, 0);
            this.tlpBSearch.Controls.Add(this.dtpBStartDate, 0, 0);
            this.tlpBSearch.Controls.Add(this.pnBDateArrow, 1, 0);
            this.tlpBSearch.Depth = 0;
            this.tlpBSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBSearch.Location = new System.Drawing.Point(10, 10);
            this.tlpBSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBSearch.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.BackgroundColor;
            this.tlpBSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.tlpBSearch.Name = "tlpBSearch";
            this.tlpBSearch.RowCount = 2;
            this.tlpBSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBSearch.Size = new System.Drawing.Size(832, 106);
            this.tlpBSearch.TabIndex = 0;
            // 
            // pnBSearchCols
            // 
            this.pnBSearchCols.Controls.Add(this.cbBSearchCols);
            this.pnBSearchCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBSearchCols.Location = new System.Drawing.Point(602, 53);
            this.pnBSearchCols.Margin = new System.Windows.Forms.Padding(0);
            this.pnBSearchCols.Name = "pnBSearchCols";
            this.pnBSearchCols.Size = new System.Drawing.Size(230, 53);
            this.pnBSearchCols.TabIndex = 4;
            // 
            // cbBSearchCols
            // 
            this.cbBSearchCols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBSearchCols.AutoResize = false;
            this.cbBSearchCols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbBSearchCols.Depth = 0;
            this.cbBSearchCols.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbBSearchCols.DisabledItems")));
            this.cbBSearchCols.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBSearchCols.DropDownHeight = 170;
            this.cbBSearchCols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBSearchCols.DropDownWidth = 121;
            this.cbBSearchCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbBSearchCols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbBSearchCols.Hint = "Campo en donde buscar";
            this.cbBSearchCols.IntegralHeight = false;
            this.cbBSearchCols.ItemHeight = 42;
            this.cbBSearchCols.Location = new System.Drawing.Point(0, 5);
            this.cbBSearchCols.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cbBSearchCols.MaxDropDownItems = 4;
            this.cbBSearchCols.MouseState = MaterialSkin.MouseState.OUT;
            this.cbBSearchCols.Name = "cbBSearchCols";
            this.cbBSearchCols.Size = new System.Drawing.Size(230, 48);
            this.cbBSearchCols.StartIndex = 0;
            this.cbBSearchCols.TabIndex = 0;
            this.cbBSearchCols.SelectedIndexChanged += new System.EventHandler(this.BillsCtrlsValueChanged);
            // 
            // txBSearch
            // 
            this.txBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBSearch.AnimateReadOnly = false;
            this.txBSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txBSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txBSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpBSearch.SetColumnSpan(this.txBSearch, 2);
            this.txBSearch.Depth = 0;
            this.txBSearch.ErrorState = false;
            this.txBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txBSearch.HideSelection = true;
            this.txBSearch.Hint = "Buscar";
            this.txBSearch.LeadingIcon = null;
            this.txBSearch.Location = new System.Drawing.Point(0, 58);
            this.txBSearch.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.txBSearch.MaxLength = 75;
            this.txBSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txBSearch.Name = "txBSearch";
            this.txBSearch.PasswordChar = '\0';
            this.txBSearch.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.txBSearch.PrefixSuffixText = null;
            this.txBSearch.ReadOnly = false;
            this.txBSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txBSearch.SelectedText = "";
            this.txBSearch.SelectionLength = 0;
            this.txBSearch.SelectionStart = 0;
            this.txBSearch.ShortcutsEnabled = true;
            this.txBSearch.Size = new System.Drawing.Size(602, 48);
            this.txBSearch.TabIndex = 3;
            this.txBSearch.TabStop = false;
            this.txBSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txBSearch.TrailingIcon = null;
            this.txBSearch.UseSystemPasswordChar = false;
            this.txBSearch.TextChanged += new System.EventHandler(this.BillsCtrlsValueChanged);
            // 
            // dtpBEndDate
            // 
            this.dtpBEndDate.AllowPromptAsInput = true;
            this.dtpBEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBEndDate.AnimateReadOnly = false;
            this.dtpBEndDate.AsciiOnly = false;
            this.dtpBEndDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dtpBEndDate.BeepOnError = false;
            this.dtpBEndDate.CalendarSize = new System.Drawing.Size(1, 1);
            this.dtpBEndDate.Depth = 0;
            this.dtpBEndDate.ErrorState = false;
            this.dtpBEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpBEndDate.HidePromptOnLeave = false;
            this.dtpBEndDate.HideSelection = true;
            this.dtpBEndDate.Hint = "Fecha de fin";
            this.dtpBEndDate.IconPadding = 9;
            this.dtpBEndDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dtpBEndDate.LeadingIcon = null;
            this.dtpBEndDate.Location = new System.Drawing.Point(602, 0);
            this.dtpBEndDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpBEndDate.MaxLength = 32767;
            this.dtpBEndDate.MouseState = MaterialSkin.MouseState.OUT;
            this.dtpBEndDate.Name = "dtpBEndDate";
            this.dtpBEndDate.PrefixSuffixText = null;
            this.dtpBEndDate.RejectInputOnFirstFailure = false;
            this.dtpBEndDate.ResetOnPrompt = true;
            this.dtpBEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBEndDate.SelectedText = "";
            this.dtpBEndDate.SelectionLength = 0;
            this.dtpBEndDate.SelectionStart = 0;
            this.dtpBEndDate.ShortcutsEnabled = true;
            this.dtpBEndDate.Size = new System.Drawing.Size(230, 48);
            this.dtpBEndDate.TabIndex = 1;
            this.dtpBEndDate.TabStop = false;
            this.dtpBEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dtpBEndDate.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("dtpBEndDate.TrailingIcon")));
            this.dtpBEndDate.ValidatingType = null;
            this.dtpBEndDate.Value = new System.DateTime(2023, 9, 2, 0, 0, 0, 0);
            // 
            // dtpBStartDate
            // 
            this.dtpBStartDate.AllowPromptAsInput = true;
            this.dtpBStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBStartDate.AnimateReadOnly = false;
            this.dtpBStartDate.AsciiOnly = false;
            this.dtpBStartDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dtpBStartDate.BeepOnError = false;
            this.dtpBStartDate.CalendarSize = new System.Drawing.Size(1, 1);
            this.dtpBStartDate.Depth = 0;
            this.dtpBStartDate.ErrorState = false;
            this.dtpBStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpBStartDate.HidePromptOnLeave = false;
            this.dtpBStartDate.HideSelection = true;
            this.dtpBStartDate.Hint = "Fecha de inicio";
            this.dtpBStartDate.IconPadding = 9;
            this.dtpBStartDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dtpBStartDate.LeadingIcon = null;
            this.dtpBStartDate.Location = new System.Drawing.Point(0, 0);
            this.dtpBStartDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpBStartDate.MaxLength = 32767;
            this.dtpBStartDate.MouseState = MaterialSkin.MouseState.OUT;
            this.dtpBStartDate.Name = "dtpBStartDate";
            this.dtpBStartDate.PrefixSuffixText = null;
            this.dtpBStartDate.RejectInputOnFirstFailure = false;
            this.dtpBStartDate.ResetOnPrompt = true;
            this.dtpBStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBStartDate.SelectedText = "";
            this.dtpBStartDate.SelectionLength = 0;
            this.dtpBStartDate.SelectionStart = 0;
            this.dtpBStartDate.ShortcutsEnabled = true;
            this.dtpBStartDate.Size = new System.Drawing.Size(230, 48);
            this.dtpBStartDate.TabIndex = 1;
            this.dtpBStartDate.TabStop = false;
            this.dtpBStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dtpBStartDate.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("dtpBStartDate.TrailingIcon")));
            this.dtpBStartDate.ValidatingType = null;
            this.dtpBStartDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // pnBDateArrow
            // 
            this.pnBDateArrow.Controls.Add(this.bnBNextMonth);
            this.pnBDateArrow.Controls.Add(this.bnBPrevMonth);
            this.pnBDateArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBDateArrow.Location = new System.Drawing.Point(237, 0);
            this.pnBDateArrow.Margin = new System.Windows.Forms.Padding(7, 0, 7, 3);
            this.pnBDateArrow.Name = "pnBDateArrow";
            this.pnBDateArrow.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.pnBDateArrow.Size = new System.Drawing.Size(358, 50);
            this.pnBDateArrow.TabIndex = 5;
            // 
            // bnBNextMonth
            // 
            this.bnBNextMonth.AutoSize = false;
            this.bnBNextMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnBNextMonth.CornerRadius = 3;
            this.bnBNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnBNextMonth.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnBNextMonth.Depth = 0;
            this.bnBNextMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnBNextMonth.HighEmphasis = true;
            this.bnBNextMonth.Icon = null;
            this.bnBNextMonth.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnBNextMonth.IconAndTextPadding = 4;
            this.bnBNextMonth.IconAutoSizePercentage = 20D;
            this.bnBNextMonth.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnBNextMonth.IconTransparency = 70D;
            this.bnBNextMonth.Location = new System.Drawing.Point(329, 1);
            this.bnBNextMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnBNextMonth.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.BackgroundColor;
            this.bnBNextMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnBNextMonth.Name = "bnBNextMonth";
            this.bnBNextMonth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnBNextMonth.Size = new System.Drawing.Size(26, 46);
            this.bnBNextMonth.TabIndex = 0;
            this.bnBNextMonth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnBNextMonth.UseAccentColor = true;
            this.bnBNextMonth.UseVisualStyleBackColor = true;
            this.bnBNextMonth.Click += new System.EventHandler(this.bnBNextMonth_Click);
            // 
            // bnBPrevMonth
            // 
            this.bnBPrevMonth.AutoSize = false;
            this.bnBPrevMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnBPrevMonth.CornerRadius = 3;
            this.bnBPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnBPrevMonth.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnBPrevMonth.Depth = 0;
            this.bnBPrevMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnBPrevMonth.HighEmphasis = true;
            this.bnBPrevMonth.Icon = null;
            this.bnBPrevMonth.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Center;
            this.bnBPrevMonth.IconAndTextPadding = 0;
            this.bnBPrevMonth.IconAutoSizePercentage = 20D;
            this.bnBPrevMonth.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnBPrevMonth.IconTransparency = 70D;
            this.bnBPrevMonth.Location = new System.Drawing.Point(3, 1);
            this.bnBPrevMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnBPrevMonth.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.BackgroundColor;
            this.bnBPrevMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnBPrevMonth.Name = "bnBPrevMonth";
            this.bnBPrevMonth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnBPrevMonth.Size = new System.Drawing.Size(26, 46);
            this.bnBPrevMonth.TabIndex = 0;
            this.bnBPrevMonth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnBPrevMonth.UseAccentColor = true;
            this.bnBPrevMonth.UseVisualStyleBackColor = true;
            this.bnBPrevMonth.Click += new System.EventHandler(this.bnBPrevMonth_Click);
            // 
            // tpUsers
            // 
            this.tpUsers.BackColor = System.Drawing.Color.White;
            this.tpUsers.Controls.Add(this.tlpUsers);
            this.tpUsers.ImageKey = "Users24.png";
            this.tpUsers.Location = new System.Drawing.Point(4, 31);
            this.tpUsers.Margin = new System.Windows.Forms.Padding(0);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Size = new System.Drawing.Size(1164, 686);
            this.tpUsers.TabIndex = 3;
            this.tpUsers.Text = "Usuarios";
            // 
            // tlpUsers
            // 
            this.tlpUsers.ColumnCount = 2;
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpUsers.Controls.Add(this.mcUDgv, 0, 1);
            this.tlpUsers.Controls.Add(this.mcUStats, 1, 0);
            this.tlpUsers.Controls.Add(this.mcUSearch, 0, 0);
            this.tlpUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsers.Location = new System.Drawing.Point(0, 0);
            this.tlpUsers.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUsers.Name = "tlpUsers";
            this.tlpUsers.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpUsers.RowCount = 2;
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.Size = new System.Drawing.Size(1164, 686);
            this.tlpUsers.TabIndex = 1;
            // 
            // mcUDgv
            // 
            this.mcUDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcUDgv.Controls.Add(this.dgvUsers);
            this.mcUDgv.Depth = 0;
            this.mcUDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcUDgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcUDgv.Location = new System.Drawing.Point(8, 84);
            this.mcUDgv.Margin = new System.Windows.Forms.Padding(6, 4, 4, 6);
            this.mcUDgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcUDgv.Name = "mcUDgv";
            this.mcUDgv.Padding = new System.Windows.Forms.Padding(10);
            this.mcUDgv.Size = new System.Drawing.Size(852, 596);
            this.mcUDgv.TabIndex = 2;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AddQuery = null;
            this.dgvUsers.ColumnCount = 1;
            this.dgvUsers.ControlButtonsWidth = 48F;
            this.dgvUsers.ControlsHeight = 34F;
            this.dgvUsers.CurrentPage = 1;
            this.dgvUsers.DeleteQuery = null;
            this.dgvUsers.Depth = 0;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(10, 10);
            this.dgvUsers.ModifyQuery = null;
            this.dgvUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.OrderBy = null;
            this.dgvUsers.RowCount = 2;
            this.dgvUsers.Size = new System.Drawing.Size(832, 576);
            this.dgvUsers.SourceQuery = null;
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.TotalItemsQuery = null;
            // 
            // mcUStats
            // 
            this.mcUStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcUStats.Controls.Add(this.dgvUsersLogIns);
            this.mcUStats.Depth = 0;
            this.mcUStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcUStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcUStats.Location = new System.Drawing.Point(868, 8);
            this.mcUStats.Margin = new System.Windows.Forms.Padding(4, 6, 6, 6);
            this.mcUStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcUStats.Name = "mcUStats";
            this.mcUStats.Padding = new System.Windows.Forms.Padding(6);
            this.tlpUsers.SetRowSpan(this.mcUStats, 2);
            this.mcUStats.Size = new System.Drawing.Size(290, 672);
            this.mcUStats.TabIndex = 3;
            // 
            // dgvUsersLogIns
            // 
            this.dgvUsersLogIns.AddQuery = null;
            this.dgvUsersLogIns.ColumnCount = 1;
            this.dgvUsersLogIns.ControlButtonsWidth = 48F;
            this.dgvUsersLogIns.ControlsHeight = 34F;
            this.dgvUsersLogIns.CurrentPage = 1;
            this.dgvUsersLogIns.DeleteQuery = null;
            this.dgvUsersLogIns.Depth = 0;
            this.dgvUsersLogIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersLogIns.Location = new System.Drawing.Point(6, 6);
            this.dgvUsersLogIns.ModifyQuery = null;
            this.dgvUsersLogIns.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvUsersLogIns.Name = "dgvUsersLogIns";
            this.dgvUsersLogIns.OrderBy = "";
            this.dgvUsersLogIns.RowCount = 2;
            this.dgvUsersLogIns.Size = new System.Drawing.Size(278, 660);
            this.dgvUsersLogIns.SourceQuery = null;
            this.dgvUsersLogIns.TabIndex = 0;
            this.dgvUsersLogIns.TotalItemsQuery = null;
            // 
            // mcUSearch
            // 
            this.mcUSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcUSearch.Controls.Add(this.tlpUSearch);
            this.mcUSearch.Depth = 0;
            this.mcUSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcUSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcUSearch.Location = new System.Drawing.Point(8, 8);
            this.mcUSearch.Margin = new System.Windows.Forms.Padding(6, 6, 4, 4);
            this.mcUSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcUSearch.Name = "mcUSearch";
            this.mcUSearch.Padding = new System.Windows.Forms.Padding(10);
            this.mcUSearch.Size = new System.Drawing.Size(852, 68);
            this.mcUSearch.TabIndex = 1;
            // 
            // tlpUSearch
            // 
            this.tlpUSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpUSearch.ColumnCount = 2;
            this.tlpUSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpUSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUSearch.Controls.Add(this.pnUSearchCols, 1, 0);
            this.tlpUSearch.Controls.Add(this.txUSearch, 0, 0);
            this.tlpUSearch.Depth = 0;
            this.tlpUSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUSearch.Location = new System.Drawing.Point(10, 10);
            this.tlpUSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUSearch.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.BackgroundColor;
            this.tlpUSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.tlpUSearch.Name = "tlpUSearch";
            this.tlpUSearch.RowCount = 1;
            this.tlpUSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUSearch.Size = new System.Drawing.Size(832, 48);
            this.tlpUSearch.TabIndex = 0;
            // 
            // pnUSearchCols
            // 
            this.pnUSearchCols.Controls.Add(this.cbUSearchCols);
            this.pnUSearchCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUSearchCols.Location = new System.Drawing.Point(602, 0);
            this.pnUSearchCols.Margin = new System.Windows.Forms.Padding(0);
            this.pnUSearchCols.Name = "pnUSearchCols";
            this.pnUSearchCols.Size = new System.Drawing.Size(230, 48);
            this.pnUSearchCols.TabIndex = 4;
            // 
            // cbUSearchCols
            // 
            this.cbUSearchCols.AutoResize = false;
            this.cbUSearchCols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbUSearchCols.Depth = 0;
            this.cbUSearchCols.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbUSearchCols.DisabledItems")));
            this.cbUSearchCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUSearchCols.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUSearchCols.DropDownHeight = 170;
            this.cbUSearchCols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUSearchCols.DropDownWidth = 121;
            this.cbUSearchCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbUSearchCols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbUSearchCols.Hint = "Campo en donde buscar";
            this.cbUSearchCols.IntegralHeight = false;
            this.cbUSearchCols.ItemHeight = 42;
            this.cbUSearchCols.Location = new System.Drawing.Point(0, 0);
            this.cbUSearchCols.Margin = new System.Windows.Forms.Padding(0);
            this.cbUSearchCols.MaxDropDownItems = 4;
            this.cbUSearchCols.MouseState = MaterialSkin.MouseState.OUT;
            this.cbUSearchCols.Name = "cbUSearchCols";
            this.cbUSearchCols.Size = new System.Drawing.Size(230, 48);
            this.cbUSearchCols.StartIndex = 0;
            this.cbUSearchCols.TabIndex = 0;
            this.cbUSearchCols.SelectedIndexChanged += new System.EventHandler(this.UsersCtrlsValueChanged);
            // 
            // txUSearch
            // 
            this.txUSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txUSearch.AnimateReadOnly = false;
            this.txUSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txUSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txUSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txUSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txUSearch.Depth = 0;
            this.txUSearch.ErrorState = false;
            this.txUSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txUSearch.HideSelection = true;
            this.txUSearch.Hint = "Buscar";
            this.txUSearch.LeadingIcon = null;
            this.txUSearch.Location = new System.Drawing.Point(0, 0);
            this.txUSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txUSearch.MaxLength = 65;
            this.txUSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txUSearch.Name = "txUSearch";
            this.txUSearch.PasswordChar = '\0';
            this.txUSearch.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.txUSearch.PrefixSuffixText = null;
            this.txUSearch.ReadOnly = false;
            this.txUSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txUSearch.SelectedText = "";
            this.txUSearch.SelectionLength = 0;
            this.txUSearch.SelectionStart = 0;
            this.txUSearch.ShortcutsEnabled = true;
            this.txUSearch.Size = new System.Drawing.Size(602, 48);
            this.txUSearch.TabIndex = 3;
            this.txUSearch.TabStop = false;
            this.txUSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUSearch.TrailingIcon = null;
            this.txUSearch.UseSystemPasswordChar = false;
            this.txUSearch.TextChanged += new System.EventHandler(this.UsersCtrlsValueChanged);
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.White;
            this.tpSettings.Controls.Add(this.tcSSettings);
            this.tpSettings.Controls.Add(this.tsSettings);
            this.tpSettings.ImageKey = "Settings24.png";
            this.tpSettings.Location = new System.Drawing.Point(4, 31);
            this.tpSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(1164, 686);
            this.tpSettings.TabIndex = 4;
            this.tpSettings.Text = "Ajustes";
            // 
            // tcSSettings
            // 
            this.tcSSettings.Controls.Add(this.tpSInnerTables);
            this.tcSSettings.Controls.Add(this.tpSAccount);
            this.tcSSettings.Controls.Add(this.tpSShop);
            this.tcSSettings.Controls.Add(this.tpSCustom);
            this.tcSSettings.Controls.Add(this.tpSAbout);
            this.tcSSettings.Depth = 0;
            this.tcSSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSSettings.Location = new System.Drawing.Point(0, 40);
            this.tcSSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcSSettings.Multiline = true;
            this.tcSSettings.Name = "tcSSettings";
            this.tcSSettings.SelectedIndex = 0;
            this.tcSSettings.Size = new System.Drawing.Size(1164, 646);
            this.tcSSettings.TabIndex = 0;
            this.tcSSettings.SelectedIndexChanged += new System.EventHandler(this.tcSSettings_SelectedIndexChanged);
            this.tcSSettings.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcsAnimation_Selecting);
            // 
            // tpSInnerTables
            // 
            this.tpSInnerTables.BackColor = System.Drawing.Color.White;
            this.tpSInnerTables.Controls.Add(this.tlpSInnerTables);
            this.tpSInnerTables.Location = new System.Drawing.Point(4, 22);
            this.tpSInnerTables.Margin = new System.Windows.Forms.Padding(0);
            this.tpSInnerTables.Name = "tpSInnerTables";
            this.tpSInnerTables.Size = new System.Drawing.Size(1156, 620);
            this.tpSInnerTables.TabIndex = 0;
            this.tpSInnerTables.Text = "Tablas internas";
            // 
            // tlpSInnerTables
            // 
            this.tlpSInnerTables.ColumnCount = 2;
            this.tlpSInnerTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSInnerTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSInnerTables.Controls.Add(this.mcSITCategories, 0, 0);
            this.tlpSInnerTables.Controls.Add(this.mcSITPayTypes, 1, 0);
            this.tlpSInnerTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSInnerTables.Location = new System.Drawing.Point(0, 0);
            this.tlpSInnerTables.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSInnerTables.Name = "tlpSInnerTables";
            this.tlpSInnerTables.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpSInnerTables.RowCount = 1;
            this.tlpSInnerTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSInnerTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpSInnerTables.Size = new System.Drawing.Size(1156, 620);
            this.tlpSInnerTables.TabIndex = 2;
            // 
            // mcSITCategories
            // 
            this.mcSITCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSITCategories.Controls.Add(this.dgvSITCategories);
            this.mcSITCategories.Controls.Add(this.lbSITCategories);
            this.mcSITCategories.Depth = 0;
            this.mcSITCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcSITCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSITCategories.Location = new System.Drawing.Point(8, 8);
            this.mcSITCategories.Margin = new System.Windows.Forms.Padding(6, 6, 4, 6);
            this.mcSITCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSITCategories.Name = "mcSITCategories";
            this.mcSITCategories.Padding = new System.Windows.Forms.Padding(10);
            this.mcSITCategories.Size = new System.Drawing.Size(567, 606);
            this.mcSITCategories.TabIndex = 1;
            // 
            // dgvSITCategories
            // 
            this.dgvSITCategories.AddQuery = null;
            this.dgvSITCategories.ColumnCount = 1;
            this.dgvSITCategories.ControlButtonsWidth = 48F;
            this.dgvSITCategories.ControlsHeight = 34F;
            this.dgvSITCategories.CurrentPage = 1;
            this.dgvSITCategories.DeleteQuery = null;
            this.dgvSITCategories.Depth = 0;
            this.dgvSITCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSITCategories.Location = new System.Drawing.Point(10, 36);
            this.dgvSITCategories.ModifyQuery = null;
            this.dgvSITCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvSITCategories.Name = "dgvSITCategories";
            this.dgvSITCategories.OrderBy = "";
            this.dgvSITCategories.RowCount = 2;
            this.dgvSITCategories.Size = new System.Drawing.Size(547, 560);
            this.dgvSITCategories.SourceQuery = null;
            this.dgvSITCategories.TabIndex = 0;
            this.dgvSITCategories.TotalItemsQuery = null;
            // 
            // lbSITCategories
            // 
            this.lbSITCategories.Depth = 0;
            this.lbSITCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSITCategories.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSITCategories.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbSITCategories.Location = new System.Drawing.Point(10, 10);
            this.lbSITCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSITCategories.Name = "lbSITCategories";
            this.lbSITCategories.Size = new System.Drawing.Size(547, 26);
            this.lbSITCategories.TabIndex = 3;
            this.lbSITCategories.Text = "Categorías";
            this.lbSITCategories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSITCategories.UseAccent = true;
            // 
            // mcSITPayTypes
            // 
            this.mcSITPayTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSITPayTypes.Controls.Add(this.dgvSITPayTypes);
            this.mcSITPayTypes.Controls.Add(this.lbSITPayTypes);
            this.mcSITPayTypes.Depth = 0;
            this.mcSITPayTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcSITPayTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSITPayTypes.Location = new System.Drawing.Point(583, 8);
            this.mcSITPayTypes.Margin = new System.Windows.Forms.Padding(4, 6, 6, 6);
            this.mcSITPayTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSITPayTypes.Name = "mcSITPayTypes";
            this.mcSITPayTypes.Padding = new System.Windows.Forms.Padding(10);
            this.mcSITPayTypes.Size = new System.Drawing.Size(567, 606);
            this.mcSITPayTypes.TabIndex = 2;
            // 
            // dgvSITPayTypes
            // 
            this.dgvSITPayTypes.AddQuery = null;
            this.dgvSITPayTypes.ColumnCount = 1;
            this.dgvSITPayTypes.ControlButtonsWidth = 48F;
            this.dgvSITPayTypes.ControlsHeight = 34F;
            this.dgvSITPayTypes.CurrentPage = 1;
            this.dgvSITPayTypes.DeleteQuery = null;
            this.dgvSITPayTypes.Depth = 0;
            this.dgvSITPayTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSITPayTypes.Location = new System.Drawing.Point(10, 36);
            this.dgvSITPayTypes.ModifyQuery = null;
            this.dgvSITPayTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvSITPayTypes.Name = "dgvSITPayTypes";
            this.dgvSITPayTypes.OrderBy = "";
            this.dgvSITPayTypes.RowCount = 2;
            this.dgvSITPayTypes.Size = new System.Drawing.Size(547, 560);
            this.dgvSITPayTypes.SourceQuery = null;
            this.dgvSITPayTypes.TabIndex = 1;
            this.dgvSITPayTypes.TotalItemsQuery = null;
            // 
            // lbSITPayTypes
            // 
            this.lbSITPayTypes.Depth = 0;
            this.lbSITPayTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSITPayTypes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSITPayTypes.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbSITPayTypes.Location = new System.Drawing.Point(10, 10);
            this.lbSITPayTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSITPayTypes.Name = "lbSITPayTypes";
            this.lbSITPayTypes.Size = new System.Drawing.Size(547, 26);
            this.lbSITPayTypes.TabIndex = 3;
            this.lbSITPayTypes.Text = "Tipos de pago";
            this.lbSITPayTypes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSITPayTypes.UseAccent = true;
            // 
            // tpSAccount
            // 
            this.tpSAccount.BackColor = System.Drawing.Color.White;
            this.tpSAccount.Controls.Add(this.tlpSABack);
            this.tpSAccount.Location = new System.Drawing.Point(4, 40);
            this.tpSAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tpSAccount.Name = "tpSAccount";
            this.tpSAccount.Size = new System.Drawing.Size(184, 0);
            this.tpSAccount.TabIndex = 3;
            this.tpSAccount.Text = "Cuenta";
            // 
            // tlpSABack
            // 
            this.tlpSABack.ColumnCount = 1;
            this.tlpSABack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSABack.Controls.Add(this.tlpSAccount, 0, 0);
            this.tlpSABack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSABack.Location = new System.Drawing.Point(0, 0);
            this.tlpSABack.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSABack.Name = "tlpSABack";
            this.tlpSABack.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpSABack.RowCount = 1;
            this.tlpSABack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSABack.Size = new System.Drawing.Size(184, 0);
            this.tlpSABack.TabIndex = 0;
            // 
            // tlpSAccount
            // 
            this.tlpSAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpSAccount.ColumnCount = 2;
            this.tlpSAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpSAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpSAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSAccount.Controls.Add(this.mcSAData, 0, 0);
            this.tlpSAccount.Controls.Add(this.mcSARightPanel, 1, 0);
            this.tlpSAccount.Controls.Add(this.mcSAPass, 0, 1);
            this.tlpSAccount.Location = new System.Drawing.Point(2, 2);
            this.tlpSAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSAccount.Name = "tlpSAccount";
            this.tlpSAccount.RowCount = 2;
            this.tlpSAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tlpSAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tlpSAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSAccount.Size = new System.Drawing.Size(182, 1);
            this.tlpSAccount.TabIndex = 0;
            // 
            // mcSAData
            // 
            this.mcSAData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSAData.Controls.Add(this.tlpSAData);
            this.mcSAData.Depth = 0;
            this.mcSAData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcSAData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSAData.Location = new System.Drawing.Point(6, 6);
            this.mcSAData.Margin = new System.Windows.Forms.Padding(6, 6, 4, 4);
            this.mcSAData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSAData.Name = "mcSAData";
            this.mcSAData.Padding = new System.Windows.Forms.Padding(10);
            this.mcSAData.Size = new System.Drawing.Size(71, 305);
            this.mcSAData.TabIndex = 0;
            // 
            // tlpSAData
            // 
            this.tlpSAData.ColumnCount = 1;
            this.tlpSAData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSAData.Controls.Add(this.lbSAData, 0, 0);
            this.tlpSAData.Controls.Add(this.txSADNI, 0, 1);
            this.tlpSAData.Controls.Add(this.txSAName, 0, 2);
            this.tlpSAData.Controls.Add(this.txSALastName, 0, 3);
            this.tlpSAData.Controls.Add(this.txSAEmail, 0, 4);
            this.tlpSAData.Controls.Add(this.txSAPhone, 0, 5);
            this.tlpSAData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSAData.Location = new System.Drawing.Point(10, 10);
            this.tlpSAData.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSAData.Name = "tlpSAData";
            this.tlpSAData.RowCount = 6;
            this.tlpSAData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSAData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAData.Size = new System.Drawing.Size(51, 285);
            this.tlpSAData.TabIndex = 0;
            // 
            // lbSAData
            // 
            this.lbSAData.Depth = 0;
            this.lbSAData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSAData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSAData.Location = new System.Drawing.Point(0, 0);
            this.lbSAData.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbSAData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSAData.Name = "lbSAData";
            this.lbSAData.Size = new System.Drawing.Size(51, 20);
            this.lbSAData.TabIndex = 0;
            this.lbSAData.Text = "Modificar datos";
            this.lbSAData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txSADNI
            // 
            this.txSADNI.AnimateReadOnly = false;
            this.txSADNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSADNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSADNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSADNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSADNI.Depth = 0;
            this.txSADNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSADNI.ErrorState = false;
            this.txSADNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSADNI.HideSelection = true;
            this.txSADNI.Hint = "DNI";
            this.txSADNI.LeadingIcon = null;
            this.txSADNI.Location = new System.Drawing.Point(3, 28);
            this.txSADNI.MaxLength = 8;
            this.txSADNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txSADNI.Name = "txSADNI";
            this.txSADNI.PasswordChar = '\0';
            this.txSADNI.PrefixSuffixText = null;
            this.txSADNI.ReadOnly = false;
            this.txSADNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSADNI.SelectedText = "";
            this.txSADNI.SelectionLength = 0;
            this.txSADNI.SelectionStart = 0;
            this.txSADNI.ShortcutsEnabled = true;
            this.txSADNI.Size = new System.Drawing.Size(45, 48);
            this.txSADNI.TabIndex = 1;
            this.txSADNI.TabStop = false;
            this.txSADNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSADNI.TrailingIcon = null;
            this.txSADNI.UseSystemPasswordChar = false;
            this.txSADNI.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // txSAName
            // 
            this.txSAName.AnimateReadOnly = false;
            this.txSAName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSAName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSAName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSAName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSAName.Depth = 0;
            this.txSAName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSAName.ErrorState = false;
            this.txSAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSAName.HideSelection = true;
            this.txSAName.Hint = "Nombre";
            this.txSAName.LeadingIcon = null;
            this.txSAName.Location = new System.Drawing.Point(3, 80);
            this.txSAName.MaxLength = 32;
            this.txSAName.MouseState = MaterialSkin.MouseState.OUT;
            this.txSAName.Name = "txSAName";
            this.txSAName.PasswordChar = '\0';
            this.txSAName.PrefixSuffixText = null;
            this.txSAName.ReadOnly = false;
            this.txSAName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSAName.SelectedText = "";
            this.txSAName.SelectionLength = 0;
            this.txSAName.SelectionStart = 0;
            this.txSAName.ShortcutsEnabled = true;
            this.txSAName.Size = new System.Drawing.Size(45, 48);
            this.txSAName.TabIndex = 2;
            this.txSAName.TabStop = false;
            this.txSAName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSAName.TrailingIcon = null;
            this.txSAName.UseSystemPasswordChar = false;
            this.txSAName.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // txSALastName
            // 
            this.txSALastName.AnimateReadOnly = false;
            this.txSALastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSALastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSALastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSALastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSALastName.Depth = 0;
            this.txSALastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSALastName.ErrorState = false;
            this.txSALastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSALastName.HideSelection = true;
            this.txSALastName.Hint = "Apellido";
            this.txSALastName.LeadingIcon = null;
            this.txSALastName.Location = new System.Drawing.Point(3, 132);
            this.txSALastName.MaxLength = 32;
            this.txSALastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txSALastName.Name = "txSALastName";
            this.txSALastName.PasswordChar = '\0';
            this.txSALastName.PrefixSuffixText = null;
            this.txSALastName.ReadOnly = false;
            this.txSALastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSALastName.SelectedText = "";
            this.txSALastName.SelectionLength = 0;
            this.txSALastName.SelectionStart = 0;
            this.txSALastName.ShortcutsEnabled = true;
            this.txSALastName.Size = new System.Drawing.Size(45, 48);
            this.txSALastName.TabIndex = 3;
            this.txSALastName.TabStop = false;
            this.txSALastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSALastName.TrailingIcon = null;
            this.txSALastName.UseSystemPasswordChar = false;
            this.txSALastName.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // txSAEmail
            // 
            this.txSAEmail.AnimateReadOnly = false;
            this.txSAEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSAEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSAEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSAEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSAEmail.Depth = 0;
            this.txSAEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSAEmail.ErrorState = false;
            this.txSAEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSAEmail.HideSelection = true;
            this.txSAEmail.Hint = "Email";
            this.txSAEmail.LeadingIcon = null;
            this.txSAEmail.Location = new System.Drawing.Point(3, 184);
            this.txSAEmail.MaxLength = 320;
            this.txSAEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txSAEmail.Name = "txSAEmail";
            this.txSAEmail.PasswordChar = '\0';
            this.txSAEmail.PrefixSuffixText = null;
            this.txSAEmail.ReadOnly = false;
            this.txSAEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSAEmail.SelectedText = "";
            this.txSAEmail.SelectionLength = 0;
            this.txSAEmail.SelectionStart = 0;
            this.txSAEmail.ShortcutsEnabled = true;
            this.txSAEmail.Size = new System.Drawing.Size(45, 48);
            this.txSAEmail.TabIndex = 4;
            this.txSAEmail.TabStop = false;
            this.txSAEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSAEmail.TrailingIcon = null;
            this.txSAEmail.UseSystemPasswordChar = false;
            this.txSAEmail.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // txSAPhone
            // 
            this.txSAPhone.AllowPromptAsInput = true;
            this.txSAPhone.AnimateReadOnly = false;
            this.txSAPhone.AsciiOnly = false;
            this.txSAPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSAPhone.BeepOnError = false;
            this.txSAPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txSAPhone.Depth = 0;
            this.txSAPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSAPhone.ErrorState = false;
            this.txSAPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSAPhone.HidePromptOnLeave = false;
            this.txSAPhone.HideSelection = true;
            this.txSAPhone.Hint = "Teléfono";
            this.txSAPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txSAPhone.LeadingIcon = null;
            this.txSAPhone.Location = new System.Drawing.Point(3, 236);
            this.txSAPhone.Mask = "+00 000 000-0000";
            this.txSAPhone.MaxLength = 32767;
            this.txSAPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txSAPhone.Name = "txSAPhone";
            this.txSAPhone.PasswordChar = '\0';
            this.txSAPhone.PrefixSuffixText = null;
            this.txSAPhone.PromptChar = '_';
            this.txSAPhone.ReadOnly = false;
            this.txSAPhone.RejectInputOnFirstFailure = false;
            this.txSAPhone.ResetOnPrompt = true;
            this.txSAPhone.ResetOnSpace = false;
            this.txSAPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSAPhone.SelectedText = "";
            this.txSAPhone.SelectionLength = 0;
            this.txSAPhone.SelectionStart = 0;
            this.txSAPhone.ShortcutsEnabled = true;
            this.txSAPhone.Size = new System.Drawing.Size(45, 48);
            this.txSAPhone.SkipLiterals = true;
            this.txSAPhone.TabIndex = 5;
            this.txSAPhone.TabStop = false;
            this.txSAPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSAPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txSAPhone.TrailingIcon = null;
            this.txSAPhone.UseSystemPasswordChar = false;
            this.txSAPhone.ValidatingType = null;
            this.txSAPhone.Enter += new System.EventHandler(this.txSAPhone_Enter);
            this.txSAPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSAPhone_KeyPress);
            this.txSAPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txSAPhone_KeyUp);
            this.txSAPhone.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // mcSARightPanel
            // 
            this.mcSARightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSARightPanel.Controls.Add(this.tlpSARightPanel);
            this.mcSARightPanel.Depth = 0;
            this.mcSARightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcSARightPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSARightPanel.Location = new System.Drawing.Point(85, 6);
            this.mcSARightPanel.Margin = new System.Windows.Forms.Padding(4, 6, 6, 6);
            this.mcSARightPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSARightPanel.Name = "mcSARightPanel";
            this.mcSARightPanel.Padding = new System.Windows.Forms.Padding(4);
            this.tlpSAccount.SetRowSpan(this.mcSARightPanel, 2);
            this.mcSARightPanel.Size = new System.Drawing.Size(91, 462);
            this.mcSARightPanel.TabIndex = 0;
            // 
            // tlpSARightPanel
            // 
            this.tlpSARightPanel.ColumnCount = 2;
            this.tlpSARightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpSARightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpSARightPanel.Controls.Add(this.pnSAUpdate, 1, 2);
            this.tlpSARightPanel.Controls.Add(this.mcSADetails, 0, 0);
            this.tlpSARightPanel.Controls.Add(this.lbSAError, 0, 1);
            this.tlpSARightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSARightPanel.Location = new System.Drawing.Point(4, 4);
            this.tlpSARightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSARightPanel.Name = "tlpSARightPanel";
            this.tlpSARightPanel.RowCount = 3;
            this.tlpSARightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSARightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSARightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSARightPanel.Size = new System.Drawing.Size(83, 454);
            this.tlpSARightPanel.TabIndex = 0;
            // 
            // pnSAUpdate
            // 
            this.pnSAUpdate.Controls.Add(this.bnSAUpdate);
            this.pnSAUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSAUpdate.Location = new System.Drawing.Point(45, 402);
            this.pnSAUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.pnSAUpdate.Name = "pnSAUpdate";
            this.pnSAUpdate.Padding = new System.Windows.Forms.Padding(4, 6, 6, 6);
            this.pnSAUpdate.Size = new System.Drawing.Size(38, 52);
            this.pnSAUpdate.TabIndex = 0;
            this.pnSAUpdate.MouseEnter += new System.EventHandler(this.pnSAUpdate_MouseEnter);
            this.pnSAUpdate.MouseLeave += new System.EventHandler(this.pnSAUpdate_MouseLeave);
            // 
            // bnSAUpdate
            // 
            this.bnSAUpdate.AutoSize = false;
            this.bnSAUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnSAUpdate.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnSAUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSAUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnSAUpdate.Depth = 0;
            this.bnSAUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSAUpdate.HighEmphasis = true;
            this.bnSAUpdate.Icon = null;
            this.bnSAUpdate.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnSAUpdate.IconAndTextPadding = 4;
            this.bnSAUpdate.IconAutoSizePercentage = 20D;
            this.bnSAUpdate.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnSAUpdate.IconTransparency = 70D;
            this.bnSAUpdate.Location = new System.Drawing.Point(4, 6);
            this.bnSAUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.bnSAUpdate.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnSAUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnSAUpdate.Name = "bnSAUpdate";
            this.bnSAUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnSAUpdate.Size = new System.Drawing.Size(28, 40);
            this.bnSAUpdate.TabIndex = 10;
            this.bnSAUpdate.Text = "Modificar";
            this.bnSAUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnSAUpdate.UseAccentColor = false;
            this.bnSAUpdate.UseVisualStyleBackColor = true;
            this.bnSAUpdate.Click += new System.EventHandler(this.bnSAUpdate_Click);
            // 
            // mcSADetails
            // 
            this.mcSADetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mcSADetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpSARightPanel.SetColumnSpan(this.mcSADetails, 2);
            this.mcSADetails.Controls.Add(this.tlpSADetails);
            this.mcSADetails.Depth = 0;
            this.mcSADetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSADetails.Location = new System.Drawing.Point(6, 27);
            this.mcSADetails.Margin = new System.Windows.Forms.Padding(6);
            this.mcSADetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSADetails.Name = "mcSADetails";
            this.mcSADetails.Padding = new System.Windows.Forms.Padding(10);
            this.mcSADetails.Size = new System.Drawing.Size(71, 327);
            this.mcSADetails.TabIndex = 3;
            // 
            // tlpSADetails
            // 
            this.tlpSADetails.ColumnCount = 1;
            this.tlpSADetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSADetails.Controls.Add(this.lbSADetails, 0, 0);
            this.tlpSADetails.Controls.Add(this.txSADetails, 0, 1);
            this.tlpSADetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSADetails.Location = new System.Drawing.Point(10, 10);
            this.tlpSADetails.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSADetails.Name = "tlpSADetails";
            this.tlpSADetails.RowCount = 2;
            this.tlpSADetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSADetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSADetails.Size = new System.Drawing.Size(51, 307);
            this.tlpSADetails.TabIndex = 0;
            // 
            // lbSADetails
            // 
            this.lbSADetails.Depth = 0;
            this.lbSADetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSADetails.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSADetails.Location = new System.Drawing.Point(0, 0);
            this.lbSADetails.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbSADetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSADetails.Name = "lbSADetails";
            this.lbSADetails.Size = new System.Drawing.Size(51, 20);
            this.lbSADetails.TabIndex = 0;
            this.lbSADetails.Text = "Modificar detalles";
            this.lbSADetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txSADetails
            // 
            this.txSADetails.AnimateReadOnly = false;
            this.txSADetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSADetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSADetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txSADetails.Depth = 0;
            this.txSADetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSADetails.HideSelection = true;
            this.txSADetails.Hint = "Detalles";
            this.txSADetails.Location = new System.Drawing.Point(3, 28);
            this.txSADetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.txSADetails.MaxLength = 512;
            this.txSADetails.MouseState = MaterialSkin.MouseState.OUT;
            this.txSADetails.Name = "txSADetails";
            this.txSADetails.PasswordChar = '\0';
            this.txSADetails.ReadOnly = false;
            this.txSADetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txSADetails.SelectedText = "";
            this.txSADetails.SelectionLength = 0;
            this.txSADetails.SelectionStart = 0;
            this.txSADetails.ShortcutsEnabled = true;
            this.txSADetails.Size = new System.Drawing.Size(45, 279);
            this.txSADetails.TabIndex = 9;
            this.txSADetails.TabStop = false;
            this.txSADetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSADetails.UseSystemPasswordChar = false;
            this.txSADetails.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // lbSAError
            // 
            this.lbSAError.AutoSize = true;
            this.tlpSARightPanel.SetColumnSpan(this.lbSAError, 2);
            this.lbSAError.Depth = 0;
            this.lbSAError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSAError.ErrorState = true;
            this.lbSAError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSAError.Location = new System.Drawing.Point(0, 384);
            this.lbSAError.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lbSAError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSAError.Name = "lbSAError";
            this.lbSAError.Size = new System.Drawing.Size(83, 18);
            this.lbSAError.TabIndex = 0;
            this.lbSAError.Text = "Actualice algun valor";
            this.lbSAError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSAError.TextChanged += new System.EventHandler(this.lbSAError_TextChanged);
            // 
            // mcSAPass
            // 
            this.mcSAPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSAPass.Controls.Add(this.tlpSAPass);
            this.mcSAPass.Depth = 0;
            this.mcSAPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcSAPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSAPass.Location = new System.Drawing.Point(6, 319);
            this.mcSAPass.Margin = new System.Windows.Forms.Padding(6, 4, 4, 6);
            this.mcSAPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSAPass.Name = "mcSAPass";
            this.mcSAPass.Padding = new System.Windows.Forms.Padding(10);
            this.mcSAPass.Size = new System.Drawing.Size(71, 149);
            this.mcSAPass.TabIndex = 0;
            // 
            // tlpSAPass
            // 
            this.tlpSAPass.ColumnCount = 1;
            this.tlpSAPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSAPass.Controls.Add(this.lbSAPass, 0, 0);
            this.tlpSAPass.Controls.Add(this.txSAPass, 0, 1);
            this.tlpSAPass.Controls.Add(this.txSANewPass, 0, 2);
            this.tlpSAPass.Controls.Add(this.txSARepNewPass, 0, 3);
            this.tlpSAPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSAPass.Location = new System.Drawing.Point(10, 10);
            this.tlpSAPass.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSAPass.Name = "tlpSAPass";
            this.tlpSAPass.RowCount = 4;
            this.tlpSAPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSAPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAPass.Size = new System.Drawing.Size(51, 129);
            this.tlpSAPass.TabIndex = 0;
            // 
            // lbSAPass
            // 
            this.lbSAPass.Depth = 0;
            this.lbSAPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSAPass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSAPass.Location = new System.Drawing.Point(0, 0);
            this.lbSAPass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbSAPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSAPass.Name = "lbSAPass";
            this.lbSAPass.Size = new System.Drawing.Size(51, 20);
            this.lbSAPass.TabIndex = 0;
            this.lbSAPass.Text = "Modificar contraseña";
            this.lbSAPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txSAPass
            // 
            this.txSAPass.AnimateReadOnly = false;
            this.txSAPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSAPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSAPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSAPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSAPass.Depth = 0;
            this.txSAPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSAPass.ErrorState = false;
            this.txSAPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSAPass.HideSelection = true;
            this.txSAPass.Hint = "Contraseña actual";
            this.txSAPass.LeadingIcon = null;
            this.txSAPass.Location = new System.Drawing.Point(3, 28);
            this.txSAPass.MaxLength = 64;
            this.txSAPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txSAPass.Name = "txSAPass";
            this.txSAPass.PasswordChar = '●';
            this.txSAPass.PrefixSuffixText = null;
            this.txSAPass.ReadOnly = false;
            this.txSAPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSAPass.SelectedText = "";
            this.txSAPass.SelectionLength = 0;
            this.txSAPass.SelectionStart = 0;
            this.txSAPass.ShortcutsEnabled = true;
            this.txSAPass.Size = new System.Drawing.Size(45, 48);
            this.txSAPass.TabIndex = 6;
            this.txSAPass.TabStop = false;
            this.txSAPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSAPass.TrailingIcon = null;
            this.txSAPass.UseSystemPasswordChar = true;
            this.txSAPass.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // txSANewPass
            // 
            this.txSANewPass.AnimateReadOnly = false;
            this.txSANewPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSANewPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSANewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSANewPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSANewPass.Depth = 0;
            this.txSANewPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSANewPass.ErrorState = false;
            this.txSANewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSANewPass.HideSelection = true;
            this.txSANewPass.Hint = "Nueva contraseña";
            this.txSANewPass.LeadingIcon = null;
            this.txSANewPass.Location = new System.Drawing.Point(3, 80);
            this.txSANewPass.MaxLength = 64;
            this.txSANewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txSANewPass.Name = "txSANewPass";
            this.txSANewPass.PasswordChar = '●';
            this.txSANewPass.PrefixSuffixText = null;
            this.txSANewPass.ReadOnly = false;
            this.txSANewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSANewPass.SelectedText = "";
            this.txSANewPass.SelectionLength = 0;
            this.txSANewPass.SelectionStart = 0;
            this.txSANewPass.ShortcutsEnabled = true;
            this.txSANewPass.Size = new System.Drawing.Size(45, 48);
            this.txSANewPass.TabIndex = 7;
            this.txSANewPass.TabStop = false;
            this.txSANewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSANewPass.TrailingIcon = null;
            this.txSANewPass.UseSystemPasswordChar = true;
            this.txSANewPass.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // txSARepNewPass
            // 
            this.txSARepNewPass.AnimateReadOnly = false;
            this.txSARepNewPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSARepNewPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSARepNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSARepNewPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSARepNewPass.Depth = 0;
            this.txSARepNewPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSARepNewPass.ErrorState = false;
            this.txSARepNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSARepNewPass.HideSelection = true;
            this.txSARepNewPass.Hint = "Repita la contraseña";
            this.txSARepNewPass.LeadingIcon = null;
            this.txSARepNewPass.Location = new System.Drawing.Point(3, 132);
            this.txSARepNewPass.MaxLength = 64;
            this.txSARepNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txSARepNewPass.Name = "txSARepNewPass";
            this.txSARepNewPass.PasswordChar = '●';
            this.txSARepNewPass.PrefixSuffixText = null;
            this.txSARepNewPass.ReadOnly = false;
            this.txSARepNewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSARepNewPass.SelectedText = "";
            this.txSARepNewPass.SelectionLength = 0;
            this.txSARepNewPass.SelectionStart = 0;
            this.txSARepNewPass.ShortcutsEnabled = true;
            this.txSARepNewPass.Size = new System.Drawing.Size(45, 48);
            this.txSARepNewPass.TabIndex = 8;
            this.txSARepNewPass.TabStop = false;
            this.txSARepNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSARepNewPass.TrailingIcon = null;
            this.txSARepNewPass.UseSystemPasswordChar = true;
            this.txSARepNewPass.TextChanged += new System.EventHandler(this.CtrlsSettingsAccountValueChanged);
            // 
            // tpSShop
            // 
            this.tpSShop.BackColor = System.Drawing.Color.White;
            this.tpSShop.Controls.Add(this.tlpSSBack);
            this.tpSShop.Location = new System.Drawing.Point(4, 40);
            this.tpSShop.Margin = new System.Windows.Forms.Padding(0);
            this.tpSShop.Name = "tpSShop";
            this.tpSShop.Size = new System.Drawing.Size(184, 0);
            this.tpSShop.TabIndex = 4;
            this.tpSShop.Text = "Negocio";
            // 
            // tlpSSBack
            // 
            this.tlpSSBack.ColumnCount = 1;
            this.tlpSSBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSSBack.Controls.Add(this.mcSShop, 0, 0);
            this.tlpSSBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSSBack.Location = new System.Drawing.Point(0, 0);
            this.tlpSSBack.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSSBack.Name = "tlpSSBack";
            this.tlpSSBack.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpSSBack.RowCount = 1;
            this.tlpSSBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSSBack.Size = new System.Drawing.Size(184, 0);
            this.tlpSSBack.TabIndex = 0;
            // 
            // mcSShop
            // 
            this.mcSShop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcSShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSShop.Controls.Add(this.tlpSShop);
            this.mcSShop.Depth = 0;
            this.mcSShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSShop.Location = new System.Drawing.Point(8, 8);
            this.mcSShop.Margin = new System.Windows.Forms.Padding(6);
            this.mcSShop.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSShop.Name = "mcSShop";
            this.mcSShop.Padding = new System.Windows.Forms.Padding(10);
            this.mcSShop.Size = new System.Drawing.Size(170, 1);
            this.mcSShop.TabIndex = 0;
            // 
            // tlpSShop
            // 
            this.tlpSShop.ColumnCount = 2;
            this.tlpSShop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSShop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSShop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSShop.Controls.Add(this.lbSSTitle, 0, 0);
            this.tlpSShop.Controls.Add(this.txSSCategory, 0, 1);
            this.tlpSShop.Controls.Add(this.dgvSSHolidays, 0, 3);
            this.tlpSShop.Controls.Add(this.txSSWeekDays, 1, 1);
            this.tlpSShop.Controls.Add(this.lbSSHolidaysTitle, 0, 2);
            this.tlpSShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSShop.Location = new System.Drawing.Point(10, 10);
            this.tlpSShop.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSShop.Name = "tlpSShop";
            this.tlpSShop.RowCount = 4;
            this.tlpSShop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSShop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSShop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSShop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSShop.Size = new System.Drawing.Size(150, 0);
            this.tlpSShop.TabIndex = 0;
            // 
            // lbSSTitle
            // 
            this.lbSSTitle.AutoSize = true;
            this.tlpSShop.SetColumnSpan(this.lbSSTitle, 2);
            this.lbSSTitle.Depth = 0;
            this.lbSSTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSSTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbSSTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbSSTitle.Location = new System.Drawing.Point(0, 0);
            this.lbSSTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbSSTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSSTitle.Name = "lbSSTitle";
            this.lbSSTitle.Size = new System.Drawing.Size(150, 20);
            this.lbSSTitle.TabIndex = 0;
            this.lbSSTitle.Text = "Negocio ID 0";
            this.lbSSTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txSSCategory
            // 
            this.txSSCategory.AnimateReadOnly = false;
            this.txSSCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSSCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSSCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSSCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSSCategory.Depth = 0;
            this.txSSCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSSCategory.ErrorState = false;
            this.txSSCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSSCategory.HideSelection = true;
            this.txSSCategory.Hint = "Categoría";
            this.txSSCategory.LeadingIcon = null;
            this.txSSCategory.Location = new System.Drawing.Point(0, 28);
            this.txSSCategory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txSSCategory.MaxLength = 1;
            this.txSSCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.txSSCategory.Name = "txSSCategory";
            this.txSSCategory.PasswordChar = '\0';
            this.txSSCategory.PrefixSuffixText = null;
            this.txSSCategory.ReadOnly = false;
            this.txSSCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSSCategory.SelectedText = "";
            this.txSSCategory.SelectionLength = 0;
            this.txSSCategory.SelectionStart = 0;
            this.txSSCategory.ShortcutsEnabled = true;
            this.txSSCategory.Size = new System.Drawing.Size(72, 48);
            this.txSSCategory.TabIndex = 1;
            this.txSSCategory.TabStop = false;
            this.txSSCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSSCategory.TrailingIcon = null;
            this.txSSCategory.UseSystemPasswordChar = false;
            this.txSSCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSSCategory_KeyPress);
            this.txSSCategory.Leave += new System.EventHandler(this.CtrlsSettingsShopValueChanged);
            // 
            // dgvSSHolidays
            // 
            this.dgvSSHolidays.AddQuery = null;
            this.dgvSSHolidays.ColumnCount = 1;
            this.tlpSShop.SetColumnSpan(this.dgvSSHolidays, 2);
            this.dgvSSHolidays.ControlButtonsWidth = 48F;
            this.dgvSSHolidays.ControlsHeight = 34F;
            this.dgvSSHolidays.CurrentPage = 1;
            this.dgvSSHolidays.DeleteQuery = null;
            this.dgvSSHolidays.Depth = 0;
            this.dgvSSHolidays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSSHolidays.Location = new System.Drawing.Point(0, 102);
            this.dgvSSHolidays.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSSHolidays.ModifyQuery = null;
            this.dgvSSHolidays.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvSSHolidays.Name = "dgvSSHolidays";
            this.dgvSSHolidays.OrderBy = "";
            this.dgvSSHolidays.RowCount = 2;
            this.dgvSSHolidays.Size = new System.Drawing.Size(150, 1);
            this.dgvSSHolidays.SourceQuery = null;
            this.dgvSSHolidays.TabIndex = 3;
            this.dgvSSHolidays.TotalItemsQuery = null;
            // 
            // txSSWeekDays
            // 
            this.txSSWeekDays.AnimateReadOnly = false;
            this.txSSWeekDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txSSWeekDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txSSWeekDays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txSSWeekDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txSSWeekDays.Depth = 0;
            this.txSSWeekDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txSSWeekDays.ErrorState = false;
            this.txSSWeekDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSSWeekDays.HideSelection = true;
            this.txSSWeekDays.Hint = "Dias de trabajo a la semana";
            this.txSSWeekDays.LeadingIcon = null;
            this.txSSWeekDays.Location = new System.Drawing.Point(78, 28);
            this.txSSWeekDays.MaxLength = 1;
            this.txSSWeekDays.MouseState = MaterialSkin.MouseState.OUT;
            this.txSSWeekDays.Name = "txSSWeekDays";
            this.txSSWeekDays.PasswordChar = '\0';
            this.txSSWeekDays.PrefixSuffixText = null;
            this.txSSWeekDays.ReadOnly = false;
            this.txSSWeekDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txSSWeekDays.SelectedText = "";
            this.txSSWeekDays.SelectionLength = 0;
            this.txSSWeekDays.SelectionStart = 0;
            this.txSSWeekDays.ShortcutsEnabled = true;
            this.txSSWeekDays.Size = new System.Drawing.Size(69, 48);
            this.txSSWeekDays.TabIndex = 1;
            this.txSSWeekDays.TabStop = false;
            this.txSSWeekDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txSSWeekDays.TrailingIcon = null;
            this.txSSWeekDays.UseSystemPasswordChar = false;
            this.txSSWeekDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSSWeekDays_KeyPress);
            this.txSSWeekDays.Leave += new System.EventHandler(this.CtrlsSettingsShopValueChanged);
            // 
            // lbSSHolidaysTitle
            // 
            this.lbSSHolidaysTitle.AutoSize = true;
            this.tlpSShop.SetColumnSpan(this.lbSSHolidaysTitle, 2);
            this.lbSSHolidaysTitle.Depth = 0;
            this.lbSSHolidaysTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSSHolidaysTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSSHolidaysTitle.Location = new System.Drawing.Point(0, 82);
            this.lbSSHolidaysTitle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbSSHolidaysTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSSHolidaysTitle.Name = "lbSSHolidaysTitle";
            this.lbSSHolidaysTitle.Size = new System.Drawing.Size(150, 20);
            this.lbSSHolidaysTitle.TabIndex = 5;
            this.lbSSHolidaysTitle.Text = "Periodos de vacaciones:";
            this.lbSSHolidaysTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpSCustom
            // 
            this.tpSCustom.BackColor = System.Drawing.Color.White;
            this.tpSCustom.Controls.Add(this.tlpSCBack);
            this.tpSCustom.Location = new System.Drawing.Point(4, 40);
            this.tpSCustom.Margin = new System.Windows.Forms.Padding(0);
            this.tpSCustom.Name = "tpSCustom";
            this.tpSCustom.Size = new System.Drawing.Size(184, 0);
            this.tpSCustom.TabIndex = 2;
            this.tpSCustom.Text = "Personalización";
            // 
            // tlpSCBack
            // 
            this.tlpSCBack.ColumnCount = 1;
            this.tlpSCBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSCBack.Controls.Add(this.mcSCustom, 0, 0);
            this.tlpSCBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSCBack.Location = new System.Drawing.Point(0, 0);
            this.tlpSCBack.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSCBack.Name = "tlpSCBack";
            this.tlpSCBack.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpSCBack.RowCount = 1;
            this.tlpSCBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSCBack.Size = new System.Drawing.Size(184, 0);
            this.tlpSCBack.TabIndex = 2;
            // 
            // mcSCustom
            // 
            this.mcSCustom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcSCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSCustom.Controls.Add(this.tlpSCustom);
            this.mcSCustom.Depth = 0;
            this.mcSCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSCustom.Location = new System.Drawing.Point(8, 8);
            this.mcSCustom.Margin = new System.Windows.Forms.Padding(6);
            this.mcSCustom.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSCustom.Name = "mcSCustom";
            this.mcSCustom.Padding = new System.Windows.Forms.Padding(10);
            this.mcSCustom.Size = new System.Drawing.Size(170, 1);
            this.mcSCustom.TabIndex = 0;
            // 
            // tlpSCustom
            // 
            this.tlpSCustom.ColumnCount = 1;
            this.tlpSCustom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSCustom.Controls.Add(this.cbSCPrimary, 0, 1);
            this.tlpSCustom.Controls.Add(this.cbSCLight, 0, 2);
            this.tlpSCustom.Controls.Add(this.cbSCDark, 0, 3);
            this.tlpSCustom.Controls.Add(this.cbSCAccent, 0, 4);
            this.tlpSCustom.Controls.Add(this.cbSCTextShade, 0, 5);
            this.tlpSCustom.Controls.Add(this.cbSCTheme, 0, 0);
            this.tlpSCustom.Controls.Add(this.swSCSaveLastRect, 0, 6);
            this.tlpSCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSCustom.Location = new System.Drawing.Point(10, 10);
            this.tlpSCustom.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSCustom.Name = "tlpSCustom";
            this.tlpSCustom.RowCount = 7;
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSCustom.Size = new System.Drawing.Size(150, 0);
            this.tlpSCustom.TabIndex = 4;
            // 
            // cbSCPrimary
            // 
            this.cbSCPrimary.AutoResize = false;
            this.cbSCPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSCPrimary.Depth = 0;
            this.cbSCPrimary.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbSCPrimary.DisabledItems")));
            this.cbSCPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSCPrimary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSCPrimary.DropDownHeight = 170;
            this.cbSCPrimary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCPrimary.DropDownWidth = 121;
            this.cbSCPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSCPrimary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSCPrimary.FormattingEnabled = true;
            this.cbSCPrimary.Hint = "Color primario";
            this.cbSCPrimary.IntegralHeight = false;
            this.cbSCPrimary.ItemHeight = 42;
            this.cbSCPrimary.Location = new System.Drawing.Point(3, 55);
            this.cbSCPrimary.MaxDropDownItems = 4;
            this.cbSCPrimary.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSCPrimary.Name = "cbSCPrimary";
            this.cbSCPrimary.Size = new System.Drawing.Size(144, 48);
            this.cbSCPrimary.StartIndex = 0;
            this.cbSCPrimary.TabIndex = 3;
            this.cbSCPrimary.UseAccent = false;
            // 
            // cbSCLight
            // 
            this.cbSCLight.AutoResize = false;
            this.cbSCLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSCLight.Depth = 0;
            this.cbSCLight.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbSCLight.DisabledItems")));
            this.cbSCLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSCLight.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSCLight.DropDownHeight = 170;
            this.cbSCLight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCLight.DropDownWidth = 121;
            this.cbSCLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSCLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSCLight.FormattingEnabled = true;
            this.cbSCLight.Hint = "Color primario oscuro";
            this.cbSCLight.IntegralHeight = false;
            this.cbSCLight.ItemHeight = 42;
            this.cbSCLight.Location = new System.Drawing.Point(3, 107);
            this.cbSCLight.MaxDropDownItems = 4;
            this.cbSCLight.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSCLight.Name = "cbSCLight";
            this.cbSCLight.Size = new System.Drawing.Size(144, 48);
            this.cbSCLight.StartIndex = 0;
            this.cbSCLight.TabIndex = 3;
            this.cbSCLight.UseAccent = false;
            // 
            // cbSCDark
            // 
            this.cbSCDark.AutoResize = false;
            this.cbSCDark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSCDark.Depth = 0;
            this.cbSCDark.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbSCDark.DisabledItems")));
            this.cbSCDark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSCDark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSCDark.DropDownHeight = 170;
            this.cbSCDark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCDark.DropDownWidth = 121;
            this.cbSCDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSCDark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSCDark.FormattingEnabled = true;
            this.cbSCDark.Hint = "Color primario claro";
            this.cbSCDark.IntegralHeight = false;
            this.cbSCDark.ItemHeight = 42;
            this.cbSCDark.Location = new System.Drawing.Point(3, 159);
            this.cbSCDark.MaxDropDownItems = 4;
            this.cbSCDark.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSCDark.Name = "cbSCDark";
            this.cbSCDark.Size = new System.Drawing.Size(144, 48);
            this.cbSCDark.StartIndex = 0;
            this.cbSCDark.TabIndex = 3;
            this.cbSCDark.UseAccent = false;
            // 
            // cbSCAccent
            // 
            this.cbSCAccent.AutoResize = false;
            this.cbSCAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSCAccent.Depth = 0;
            this.cbSCAccent.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbSCAccent.DisabledItems")));
            this.cbSCAccent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSCAccent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSCAccent.DropDownHeight = 170;
            this.cbSCAccent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCAccent.DropDownWidth = 121;
            this.cbSCAccent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSCAccent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSCAccent.FormattingEnabled = true;
            this.cbSCAccent.Hint = "Color de acento";
            this.cbSCAccent.IntegralHeight = false;
            this.cbSCAccent.ItemHeight = 42;
            this.cbSCAccent.Location = new System.Drawing.Point(3, 211);
            this.cbSCAccent.MaxDropDownItems = 4;
            this.cbSCAccent.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSCAccent.Name = "cbSCAccent";
            this.cbSCAccent.Size = new System.Drawing.Size(144, 48);
            this.cbSCAccent.StartIndex = 0;
            this.cbSCAccent.TabIndex = 3;
            // 
            // cbSCTextShade
            // 
            this.cbSCTextShade.AutoResize = false;
            this.cbSCTextShade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSCTextShade.Depth = 0;
            this.cbSCTextShade.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbSCTextShade.DisabledItems")));
            this.cbSCTextShade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSCTextShade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSCTextShade.DropDownHeight = 170;
            this.cbSCTextShade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCTextShade.DropDownWidth = 121;
            this.cbSCTextShade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSCTextShade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSCTextShade.FormattingEnabled = true;
            this.cbSCTextShade.Hint = "Color del texto";
            this.cbSCTextShade.IntegralHeight = false;
            this.cbSCTextShade.ItemHeight = 42;
            this.cbSCTextShade.Location = new System.Drawing.Point(3, 263);
            this.cbSCTextShade.MaxDropDownItems = 4;
            this.cbSCTextShade.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSCTextShade.Name = "cbSCTextShade";
            this.cbSCTextShade.Size = new System.Drawing.Size(144, 48);
            this.cbSCTextShade.StartIndex = 0;
            this.cbSCTextShade.TabIndex = 3;
            // 
            // cbSCTheme
            // 
            this.cbSCTheme.AutoResize = false;
            this.cbSCTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSCTheme.Depth = 0;
            this.cbSCTheme.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbSCTheme.DisabledItems")));
            this.cbSCTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSCTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSCTheme.DropDownHeight = 170;
            this.cbSCTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCTheme.DropDownWidth = 121;
            this.cbSCTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSCTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSCTheme.FormattingEnabled = true;
            this.cbSCTheme.Hint = "Tema";
            this.cbSCTheme.IntegralHeight = false;
            this.cbSCTheme.ItemHeight = 42;
            this.cbSCTheme.Items.AddRange(new object[] {
            "Sistema",
            "Claro",
            "Oscuro"});
            this.cbSCTheme.Location = new System.Drawing.Point(3, 3);
            this.cbSCTheme.MaxDropDownItems = 4;
            this.cbSCTheme.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSCTheme.Name = "cbSCTheme";
            this.cbSCTheme.Size = new System.Drawing.Size(144, 48);
            this.cbSCTheme.StartIndex = 0;
            this.cbSCTheme.TabIndex = 4;
            // 
            // swSCSaveLastRect
            // 
            this.swSCSaveLastRect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.swSCSaveLastRect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swSCSaveLastRect.Depth = 0;
            this.swSCSaveLastRect.Location = new System.Drawing.Point(0, 326);
            this.swSCSaveLastRect.Margin = new System.Windows.Forms.Padding(0);
            this.swSCSaveLastRect.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swSCSaveLastRect.MouseState = MaterialSkin.MouseState.HOVER;
            this.swSCSaveLastRect.Name = "swSCSaveLastRect";
            this.swSCSaveLastRect.Ripple = true;
            this.swSCSaveLastRect.Size = new System.Drawing.Size(150, 24);
            this.swSCSaveLastRect.TabIndex = 5;
            this.swSCSaveLastRect.Text = "Guardar último tamaño de la App";
            this.swSCSaveLastRect.UseVisualStyleBackColor = true;
            this.swSCSaveLastRect.CheckedChanged += new System.EventHandler(this.CtrlsSettingsCustomValueChanged);
            // 
            // tpSAbout
            // 
            this.tpSAbout.BackColor = System.Drawing.Color.White;
            this.tpSAbout.Controls.Add(this.tlpSBBack);
            this.tpSAbout.Location = new System.Drawing.Point(4, 22);
            this.tpSAbout.Margin = new System.Windows.Forms.Padding(0);
            this.tpSAbout.Name = "tpSAbout";
            this.tpSAbout.Size = new System.Drawing.Size(1156, 620);
            this.tpSAbout.TabIndex = 5;
            this.tpSAbout.Text = "Acerca de";
            // 
            // tlpSBBack
            // 
            this.tlpSBBack.ColumnCount = 1;
            this.tlpSBBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSBBack.Controls.Add(this.mcSAbout, 0, 0);
            this.tlpSBBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSBBack.Location = new System.Drawing.Point(0, 0);
            this.tlpSBBack.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSBBack.Name = "tlpSBBack";
            this.tlpSBBack.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tlpSBBack.RowCount = 1;
            this.tlpSBBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSBBack.Size = new System.Drawing.Size(1156, 620);
            this.tlpSBBack.TabIndex = 0;
            // 
            // mcSAbout
            // 
            this.mcSAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcSAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSAbout.Controls.Add(this.tlpSAbout);
            this.mcSAbout.Depth = 0;
            this.mcSAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSAbout.Location = new System.Drawing.Point(269, 99);
            this.mcSAbout.Margin = new System.Windows.Forms.Padding(6);
            this.mcSAbout.MinimumSize = new System.Drawing.Size(620, 424);
            this.mcSAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSAbout.Name = "mcSAbout";
            this.mcSAbout.Padding = new System.Windows.Forms.Padding(10);
            this.mcSAbout.Size = new System.Drawing.Size(620, 424);
            this.mcSAbout.TabIndex = 0;
            // 
            // tlpSAbout
            // 
            this.tlpSAbout.ColumnCount = 3;
            this.tlpSAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpSAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpSAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpSAbout.Controls.Add(this.mdSB2, 0, 1);
            this.tlpSAbout.Controls.Add(this.lbSBTitle, 0, 0);
            this.tlpSAbout.Controls.Add(this.lbSBCopyright, 0, 8);
            this.tlpSAbout.Controls.Add(this.mdSB1, 0, 7);
            this.tlpSAbout.Controls.Add(this.bnSBWeb, 0, 6);
            this.tlpSAbout.Controls.Add(this.bnSBWhatsApp, 1, 6);
            this.tlpSAbout.Controls.Add(this.bnSBEmail, 2, 6);
            this.tlpSAbout.Controls.Add(this.mdSB3, 0, 4);
            this.tlpSAbout.Controls.Add(this.lbSBContact, 0, 5);
            this.tlpSAbout.Controls.Add(this.lbSBText, 0, 2);
            this.tlpSAbout.Controls.Add(this.bnSBOpen, 2, 3);
            this.tlpSAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSAbout.Location = new System.Drawing.Point(10, 10);
            this.tlpSAbout.Name = "tlpSAbout";
            this.tlpSAbout.RowCount = 9;
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpSAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpSAbout.Size = new System.Drawing.Size(600, 404);
            this.tlpSAbout.TabIndex = 0;
            // 
            // mdSB2
            // 
            this.mdSB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tlpSAbout.SetColumnSpan(this.mdSB2, 3);
            this.mdSB2.Depth = 0;
            this.mdSB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdSB2.Location = new System.Drawing.Point(0, 52);
            this.mdSB2.Margin = new System.Windows.Forms.Padding(0);
            this.mdSB2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdSB2.Name = "mdSB2";
            this.mdSB2.Size = new System.Drawing.Size(600, 1);
            this.mdSB2.TabIndex = 3;
            // 
            // lbSBTitle
            // 
            this.tlpSAbout.SetColumnSpan(this.lbSBTitle, 3);
            this.lbSBTitle.Depth = 0;
            this.lbSBTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSBTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbSBTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbSBTitle.Location = new System.Drawing.Point(0, 0);
            this.lbSBTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbSBTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSBTitle.Name = "lbSBTitle";
            this.lbSBTitle.Size = new System.Drawing.Size(600, 52);
            this.lbSBTitle.TabIndex = 0;
            this.lbSBTitle.Text = "Sistema de Administración de Facturas";
            this.lbSBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSBCopyright
            // 
            this.tlpSAbout.SetColumnSpan(this.lbSBCopyright, 3);
            this.lbSBCopyright.Depth = 0;
            this.lbSBCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSBCopyright.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSBCopyright.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lbSBCopyright.Location = new System.Drawing.Point(0, 386);
            this.lbSBCopyright.Margin = new System.Windows.Forms.Padding(0);
            this.lbSBCopyright.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSBCopyright.Name = "lbSBCopyright";
            this.lbSBCopyright.Size = new System.Drawing.Size(600, 18);
            this.lbSBCopyright.TabIndex = 1;
            this.lbSBCopyright.Text = "Copyright © 2023 ErmG LLC. All rights reserved.";
            this.lbSBCopyright.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mdSB1
            // 
            this.mdSB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tlpSAbout.SetColumnSpan(this.mdSB1, 3);
            this.mdSB1.Depth = 0;
            this.mdSB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdSB1.Location = new System.Drawing.Point(0, 385);
            this.mdSB1.Margin = new System.Windows.Forms.Padding(0);
            this.mdSB1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdSB1.Name = "mdSB1";
            this.mdSB1.Size = new System.Drawing.Size(600, 1);
            this.mdSB1.TabIndex = 2;
            // 
            // bnSBWeb
            // 
            this.bnSBWeb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnSBWeb.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnSBWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSBWeb.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnSBWeb.Depth = 0;
            this.bnSBWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSBWeb.HighEmphasis = false;
            this.bnSBWeb.Icon = global::SAF.Properties.Resources.Web32;
            this.bnSBWeb.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnSBWeb.IconAndTextPadding = 4;
            this.bnSBWeb.IconAutoSizePercentage = 20D;
            this.bnSBWeb.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.BackgroundBased;
            this.bnSBWeb.IconPadding = 36;
            this.bnSBWeb.IconTransparency = 80D;
            this.bnSBWeb.Location = new System.Drawing.Point(4, 339);
            this.bnSBWeb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnSBWeb.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnSBWeb.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnSBWeb.Name = "bnSBWeb";
            this.bnSBWeb.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnSBWeb.Size = new System.Drawing.Size(191, 40);
            this.bnSBWeb.TabIndex = 4;
            this.bnSBWeb.Text = "https://saf.ar";
            this.bnSBWeb.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnSBWeb.UseAccentColor = true;
            this.bnSBWeb.UseVisualStyleBackColor = true;
            this.bnSBWeb.Click += new System.EventHandler(this.bnSBWeb_Click);
            // 
            // bnSBWhatsApp
            // 
            this.bnSBWhatsApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnSBWhatsApp.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnSBWhatsApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSBWhatsApp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnSBWhatsApp.Depth = 0;
            this.bnSBWhatsApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSBWhatsApp.HighEmphasis = false;
            this.bnSBWhatsApp.Icon = global::SAF.Properties.Resources.WhatsApp32;
            this.bnSBWhatsApp.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnSBWhatsApp.IconAndTextPadding = 4;
            this.bnSBWhatsApp.IconAutoSizePercentage = 20D;
            this.bnSBWhatsApp.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.BackgroundBased;
            this.bnSBWhatsApp.IconPadding = 16;
            this.bnSBWhatsApp.IconTransparency = 80D;
            this.bnSBWhatsApp.Location = new System.Drawing.Point(203, 339);
            this.bnSBWhatsApp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnSBWhatsApp.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnSBWhatsApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnSBWhatsApp.Name = "bnSBWhatsApp";
            this.bnSBWhatsApp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnSBWhatsApp.Size = new System.Drawing.Size(192, 40);
            this.bnSBWhatsApp.TabIndex = 4;
            this.bnSBWhatsApp.Text = "+54 9 291 000-0000";
            this.bnSBWhatsApp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnSBWhatsApp.UseAccentColor = true;
            this.bnSBWhatsApp.UseVisualStyleBackColor = true;
            this.bnSBWhatsApp.Click += new System.EventHandler(this.bnSBWhatsApp_Click);
            // 
            // bnSBEmail
            // 
            this.bnSBEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnSBEmail.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnSBEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSBEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnSBEmail.Depth = 0;
            this.bnSBEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSBEmail.HighEmphasis = false;
            this.bnSBEmail.Icon = global::SAF.Properties.Resources.Email32;
            this.bnSBEmail.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnSBEmail.IconAndTextPadding = 4;
            this.bnSBEmail.IconAutoSizePercentage = 20D;
            this.bnSBEmail.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.BackgroundBased;
            this.bnSBEmail.IconPadding = 39;
            this.bnSBEmail.IconTransparency = 80D;
            this.bnSBEmail.Location = new System.Drawing.Point(403, 339);
            this.bnSBEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnSBEmail.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnSBEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnSBEmail.Name = "bnSBEmail";
            this.bnSBEmail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnSBEmail.Size = new System.Drawing.Size(193, 40);
            this.bnSBEmail.TabIndex = 4;
            this.bnSBEmail.Text = "help@saf.ar";
            this.bnSBEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnSBEmail.UseAccentColor = true;
            this.bnSBEmail.UseVisualStyleBackColor = true;
            this.bnSBEmail.Click += new System.EventHandler(this.bnSBEmail_Click);
            // 
            // mdSB3
            // 
            this.mdSB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tlpSAbout.SetColumnSpan(this.mdSB3, 3);
            this.mdSB3.Depth = 0;
            this.mdSB3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdSB3.Location = new System.Drawing.Point(0, 312);
            this.mdSB3.Margin = new System.Windows.Forms.Padding(0);
            this.mdSB3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdSB3.Name = "mdSB3";
            this.mdSB3.Size = new System.Drawing.Size(600, 1);
            this.mdSB3.TabIndex = 5;
            // 
            // lbSBContact
            // 
            this.tlpSAbout.SetColumnSpan(this.lbSBContact, 3);
            this.lbSBContact.Depth = 0;
            this.lbSBContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSBContact.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSBContact.Location = new System.Drawing.Point(3, 313);
            this.lbSBContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSBContact.Name = "lbSBContact";
            this.lbSBContact.Size = new System.Drawing.Size(594, 20);
            this.lbSBContact.TabIndex = 1;
            this.lbSBContact.Text = "Contactanos:";
            this.lbSBContact.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbSBText
            // 
            this.lbSBText.AutoSize = true;
            this.tlpSAbout.SetColumnSpan(this.lbSBText, 3);
            this.lbSBText.Depth = 0;
            this.lbSBText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSBText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSBText.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbSBText.Location = new System.Drawing.Point(3, 61);
            this.lbSBText.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbSBText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSBText.Name = "lbSBText";
            this.lbSBText.Size = new System.Drawing.Size(594, 199);
            this.lbSBText.TabIndex = 6;
            this.lbSBText.Text = resources.GetString("lbSBText.Text");
            // 
            // bnSBOpen
            // 
            this.bnSBOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bnSBOpen.AutoSize = false;
            this.bnSBOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnSBOpen.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnSBOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSBOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnSBOpen.Depth = 0;
            this.bnSBOpen.HighEmphasis = true;
            this.bnSBOpen.Icon = ((System.Drawing.Image)(resources.GetObject("bnSBOpen.Icon")));
            this.bnSBOpen.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnSBOpen.IconAndTextPadding = 3;
            this.bnSBOpen.IconAutoSizePercentage = 20D;
            this.bnSBOpen.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnSBOpen.IconPadding = 7;
            this.bnSBOpen.IconSize = 32;
            this.bnSBOpen.IconTransparency = 80D;
            this.bnSBOpen.Location = new System.Drawing.Point(429, 266);
            this.bnSBOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnSBOpen.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnSBOpen.MinimumSize = new System.Drawing.Size(140, 40);
            this.bnSBOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnSBOpen.Name = "bnSBOpen";
            this.bnSBOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnSBOpen.Size = new System.Drawing.Size(140, 40);
            this.bnSBOpen.TabIndex = 7;
            this.bnSBOpen.Text = "Abrir manual";
            this.bnSBOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnSBOpen.UseAccentColor = true;
            this.bnSBOpen.UseVisualStyleBackColor = true;
            this.bnSBOpen.Click += new System.EventHandler(this.OpenManual);
            // 
            // tsSettings
            // 
            this.tsSettings.BaseTabControl = this.tcSSettings;
            this.tsSettings.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tsSettings.Depth = 0;
            this.tsSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsSettings.FirstTabPadding = 30;
            this.tsSettings.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsSettings.Location = new System.Drawing.Point(0, 0);
            this.tsSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tsSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsSettings.Name = "tsSettings";
            this.tsSettings.Size = new System.Drawing.Size(1164, 40);
            this.tsSettings.TabIndex = 0;
            this.tsSettings.TabIndicatorHeight = 1;
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "Home24.png");
            this.Icons.Images.SetKeyName(1, "NewBill24.png");
            this.Icons.Images.SetKeyName(2, "Settings24.png");
            this.Icons.Images.SetKeyName(3, "Users24.png");
            this.Icons.Images.SetKeyName(4, "Bills24.png");
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 788);
            this.Controls.Add(this.tcMain);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 1;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tcMain;
            this.HelpButton = true;
            this.Icon = global::SAF.Properties.Resources.IconN;
            this.MinimumSize = new System.Drawing.Size(667, 371);
            this.Name = "fMain";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - SAF";
            this.Resize += new System.EventHandler(this.this_Resize);
            this.tcMain.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tlpHome.ResumeLayout(false);
            this.mcHBtns.ResumeLayout(false);
            this.tlpHBtns.ResumeLayout(false);
            this.tlpHBtns.PerformLayout();
            this.mcHAlerts.ResumeLayout(false);
            this.tcHAlerts.ResumeLayout(false);
            this.tpHAAlerts.ResumeLayout(false);
            this.mcHSession.ResumeLayout(false);
            this.tlpHSession.ResumeLayout(false);
            this.tlpHSession.PerformLayout();
            this.tpNewBill.ResumeLayout(false);
            this.tlpNewBill.ResumeLayout(false);
            this.mcNAdd.ResumeLayout(false);
            this.tlpNAdd.ResumeLayout(false);
            this.tlpNAdd.PerformLayout();
            this.tlpNAddInner.ResumeLayout(false);
            this.pnNAdd.ResumeLayout(false);
            this.mcNIc.ResumeLayout(false);
            this.pnNMPrice.ResumeLayout(false);
            this.mcBNC.ResumeLayout(false);
            this.tlpBNC.ResumeLayout(false);
            this.tlpBNC.PerformLayout();
            this.mcBDailyGoal.ResumeLayout(false);
            this.pnBDailyGoal.ResumeLayout(false);
            this.tpBills.ResumeLayout(false);
            this.tlpBills.ResumeLayout(false);
            this.mcBPayTypes.ResumeLayout(false);
            this.mcBStats.ResumeLayout(false);
            this.mcBIc.ResumeLayout(false);
            this.pnBSumP.ResumeLayout(false);
            this.mcBDgv.ResumeLayout(false);
            this.mcBSearch.ResumeLayout(false);
            this.tlpBSearch.ResumeLayout(false);
            this.pnBSearchCols.ResumeLayout(false);
            this.pnBDateArrow.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tlpUsers.ResumeLayout(false);
            this.mcUDgv.ResumeLayout(false);
            this.mcUStats.ResumeLayout(false);
            this.mcUSearch.ResumeLayout(false);
            this.tlpUSearch.ResumeLayout(false);
            this.pnUSearchCols.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tcSSettings.ResumeLayout(false);
            this.tpSInnerTables.ResumeLayout(false);
            this.tlpSInnerTables.ResumeLayout(false);
            this.mcSITCategories.ResumeLayout(false);
            this.mcSITPayTypes.ResumeLayout(false);
            this.tpSAccount.ResumeLayout(false);
            this.tlpSABack.ResumeLayout(false);
            this.tlpSAccount.ResumeLayout(false);
            this.mcSAData.ResumeLayout(false);
            this.tlpSAData.ResumeLayout(false);
            this.mcSARightPanel.ResumeLayout(false);
            this.tlpSARightPanel.ResumeLayout(false);
            this.tlpSARightPanel.PerformLayout();
            this.pnSAUpdate.ResumeLayout(false);
            this.mcSADetails.ResumeLayout(false);
            this.tlpSADetails.ResumeLayout(false);
            this.mcSAPass.ResumeLayout(false);
            this.tlpSAPass.ResumeLayout(false);
            this.tpSShop.ResumeLayout(false);
            this.tlpSSBack.ResumeLayout(false);
            this.mcSShop.ResumeLayout(false);
            this.tlpSShop.ResumeLayout(false);
            this.tlpSShop.PerformLayout();
            this.tpSCustom.ResumeLayout(false);
            this.tlpSCBack.ResumeLayout(false);
            this.mcSCustom.ResumeLayout(false);
            this.tlpSCustom.ResumeLayout(false);
            this.tpSAbout.ResumeLayout(false);
            this.tlpSBBack.ResumeLayout(false);
            this.mcSAbout.ResumeLayout(false);
            this.tlpSAbout.ResumeLayout(false);
            this.tlpSAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpNewBill;
        private System.Windows.Forms.TabPage tpBills;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TableLayoutPanel tlpBills;
        private MaterialSkin.Controls.MaterialCard mcBStats;
        private MaterialSkin.Controls.MaterialCard mcBIc;
        private MaterialSkin.Controls.MaterialCard mcBSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txBSearch;
        private CustomControls.CustomDTP dtpBEndDate;
        private CustomControls.CustomDTP dtpBStartDate;
        private System.Windows.Forms.TableLayoutPanel tlpNewBill;
        private MaterialSkin.Controls.MaterialCard mcNAdd;
        private MaterialSkin.Controls.MaterialCard mcNIc;
        private MaterialSkin.Controls.MaterialTextBox2 txNPrice;
        private MaterialSkin.Controls.MaterialComboBox cbNPayType;
        private System.Windows.Forms.TableLayoutPanel tlpHome;
        private MaterialSkin.Controls.MaterialCard mcHBtns;
        private System.Windows.Forms.TableLayoutPanel tlpHBtns;
        private MaterialSkin.Controls.MaterialButton bnHSettings;
        private MaterialSkin.Controls.MaterialButton bnHNewBill;
        private MaterialSkin.Controls.MaterialButton bnHBills;
        private MaterialSkin.Controls.MaterialButton bnHUsers;
        private MaterialSkin.Controls.MaterialCard mcHAlerts;
        private MaterialSkin.Controls.MaterialTabControl tcHAlerts;
        private System.Windows.Forms.TabPage tpHAAlerts;
        private MaterialSkin.Controls.MaterialListBox lsHAAlerts;
        private MaterialSkin.Controls.MaterialTabSelector tsHAlerts;
        private MaterialSkin.Controls.MaterialCard mcHSession;
        private MaterialSkin.Controls.MaterialButton bnNAdd;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txNDesc;
        private System.Windows.Forms.TabPage tpUsers;
        private CustomControls.CustomTLP tlpNAdd;
        private CustomControls.CustomTLP tlpNAddInner;
        private MaterialSkin.Controls.MaterialSwitch swNAInner;
        private MaterialSkin.Controls.MaterialTextBox2 txNBillID;
        private CustomControls.CustomDTP dtpNDate;
        private CustomControls.CustomTLP tlpBSearch;
        private System.Windows.Forms.Panel pnBSearchCols;
        private MaterialSkin.Controls.MaterialComboBox cbBSearchCols;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.Panel pnBDateArrow;
        private MaterialSkin.Controls.MaterialComboBox cbNDNI;
        private System.Windows.Forms.TableLayoutPanel tlpUsers;
        private MaterialSkin.Controls.MaterialCard mcUDgv;
        private CustomControls.CustomExDGV dgvUsers;
        private MaterialSkin.Controls.MaterialCard mcUStats;
        private MaterialSkin.Controls.MaterialCard mcUSearch;
        private CustomControls.CustomTLP tlpUSearch;
        private System.Windows.Forms.Panel pnUSearchCols;
        private MaterialSkin.Controls.MaterialComboBox cbUSearchCols;
        private MaterialSkin.Controls.MaterialTabSelector tsSettings;
        private MaterialSkin.Controls.MaterialTabControl tcSSettings;
        private System.Windows.Forms.TabPage tpSInnerTables;
        private System.Windows.Forms.TabPage tpSCustom;
        private MaterialSkin.Controls.MaterialLabel lbBTPriceTitle;
        private MaterialSkin.Controls.MaterialLabel lbBTPrice;
        private LiveCharts.WinForms.CartesianChart chtBPrices;
        private CustomControls.CustomExDGV dgvSITCategories;
        private MaterialSkin.Controls.MaterialCard mcSITCategories;
        private System.Windows.Forms.TableLayoutPanel tlpSInnerTables;
        private MaterialSkin.Controls.MaterialCard mcSITPayTypes;
        private CustomControls.CustomExDGV dgvSITPayTypes;
        private MaterialSkin.Controls.MaterialLabel lbSITCategories;
        private MaterialSkin.Controls.MaterialLabel lbSITPayTypes;
        private System.Windows.Forms.Panel pnBSumP;
        private MaterialSkin.Controls.MaterialLabel lbBSumPTitle;
        private MaterialSkin.Controls.MaterialButton bnBPrevMonth;
        private MaterialSkin.Controls.MaterialButton bnBNextMonth;
        private MaterialSkin.Controls.MaterialCard mcBDgv;
        private CustomControls.CustomExDGV dgvBills;
        private MaterialSkin.Controls.MaterialCard mcBNC;
        private System.Windows.Forms.TableLayoutPanel tlpBNC;
        private LiveCharts.WinForms.SolidGauge chtBNC;
        private MaterialSkin.Controls.MaterialLabel lbBNCFrom;
        private MaterialSkin.Controls.MaterialLabel lbBNCTo;
        private MaterialSkin.Controls.MaterialLabel lbBNCValue;
        private MaterialSkin.Controls.MaterialLabel lbBNCTitle;
        private MaterialSkin.Controls.MaterialCard mcBPayTypes;
        private LiveCharts.WinForms.PieChart chtBPayTypes;
        private MaterialSkin.Controls.MaterialLabel lbBPayTypesTitle;
        private MaterialSkin.Controls.MaterialCard mcBDailyGoal;
        private MaterialSkin.Controls.MaterialLabel lbNMPriceTitle;
        private MaterialSkin.Controls.MaterialLabel lbNMPrice;
        private System.Windows.Forms.Panel pnNAdd;
        private MaterialSkin.Controls.MaterialLabel lbNError;
        private MaterialSkin.Controls.MaterialProgressBar pbBDailyGoal;
        private System.Windows.Forms.Panel pnNMPrice;
        private System.Windows.Forms.Panel pnBDailyGoal;
        private MaterialSkin.Controls.MaterialLabel lbBDailyGoalPrice;
        private MaterialSkin.Controls.MaterialLabel lbBDailyGoalTitle;
        private MaterialSkin.Controls.MaterialLabel lbBDailyGoalPercent;
        private System.Windows.Forms.TabPage tpSAccount;
        private System.Windows.Forms.TableLayoutPanel tlpSABack;
        private System.Windows.Forms.TableLayoutPanel tlpSAccount;
        private MaterialSkin.Controls.MaterialCard mcSAData;
        private System.Windows.Forms.TableLayoutPanel tlpSAData;
        private MaterialSkin.Controls.MaterialLabel lbSAData;
        private MaterialSkin.Controls.MaterialTextBox2 txSADNI;
        private MaterialSkin.Controls.MaterialTextBox2 txSAName;
        private MaterialSkin.Controls.MaterialTextBox2 txSALastName;
        private MaterialSkin.Controls.MaterialTextBox2 txSAEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txSAPhone;
        private MaterialSkin.Controls.MaterialCard mcSARightPanel;
        private System.Windows.Forms.TableLayoutPanel tlpSARightPanel;
        private System.Windows.Forms.Panel pnSAUpdate;
        private MaterialSkin.Controls.MaterialButton bnSAUpdate;
        private MaterialSkin.Controls.MaterialCard mcSADetails;
        private System.Windows.Forms.TableLayoutPanel tlpSADetails;
        private MaterialSkin.Controls.MaterialLabel lbSADetails;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txSADetails;
        private MaterialSkin.Controls.MaterialLabel lbSAError;
        private MaterialSkin.Controls.MaterialCard mcSAPass;
        private System.Windows.Forms.TableLayoutPanel tlpSAPass;
        private MaterialSkin.Controls.MaterialLabel lbSAPass;
        private MaterialSkin.Controls.MaterialTextBox2 txSAPass;
        private MaterialSkin.Controls.MaterialTextBox2 txSANewPass;
        private MaterialSkin.Controls.MaterialTextBox2 txSARepNewPass;
        private System.Windows.Forms.TabPage tpSShop;
        private System.Windows.Forms.TableLayoutPanel tlpSSBack;
        private MaterialSkin.Controls.MaterialCard mcSShop;
        private System.Windows.Forms.TableLayoutPanel tlpSShop;
        private MaterialSkin.Controls.MaterialLabel lbSSTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txSSCategory;
        private MaterialSkin.Controls.MaterialTextBox2 txSSWeekDays;
        private CustomControls.CustomExDGV dgvSSHolidays;
        private MaterialSkin.Controls.MaterialLabel lbSSHolidaysTitle;
        private CustomControls.CustomExDGV dgvUsersLogIns;
        private System.Windows.Forms.TableLayoutPanel tlpHSession;
        private MaterialSkin.Controls.MaterialButton bnHSLogOut;
        private MaterialSkin.Controls.MaterialButton bnHSSettings;
        private MaterialSkin.Controls.MaterialButton bnHSession;
        private MaterialSkin.Controls.MaterialLabel lbHSession;
        private System.Windows.Forms.TableLayoutPanel tlpSCBack;
        private MaterialSkin.Controls.MaterialCard mcSCustom;
        private MaterialSkin.Controls.MaterialComboBox cbSCPrimary;
        private System.Windows.Forms.TableLayoutPanel tlpSCustom;
        private MaterialSkin.Controls.MaterialComboBox cbSCLight;
        private MaterialSkin.Controls.MaterialComboBox cbSCDark;
        private MaterialSkin.Controls.MaterialComboBox cbSCAccent;
        private MaterialSkin.Controls.MaterialComboBox cbSCTextShade;
        private MaterialSkin.Controls.MaterialTextBox2 txUSearch;
        private MaterialSkin.Controls.MaterialComboBox cbSCTheme;
        private MaterialSkin.Controls.MaterialSwitch swSCSaveLastRect;
        private System.Windows.Forms.TabPage tpSAbout;
        private System.Windows.Forms.TableLayoutPanel tlpSBBack;
        private MaterialSkin.Controls.MaterialCard mcSAbout;
        private System.Windows.Forms.TableLayoutPanel tlpSAbout;
        private MaterialSkin.Controls.MaterialLabel lbSBTitle;
        private MaterialSkin.Controls.MaterialDivider mdSB1;
        private MaterialSkin.Controls.MaterialLabel lbSBCopyright;
        private MaterialSkin.Controls.MaterialDivider mdSB2;
        private MaterialSkin.Controls.MaterialButton bnSBWeb;
        private MaterialSkin.Controls.MaterialButton bnSBWhatsApp;
        private MaterialSkin.Controls.MaterialButton bnSBEmail;
        private MaterialSkin.Controls.MaterialDivider mdSB3;
        private MaterialSkin.Controls.MaterialLabel lbSBContact;
        private MaterialSkin.Controls.MaterialLabel lbSBText;
        private MaterialSkin.Controls.MaterialButton bnSBOpen;
    }
}

