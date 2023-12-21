namespace SAF.Vista {
    partial class fLogIn {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogIn));
            this.mcMain = new MaterialSkin.Controls.MaterialCard();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.txPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.bnClose = new MaterialSkin.Controls.MaterialButton();
            this.txDNI = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnLogIn = new System.Windows.Forms.Panel();
            this.bnLogIn = new MaterialSkin.Controls.MaterialButton();
            this.lbError = new MaterialSkin.Controls.MaterialLabel();
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.mcMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnLogIn.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcMain
            // 
            this.mcMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcMain.Controls.Add(this.tlpMain);
            this.mcMain.Depth = 0;
            resources.ApplyResources(this.mcMain, "mcMain");
            this.mcMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcMain.Name = "mcMain";
            // 
            // tlpMain
            // 
            resources.ApplyResources(this.tlpMain, "tlpMain");
            this.tlpMain.Controls.Add(this.txPass, 0, 2);
            this.tlpMain.Controls.Add(this.bnClose, 0, 4);
            this.tlpMain.Controls.Add(this.txDNI, 0, 0);
            this.tlpMain.Controls.Add(this.pnLogIn, 1, 4);
            this.tlpMain.Controls.Add(this.lbError, 0, 3);
            this.tlpMain.Name = "tlpMain";
            // 
            // txPass
            // 
            this.txPass.AnimateReadOnly = false;
            this.txPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            resources.ApplyResources(this.txPass, "txPass");
            this.txPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpMain.SetColumnSpan(this.txPass, 2);
            this.txPass.Depth = 0;
            this.txPass.ErrorState = false;
            this.txPass.HideSelection = true;
            this.txPass.LeadingIcon = null;
            this.txPass.MaxLength = 64;
            this.txPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '●';
            this.txPass.ReadOnly = false;
            this.txPass.SelectedText = "";
            this.txPass.SelectionLength = 0;
            this.txPass.SelectionStart = 0;
            this.txPass.ShortcutsEnabled = true;
            this.txPass.TabStop = false;
            this.txPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPass.TrailingIcon = null;
            this.txPass.UseSystemPasswordChar = true;
            this.txPass.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // bnClose
            // 
            resources.ApplyResources(this.bnClose, "bnClose");
            this.bnClose.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnClose.Depth = 0;
            this.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnClose.HighEmphasis = false;
            this.bnClose.Icon = null;
            this.bnClose.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnClose.IconAndTextPadding = 4;
            this.bnClose.IconAutoSizePercentage = 20D;
            this.bnClose.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnClose.IconTransparency = 70D;
            this.bnClose.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnClose.Name = "bnClose";
            this.bnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnClose.UseAccentColor = false;
            this.bnClose.UseVisualStyleBackColor = true;
            // 
            // txDNI
            // 
            this.txDNI.AnimateReadOnly = false;
            this.txDNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txDNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            resources.ApplyResources(this.txDNI, "txDNI");
            this.txDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlpMain.SetColumnSpan(this.txDNI, 2);
            this.txDNI.Depth = 0;
            this.txDNI.ErrorState = false;
            this.txDNI.HideSelection = true;
            this.txDNI.LeadingIcon = null;
            this.txDNI.MaxLength = 8;
            this.txDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txDNI.Name = "txDNI";
            this.txDNI.PasswordChar = '\0';
            this.txDNI.ReadOnly = false;
            this.txDNI.SelectedText = "";
            this.txDNI.SelectionLength = 0;
            this.txDNI.SelectionStart = 0;
            this.txDNI.ShortcutsEnabled = true;
            this.txDNI.TabStop = false;
            this.txDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDNI.TrailingIcon = null;
            this.txDNI.UseSystemPasswordChar = false;
            this.txDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDNI_KeyPress);
            this.txDNI.TextChanged += new System.EventHandler(this.CtrlsValueChanged);
            // 
            // pnLogIn
            // 
            this.pnLogIn.Controls.Add(this.bnLogIn);
            resources.ApplyResources(this.pnLogIn, "pnLogIn");
            this.pnLogIn.Name = "pnLogIn";
            this.pnLogIn.MouseEnter += new System.EventHandler(this.pnLogIn_MouseEnter);
            this.pnLogIn.MouseLeave += new System.EventHandler(this.pnLogIn_MouseLeave);
            // 
            // bnLogIn
            // 
            resources.ApplyResources(this.bnLogIn, "bnLogIn");
            this.bnLogIn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.bnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnLogIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnLogIn.Depth = 0;
            this.bnLogIn.HighEmphasis = true;
            this.bnLogIn.Icon = null;
            this.bnLogIn.IconAlign = MaterialSkin.Controls.MaterialButton.MaterialIconAlign.Left;
            this.bnLogIn.IconAndTextPadding = 4;
            this.bnLogIn.IconAutoSizePercentage = 20D;
            this.bnLogIn.IconColor = MaterialSkin.Controls.MaterialButton.MaterialIconColor.TextBased;
            this.bnLogIn.IconTransparency = 70D;
            this.bnLogIn.MaterialBackColor = MaterialSkin.MaterialSkinManager.Colors.None;
            this.bnLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnLogIn.Name = "bnLogIn";
            this.bnLogIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnLogIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnLogIn.UseAccentColor = false;
            this.bnLogIn.UseVisualStyleBackColor = true;
            this.bnLogIn.Click += new System.EventHandler(this.bnLogIn_Click);
            // 
            // lbError
            // 
            resources.ApplyResources(this.lbError, "lbError");
            this.tlpMain.SetColumnSpan(this.lbError, 2);
            this.lbError.Depth = 0;
            this.lbError.ErrorState = true;
            this.lbError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbError.Name = "lbError";
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Depth = 0;
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.White;
            this.tpMain.Controls.Add(this.mcMain);
            resources.ApplyResources(this.tpMain, "tpMain");
            this.tpMain.Name = "tpMain";
            // 
            // fLogIn
            // 
            this.AcceptButton = this.bnLogIn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnClose;
            this.Controls.Add(this.tcMain);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.HelpButton = true;
            this.Icon = global::SAF.Properties.Resources.IconN;
            this.MaximizeBox = false;
            this.Name = "fLogIn";
            this.Sizable = false;
            this.mcMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnLogIn.ResumeLayout(false);
            this.pnLogIn.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard mcMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MaterialSkin.Controls.MaterialTextBox2 txPass;
        private MaterialSkin.Controls.MaterialButton bnClose;
        private MaterialSkin.Controls.MaterialButton bnLogIn;
        private MaterialSkin.Controls.MaterialTextBox2 txDNI;
        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.Panel pnLogIn;
        private MaterialSkin.Controls.MaterialLabel lbError;
    }
}