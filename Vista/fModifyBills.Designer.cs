namespace SAF.Vista {
    partial class fModifyBills {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fModifyBills));
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.mcMain = new MaterialSkin.Controls.MaterialCard();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txDesc = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cbPayType = new MaterialSkin.Controls.MaterialComboBox();
            this.txPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpDate = new SAF.CustomControls.CustomDTP();
            this.txID = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbError = new MaterialSkin.Controls.MaterialLabel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.pnUpdate = new System.Windows.Forms.Panel();
            this.bnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.bnClose = new MaterialSkin.Controls.MaterialButton();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.mcMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.pnUpdate.SuspendLayout();
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
            this.tcMain.Size = new System.Drawing.Size(654, 365);
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
            this.tpMain.Size = new System.Drawing.Size(646, 339);
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
            this.mcMain.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.mcMain.Size = new System.Drawing.Size(606, 299);
            this.mcMain.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lbTitle, 0, 0);
            this.tlpMain.Controls.Add(this.txDesc, 1, 1);
            this.tlpMain.Controls.Add(this.cbPayType, 0, 4);
            this.tlpMain.Controls.Add(this.txPrice, 0, 3);
            this.tlpMain.Controls.Add(this.dtpDate, 0, 2);
            this.tlpMain.Controls.Add(this.txID, 0, 1);
            this.tlpMain.Controls.Add(this.lbError, 0, 5);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 6);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(10, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMain.Size = new System.Drawing.Size(586, 285);
            this.tlpMain.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lbTitle, 2);
            this.lbTitle.Depth = 0;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(586, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Modificando factura ID 0000";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txDesc
            // 
            this.txDesc.AnimateReadOnly = false;
            this.txDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txDesc.Depth = 0;
            this.txDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txDesc.HideSelection = true;
            this.txDesc.Hint = "Descripción";
            this.txDesc.Location = new System.Drawing.Point(246, 35);
            this.txDesc.Margin = new System.Windows.Forms.Padding(4, 3, 8, 0);
            this.txDesc.MaxLength = 512;
            this.txDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txDesc.Name = "txDesc";
            this.txDesc.PasswordChar = '\0';
            this.txDesc.ReadOnly = false;
            this.tlpMain.SetRowSpan(this.txDesc, 4);
            this.txDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDesc.SelectedText = "";
            this.txDesc.SelectionLength = 0;
            this.txDesc.SelectionStart = 0;
            this.txDesc.ShortcutsEnabled = true;
            this.txDesc.Size = new System.Drawing.Size(332, 205);
            this.txDesc.TabIndex = 2;
            this.txDesc.TabStop = false;
            this.txDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDesc.UseSystemPasswordChar = false;
            this.txDesc.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // cbPayType
            // 
            this.cbPayType.AutoResize = false;
            this.cbPayType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPayType.Depth = 0;
            this.cbPayType.DisabledItems = ((System.Collections.Generic.List<int>)(resources.GetObject("cbPayType.DisabledItems")));
            this.cbPayType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPayType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPayType.DropDownHeight = 170;
            this.cbPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayType.DropDownWidth = 121;
            this.cbPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPayType.FormattingEnabled = true;
            this.cbPayType.Hint = "Medio de pago";
            this.cbPayType.IntegralHeight = false;
            this.cbPayType.ItemHeight = 42;
            this.cbPayType.Location = new System.Drawing.Point(8, 191);
            this.cbPayType.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.cbPayType.MaxDropDownItems = 4;
            this.cbPayType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPayType.Name = "cbPayType";
            this.cbPayType.Size = new System.Drawing.Size(230, 48);
            this.cbPayType.StartIndex = 0;
            this.cbPayType.TabIndex = 4;
            this.cbPayType.SelectedIndexChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // txPrice
            // 
            this.txPrice.AnimateReadOnly = false;
            this.txPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txPrice.Depth = 0;
            this.txPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPrice.ErrorState = false;
            this.txPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txPrice.HideSelection = true;
            this.txPrice.Hint = "Monto";
            this.txPrice.LeadingIcon = null;
            this.txPrice.Location = new System.Drawing.Point(8, 139);
            this.txPrice.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.txPrice.MaxLength = 13;
            this.txPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txPrice.Name = "txPrice";
            this.txPrice.PasswordChar = '\0';
            this.txPrice.PrefixSuffixText = null;
            this.txPrice.ReadOnly = false;
            this.txPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txPrice.SelectedText = "";
            this.txPrice.SelectionLength = 0;
            this.txPrice.SelectionStart = 0;
            this.txPrice.ShortcutsEnabled = true;
            this.txPrice.Size = new System.Drawing.Size(230, 48);
            this.txPrice.TabIndex = 1;
            this.txPrice.TabStop = false;
            this.txPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPrice.TrailingIcon = null;
            this.txPrice.UseSystemPasswordChar = false;
            this.txPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPrice_KeyPress);
            this.txPrice.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.AllowPromptAsInput = true;
            this.dtpDate.AnimateReadOnly = false;
            this.dtpDate.AsciiOnly = false;
            this.dtpDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dtpDate.BeepOnError = false;
            this.dtpDate.CalendarSize = new System.Drawing.Size(1, 1);
            this.dtpDate.Depth = 0;
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Enabled = false;
            this.dtpDate.ErrorState = false;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpDate.HidePromptOnLeave = false;
            this.dtpDate.HideSelection = true;
            this.dtpDate.Hint = "Fecha";
            this.dtpDate.IconPadding = 9;
            this.dtpDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dtpDate.LeadingIcon = null;
            this.dtpDate.Location = new System.Drawing.Point(8, 87);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.dtpDate.MaxLength = 32767;
            this.dtpDate.MouseState = MaterialSkin.MouseState.OUT;
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.PrefixSuffixText = null;
            this.dtpDate.RejectInputOnFirstFailure = false;
            this.dtpDate.ResetOnPrompt = true;
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDate.SelectedText = "";
            this.dtpDate.SelectionLength = 0;
            this.dtpDate.SelectionStart = 0;
            this.dtpDate.ShortcutsEnabled = true;
            this.dtpDate.Size = new System.Drawing.Size(230, 48);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.TabStop = false;
            this.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dtpDate.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("dtpDate.TrailingIcon")));
            this.dtpDate.ValidatingType = null;
            this.dtpDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new SAF.CustomControls.CustomDTP.ValueChangedHandler(this.CtrlsValueChanged);
            // 
            // txID
            // 
            this.txID.AnimateReadOnly = false;
            this.txID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txID.Depth = 0;
            this.txID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txID.Enabled = false;
            this.txID.ErrorState = false;
            this.txID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txID.HideSelection = true;
            this.txID.Hint = "ID de la factura";
            this.txID.LeadingIcon = null;
            this.txID.Location = new System.Drawing.Point(8, 35);
            this.txID.Margin = new System.Windows.Forms.Padding(8, 3, 4, 3);
            this.txID.MaxLength = 8;
            this.txID.MouseState = MaterialSkin.MouseState.OUT;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PrefixSuffixText = null;
            this.txID.ReadOnly = false;
            this.txID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txID.SelectedText = "";
            this.txID.SelectionLength = 0;
            this.txID.SelectionStart = 0;
            this.txID.ShortcutsEnabled = true;
            this.txID.Size = new System.Drawing.Size(230, 48);
            this.txID.TabIndex = 1;
            this.txID.TabStop = false;
            this.txID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txID.TrailingIcon = null;
            this.txID.UseSystemPasswordChar = false;
            this.txID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txID_KeyPress);
            this.txID.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lbError, 2);
            this.lbError.Depth = 0;
            this.lbError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbError.ErrorState = true;
            this.lbError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbError.Location = new System.Drawing.Point(0, 242);
            this.lbError.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lbError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(586, 18);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "Actualice algun valor";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpButtons, 2);
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.pnUpdate, 1, 0);
            this.tlpButtons.Controls.Add(this.bnClose, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 260);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpButtons.Size = new System.Drawing.Size(586, 52);
            this.tlpButtons.TabIndex = 6;
            // 
            // pnUpdate
            // 
            this.pnUpdate.Controls.Add(this.bnUpdate);
            this.pnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUpdate.Location = new System.Drawing.Point(293, 0);
            this.pnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.pnUpdate.Name = "pnUpdate";
            this.pnUpdate.Padding = new System.Windows.Forms.Padding(4, 6, 8, 6);
            this.pnUpdate.Size = new System.Drawing.Size(293, 52);
            this.pnUpdate.TabIndex = 0;
            this.pnUpdate.MouseEnter += new System.EventHandler(this.pnUpdate_MouseEnter);
            this.pnUpdate.MouseLeave += new System.EventHandler(this.pnUpdate_MouseLeave);
            // 
            // bnUpdate
            // 
            this.bnUpdate.AutoSize = false;
            this.bnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnUpdate.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnUpdate.Depth = 0;
            this.bnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnUpdate.Enabled = false;
            this.bnUpdate.HighEmphasis = true;
            this.bnUpdate.Icon = null;
            this.bnUpdate.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnUpdate.IconAndTextPadding = 4;
            this.bnUpdate.IconAutoSizePercentage = 20D;
            this.bnUpdate.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnUpdate.IconTransparency = 70D;
            this.bnUpdate.Location = new System.Drawing.Point(4, 6);
            this.bnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.bnUpdate.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnUpdate.Name = "bnUpdate";
            this.bnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnUpdate.Size = new System.Drawing.Size(281, 40);
            this.bnUpdate.TabIndex = 1;
            this.bnUpdate.Text = "Modificar";
            this.bnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnUpdate.UseAccentColor = false;
            this.bnUpdate.UseVisualStyleBackColor = true;
            this.bnUpdate.Click += new System.EventHandler(this.bnUpdate_Click);
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
            this.bnClose.Location = new System.Drawing.Point(8, 6);
            this.bnClose.Margin = new System.Windows.Forms.Padding(8, 6, 4, 6);
            this.bnClose.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnClose.Name = "bnClose";
            this.bnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnClose.Size = new System.Drawing.Size(281, 40);
            this.bnClose.TabIndex = 1;
            this.bnClose.Text = "Cancelar";
            this.bnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnClose.UseAccentColor = false;
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // fModifyBills
            // 
            this.AcceptButton = this.bnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.ClientSize = new System.Drawing.Size(656, 367);
            this.ControlBox = false;
            this.Controls.Add(this.tcMain);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fModifyBills";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fModifyBills";
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.mcMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.pnUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private MaterialSkin.Controls.MaterialCard mcMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MaterialSkin.Controls.MaterialLabel lbTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txPrice;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txDesc;
        private CustomControls.CustomDTP dtpDate;
        private MaterialSkin.Controls.MaterialComboBox cbPayType;
        private MaterialSkin.Controls.MaterialTextBox2 txID;
        private MaterialSkin.Controls.MaterialLabel lbError;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Panel pnUpdate;
        private MaterialSkin.Controls.MaterialButton bnUpdate;
        private MaterialSkin.Controls.MaterialButton bnClose;
    }
}