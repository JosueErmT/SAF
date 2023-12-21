using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAF.CustomControls {
    public class CustomTLP : TableLayoutPanel, IMaterialControl {
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private MaterialSkinManager.Colors nMaterialBackColor = MaterialSkinManager.Colors.BackdropColor;
        [Category("Appearance"), Browsable(true), DisplayName("BackColor")]
        public MaterialSkinManager.Colors MaterialBackColor {
            get => this.nMaterialBackColor; 
            set {
                this.nMaterialBackColor = value;
                RefreshTheme();
            }
        }

        [Browsable(false)]
        public override Color BackColor {
            set => RefreshTheme();
        }

        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if (this.Parent != null)
                RefreshTheme();
        }

        protected virtual void RefreshTheme() {
            base.BackColor = (Color)SkinManager.GetType().GetProperty(MaterialBackColor.ToString()).GetValue(SkinManager, null);
        }
    }
}
