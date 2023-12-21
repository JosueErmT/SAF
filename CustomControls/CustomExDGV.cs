using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAF.CustomControls {
    public class CustomExDGV : TableLayoutPanel, IMaterialControl {
        public delegate DataTable SourceQueryCallback(int iOffset, int iLimit, string sOrderBy);
        public delegate int TotalItemsCallback();
        public delegate void AddQueryCallback();
        public delegate void ModifyQueryCallback(DataGridViewRow oRow);
        public delegate List<DataGridViewRow> DeleteQueryCallback(List<DataGridViewRow> oRow);

        private int iLastItemsFit;
        private int iTotalPages;

        protected string sFirstIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAbZJREFUeNrs3TtOw0AARdEEgaB
            kSSwlrIwshSVRgiggSEaijz0e3ju3SpPEyZF/Y3l8OEiSJEmSJEmSJEmSJEmSJEmSNHHHkV92d//wdM37Pz/eX2f/Qy+/8fGynG+twF9XAh//AfDLsqzPMyzPrY
            3Y6rin5fUUyDdY1sddOv2uzYDzcKdBBrwd7hTIgLfF3R0Z8Pa4uyIDHoO7GzLgcbi7IAMeizscGfB43KHIgPfBtQ8uwD2PGMoEHIwLOBwXcDgu4HBcwOG4gMNxA
            YfjAg7HrQdOx60GbsCtBW7BrQRuwq0DbsOtAm7ErQFuxa0AbsaNB27HjQaGGwwMNxgYbjAw3OLz4NaigJe17LzBR09xM7c1GHLHJhpywT4YcsFBFuSCo+h25IrT
            pGbkmvPgVuSqgY5G5LqRrDbkyqHKJuTasegW5OqLDQ3I9VeT0pFdLgxHBhyODDgcGXA4MuBwZMDhyIDDkQGHIwPeF9kaHIxsttlgZLPNBiObbTYY2Wyzwchmmw1
            GNttsMLLZZoORzTYbjDzFTeOeAL4y8s+Tv/+AS5IkSZIkSZIkSZIkSZIkSZIkFfctwABSHla+xeGkNwAAAABJRU5ErkJggg==
        ");

        protected string sPrevIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAaNJREFUeNrs3UtOAlEURVGkMNp
            0CA6BIemIHAJMwdlp/EKkaVQ+Jrxz1k4q0CAksFK9e+vNZpIkSZIkSZIkSZIkSZIkSZIkaawur65vUn7LHOe3PWyQV/6GzLt3tbk+dhfkYFzIBbjDI09ov3A3L3
            c/fGQ5LRa372+vj4DzcIdGnuD+CXdY5Anu3g2FPME9qGGQJ7jZyBPcbOQ53Owu4B7V+uX56R4wXMBwAcMFDDceGG4wMNxgYLjBwHCDgeEGA8MNBoYbDAw3GBhuM
            DDcYGC4wcBwg4HhBgPDDQaGGwwMNxgY7mmz4R/e2Q2+b4fIt8Pkm7fLE3/1sCugUcCQC4AhFwBDLgCGXAAMuQAYcgEw5AJgyAXAkAuAIRcAQy4AhlwADLkAGHIB
            MOQCYMgFwJALgCEXAEMuAIZc8rTZZuSasdndTPR6VlbV86L/4U4++2H6uie+nxB5iE2JyjMbToA8zBpM7akrRyAPteNUfW7SAcjDLbDVn3y2B3LldmJMqYdT6nd
            kuMHIcIOR4UqSJEmSJEmSJEmSJEmSJEmSJB3VpwADALKYnE2cwkfaAAAAAElFTkSuQmCC
        ");

        protected string sNextIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAZxJREFUeNrs3V1Kw0AUhuFoK3r
            pElyCS6orcgl1C+5O8TcBva1NO8LM+Z4XQm5KSfNwaBOGZpokSZIkSZIkSZIkSZIkSZIkSVL7rq5vbp2Fv7sc+NgfZ+Q9wprTu5+3r58NcmFcyAG4kA+0GQl33u
            0OvOR+s93efX68P2MdDPgIXMijAq/AhTwa8Am4kEcBPgMXcu/ADXAh9wrcEBfyNPatyjXtUq+Tu5vgZdKWiVsmr/FbR05yl9/BkAN+RUMOuA6GXBwYcgAw5ABgy
            AHAkAOAIQcAQw4AhhwADDkAGHIAMOQAYMgBwJADgCEHAEMOAIYcAAw5ABhyAHA6csqy2dguEj7kPyym/+3p7fXlATBcwHABwwUMtzww3MLAcAsDwy0MDLcwMNzC
            wHALA8MtDAy3MDDcwsBwCwPDLQwMtzAw3MLAcAsDwy0MDLcwMNy2pSybjcRdSvi32VjcLoEbI0fjdgvcCDket2vgM5HhjgB8IjLckYBXIsMdOQ+nzEWGWxgZbmF
            kuJIkSZIkSZIkSZIkSZIkSZIkSd32LcAAe9KcTV09FbkAAAAASUVORK5CYII=
        ");

        protected string sLastIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAbFJREFUeNrs3UFOwlAUhlEkGh2
            6JJeCK5OluCSHGgcKSUkcKAFazLv/Pd+ICUnbk7bvkoauVpIkSZIkSZIkSZIkSZIkSZIkDdzNKBtyd//w+Pnx/lbhoO229WnO93f7+doR+GXa+ecCwF8zgf/tuN
            8OhLuZPpdArtJ6JNypzeFsVnHgX3AhpwAfwYVcHfgEXMhVgc/AhVwN+AJcyFWAZ+BCHh14AVzIowIviAu52hwMOQB4+tlxCzn4DIbc4BINucE9GHKDRRbkBqtoy
            A3GJMgN5mDI4cCQGwBDbgAMuQEw5AbAkBsAQ24ADLkBMOQGwJAbAENuAAy5ATDkBsCQGwBDbgCscOArPEx/aJv27wJruLm45YDhBgPDDQaGGwwMNxgYbjAw3GBg
            uMHAcIOB4QYDww0GhhsMDDcYGG4wMNxgYLjBwHCDgeEGA8MNBoYbDAy38RwMNwD4Cg+pwx3tDF4QGe6ol+gFkOGOfg+egQy3yiLrAmS41VbRZyDDrTomnYAMt/o
            cfAQZbgLwH8hwF2yIN4DvQfdv/v4BLkmSJEmSJEmSJEmSJEmSJEmSpPJ9CzAAUuBWvnWs3n4AAAAASUVORK5CYII=
        ");

        protected string sAddIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAOxJREFUeNrs3MENREAUgGFkhS6
            0stuZUnRCKcoYcbAaEAkjkpfvu7i95PmN4xQFAAAAAAAAAAAAuZRRFqmb9rs/xlzz1iWFeDeVbzw2gQVGYARGYARGYAQWGIERGIERGIERWGAERmAERmAERmAEFh
            iBERiBEZgrPrkH1k3bv7RLF2SPYV3SnGtY+UDgzbm55bcHnvyiERiBBUZgBEZgBEZgBBYYgREYgREYgRFYYKJy4/sBN74jMAIjMAIjsMAIjMAIjMAIjMAILDACI
            zACIzACI7DACIzACIzACIzAAgMAAAAAAAAAAACn/gIMAGFmE1M+EDAEAAAAAElFTkSuQmCC
        ");

        protected string sModifyIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAzpJREFUeNrs3U1u2kAYxnEojsK
            yyy6dG5Bdls0Jyg1KTsBRSk8A3TWrpCdodl2WG4QjsAzKV99RJxJtqIpnxtjz+P9IIytRbIf58Q4zTgy9HiGEEEKaSJ8uaDZHx8ORbd76L9f3m7slwPmjvrfNR2
            vjLdyXrK1dW/ti2DcA5wXrMOcedp846AuDXgPcftzSNlfWRhV3dUP2eSgywIer3O8BuNHIALcfNwoZ4Dxwg5EBzgc3CBngvHArIwOcH24l5P6BHvAoM6egK0oHx
            N0buahpvTf1i/ky00K88J13KNylb5OK+438OU//9QODxLifbPPV2lnv9SW4bHCtIhYHxnVVeDkoijLgGO9sv/7T48NNbUN0A0OTGu5663jzgEp2+5/sGqqTVLA9
            g36Am+b10yrxW0AlD61tdlXxm0TDMrgJJ0f2fTcHWFQ85ofkQ7SfUN2CW88atupwbcfsp67gKbj14EZUclLgMbjVgGP+ttsEcAlupUz8sLvvOUNm1GknWeDWgxy
            AuwS4edy9kAMrN/2FDvtFnsGNysJPpFIMy+5Cx6qrFdxG3FeVHIE724XblQpuK+4flfwCnnrppQ6cA25M/ruuVh6iO4+rDAyuMDC4wsDgCgODKwwMrjAwuMLA4A
            oDgysMDK4wMLjCwOAKA4MrDAyuMDC4wsDgCgODKwwMrjAwuMLA4CoDg7vzMU66cqGjq7jzzgGDq1/B4IoDg6v+GgwuwJ3HBVgcF2BxXIDFcQEWxwVYHBdgcVyAx
            XEBFscFWBwXYHFcgMVxARbHBVgcF2BxXIDFcQEWxwVYHBdgcVyXIkeJXR8f00TajksFi+MCLI4LsDguwOK4AIvjAiyOC7A4LsDiuACL47oULevUZ55aVDABmAAM
            MAGYAEwAJgATgAnAABOA/8qKLqw9qyaBr+n/2hPVx1H/X3x0PCxtc4tBrTm539wFV/Eg5sxPjw/rQVG4924+w6GWzAz3srEK3qrkn7083uI3pywN97Qts+jz3u9
            7e0giXN+n7VgmuRu2/LNthk2SYfk01SezJL+Jy0+8ptbG1kq89l4Kudny55gJFSGEEEIIIYQQQgghhBBCCCGEbOWXAAMAzU2hjua2lmAAAAAASUVORK5CYII=
        ");

        protected string sDeleteIcon = (@"
            iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAYxJREFUeNrs3cFRwkAYgFEicfR
            oCdCB3DxqB3ZiK1gGN0ugA+1AS+AIg4obJwecwRkOYZf8eW+GgROQ/diwSQ4ZjQAAAAAAAOA/VR+/9OXV9X2Jz91u1kuB8wTeFQrcu/G6sBOLTWCB6bM6ygIoyu
            Ku64VcdYJB2Jk357OQs4v2H4zACIzACIzACCwwYWS5/OXs1mE5Lj+awXbRCIzACIzACIzAAhNG3ccvfewZoGPPoHX9fmYwAiMwAiOwwAiMwAiMwAiMwAIjMAIjM
            AIjMAILjMAIjMAIjMAIjMACIzACIzACIzACC4zACIzACIzACCwwAiMw58htdQpyWx0ERmCBERiBERiBERiBEVjgTn0Y6jJjkivwi55lxiTX1aRJenrX9I/pdrM+
            +Swe59iS76/P1biub9LLO11/zVPcRZgZvDeTX9PT7cDjvqW4s6ir6IdmA4cctx2DmIdJ6Ze7an+984HulmfNGOT80KrU1rYLr6f0eEyPSeBDoWa1/JxjQQUAAAA
            AAACw50eAAQBNgk67RBIdHAAAAABJRU5ErkJggg==
        ");

        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public override Color BackColor {
            set => RefreshTheme();
        }

        [Category("Inner controls"), Browsable(true)]
        public CustomDGV Dgv { get; set; } = new CustomDGV();
        [Category("Inner controls"), Browsable(true)]
        public CustomTLP Tlp { get; set; } = new CustomTLP();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnFirst { get; set; } = new MaterialButton();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnPrev { get; set; } = new MaterialButton();
        [Category("Inner controls"), Browsable(true)]
        public TextBox TxtCurPage { get; set; } = new TextBox();
        [Category("Inner controls"), Browsable(true)]
        public TextBox TxtTotalPages { get; set; } = new TextBox();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnNext { get; set; } = new MaterialButton();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnLast { get; set; } = new MaterialButton();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnAdd { get; set; } = new MaterialButton();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnModify { get; set; } = new MaterialButton();
        [Category("Inner controls"), Browsable(true)]
        public MaterialButton BtnDelete { get; set; } = new MaterialButton();

        private float iControlsHeight = 34;
        [Category("Appearance"), Browsable(true), DefaultValue(34)]
        public float ControlsHeight {
            get => this.iControlsHeight;
            set {
                this.iControlsHeight = value;
                this.ArrangeLayout();
            }
        }

        private float iControlButtonsWidth = 48;
        [Category("Appearance"), Browsable(true), DefaultValue(48)]
        public float ControlButtonsWidth {
            get => this.iControlButtonsWidth;
            set {
                this.iControlButtonsWidth = value;
                this.ArrangeLayout();
            }
        }

        [Browsable(false)]
        public string OrderBy { get; set; } = "";

        [Browsable(false)]
        public int ItemsFit => this.Dgv.ItemsFit;

        [Browsable(false)]
        public int PageSize { get; private set; } = 10;
                
        [Category("Behavior"), Browsable(true), DefaultValue(false)]
        public bool AutoFill { get; set; } = false;

        private int iCurrentPage = 1;
        [Category("Behavior"), Browsable(true), DefaultValue(0)]
        public int CurrentPage {
            get => this.iCurrentPage;
            set {
                this.TxtCurPage.Text = value.ToString();
                if (this.iCurrentPage != value) {
                    this.iCurrentPage = value;
                    Fill();
                }
            }
        }

        private TotalItemsCallback fTotalItemsQuery;
        [Category("Behavior"), Browsable(true)]
        public TotalItemsCallback TotalItemsQuery { 
            get => fTotalItemsQuery; 
            set {
                this.fTotalItemsQuery = value;
                if (this.Visible && value != null)
                    GetTotalPages();
            }
        }

        private SourceQueryCallback fSourceQuery;
        [Category("Behavior"), Browsable(true)]
        public SourceQueryCallback SourceQuery {
            get => this.fSourceQuery; 
            set {
                this.fSourceQuery = value;
                if (this.Visible)
                    Fill();
            }
        }
                
        private AddQueryCallback fAddQuery;
        [Category("Behavior"), Browsable(true)]
        public AddQueryCallback AddQuery {
            get => this.fAddQuery; 
            set {
                this.fAddQuery = value;
                ArrangeButtons();
            }
        }
        
        private ModifyQueryCallback fModifyQuery;
        [Category("Behavior"), Browsable(true)]
        public ModifyQueryCallback ModifyQuery {
            get => this.fModifyQuery; 
            set {
                this.fModifyQuery = value;
                ArrangeButtons();
            }
        }

        private DeleteQueryCallback fDeleteQuery;
        [Category("Behavior"), Browsable(true)]
        public DeleteQueryCallback DeleteQuery {
            get => this.fDeleteQuery; 
            set {
                this.fDeleteQuery = value;
                ArrangeButtons();
            }
        }

        public CustomExDGV() : base() {
            this.SuspendLayout();

            this.Controls.Add(this.Dgv, 0, 0);
            this.Controls.Add(this.Tlp, 0, 1);

            this.ColumnCount = 1;
            this.RowCount = 2;

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RowStyles.Add(new RowStyle(SizeType.Absolute, this.ControlsHeight));

            this.BackColor = Color.Transparent;

            this.Tlp.Dock = DockStyle.Fill;
            this.Tlp.Margin = new Padding(0);
            this.Tlp.Padding = new Padding(0);

            this.Tlp.Controls.Add(this.BtnFirst, 0, 0);
            this.Tlp.Controls.Add(this.BtnPrev, 1, 0);
            this.Tlp.Controls.Add(this.TxtCurPage, 2, 0);
            this.Tlp.Controls.Add(this.TxtTotalPages, 3, 0);
            this.Tlp.Controls.Add(this.BtnNext, 4, 0);
            this.Tlp.Controls.Add(this.BtnLast, 5, 0);
            
            this.Tlp.ColumnCount = 6;
            this.Tlp.RowCount = 1;

            this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.Tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            this.Dgv.Name = "DGV";
            this.Dgv.Dock = DockStyle.Fill;
            this.Dgv.DisableLostFocusAnimation = true;
            this.Dgv.ScrollBars = ScrollBars.None;
            this.Dgv.Margin = new Padding(0);
            this.Dgv.TabIndex = 1;

            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Dock = DockStyle.Fill;
            this.BtnFirst.Margin = new Padding(0);
            this.BtnFirst.CornerRadius = 0;
            this.BtnFirst.HighEmphasis = false;
            this.BtnFirst.DrawShadows = false;
            this.BtnFirst.Icon = sFirstIcon.ImageFromBase64();
            this.BtnFirst.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnFirst.IconAutoSize = true;
            this.BtnFirst.IconAutoSizePercentage = 73D;
            this.BtnFirst.IconTransparency = 85D;
            this.BtnFirst.IconColor = MaterialButton.MaterialIconColor.BackgroundBased;
            this.BtnFirst.TabIndex = 2;

            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Dock = DockStyle.Fill;
            this.BtnPrev.Margin = new Padding(0);
            this.BtnPrev.CornerRadius = 0;
            this.BtnPrev.HighEmphasis = false;
            this.BtnPrev.DrawShadows = false;
            this.BtnPrev.Icon = sPrevIcon.ImageFromBase64();
            this.BtnPrev.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnPrev.IconAutoSize = true;
            this.BtnPrev.IconAutoSizePercentage = 73D;
            this.BtnPrev.IconTransparency = 85D;
            this.BtnPrev.IconColor = MaterialButton.MaterialIconColor.BackgroundBased;
            this.BtnPrev.TabIndex = 3;

            this.TxtCurPage.Name = "TxtCurPage";
            this.TxtCurPage.Text = "1";
            this.TxtCurPage.Font = this.BtnPrev.Font;
            this.TxtCurPage.Anchor = (AnchorStyles)12;
            this.TxtCurPage.Margin = new Padding(0, 2, 0, 0);
            this.TxtCurPage.BorderStyle = BorderStyle.None;
            this.TxtCurPage.TextAlign = HorizontalAlignment.Right;
            this.TxtCurPage.TabIndex = 4;

            this.TxtTotalPages.Name = "TxtTotalPages";
            this.TxtTotalPages.Text = "";
            this.TxtTotalPages.Anchor = (AnchorStyles)12;
            this.TxtTotalPages.Margin = new Padding(0, 2, 0, 0);
            this.TxtTotalPages.BorderStyle = BorderStyle.None;
            this.TxtTotalPages.TextAlign = HorizontalAlignment.Left;
            this.TxtTotalPages.ReadOnly = true;
            this.TxtTotalPages.TabStop = false;
            this.TxtTotalPages.TabIndex = 0;

            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Dock = DockStyle.Fill;
            this.BtnNext.Margin = new Padding(0);
            this.BtnNext.CornerRadius = 0;
            this.BtnNext.HighEmphasis = false;
            this.BtnNext.DrawShadows = false;
            this.BtnNext.Icon = sNextIcon.ImageFromBase64();
            this.BtnNext.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnNext.IconAutoSize = true;
            this.BtnNext.IconAutoSizePercentage = 73D;
            this.BtnNext.IconTransparency = 85D;
            this.BtnNext.IconColor = MaterialButton.MaterialIconColor.BackgroundBased;
            this.BtnNext.TabIndex = 5;

            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Dock = DockStyle.Fill;
            this.BtnLast.Margin = new Padding(0);
            this.BtnLast.CornerRadius = 0;
            this.BtnLast.HighEmphasis = false;
            this.BtnLast.DrawShadows = false;
            this.BtnLast.Icon = sLastIcon.ImageFromBase64();
            this.BtnLast.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnLast.IconAutoSize = true;
            this.BtnLast.IconAutoSizePercentage = 73D;
            this.BtnLast.IconTransparency = 85D;
            this.BtnLast.IconColor = MaterialButton.MaterialIconColor.BackgroundBased;
            this.BtnLast.TabIndex = 6;

            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Dock = DockStyle.Fill;
            this.BtnAdd.Margin = new Padding(2, 2, 0, 2);
            this.BtnAdd.CornerRadius = 3;
            this.BtnAdd.UseAccentColor = true;
            this.BtnAdd.Icon = sAddIcon.ImageFromBase64();
            this.BtnAdd.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnAdd.IconAutoSize = true;
            this.BtnAdd.IconAutoSizePercentage = 75D;
            this.BtnAdd.IconTransparency = 85D;
            this.BtnAdd.TabIndex = 7;

            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Dock = DockStyle.Fill;
            this.BtnModify.CornerRadius = 3;
            this.BtnModify.Margin = new Padding(2, 2, 0, 2);
            this.BtnModify.Icon = sModifyIcon.ImageFromBase64();
            this.BtnModify.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnModify.IconAutoSize = true;
            this.BtnModify.IconAutoSizePercentage = 75D;
            this.BtnModify.IconTransparency = 85D;
            this.BtnModify.TabIndex = 8;

            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Dock = DockStyle.Fill;
            this.BtnDelete.CornerRadius = 3;
            this.BtnDelete.Margin = new Padding(2);
            this.BtnDelete.MaterialBackColor = MaterialSkinManager.Colors.BackgroundHoverRedColor;
            this.BtnDelete.Icon = sDeleteIcon.ImageFromBase64();
            this.BtnDelete.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnDelete.IconAutoSize = true;
            this.BtnDelete.IconAutoSizePercentage = 75D;
            this.BtnDelete.IconTransparency = 85D;
            this.BtnDelete.TabIndex = 9;

            this.RefreshTheme();

            this.ResumeLayout();

            this.Dgv.SelectionChanged += (sender, e) => {
                DataGridView oCtrl = sender as DataGridView;
                if (oCtrl != null) {
                    IList<DataGridViewRow> rSelRows = oCtrl.SelectedCells.Cast<DataGridViewCell>().Select(i => oCtrl.Rows[i.RowIndex]).Distinct().ToList();
                    if (rSelRows.Count > 0) {
                        this.BtnModify.Enabled = rSelRows.Count == 1;
                        this.BtnDelete.Enabled = true;
                    }
                    else {
                        this.BtnModify.Enabled =
                        this.BtnDelete.Enabled = false;
                    }
                }
            };

            this.Dgv.ColumnHeaderMouseClick += (sender, e) => {
                int iColIndex = GetColUnderMouse();
                if (iColIndex < 0)
                    return;

                DataGridViewColumn oNewColumn = this.Dgv.Columns[iColIndex];
                ListSortDirection nDirection;
                nDirection = ListSortDirection.Ascending;

                string sOrderBy = "`" + oNewColumn.HeaderText + "`";
                if (this.OrderBy != null) {
                    string[] rOrderBy = this.OrderBy.Split('`');
                    nDirection = rOrderBy.Length >= 2 && rOrderBy[1] == oNewColumn.HeaderText && rOrderBy[2] == " ASC"
                               ? ListSortDirection.Descending : ListSortDirection.Ascending;
                }
                this.OrderBy = sOrderBy + (nDirection == ListSortDirection.Ascending ? " ASC" : " DESC");

                Fill();
                oNewColumn = this.Dgv.Columns[iColIndex];
                oNewColumn.HeaderCell.SortGlyphDirection = (SortOrder)nDirection + 1;

                int GetColUnderMouse() {
                    int iWidth = this.Dgv.RowHeadersVisible ? this.Dgv.RowHeadersWidth : 0;
                    int iColIndex2 = 0;
                    foreach (DataGridViewColumn oCol in this.Dgv.Columns) {
                        if ((iWidth += oCol.Width) >= this.Dgv.HorizontalScrollingOffset + e.X)
                            return iColIndex2;
                        iColIndex2++;
                    }

                    return -1;
                }
            };

            this.BtnFirst.Click += (sender, e) => {
                this.CurrentPage = 1;
            };

            this.BtnPrev.Click += (sender, e) => {
                if (this.CurrentPage > 1)
                    this.CurrentPage--;
            };

            this.TxtCurPage.KeyPress += (sender, e) => {
                TextBox oCtrl = sender as TextBox;
                if (oCtrl != null) {
                    if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || 
                                                       e.KeyChar == '0' && oCtrl.SelectionStart <= 0 || 
                                                       oCtrl.Text.Length >= oCtrl.MaxLength && oCtrl.SelectionLength <= 0))
                        e.Handled = true;
                    else if (e.KeyChar == 13) {
                        CheckCurPage();
                        e.Handled = true;
                    }
                }
            };

            this.TxtTotalPages.GotFocus += (sender, e) => {
                this.TxtCurPage.Select();
                this.TxtCurPage.SelectionStart = this.TxtCurPage.TextLength;
            };

            this.BtnNext.Click += (sender, e) => {
                if (this.iTotalPages == 0 || this.CurrentPage < this.iTotalPages)
                    this.CurrentPage++;
            };

            this.BtnLast.Click += (sender, e) => {
                this.CurrentPage = (this.TotalItemsQuery != null) ? this.iTotalPages : 10;
            };

            this.BtnAdd.Click += (sender, e) => {
                this.AddQuery();
            };

            this.BtnModify.Click += (sender, e) => {
                if (this.Dgv.SelectedRows.Count == 1)
                    this.ModifyQuery(this.Dgv.SelectedRows[0]);
            };

            this.BtnDelete.Click += (sender, e) => {
                IList<DataGridViewRow> rSelRows = this.Dgv.SelectedCells.Cast<DataGridViewCell>().Select(i => this.Dgv.Rows[i.RowIndex]).Distinct().ToList();
                if (rSelRows.Count > 0) {
                    foreach (DataGridViewRow oRow in this.DeleteQuery(rSelRows.Cast<DataGridViewRow>().ToList()))
                        this.Dgv.Rows.Remove(oRow);

                    //this.CheckRows();
                    this.Dgv.ClearSelection();
                }
            };

            this.BtnFirst.GotFocus += OnGotFocus;
            this.BtnPrev.GotFocus += OnGotFocus;
            this.TxtCurPage.GotFocus += OnGotFocus;
            this.BtnNext.GotFocus += OnGotFocus;
            this.BtnLast.GotFocus += OnGotFocus;
            this.BtnAdd.GotFocus += OnGotFocus;
            this.BtnModify.GotFocus += OnGotFocus;
            this.BtnDelete.GotFocus += OnGotFocus;
            void OnGotFocus(object sender, EventArgs e) {
                if (!this.Dgv.AnimationManager.IsAnimating())
                    this.Dgv.AnimateIn();
            }

            this.Dgv.LostFocus += OnLostFocus;
            this.BtnFirst.LostFocus += OnLostFocus;
            this.BtnPrev.LostFocus += OnLostFocus;
            this.TxtCurPage.LostFocus += OnLostFocus;
            this.TxtCurPage.LostFocus += (sender, e) => CheckCurPage();
            this.BtnNext.LostFocus += OnLostFocus;
            this.BtnLast.LostFocus += OnLostFocus;
            this.BtnAdd.LostFocus += OnLostFocus;
            this.BtnModify.LostFocus += OnLostFocus;
            this.BtnDelete.LostFocus += OnLostFocus;
            void OnLostFocus(object sender, EventArgs e) {
                if (!this.ContainsFocus) {
                    this.Dgv.AnimateOut();
                    this.Dgv.ClearSelection();
                }
            }

            this.iLastItemsFit = this.ItemsFit;
        }

        public void Fill() {
            if (this.SourceQuery == null)
                return;

            List<int> rSelectedRows = this.Dgv.SelectedRows.Cast<DataGridViewRow>().Select(i => i.Index).ToList();

            int iFirstItem = (this.CurrentPage - 1) * this.ItemsFit;
            this.Dgv.DataSource = this.SourceQuery(iFirstItem, this.ItemsFit, this.OrderBy);
            GetTotalPages();

            this.Dgv.ClearSelection();
            foreach (int iRow in rSelectedRows) {
                if (iRow >= this.Dgv.Rows.Count)
                    break;
                this.Dgv.Rows[iRow].Selected = true;
            }
        }
        
        public int GetTotalPages() {
            if (this.TotalItemsQuery == null)
                return 0;

            this.iTotalPages = (int)Math.Ceiling((double)this.TotalItemsQuery() / (double)this.ItemsFit);
            this.TxtTotalPages.Text = "/" + iTotalPages;
            this.TxtCurPage.MaxLength = iTotalPages > 0 ? (int)Math.Floor(Math.Log10(iTotalPages)) + 1 : 0;
            return this.iTotalPages;
        }

        public bool CheckCurPage() {
            bool bSuccess = false;
            int iPage;

            if (!int.TryParse(this.TxtCurPage.Text, out iPage))
                iPage = 1;
            else {
                if (iPage < 1)
                    iPage = 1;
                else if (this.iTotalPages != 0 && iPage > this.iTotalPages)
                    iPage = this.iTotalPages;
                else
                    bSuccess = true;
            }
            
            this.CurrentPage = iPage;
            return bSuccess;
        }

        public void CheckRows() {
            if (this.ItemsFit >= this.iLastItemsFit)
                Fill();
            else for (int i = this.Dgv.RowCount - 1; i > this.ItemsFit - 1; i--)
                this.Dgv.Rows.RemoveAt(i);

            this.iLastItemsFit = this.ItemsFit;
        }

        protected void ArrangeLayout() {
            this.RowStyles[1].Height = this.ControlsHeight;

            foreach (ColumnStyle oStyle in this.Tlp.ColumnStyles)
                if (oStyle.SizeType == SizeType.Absolute)
                    oStyle.Width = this.ControlButtonsWidth;
        }
        
        protected void ArrangeButtons() {
            TableLayoutPanelCellPosition oCurCell = new TableLayoutPanelCellPosition(6, 0);

            if (this.AddQuery != null) {
                this.Tlp.Controls.Add(this.BtnAdd, oCurCell.Column, oCurCell.Row);
                oCurCell.Column++;

                if (this.ModifyQuery == null && this.DeleteQuery == null)
                    this.BtnAdd.Margin = new Padding(2);
            }
            if (this.ModifyQuery != null) {
                this.Tlp.Controls.Add(this.BtnModify, oCurCell.Column, oCurCell.Row);
                oCurCell.Column++;

                if (this.DeleteQuery == null) {
                    this.BtnAdd.Margin = new Padding(2, 2, 0, 2);
                    this.BtnModify.Margin = new Padding(2);
                }
            }
            if (this.DeleteQuery != null) {
                this.Tlp.Controls.Add(this.BtnDelete, oCurCell.Column, oCurCell.Row);
                oCurCell.Column++;

                this.BtnAdd.Margin = new Padding(2, 2, 0, 2);
                this.BtnModify.Margin = new Padding(2, 2, 0, 2);
            }

            for (int i = this.Tlp.ColumnCount; i < oCurCell.Column; i++) {
                this.Tlp.ColumnCount++;
                this.Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            }

            for (int i = this.Tlp.ColumnCount - 1; i > oCurCell.Column; i--)
                this.Tlp.ColumnStyles.RemoveAt(i);
        }

        protected void RefreshTheme() {
            this.Dgv.BackColor = this.BackColor;

            this.TxtCurPage.BackColor =
            this.TxtTotalPages.BackColor = SkinManager.BackdropColor;
            this.BtnFirst.MaterialBackColor =
            this.BtnPrev.MaterialBackColor =
            this.BtnNext.MaterialBackColor =
            this.BtnLast.MaterialBackColor =
            this.Tlp.MaterialBackColor = MaterialSkinManager.Colors.BackdropColor;
        }

        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if (this.Parent != null)
                RefreshTheme();
        }

        protected override void OnCreateControl() {
            base.OnCreateControl();
            
            Form oForm;
            if ((oForm = this.FindForm()) != null)
                oForm.ResizeEnd += (sender, e) => this.CheckRows();
        }

        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);

            if (this.Visible) {
                this.ArrangeLayout();
                if (this.AutoFill)
                    this.Fill();
                this.GetTotalPages();
                this.Dgv.ClearSelection();
            }
        }
    }
}
