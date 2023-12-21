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
    public class CustomPN : Panel, IMaterialControl {
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

        private void RefreshTheme() {
            if (this.Parent != null) {
                base.BackColor = ColorHelper.RemoveAlpha(
                    (Color)SkinManager.GetType().GetProperty(MaterialBackColor.ToString()).GetValue(SkinManager, null),
                    this.Parent.BackColor
                );
            }
        }
    }
}
