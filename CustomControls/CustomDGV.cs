using Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Animations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SAF.CustomControls {
    public class CustomDGV : KryptonDataGridView, IMaterialControl {
        public delegate void ColumnHeaderMouseClickHandler(object sender, CancelMouseEventArgs e);
        public new event ColumnHeaderMouseClickHandler ColumnHeaderMouseClick;

        private bool bFocused = false;
        private bool bHover = false;
        private bool bSortable = false;

        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private AnimationManager oAnimationManager;
        [Browsable(false)]
        public AnimationManager AnimationManager => oAnimationManager;

        public override Color BackColor {
            set => RefreshTheme();
        }
        
        public Color ColorColsBack { get; set; }
        public Color ColorFocusColsBack { get; set; }
        public Color ColorHoverColsBack { get; set; }

        [Browsable(false)]
        public bool DisableLostFocusAnimation { get; set; } = false;

        [Browsable(false)]
        public int ItemsFit => (this.Height - this.ColumnHeadersHeight) / this.RowTemplate.Height;

        private int iCurrentPage = 0;
        [Category("Behavior"), Browsable(true), DefaultValue(0)]
        public int CurrentPage {
            get => this.iCurrentPage;
            set {
                if (this.oPageDataSource == null)
                    return;
                this.iCurrentPage = value;

                IList oPage = new List<object>();
                int iFirstItem = (value - 1) * this.PageSize;
                int iMaxItem = Math.Min(iFirstItem + this.PageSize, this.oPageDataSource.Count);
                for (int i = iFirstItem; i < iMaxItem; i++)
                    oPage.Add(this.oPageDataSource[i]);

                this.DataSource = oPage;
            }
        }
        
        private IList oPageDataSource = null;
        [Category("Behavior"), Browsable(true)]
        public object PageDataSource {
            get => this.oPageDataSource;
            set {
                this.oPageDataSource = (value is IListSource) ? ((IListSource)value).GetList()
                                                              : (IList)value;
                this.CurrentPage = 1;
            }
        }
     
        [Category("Behavior"), Browsable(true), DefaultValue(false)]
        public bool Pagination { get; set; }

        [Category("Behavior"), Browsable(true), DefaultValue(10)]
        public int PageSize { get; set; } = 10;

        public CustomDGV() : base() {
            this.oAnimationManager = new AnimationManager() {
                Increment = 0.06,
                AnimationType = AnimationType.EaseInOut,
                InterruptAnimation = false
            };
            this.AnimationManager.OnAnimationProgress += sender => Invalidate();

            this.AllowUserToAddRows =
            this.AllowUserToDeleteRows =
            this.AllowUserToResizeRows =
            this.AllowUserToOrderColumns = false;
            this.AllowUserToResizeColumns = true;

            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.StandardTab = true;
            this.ReadOnly = true;
            this.EditMode = DataGridViewEditMode.EditProgrammatically;

            this.DataSourceChanged += this.OnDataSourceChanged;

            this.DoubleBuffered = true;

            SetStyle();
        }

        private void SetStyle() {
            HideOuterBorders = true;
            RowHeadersVisible = false;

            ColumnHeadersHeight = 48;
            RowTemplate.Height = 36;

            PaletteMode = PaletteMode.Custom;

            StateCommon.HeaderColumn.Content.Font = this.SkinManager.getFontByType(MaterialSkinManager.fontType.Subtitle1);
            StateCommon.DataCell.Content.Font = this.SkinManager.getFontByType(MaterialSkinManager.fontType.Body1);

            StateCommon.DataCell.Content.TextH =
            StateCommon.DataCell.Content.TextV =
            StateCommon.HeaderColumn.Content.TextH =
            StateCommon.HeaderColumn.Content.TextV = PaletteRelativeAlign.Center;
        }

        private void RefreshColors(System.Windows.Forms.Control oParent) {
            if (oParent.BackColor != this.ColorColsBack) {
                this.ColorColsBack = DrawHelper.BlendColor(oParent.BackColor, this.SkinManager.BackgroundAlternativeColor, this.SkinManager.BackgroundAlternativeColor.A);
                //this.ColorColsBack = oParent.BackColor;
                this.ColorFocusColsBack = DrawHelper.BlendColor(oParent.BackColor, this.SkinManager.BackgroundFocusColor, this.SkinManager.BackgroundFocusColor.A);
                this.ColorHoverColsBack = DrawHelper.BlendColor(oParent.BackColor, this.SkinManager.BackgroundHoverColor, this.SkinManager.BackgroundHoverColor.A);
            }
        }

        private void RefreshState() {
            StateCommon.HeaderColumn.Back.Color1 =
            StateCommon.HeaderColumn.Back.Color2 = bFocused ? ColorFocusColsBack :
                                                   bHover ? ColorHoverColsBack :
                                                   ColorColsBack;
        }

        private void RefreshTheme() {
            if (this.Parent != null)
                RefreshColors(this.Parent);

            StateCommon.Background.Color1 =
            StateCommon.Background.Color2 = this.SkinManager.BackdropColor;

            StateCommon.DataCell.Back.Color1 =
            StateCommon.DataCell.Back.Color2 = this.SkinManager.BackdropColor;

            StateSelected.DataCell.Back.Color1 =
            StateSelected.DataCell.Back.Color2 = this.SkinManager.BackgroundAlternativeColor;

            StateCommon.HeaderColumn.Border.Draw = InheritBool.False;

            StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Bottom;
            StateCommon.DataCell.Border.Color1 =
            StateCommon.DataCell.Border.Color2 = this.SkinManager.DividersColor;
            StateCommon.DataCell.Content.Color1 =
            StateCommon.DataCell.Content.Color2 = this.SkinManager.TextHighEmphasisColor;

            StateCommon.HeaderRow.Back.Color1 =
            StateCommon.HeaderRow.Back.Color2 = this.SkinManager.BackdropColor;
            StateCommon.HeaderRow.Border.Draw = InheritBool.False;

            StateCommon.HeaderColumn.Content.Color1 =
            StateCommon.HeaderColumn.Content.Color2 =
            StateCommon.HeaderRow.Content.Color1 =
            StateCommon.HeaderRow.Content.Color2 =
            StateCommon.DataCell.Content.Color1 =
            StateCommon.DataCell.Content.Color2 = this.SkinManager.TextHighEmphasisColor;

            RefreshState();
        }
        
        public void NextPage() {
            if (this.CurrentPage < (double)this.oPageDataSource.Count / (double)this.PageSize)
                this.CurrentPage++;
        }

        public void PreviousPage() {
            if (this.CurrentPage > 1)
                this.CurrentPage--;
        }

        public void AnimateIn() {
            this.bFocused = true;
            AnimationManager.StartNewAnimation(AnimationDirection.In);
            RefreshState();
        }

        public void AnimateOut() {
            this.bFocused = false;
            AnimationManager.StartNewAnimation(AnimationDirection.Out);
            RefreshState();
        }

        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if (this.Parent != null)
                RefreshTheme();
        }

        protected override void OnGotFocus(EventArgs e) {
            base.OnGotFocus(e);
            if (this.Enabled)
                AnimateIn();
        }

        protected override void OnLostFocus(EventArgs e) {
            base.OnLostFocus(e);
            if (!DisableLostFocusAnimation)
                AnimateOut();
        }

        protected override void OnMouseEnter(EventArgs e) {
            base.OnMouseEnter(e);
            if (this.Enabled) {
                this.bHover = true;
                RefreshState();
            }
        }

        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            this.bHover = false;
            RefreshState();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.FillRectangle(this.SkinManager.DividersAlternativeBrush, 0, this.ColumnHeadersHeight - 2, this.Width, 1);

            if (!this.oAnimationManager.IsAnimating()) {
                if (this.bFocused)
                    e.Graphics.FillRectangle(this.SkinManager.ColorScheme.AccentBrush, 0, this.ColumnHeadersHeight - 2, this.Width, 2);
            }
            else {
//              Animate - Got/Lost focus
                double dProgress = this.oAnimationManager.GetProgress();

//              Line animation
                int iLineWidth = (int)(this.Width * dProgress);
                int iLineX = (this.Width - iLineWidth) / 2;
                e.Graphics.FillRectangle(this.SkinManager.ColorScheme.AccentBrush, iLineX, this.ColumnHeadersHeight - 2, iLineWidth, 2);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            if (this.VerticalScrollingOffset + e.Y > this.ColumnHeadersHeight)
                base.OnMouseDown(e);
            else {
                CancelMouseEventArgs oArgs = new CancelMouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta);
                ColumnHeaderMouseClick(this, oArgs);

                if (!oArgs.Cancel && this.bSortable) {
                    DataGridViewColumn oNewColumn = this.Columns[GetColUnderMouse()];
                    DataGridViewColumn oOldColumn = this.SortedColumn;
                    ListSortDirection nDirection;

    //              If oOldColumn is null, then the DataGridView is not sorted.
                    if (oOldColumn == null)
                        nDirection = ListSortDirection.Ascending;
                    else {
    //                  Sort the same column again, reversing the SortOrder.
                        if (oOldColumn == oNewColumn && this.SortOrder == SortOrder.Ascending)
                            nDirection = ListSortDirection.Descending;
                        else {
    //                      Sort OnLostFocus new column and remove the old SortGlyph.
                            nDirection = ListSortDirection.Ascending;
                            oOldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                        }
                    }

                    try {
    //                  Sort the selected column.
                        this.Sort(oNewColumn, nDirection);
                        oNewColumn.HeaderCell.SortGlyphDirection = (SortOrder)nDirection + 1;
                    }
                    catch (InvalidOperationException oEx) {
                        if (!(oEx.InnerException is ArgumentException))
                            throw oEx;
                    }
                }

                int GetColUnderMouse() {
                    int iWidth = this.RowHeadersVisible ? this.RowHeadersWidth : 0;
                    int iColIndex = 0;
                    foreach (DataGridViewColumn oCol in this.Columns) {
                        if ((iWidth += oCol.Width) >= this.HorizontalScrollingOffset + e.X) 
                            return iColIndex; 
                        iColIndex++;
                    }

                    return -1;
                }
            }
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e) {
            base.OnDataBindingComplete(e);

//          Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn oCol in this.Columns)
                oCol.SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        private void OnDataSourceChanged(object sender, EventArgs e) {
            this.bSortable = this.DataSource is IBindingList && ((IBindingList)this.DataSource).SupportsSorting;
        }

        public class CancelMouseEventArgs : MouseEventArgs {
            public bool Cancel { get; set; } = false;

            public CancelMouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta) : 
                base(button, clicks, x, y, delta) {}
        }
    }
}
