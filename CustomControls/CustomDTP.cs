using Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SAF.CustomControls {
    public class CustomDTP : MaterialMaskedTextBox {
        public delegate void ValueChangedHandler(object sender, EventArgs e);
        [Category("Property Changed"), Browsable(true)]
        public event ValueChangedHandler ValueChanged;

        public delegate void TextChangedHandler(object sender, EventArgs e);
        [Category("Property Changed"), Browsable(true)]
        public new event TextChangedHandler TextChanged;

//      Extern functions
        [DllImport("User32.dll")]
        internal static extern bool HideCaret(IntPtr hWnd);

//      Disabled properties
        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Mask { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new char PromptChar { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool SkipLiterals { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Char PasswordChar { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool UseSystemPasswordChar { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool TextMaskFormat { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool CutCopyMaskFormat { get; set; }

        [Obsolete(), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool ResetOnSpace { get; set; } = false;

//      Class fields
        private static string sSysDateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
        private static Regex rxPFormat = new Regex(@"(\w*?)\/(\w*?)\/(\w*)");

//      Instance fields
        protected bool bTextChanging = false;
        protected bool bWideDate = false;
        private Regex rxPText = new Regex(@"([\d\s]*?) \/ ([\d\s]*?) \/ ([\d\s]*)");

        protected KryptonMonthCalendar Calendar;
        protected Image oDefaultIcon;
        protected string sDefaultIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAidJREFUeNrs3N1t4kAUgFGIUgj
            pgO2ADqAE0kFa2Qq2hU0HdODtwHRgOnAG7SDlAa/ANmZ89xxplIcoSL4f/pWVxQIAAAAAItml9SutOq22xxqiLWhNvR11nvvuUWE/BkQVeNztqHOPUazTqoIMpg
            22HVXu09s+rSbgYCJtR5M79YobeTDRtmN/72G5EXhW29Hcc7iu/qPBRNqO6tar5Vbg2W5H59X1Mv88X4KvHngfvRw4mFKUuh3HtN6u/eIl30SvFszZquthyDnw1
            nxC2HYF3phNCJuuc8oU5zjn4CfN+cUXPzaBg5vqEM2TTiH2YIdoBEZgBEZgBEZggREYgREYgRGYbq8D/35phKNr7cEIjMAC4yJr7IuEpc+zByMwAguMwAiMwAiM
            wAgsMAIjMAIzlaH/wsE7WeMbtYc92CEagRGY5/BOVnmfZw9GYAQWGIERGIERGIERWGAERmAEZiLeySqPd7JwiEZggQnAO1nlfZ49GIERWGAERmAERmAERmCBERi
            BEZiJeCerPN7JwiEagQUmgKHvZLVGaA9GYB4Z+GgMIRy7Ah/MJoRDV+BPswnhasfLo606rZUZzfrw/Pavi6yfZjRrnf2+P5yu0lqb1ez8SevHLbdJ72mdzGtWTr
            nbzfaLv0+nrHmsfZ9vxfmPGsMrejV9416s8znZMMtbo14rfeRbKIN9/qpzj7vc+srNLq1tWhv3y5Pf3x7yQ4zffT7gS4ABAOeDJc9KYfOaAAAAAElFTkSuQmCC
        ");

//      Properties
        public new bool ContainsFocus {
            get => base.ContainsFocus || Calendar != null && !Calendar.IsDisposed && Calendar.ContainsFocus;
        }

        protected bool bDefaultIcon = true;
        [Category("Material Skin"), Browsable(true), DefaultValue(true)]
        public bool DefaultIcon {
            get => bDefaultIcon;
            set => TrailingIcon = (bDefaultIcon = value) ? oDefaultIcon : null;
        }

        [Category("Behavior"), Browsable(true), DefaultValue(false)]
        public override bool ReadOnly {
            get => this._readonly;
            set => this._readonly = value;
        }
        
        [Category("Appearance"), Browsable(true)]
        public Size CalendarSize { get; set; } = new Size(1, 1);
                
        public new string Hint { 
            get => base.Hint;
            set {
                base.Hint = value;
                ValidateText();
            }
        }

        protected string sSeparator = " / ";
        [Category("Appearance"), Browsable(true), DefaultValue(" / ")]
        public string Separator {
            get => this.sSeparator; 
            set {
                this.sSeparator = value;
                rxPText = new Regex(@"([\d\s]*?)" + Regex.Escape(value) + @"([\d\s]*?)" + Regex.Escape(value) + @"([\d\s]*)");
            } 
        }

        protected DateTime oValue = DateTime.Now;
        [Category("Appearance"), Browsable(true)]
        public virtual DateTime Value {
            get => this.Focused ? GetValue(this.Text) : this.oValue;
            set {
                this.oValue = value <= DateTimePicker.MinimumDateTime ? DateTimePicker.MinimumDateTime
                            : value >= DateTimePicker.MaximumDateTime ? DateTimePicker.MaximumDateTime
                            : value;
                this.Text = this.oValue.ToString(sSysDateFormat).Replace("/", this.Separator);
                if (this.ValueChanged != null)
                    this.ValueChanged(this, new EventArgs());
            }
        }
        
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text {
            get => base.Text;
            set {
                this.bTextChanging = true;
                int iPos = this.SelectionStart;

                string sText = this.bWideDate && !this.ReadOnly ? GetWideDate(value) : value;
                base.Mask = Regex.Replace(sText, @"\d+", rxM => new string('0', rxM.Length));
                this.bTextChanging = false;
                base.Text = sText;

                this.SelectionStart = iPos;

                string GetWideDate(string sDate) {
                    Match rxMText = rxPText.Match(this.Text);
                    Match rxMDate = rxPText.Match(sDate);
                    //Match rxMFormat = rxPFormat.Match(sSysDateFormat);

                    string[] rDates = new string[rxMDate.Groups.Count - 1]; Group oItem;
                    for (int i = 0; i < rDates.Length; i++) {
                        oItem = rxMDate.Groups[i + 1];
                        rDates[i] = oItem.Value.PadLeft(oItem.Value.Length <= 2 ? 2 : 4);

                        oItem = rxMText.Groups[i + 1];
                        if (oItem.Index < iPos && oItem.Value.Length < rDates[i].Length)
                            iPos += rDates[i].Length - oItem.Value.Length;
                    }

                    return rDates[0] + this.Separator + rDates[1] + this.Separator + rDates[2];
                }
            }
        }

//      Constructor
        public CustomDTP() : base() {
            this._iconPadding = 9;
            this.BaseTextBox.ReadOnly = true;
            this.Size = new Size(230, this.Height);

            this.oDefaultIcon = sDefaultIcon.ImageFromBase64();
            this.TrailingIcon = this.oDefaultIcon;

            this.TrailingIconClick += OnTrailingIconClick;
            this.MouseDown += OnMouseDown;
            this.MouseUp += OnMouseUp;
            this.KeyDown += OnKeyDown;
            this.KeyUp += OnKeyUp;

            base.TextChanged += (sender, e) => {
                if (!bTextChanging && this.TextChanged != null)
                    this.TextChanged(this, e);
            };
        }

        protected void CorrectSel(bool bValidate = true) {
            if (string.IsNullOrEmpty(base.Mask))
                return;

            if (bValidate)
                ValidateText();

            int iPos = base.Mask.LastIndexOf(this.Separator, Math.Min(this.SelectionStart + this.Separator.Length / 2, base.Mask.Length), StringComparison.Ordinal);
            this.SelectionStart = iPos >= 0 ? iPos + this.Separator.Length : 0;
            int iLength = base.Mask.IndexOf(this.Separator, this.SelectionStart, StringComparison.Ordinal) - this.SelectionStart;
            this.SelectionLength = iLength >= 0 ? iLength : base.Mask.Length - this.SelectionStart;
        }

        public void ValidateText() {
            this.Value = GetValue(this.Text);
        }

        protected DateTime GetValue(string sText) {
            int iDay = 0, iMonth = 0, iYear = 0;
            Match rxMDate = rxPText.Match(sText);
            Match rxMFormat = rxPFormat.Match(sSysDateFormat);

            int iTry;
            for (int i = 1; i < rxMFormat.Groups.Count; i++) {
                if (rxMFormat.Groups[i].Value.StartsWith("d"))
                    iDay = int.TryParse(rxMDate.Groups[i].Value, out iTry) ? iTry : 0;
                else if (rxMFormat.Groups[i].Value.StartsWith("M"))
                    iMonth = int.TryParse(rxMDate.Groups[i].Value, out iTry) ? iTry : 0;
                else if (rxMFormat.Groups[i].Value.StartsWith("y"))
                    iYear = int.TryParse(rxMDate.Groups[i].Value, out iTry) ? iTry : 0;
            }

            if (iYear <= 99) {
                int i2Year = int.Parse(DateTime.Today.ToString("yy"));
                iYear = (DateTime.Today.Year / 100 * 100) - (iYear <= i2Year + 20 ? 0 : 100) + iYear;
            }
            else
                iYear = Math.Max(1, Math.Min(iYear, 9999));
            iMonth = Math.Max(1, Math.Min(iMonth, 12));
            iDay = Math.Max(1, Math.Min(iDay, DateTime.DaysInMonth(iYear, iMonth)));

            return new DateTime(iYear, iMonth, iDay);
        }

        protected void ShowCalendar() {
            if (Calendar != null && !Calendar.IsDisposed)
                Calendar.Dispose();
            Calendar = new KryptonMonthCalendar();
            Calendar.Name = "Calendar";
            Calendar.TabStop = false;
            Calendar.TabIndex = 0;
            Calendar.MaxSelectionCount = 1;  

            Calendar.LostFocus += CalendarOnLostFocus;
            Calendar.DateChanged += CalendarDateChanged;
            Calendar.KeyUp += CalendarKeyUp;

            this.FindForm().Controls.Add(Calendar);
            Calendar.BringToFront();

            Point oPosInForm = this.FindForm().PointToClient(this.PointToScreen(new Point()));
            Calendar.Location = new Point(oPosInForm.X, oPosInForm.Y + this.Height);
            Calendar.Size = new Size(Calendar.Size.Width * this.CalendarSize.Width, Calendar.Size.Height * this.CalendarSize.Height);

            Calendar.PaletteMode = this.SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ?
                                   PaletteMode.Office365White : PaletteMode.Office365BlackDarkMode;
            Calendar.ControlBackStyle = PaletteBackStyle.ControlRibbonAppMenu;
            Calendar.ControlBorderStyle = PaletteBorderStyle.ButtonStandalone;

            Calendar.StateCommon.Back.Color1 =
            Calendar.StateCommon.Back.Color2 = this.SkinManager.BackgroundAlternativeColor;
            Calendar.StateCommon.Border.Width = 1;
            Calendar.StateCommon.Border.DrawBorders = PaletteDrawBorders.BottomLeftRight;
            Calendar.StateCommon.Border.Color1 =
            Calendar.StateCommon.Border.Color2 = this.SkinManager.ColorScheme.AccentColor;
            Calendar.StateCommon.Header.Back.Color1 =
            Calendar.StateCommon.Header.Back.Color2 = this.SkinManager.BackgroundColor;
            Calendar.StateCommon.Day.Back.Color1 = this.SkinManager.BackgroundColor;

            Calendar.OverrideToday.Day.Border.DrawBorders = PaletteDrawBorders.Bottom;
            Calendar.OverrideToday.Day.Border.Color1 =
            Calendar.OverrideToday.Day.Border.Color2 = this.SkinManager.ColorScheme.AccentColor;

            this.AnimateIn();
            Calendar.Select();
            this.bWideDate = false;
            ValidateText();
            Calendar.SelectionStart = this.Value <= Calendar.MinDate ? Calendar.MinDate
                                    : this.Value >= Calendar.MaxDate ? Calendar.MaxDate
                                    : this.Value;
        }

        protected void CalendarOnLostFocus(object sender, EventArgs e) {
            if (!Calendar.IsDisposed && !Calendar.Focused) {
                if (!this.Focused)
                    this.AnimateOut();
                else
                    this.Select();
                Calendar.Dispose();
            }
            ValidateText();
        }

        protected void CalendarDateChanged(object sender, DateRangeEventArgs e) {
            this.Value = e.Start;
            ValidateText();
        }

        protected void CalendarKeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space) {
                this.Select();
                CorrectSel();
            }
        }

        protected void OnMouseDown(object sender, MouseEventArgs e) {
            this.SuspendDrawing();
        }

        protected void OnMouseUp(object sender, MouseEventArgs e) {
            this.ResumeDrawing();
            CorrectSel();
        }

        protected void OnKeyDown(object sender, KeyEventArgs e) {
            if (this.ReadOnly) {
                e.Handled = true;
                return;
            }
            int iPos = -1;

            if (e.KeyCode == Keys.Right) {
                if (this.SelectionLength == 0)
                    CorrectSel(false);

                iPos = base.Mask.IndexOf(this.Separator, this.SelectionStart, StringComparison.Ordinal);
                iPos = iPos >= 0 ? iPos + this.Separator.Length : 0;
            }
            else if (e.KeyCode == Keys.Left) {
                if (this.SelectionLength == 0)
                    CorrectSel(false);

                if ((iPos = base.Mask.LastIndexOf(this.Separator, this.SelectionStart, StringComparison.Ordinal) - 1) < 0)
                    iPos = base.Mask.Length;
            }
            else if (e.KeyCode == Keys.Back) {
                if (this.SelectionLength == 0)
                    CorrectSel(false);

                int iDatePos = base.Mask.Substring(0, this.SelectionStart).Count(this.Separator);
                int iSpaces = this.Text.Substring(this.SelectionStart, this.SelectionLength).Count(i => i == ' ');
                iPos = this.SelectionStart;
                this.Text = this.Text.Remove(iPos + this.SelectedText.Length - 1, 1).Insert(iPos, " ");
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) {
                if (this.SelectionLength == 0)
                    CorrectSel(false);

                string sKey = ((char)(e.KeyValue >= 96 ? e.KeyValue - 48 : e.KeyValue)).ToString();

                int iDatePos = base.Mask.Substring(0, this.SelectionStart).Count(this.Separator);
                string sCurFormat = Regex.Replace(sSysDateFormat, @".*?(?:\/.*?){" + iDatePos + @"}(.*?)(?:\/.*|$)", "$1");
                int iSpaces = this.SelectedText.Count(i => i == ' ');

                iPos = this.SelectionStart;
                string s = this.SelectedText + sKey;
                if (iSpaces <= 0 ||
                    sCurFormat.StartsWith("d") && int.Parse(this.SelectedText + sKey) > 31 || 
                    sCurFormat.StartsWith("M") && int.Parse(this.SelectedText + sKey) > 12)
                    this.Text = this.Text.Remove(iPos, this.SelectionLength).Insert(iPos, new string(' ', this.SelectionLength <= 2 ? 1 : 3) + sKey);
                else
                    this.Text = this.Text.Remove(iPos + iSpaces - 1, 1).Insert(iPos + this.SelectionLength - 1, sKey);
            }

            if (iPos >= 0) {
                this.SelectionStart = iPos;
                CorrectSel(false);
            }
            e.Handled = true;
        }

        protected void OnKeyUp(object sender, KeyEventArgs e) {
            if (this.ReadOnly) {
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Space)
                ShowCalendar();
            else {
                CorrectSel(
                    (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
                    (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) &&
                    e.KeyCode != Keys.Back
                );
            }
        }

        protected override void OnGotFocus(object sender, EventArgs e) {
            base.OnGotFocus(sender, e);
            HideCaret(this.BaseTextBox.Handle);
            this.bWideDate = true;
        }

        protected override void OnLostFocus(object sender, EventArgs e) {
            if (Calendar != null && !Calendar.IsDisposed) {
                if (Calendar.Focused)
                    return;
                Calendar.Dispose();
            }
            this.bWideDate = false;
            ValidateText();

            base.OnLostFocus(sender, e);
        }

        private void OnTrailingIconClick(object sender, EventArgs e) {
            if (this.ReadOnly)
                return;

            if (Calendar == null || Calendar.IsDisposed)
                ShowCalendar();
            else
                Calendar.Dispose();
        }
    }
}