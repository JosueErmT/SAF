namespace SAF.Vista {
    partial class fSignUp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSignUp));
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.mcMain = new MaterialSkin.Controls.MaterialCard();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.txDNI = new MaterialSkin.Controls.MaterialTextBox2();
            this.txEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txRepPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.txPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.txDetails = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cbType = new MaterialSkin.Controls.MaterialComboBox();
            this.bnClose = new MaterialSkin.Controls.MaterialButton();
            this.lbError = new MaterialSkin.Controls.MaterialLabel();
            this.pnSignUp = new System.Windows.Forms.Panel();
            this.bnSignUp = new MaterialSkin.Controls.MaterialButton();
            this.txPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.mcMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Depth = 0;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(1, 1);
            this.tcMain.Margin = new System.Windows.Forms.Padding(0);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(530, 552);
            this.tcMain.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.White;
            this.tpMain.Controls.Add(this.mcMain);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(20);
            this.tpMain.Size = new System.Drawing.Size(522, 526);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "tpMain";
            // 
            // mcMain
            // 
            this.mcMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcMain.Controls.Add(this.tlpMain);
            this.mcMain.Depth = 0;
            this.mcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcMain.Location = new System.Drawing.Point(20, 20);
            this.mcMain.Margin = new System.Windows.Forms.Padding(0);
            this.mcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcMain.Name = "mcMain";
            this.mcMain.Padding = new System.Windows.Forms.Padding(10, 14, 10, 10);
            this.mcMain.Size = new System.Drawing.Size(482, 486);
            this.mcMain.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.txDNI, 0, 0);
            this.tlpMain.Controls.Add(this.txEmail, 0, 2);
            this.tlpMain.Controls.Add(this.txLastName, 1, 1);
            this.tlpMain.Controls.Add(this.txName, 0, 1);
            this.tlpMain.Controls.Add(this.txRepPass, 0, 4);
            this.tlpMain.Controls.Add(this.txPass, 0, 3);
            this.tlpMain.Controls.Add(this.txDetails, 0, 5);
            this.tlpMain.Controls.Add(this.cbType, 1, 0);
            this.tlpMain.Controls.Add(this.bnClose, 0, 7);
            this.tlpMain.Controls.Add(this.lbError, 0, 6);
            this.tlpMain.Controls.Add(this.pnSignUp, 1, 7);
            this.tlpMain.Controls.Add(this.txPhone, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(10, 14);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.Size = new System.Drawing.Size(462, 462);
            this.tlpMain.TabIndex = 0;
            // 
            // txDNI
            // 
            this.txDNI.AnimateReadOnly = false;
            this.txDNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txDNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txDNI.Depth = 0;
            this.txDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txDNI.ErrorState = false;
            this.txDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDNI.HideSelection = true;
            this.txDNI.Hint = "DNI";
            this.txDNI.LeadingIcon = null;
            this.txDNI.Location = new System.Drawing.Point(8, 3);
            this.txDNI.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.txDNI.MaxLength = 8;
            this.txDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txDNI.Name = "txDNI";
            this.txDNI.PasswordChar = '\0';
            this.txDNI.PrefixSuffixText = null;
            this.txDNI.ReadOnly = false;
            this.txDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txDNI.SelectedText = "";
            this.txDNI.SelectionLength = 0;
            this.txDNI.SelectionStart = 0;
            this.txDNI.ShortcutsEnabled = true;
            this.txDNI.Size = new System.Drawing.Size(219, 48);
            this.txDNI.TabIndex = 1;
            this.txDNI.TabStop = false;
            this.txDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDNI.TrailingIcon = null;
            this.txDNI.UseSystemPasswordChar = false;
            this.txDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDNI_KeyPress);
            this.txDNI.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // txEmail
            // 
            this.txEmail.AnimateReadOnly = false;
            this.txEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txEmail.Depth = 0;
            this.txEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txEmail.ErrorState = false;
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txEmail.HideSelection = true;
            this.txEmail.Hint = "Email";
            this.txEmail.LeadingIcon = null;
            this.txEmail.Location = new System.Drawing.Point(8, 107);
            this.txEmail.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.txEmail.MaxLength = 320;
            this.txEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txEmail.Name = "txEmail";
            this.txEmail.PasswordChar = '\0';
            this.txEmail.PrefixSuffixText = null;
            this.txEmail.ReadOnly = false;
            this.txEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txEmail.SelectedText = "";
            this.txEmail.SelectionLength = 0;
            this.txEmail.SelectionStart = 0;
            this.txEmail.ShortcutsEnabled = true;
            this.txEmail.Size = new System.Drawing.Size(219, 48);
            this.txEmail.TabIndex = 5;
            this.txEmail.TabStop = false;
            this.txEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txEmail.TrailingIcon = null;
            this.txEmail.UseSystemPasswordChar = false;
            this.txEmail.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // txLastName
            // 
            this.txLastName.AnimateReadOnly = false;
            this.txLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txLastName.Depth = 0;
            this.txLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txLastName.ErrorState = false;
            this.txLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txLastName.HideSelection = true;
            this.txLastName.Hint = "Apellido";
            this.txLastName.LeadingIcon = null;
            this.txLastName.Location = new System.Drawing.Point(235, 55);
            this.txLastName.Margin = new System.Windows.Forms.Padding(4, 3, 8, 3);
            this.txLastName.MaxLength = 32;
            this.txLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txLastName.Name = "txLastName";
            this.txLastName.PasswordChar = '\0';
            this.txLastName.PrefixSuffixText = null;
            this.txLastName.ReadOnly = false;
            this.txLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txLastName.SelectedText = "";
            this.txLastName.SelectionLength = 0;
            this.txLastName.SelectionStart = 0;
            this.txLastName.ShortcutsEnabled = true;
            this.txLastName.Size = new System.Drawing.Size(219, 48);
            this.txLastName.TabIndex = 4;
            this.txLastName.TabStop = false;
            this.txLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txLastName.TrailingIcon = null;
            this.txLastName.UseSystemPasswordChar = false;
            // 
            // txName
            // 
            this.txName.AnimateReadOnly = false;
            this.txName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txName.Depth = 0;
            this.txName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txName.ErrorState = false;
            this.txName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txName.HideSelection = true;
            this.txName.Hint = "Nombre";
            this.txName.LeadingIcon = null;
            this.txName.Location = new System.Drawing.Point(8, 55);
            this.txName.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.txName.MaxLength = 32;
            this.txName.MouseState = MaterialSkin.MouseState.OUT;
            this.txName.Name = "txName";
            this.txName.PasswordChar = '\0';
            this.txName.PrefixSuffixText = null;
            this.txName.ReadOnly = false;
            this.txName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txName.SelectedText = "";
            this.txName.SelectionLength = 0;
            this.txName.SelectionStart = 0;
            this.txName.ShortcutsEnabled = true;
            this.txName.Size = new System.Drawing.Size(219, 48);
            this.txName.TabIndex = 3;
            this.txName.TabStop = false;
            this.txName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txName.TrailingIcon = null;
            this.txName.UseSystemPasswordChar = false;
            // 
            // txRepPass
            // 
            this.txRepPass.AnimateReadOnly = false;
            this.txRepPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txRepPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txRepPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txRepPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpMain.SetColumnSpan(this.txRepPass, 2);
            this.txRepPass.Depth = 0;
            this.txRepPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txRepPass.ErrorState = false;
            this.txRepPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txRepPass.HideSelection = true;
            this.txRepPass.Hint = "Repita la contraseña";
            this.txRepPass.LeadingIcon = null;
            this.txRepPass.Location = new System.Drawing.Point(8, 211);
            this.txRepPass.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txRepPass.MaxLength = 64;
            this.txRepPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txRepPass.Name = "txRepPass";
            this.txRepPass.PasswordChar = '●';
            this.txRepPass.PrefixSuffixText = null;
            this.txRepPass.ReadOnly = false;
            this.txRepPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txRepPass.SelectedText = "";
            this.txRepPass.SelectionLength = 0;
            this.txRepPass.SelectionStart = 0;
            this.txRepPass.ShortcutsEnabled = true;
            this.txRepPass.Size = new System.Drawing.Size(446, 48);
            this.txRepPass.TabIndex = 8;
            this.txRepPass.TabStop = false;
            this.txRepPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txRepPass.TrailingIcon = null;
            this.txRepPass.UseSystemPasswordChar = true;
            this.txRepPass.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // txPass
            // 
            this.txPass.AnimateReadOnly = false;
            this.txPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpMain.SetColumnSpan(this.txPass, 2);
            this.txPass.Depth = 0;
            this.txPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPass.ErrorState = false;
            this.txPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txPass.HideSelection = true;
            this.txPass.Hint = "Contraseña";
            this.txPass.LeadingIcon = null;
            this.txPass.Location = new System.Drawing.Point(8, 159);
            this.txPass.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txPass.MaxLength = 64;
            this.txPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '●';
            this.txPass.PrefixSuffixText = null;
            this.txPass.ReadOnly = false;
            this.txPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txPass.SelectedText = "";
            this.txPass.SelectionLength = 0;
            this.txPass.SelectionStart = 0;
            this.txPass.ShortcutsEnabled = true;
            this.txPass.Size = new System.Drawing.Size(446, 48);
            this.txPass.TabIndex = 7;
            this.txPass.TabStop = false;
            this.txPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPass.TrailingIcon = null;
            this.txPass.UseSystemPasswordChar = true;
            this.txPass.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // txDetails
            // 
            this.txDetails.AnimateReadOnly = false;
            this.txDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpMain.SetColumnSpan(this.txDetails, 2);
            this.txDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txDetails.Depth = 0;
            this.txDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txDetails.HideSelection = true;
            this.txDetails.Hint = "Detalles";
            this.txDetails.Location = new System.Drawing.Point(8, 263);
            this.txDetails.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txDetails.MaxLength = 512;
            this.txDetails.MouseState = MaterialSkin.MouseState.OUT;
            this.txDetails.Name = "txDetails";
            this.txDetails.PasswordChar = '\0';
            this.txDetails.ReadOnly = false;
            this.txDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDetails.SelectedText = "";
            this.txDetails.SelectionLength = 0;
            this.txDetails.SelectionStart = 0;
            this.txDetails.ShortcutsEnabled = true;
            this.txDetails.Size = new System.Drawing.Size(446, 124);
            this.txDetails.TabIndex = 9;
            this.txDetails.TabStop = false;
            this.txDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDetails.UseSystemPasswordChar = false;
            // 
            // cbType
            // 
            this.cbType.AutoResize = false;
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbType.Depth = 0;
            this.cbType.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbType.DisabledItems")));
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbType.DropDownHeight = 170;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.DropDownWidth = 121;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.FormattingEnabled = true;
            this.cbType.Hint = "Tipo de usuario";
            this.cbType.IntegralHeight = false;
            this.cbType.ItemHeight = 42;
            this.cbType.Location = new System.Drawing.Point(235, 3);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 3, 8, 3);
            this.cbType.MaxDropDownItems = 4;
            this.cbType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(219, 48);
            this.cbType.StartIndex = 0;
            this.cbType.TabIndex = 2;
            // 
            // bnClose
            // 
            this.bnClose.AutoSize = false;
            this.bnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnClose.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnClose.Depth = 0;
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnClose.HighEmphasis = false;
            this.bnClose.Icon = null;
            this.bnClose.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnClose.IconAndTextPadding = 4;
            this.bnClose.IconAutoSizePercentage = 20D;
            this.bnClose.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnClose.IconTransparency = 70D;
            this.bnClose.Location = new System.Drawing.Point(8, 416);
            this.bnClose.Margin = new System.Windows.Forms.Padding(8, 6, 4, 6);
            this.bnClose.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnClose.Name = "bnClose";
            this.bnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnClose.Size = new System.Drawing.Size(219, 40);
            this.bnClose.TabIndex = 10;
            this.bnClose.Text = "Cancelar";
            this.bnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnClose.UseAccentColor = false;
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lbError, 2);
            this.lbError.Depth = 0;
            this.lbError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbError.ErrorState = true;
            this.lbError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbError.Location = new System.Drawing.Point(0, 392);
            this.lbError.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lbError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(462, 18);
            this.lbError.TabIndex = 0;
            this.lbError.Text = "DNI incompleto";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbError.Visible = false;
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            // 
            // pnSignUp
            // 
            this.pnSignUp.Controls.Add(this.bnSignUp);
            this.pnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSignUp.Location = new System.Drawing.Point(231, 410);
            this.pnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.pnSignUp.Name = "pnSignUp";
            this.pnSignUp.Padding = new System.Windows.Forms.Padding(4, 6, 8, 6);
            this.pnSignUp.Size = new System.Drawing.Size(231, 52);
            this.pnSignUp.TabIndex = 14;
            this.pnSignUp.MouseEnter += new System.EventHandler(this.pnSignUp_MouseEnter);
            this.pnSignUp.MouseLeave += new System.EventHandler(this.pnSignUp_MouseLeave);
            // 
            // bnSignUp
            // 
            this.bnSignUp.AutoSize = false;
            this.bnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnSignUp.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnSignUp.Depth = 0;
            this.bnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSignUp.Enabled = false;
            this.bnSignUp.HighEmphasis = true;
            this.bnSignUp.Icon = null;
            this.bnSignUp.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnSignUp.IconAndTextPadding = 4;
            this.bnSignUp.IconAutoSizePercentage = 20D;
            this.bnSignUp.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnSignUp.IconTransparency = 70D;
            this.bnSignUp.Location = new System.Drawing.Point(4, 6);
            this.bnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.bnSignUp.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnSignUp.Name = "bnSignUp";
            this.bnSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnSignUp.Size = new System.Drawing.Size(219, 40);
            this.bnSignUp.TabIndex = 11;
            this.bnSignUp.Text = "Registrar";
            this.bnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnSignUp.UseAccentColor = false;
            this.bnSignUp.UseVisualStyleBackColor = true;
            this.bnSignUp.Click += new System.EventHandler(this.bnSignUp_Click);
            // 
            // txPhone
            // 
            this.txPhone.AllowPromptAsInput = true;
            this.txPhone.AnimateReadOnly = false;
            this.txPhone.AsciiOnly = false;
            this.txPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txPhone.BeepOnError = false;
            this.txPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txPhone.Depth = 0;
            this.txPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPhone.ErrorState = false;
            this.txPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txPhone.HidePromptOnLeave = false;
            this.txPhone.HideSelection = true;
            this.txPhone.Hint = "Teléfono";
            this.txPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txPhone.LeadingIcon = null;
            this.txPhone.Location = new System.Drawing.Point(234, 107);
            this.txPhone.Mask = "+00 000 000-0000";
            this.txPhone.MaxLength = 32767;
            this.txPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txPhone.Name = "txPhone";
            this.txPhone.PasswordChar = '\0';
            this.txPhone.PrefixSuffixText = null;
            this.txPhone.PromptChar = '_';
            this.txPhone.ReadOnly = false;
            this.txPhone.RejectInputOnFirstFailure = false;
            this.txPhone.ResetOnPrompt = true;
            this.txPhone.ResetOnSpace = false;
            this.txPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txPhone.SelectedText = "";
            this.txPhone.SelectionLength = 0;
            this.txPhone.SelectionStart = 0;
            this.txPhone.ShortcutsEnabled = true;
            this.txPhone.Size = new System.Drawing.Size(225, 48);
            this.txPhone.SkipLiterals = true;
            this.txPhone.TabIndex = 6;
            this.txPhone.TabStop = false;
            this.txPhone.Text = "+          -";
            this.txPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txPhone.TrailingIcon = null;
            this.txPhone.UseSystemPasswordChar = false;
            this.txPhone.ValidatingType = null;
            this.txPhone.Enter += new System.EventHandler(this.txPhone_Enter);
            this.txPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPhone_KeyPress);
            this.txPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPhone_KeyUp);
            // 
            // fSignUp
            // 
            this.AcceptButton = this.bnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.ClientSize = new System.Drawing.Size(532, 554);
            this.ControlBox = false;
            this.Controls.Add(this.tcMain);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSignUp";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign In";
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.mcMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnSignUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private MaterialSkin.Controls.MaterialCard mcMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MaterialSkin.Controls.MaterialTextBox2 txDNI;
        private MaterialSkin.Controls.MaterialTextBox2 txEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txLastName;
        private MaterialSkin.Controls.MaterialTextBox2 txName;
        private MaterialSkin.Controls.MaterialTextBox2 txRepPass;
        private MaterialSkin.Controls.MaterialTextBox2 txPass;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txDetails;
        private MaterialSkin.Controls.MaterialComboBox cbType;
        private MaterialSkin.Controls.MaterialButton bnClose;
        private MaterialSkin.Controls.MaterialButton bnSignUp;
        private MaterialSkin.Controls.MaterialLabel lbError;
        private System.Windows.Forms.Panel pnSignUp;
        private MaterialSkin.Controls.MaterialMaskedTextBox txPhone;
    }
}