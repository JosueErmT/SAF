using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace SAF.CustomControls {
    public class CustomExDGV : TableLayoutPanel {
        public delegate DataTable SourceQueryCallback(int iOffset, int iLimit);
        public delegate int TotalItemsCallback();

        protected string sFirstIcon = (
            "iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAbZJREFUeNrs3TtOw0AARdEEgaBkSSwlrIwshSVRgiggSEaijz0e3ju3SpPEyZF/Y3l8OEiSJEmSJEmSJEmSJEmSJEmSNHHHkV92d//wdM37Pz/eX2f/Qy+/8fGynG+twF9XAh//AfDLsqzPMyzPrY3Y6rin5fUUyDdY1sddOv2uzYDzcKdBBrwd7hTIgLfF3R0Z8Pa4uyIDHoO7GzLgcbi7IAMeizscGfB43KHIgPfBtQ8uwD2PGMoEHIwLOBwXcDgu4HBcwOG4gMNxAYfjAg7HrQdOx60GbsCtBW7BrQRuwq0DbsOtAm7ErQFuxa0AbsaNB27HjQaGGwwMNxgYbjAw3OLz4NaigJe17LzBR09xM7c1GHLHJhpywT4YcsFBFuSCo+h25IrTpGbkmvPgVuSqgY5G5LqRrDbkyqHKJuTasegW5OqLDQ3I9VeT0pFdLgxHBhyODDgcGXA4MuBwZMDhyIDDkQGHIwPeF9kaHIxsttlgZLPNBiObbTYY2Wyzwchmmw1GNttsMLLZZoORzTYbjDzFTeOeAL4y8s+Tv/+AS5IkSZIkSZIkSZIkSZIkSZIkFfctwABSHla+xeGkNwAAAABJRU5ErkJggg=="
            //"iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAnZJREFUeNrs3f1N21AUhnGnE2S" +
            //"EjMAIGaEjMAIj0AkygkfoCHSDdIOwgdkgTVpbQgJEg+/1xzm/Rzp/RQbrPrrw5lWu0zQAAAAAAAAAMDubL163vczdjdf8vsyLJf+QXT9XnvuZnKvY9jLnL07b/w" +
            //"z8Y9+vSffOWnX9a/sp5R5HyB3mSPLfnfpzaRvjUEDuMIekYrcj1rH6xugKCu4Sin0ssIZVJZ8LTxbuL3MquG4twcsJUMcK63Z+lbYJnoHr28enSmKr7mKCP0/Gb" +
            //"WWxw5wIXl+Amn39CH7LwwxiCZ6A74WTMcELSsZPM4sleAHVIsEJqkWCJWOCI1SLBCeoFgkOXi0SHLxaJFiAInjt1SLBwatFgoNXiwQHrxYJDl4tEiwZE7zmapHg" +
            //"4NUiwcGrRYKDV4sEC1D5BD8QG1NwxGqR4ODVYmrBGarFlIIzVYvpBEvGEwje3CgYy+G/3H2zTrEhmGAQDIJBMAgGwSCYYBAMgkEwCAbBIJhgEAyCQTAIRgzBPxr" +
            //"fZbgofPDdB99HHV1x9tfhM9M4PkrwGgQP3DfOL3mEA8HrFiyIJXuM0k4Q8yA0ggMIfh3EPMowsOCBbEEsneBs1WdKwZkSd2rBGapPgoNXnwQHrz4JDl59Ehw8iB" +
            //"EcvPokOHj1SXDw6pPg4NUnwcGrT4KDJ26Cg1efBAevPgkOXn0SHLz6JDhwEDsRHLv6PBAcu/rcERy3+mxr3WjJENE1+SgRxI59qKtCycru0ORkTPVZVe5wcyX+p" +
            //"1S/0YCJu51qzbYj3wq05L4JYu0Hf7q7/rX9mF+wGSH67sZrfvH56a4e0vFzPwAAAAAAAAAQgT8CDAAkCqhMncOkxQAAAABJRU5ErkJggg=="
        );
        protected string sPrevIcon = (
            "iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAaNJREFUeNrs3UtOAlEURVGkMNp0CA6BIemIHAJMwdlp/EKkaVQ+Jrxz1k4q0CAksFK9e+vNZpIkSZIkSZIkSZIkSZIkSZIkaawur65vUn7LHOe3PWyQV/6GzLt3tbk+dhfkYFzIBbjDI09ov3A3L3c/fGQ5LRa372+vj4DzcIdGnuD+CXdY5Anu3g2FPME9qGGQJ7jZyBPcbOQ53Owu4B7V+uX56R4wXMBwAcMFDDceGG4wMNxgYLjBwHCDgeEGA8MNBoYbDAw3GBhuMDDcYGC4wcBwg4HhBgPDDQaGGwwMNxgY7mmz4R/e2Q2+b4fIt8Pkm7fLE3/1sCugUcCQC4AhFwBDLgCGXAAMuQAYcgEw5AJgyAXAkAuAIRcAQy4AhlwADLkAGHIBMOQCYMgFwJALgCEXAEMuAIZc8rTZZuSasdndTPR6VlbV86L/4U4++2H6uie+nxB5iE2JyjMbToA8zBpM7akrRyAPteNUfW7SAcjDLbDVn3y2B3LldmJMqYdT6ndkuMHIcIOR4UqSJEmSJEmSJEmSJEmSJEmSJB3VpwADALKYnE2cwkfaAAAAAElFTkSuQmCC"
            //"iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAjBJREFUeNrs3cFNA0EQRFGDjSAMh+CQIDI7BbIDYTC7kk9IcEBM91D/t9TaPexl9mmuVZuN8ydzd/9wXNc/kYt7ua7IwbgiA3CnQt7K9Hvc5fH4wyeH7W63/3g/PwuchzsNssDjcKdAFngsbjuywONxW5EFrsFtQxa4DrcFWeBa3HJkgetxS5EF7sEtQ76Vsw23ZG4kbcU9vb2+PAksrsDiCozDxQOn46KBCbhYYAouEpiEiwOm4aKAibgYYCouApiMGw9Mx40GFjcYWNxgYHGDgcUNBhY3GFjcYGBxg4HFDQYWNxhY3GBgcYOBxQ0GFjcYWNxgYHGDgcUNBhY3GFjcYGBxg4HFDQYWNxhY3GBgcYOBxQ0GFjcYWNxgYHGDgcUNBhY3GFjcYGBxg4HF7R/TZsNnaF70moO85iEvr4ei80xRRoUBFhkALDIAWGQAsMgAYJEBwCIDgEUGAIsMABYZACwyAFhkALDIAGCRAcAiA4BFBgCLDAAWGQAsMgBYZACwyABgkQHAIgOARQYAiwwAFhkALDIAWGQAsMgAYJEBwCIDgEUGAIsMABYZAExHRgCTkTHAVGQUMBEZB0xDRgKTkLHAFGQ0MAEZD5yOLHA4ssDhyKbNfplrHPEp5Tze4N6bPDzfWuA+5JLwcoF7kMuS6QWuRy6tHRC4Frm8U0LgOuSWwhCBa5Db2mAEHo/cWvUj8Fhke5z+86zFX8tevtmjfygXWdxgZHGDkafD/RRgACA972QT2PWQAAAAAElFTkSuQmCC"
            //"iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAoJJREFUeNrs3dFN40AYRWGz2gI" +
            //"owSXsdhA62BKyHVACHURUkBIoATrwdhA6yHawa0u2hBB5QNjx+M53pP8pD0hzNJPLlT1pGgAAAAAAAABYnRtLsArtOAOv42Dj7Po59nPu59+7OY+f7SzTNnfr0w" +
            //"dSL80g+taylc8g6fAJsW+nI7lssQ8XjmKSN86+n9MXxb4/rlFIgOpmFPt2Wsu7Hj/6eV5IrF28cjI+Lix2mpPl3l6A+uzgCtyvIJbgK/Br5mRMcEHJ+HllsQQvF" +
            //"KCeChFL8MwB6lCYWII3nIwJvgL7AgIUwQsFqG4DYgkusFokOLxaJFiAInjr1SLB4dUiweHVIsHh1SLB4dUiwZIxwVuuFgkOrxYJDq8WCQ6vFgkWoOoTfE9spuDE" +
            //"apHg8GqxasE1VItVCq6pWqxKsGQcLLjWajFecO3VYqzgVjIuS/D3BXpjF4cUxDdys5nrKsNulIzCPM2xg/fkZu9gu7dgT18VfDsWGAg9ou3cSlI0CAbBKC5FC1n" +
            //"hIetvP3+sf/YR/WgZc4/oCWVH6BE98Xs8rhGaoofv4TuSs/9NGiT/7OfFsuazazyy46E7k/Nc9EPjsVkPvpucV1e8++vlM7N1wRNeH63kBfC9IOYKB4JDEMQquU" +
            //"apFcRchEZwELVWn9VRWxCrEtcJV0INiRuNK/2rwY9yVJS4/axOBUEsIXEjPIghvPpEePWJ8OoT4dUnwqtPhCduhFefCK8+EV59Irz6RHAQO1nudUUvHcQOlrmMx" +
            //"L1U9dla3rKC2JyJ+2hJy2SOINY1fiKh+MR9IFfi/uhYJnejQex44eg+j5/t5v6jN9Z9tV09pePXcQAAAAAAAAAglf8CDAA5C/4v/hkLmgAAAABJRU5ErkJggg=="
        );
        protected string sNextIcon = (
            "iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAZxJREFUeNrs3V1Kw0AUhuFoK3rpElyCS6orcgl1C+5O8TcBva1NO8LM+Z4XQm5KSfNwaBOGZpokSZIkSZIkSZIkSZIkSZIkSVL7rq5vbp2Fv7sc+NgfZ+Q9wprTu5+3r58NcmFcyAG4kA+0GQl33u0OvOR+s93efX68P2MdDPgIXMijAq/AhTwa8Am4kEcBPgMXcu/ADXAh9wrcEBfyNPatyjXtUq+Tu5vgZdKWiVsmr/FbR05yl9/BkAN+RUMOuA6GXBwYcgAw5ABgyAHAkAOAIQcAQw4AhhwADDkAGHIAMOQAYMgBwJADgCEHAEMOAIYcAAw5ABhyAHA6csqy2dguEj7kPyym/+3p7fXlATBcwHABwwUMtzww3MLAcAsDwy0MDLcwMNzCwHALA8MtDAy3MDDcwsBwCwPDLQwMtzAw3MLAcAsDwy0MDLcwMNy2pSybjcRdSvi32VjcLoEbI0fjdgvcCDket2vgM5HhjgB8IjLckYBXIsMdOQ+nzEWGWxgZbmFkuJIkSZIkSZIkSZIkSZIkSZIkSd32LcAAe9KcTV09FbkAAAAASUVORK5CYII="
            //"iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAmpJREFUeNrs3X1t21AYhXFnCDI" +
            //"GgdAxyBgMQsdgEMZgGgJDGISOQcsgZZAy8BzpVrKmTlpVp7bP+3uk968qVuVH9/b0xB9dBwAAAAAAAACLs7vy8Q9tLjy2wcY5jtOPcx5n+GvO7WdHp2l77Ju84T" +
            //"/n12R1YwNy718hdzo/2ucRKHe6dX8nep30b5Q7ndM4t07pejjMKHc694JY3up9ae7GuXGal+N0ZcHP00vcyzC84whi4YKnor859bmCp4n7CwW5gqdBTOIOFqz6L" +
            //"CJY9VlEsMRdQLDqs4hg1WcRwarPIoJVn0UEC2IFBKs+iwhWfRYRrPosIlj1WUSw6rOI4NKJeyg25arPoeiUqT6H4hNffQ4mu/okNzyIERtefRIaXn0SGV59Ehhe" +
            //"fRIXXn0SFp64yQqvPkkKrz7JmT9xzxrEdjMIxrw8jfN5nIc5DvbB+Vwd+zm/xLCC18tlBX+ygnO5mSNhW8Hhq5jg9fOxBS9bdPBW7W8wCCYYeQhZQhYW/jfp6S0" +
            //"HIHjd/LRFZ69eVWUol235qxSdK9fXhaH8btvyw1p+IVdhuGTHdC66K3vZ7Oohy4XvptvwPcTEufnM7aNbhsiXA9RtFwKhHuEgQBHsXiKCVYsEqxYJzq8WCfY4YY" +
            //"LTk3F1wR7pHyrYSzlCBUdViwR7TH8JwQJUqOA7YjMFe71sqGAviA4VXLZarCC4dLWYLFgyDhWsWgwVrFoMFaxaDBWsWlyAkwCVTa9azObQqRat4k61uGn2bcWpF" +
            //"klWLW5d8mu2a8l4oxybvPM/tuJegHo/dlc+/mGySh/bAAAAAAAAAABq8UeAAQDe6wVMPG1+wgAAAABJRU5ErkJggg=="
        );
        protected string sLastIcon = (
            "iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAbFJREFUeNrs3UFOwlAUhlEkGh26JJeCK5OluCSHGgcKSUkcKAFazLv/Pd+ICUnbk7bvkoauVpIkSZIkSZIkSZIkSZIkSZIkDdzNKBtyd//w+Pnx/lbhoO229WnO93f7+doR+GXa+ecCwF8zgf/tuN8OhLuZPpdArtJ6JNypzeFsVnHgX3AhpwAfwYVcHfgEXMhVgc/AhVwN+AJcyFWAZ+BCHh14AVzIowIviAu52hwMOQB4+tlxCzn4DIbc4BINucE9GHKDRRbkBqtoyA3GJMgN5mDI4cCQGwBDbgAMuQEw5AbAkBsAQ24ADLkBMOQGwJAbAENuAAy5ATDkBsCQGwBDbgCscOArPEx/aJv27wJruLm45YDhBgPDDQaGGwwMNxgYbjAw3GBguMHAcIOB4QYDww0GhhsMDDcYGG4wMNxgYLjBwHCDgeEGA8MNBoYbDAy38RwMNwD4Cg+pwx3tDF4QGe6ol+gFkOGOfg+egQy3yiLrAmS41VbRZyDDrTomnYAMt/ocfAQZbgLwH8hwF2yIN4DvQfdv/v4BLkmSJEmSJEmSJEmSJEmSJEmSpPJ9CzAAUuBWvnWs3n4AAAAASUVORK5CYII="
            //"iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAYAAAA5ZDbSAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAo1JREFUeNrs3fFtm0AYhnHcCTI" +
            //"CI2QERugIHiEjtBN4BEboCO0GyQbOBmQDF0sg0ciWQn3A8d3vkb6/Ilunewx5eWVwVQEAAAAAAADA5hwSvlc9zJX3YXCbp36eZ77mrZ+PtRfa9NP20/Vz+TTd8L" +
            //"eGz3/Etjf26qvTDu+R3UJ/TY7ukuW+PiB3nNelJT+y0NNan8AMOSWQO93HbD+F11P3jwJFdwkFd0stsk24yHM/x4IEXxJPcuoFFjn+T2kI3l5wu5DgcX7/x6UDw" +
            //"Qk5Lyx4eilQE7y+4MuKEzGIEXxH9AvBcQVPE/d3guMKngaxhuC4gvdcfRIcvPokOHjiJjh49Ulw8OqT4ODVJ8HBq0+CgwcxgoNXnwQHrz4JDl59Ehy8+iQ4ePVJ" +
            //"cPDETXDw6pPg4NUnwcGrT4KDV58EBw9iBAevPgkOXn0SHLz6JDh4ECM4ePVJcPDEvYngw0zByIcvuftmn2JDMMEgGASDYBAMgkEwwSAYBINgEAyCQTDBIBgEg2A" +
            //"QDIL3xPX3Bn/uYaG+4+yL76Zy64qbzwh2+yjBVT73HR032j+Cq+VvKPMIh0ICFMFBAlSd0f4RnGg8CC1wMj5mvH8EPxigct8/gh+sFgmWjAn2SH+C/SgHwdtUiw" +
            //"QHrxYJFqAI3nO1SHDwapHg4NUiwcGrRYKDV4sEbzhr/NYgwcGrRYKDV4sErxSgXqoYEJxZtVic4HNh1WJxgtsVAtRzFZfsBdeFVYvFCU59FOdeLRYp+Gk44gSo+" +
            //"XSJQ2iVo+RTgWJHTokr2mppyXNO13usFnM8+42ZZbWDpBlEd3dOI20hAWqpA+PWJeQsuYeEi68nR+n7MLgveu4l4R/bBgAAAAAAAGCn/BVgAOslqJygZlPzAAAA" +
            //"AElFTkSuQmCC"
        );

        [Category("Inner controls"), Browsable(true)]
        public CustomDGV DGV { get; set; } = new CustomDGV();
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

        [Category("Appearance"), Browsable(true), DefaultValue(32)]
        public float ControlsHeight { get; set; } = 32;

        [Category("Appearance"), Browsable(true), DefaultValue(48)]
        public float ControlButtonsWidth { get; set; } = 48;
        
        [Browsable(false)]
        public int ItemsFit => this.DGV.ItemsFit;

        [Browsable(false)]
        public int PageSize { get; private set; } = 10;

        private int iCurrentPage = 1;
        [Category("Behavior"), Browsable(true), DefaultValue(0)]
        public int CurrentPage {
            get => this.iCurrentPage;
            set {
                this.TxtCurPage.Text = (this.iCurrentPage = value).ToString();
                Fill();
            }
        }

        private TotalItemsCallback fTotalItems;
        [Category("Behavior"), Browsable(true)]
        public TotalItemsCallback TotalItems { 
            get => fTotalItems; 
            set {
                this.fTotalItems = value;
                GetTotalPages();
            }
        }

        private SourceQueryCallback fSourceQuery;
        [Category("Behavior"), Browsable(true)]
        public SourceQueryCallback SourceQuery {
            get => this.fSourceQuery; 
            set {
                this.fSourceQuery = value;
                Fill();
            }
        }

        public CustomExDGV() : base() {
            this.SuspendLayout();

            this.Controls.Add(this.DGV, 0, 0);
            this.SetColumnSpan(this.DGV, 6);
            this.Controls.Add(this.BtnFirst, 0, 1);
            this.Controls.Add(this.BtnPrev, 1, 1);
            this.Controls.Add(this.TxtCurPage, 2, 1);
            this.Controls.Add(this.TxtTotalPages, 3, 1);
            this.Controls.Add(this.BtnNext, 4, 1);
            this.Controls.Add(this.BtnLast, 5, 1);

            this.ColumnCount = 6;
            this.RowCount = 2;

            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.ControlButtonsWidth));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.RowStyles.Add(new RowStyle(SizeType.Absolute, this.ControlsHeight));

            this.DGV.Name = "DGV";
            this.DGV.Dock = DockStyle.Fill;
            this.DGV.Margin = new Padding(0);
            this.DGV.TabIndex = 1;
            this.DGV.DisableLostFocusAnimation = true;

            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Dock = DockStyle.Fill;
            this.BtnFirst.Margin = new Padding(0);
            this.BtnFirst.CornerRadius = 0;
            this.BtnFirst.HighEmphasis = false;
            this.BtnFirst.DrawShadows = false;
            this.BtnFirst.UseAccentColor = true;
            this.BtnFirst.Icon = sFirstIcon.ImageFromBase64();
            this.BtnFirst.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnFirst.IconAutoSize = true;
            this.BtnFirst.IconAutoSizePercentage = 75D;
            this.BtnFirst.TabIndex = 2;

            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Dock = DockStyle.Fill;
            this.BtnPrev.Margin = new Padding(0);
            this.BtnPrev.CornerRadius = 0;
            this.BtnPrev.HighEmphasis = false;
            this.BtnPrev.DrawShadows = false;
            this.BtnPrev.UseAccentColor = true;
            this.BtnPrev.Icon = sPrevIcon.ImageFromBase64();
            this.BtnPrev.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnPrev.IconAutoSize = true;
            this.BtnPrev.IconAutoSizePercentage = 75D;
            this.BtnPrev.TabIndex = 3;

            this.TxtCurPage.Name = "TxtCurPage";
            this.TxtCurPage.Text = "1";
            this.TxtCurPage.Font = this.BtnPrev.Font;
            this.TxtCurPage.Anchor = (AnchorStyles)12;
            //this.TxtCurPage.Margin = new Padding(0);
            this.TxtCurPage.Margin = new Padding(0, 2, 0, 0);
            this.TxtCurPage.BorderStyle = BorderStyle.None;
            this.TxtCurPage.TextAlign = HorizontalAlignment.Right;
            this.TxtCurPage.TabIndex = 4;

            this.TxtTotalPages.Name = "TxtTotalPages";
            this.TxtTotalPages.Text = "/0";
            this.TxtTotalPages.Anchor = (AnchorStyles)12;
            //this.TxtTotalPages.Margin = new Padding(0);
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
            this.BtnNext.UseAccentColor = true;
            this.BtnNext.DrawShadows = false;
            this.BtnNext.Icon = sNextIcon.ImageFromBase64();
            this.BtnNext.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnNext.IconAutoSize = true;
            this.BtnNext.IconAutoSizePercentage = 75D;
            this.BtnNext.TabIndex = 5;

            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Dock = DockStyle.Fill;
            this.BtnLast.Margin = new Padding(0);
            this.BtnLast.CornerRadius = 0;
            this.BtnLast.HighEmphasis = false;
            this.BtnLast.DrawShadows = false;
            this.BtnLast.UseAccentColor = true;
            this.BtnLast.Icon = sLastIcon.ImageFromBase64();
            this.BtnLast.IconAlign = MaterialButton.MaterialIconAlign.Center;
            this.BtnLast.IconAutoSize = true;
            this.BtnLast.IconAutoSizePercentage = 75D;
            this.BtnLast.TabIndex = 6;

            this.RefreshTheme();

            this.ResumeLayout();

            this.BtnFirst.Click += (sender, e) => {
                this.CurrentPage = 1;
            };

            this.BtnPrev.Click += (sender, e) => {
                if (this.CurrentPage > 1)
                    this.CurrentPage--;
            };

            this.TxtCurPage.KeyPress += (sender, e) => {
                TextBox oTxt = sender as TextBox;
                if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || e.KeyChar == '0' && oTxt.SelectionStart <= 0 || oTxt.Text.Length == oTxt.MaxLength))
                    e.Handled = true;
                else if (e.KeyChar == 13) {
                    CheckCurPage();
                    e.Handled = true;
                    //if (!CheckCurPage())
                    //    e.Handled = true;
                }
            };

            this.TxtTotalPages.GotFocus += (sender, e) => {
                this.TxtCurPage.Select();
                this.TxtCurPage.SelectionStart = this.TxtCurPage.TextLength;
            };

            this.BtnNext.Click += (sender, e) => {
                if (this.CurrentPage < this.GetTotalPages())
                    this.CurrentPage++;
            };

            this.BtnLast.Click += (sender, e) => {
                this.CurrentPage = this.GetTotalPages();
            };

            this.DGV.GotFocus += OnThisGotFocus;
            this.BtnFirst.GotFocus += OnThisGotFocus;
            this.BtnPrev.GotFocus += OnThisGotFocus;
            this.TxtCurPage.GotFocus += OnThisGotFocus;
            this.BtnNext.GotFocus += OnThisGotFocus;
            this.BtnLast.GotFocus += OnThisGotFocus;
            void OnThisGotFocus(object sender, EventArgs e) => this.OnGotFocus(e);

            this.BtnFirst.GotFocus += OnGotFocus;
            this.BtnPrev.GotFocus += OnGotFocus;
            this.TxtCurPage.GotFocus += OnGotFocus;
            this.BtnNext.GotFocus += OnGotFocus;
            this.BtnLast.GotFocus += OnGotFocus;
            void OnGotFocus(object sender, EventArgs e) {
                if (!this.DGV.AnimationManager.IsAnimating())
                    this.DGV.AnimateIn();
            }

            this.DGV.GotFocus += OnThisLostFocus;
            this.BtnFirst.GotFocus += OnThisLostFocus;
            this.BtnPrev.GotFocus += OnThisLostFocus;
            this.TxtCurPage.GotFocus += OnThisLostFocus;
            this.BtnNext.GotFocus += OnThisLostFocus;
            this.BtnLast.GotFocus += OnThisLostFocus;
            void OnThisLostFocus(object sender, EventArgs e) => this.OnLostFocus(e);

            this.DGV.LostFocus += OnLostFocus;
            this.BtnFirst.LostFocus += OnLostFocus;
            this.BtnPrev.LostFocus += OnLostFocus;
            this.TxtCurPage.LostFocus += OnLostFocus;
            this.TxtCurPage.LostFocus += (sender, e) => CheckCurPage();
            this.BtnNext.LostFocus += OnLostFocus;
            this.BtnLast.LostFocus += OnLostFocus;
            void OnLostFocus(object sender, EventArgs e) {
                if (!this.DGV.Focused && !this.BtnFirst.Focused && !this.BtnPrev.Focused && !this.TxtCurPage.Focused && 
                                         !this.TxtTotalPages.Focused && !this.BtnNext.Focused && !this.BtnLast.Focused) {
                    this.DGV.AnimateOut();
                }
            }
            
            this.DGV.MouseHover += OnThisMouseHover;
            this.BtnFirst.MouseHover += OnThisMouseHover;
            this.BtnPrev.MouseHover += OnThisMouseHover;
            this.TxtCurPage.MouseHover += OnThisMouseHover;
            this.BtnNext.MouseHover += OnThisMouseHover;
            this.BtnLast.MouseHover += OnThisMouseHover;
            void OnThisMouseHover(object sender, EventArgs e) => this.OnMouseHover(e);
        }
        
        public int GetTotalPages() {
            int iTotalPages = (int)Math.Ceiling((double)this.TotalItems() / (double)this.ItemsFit);
            this.TxtTotalPages.Text = "/" + iTotalPages;
            this.TxtCurPage.MaxLength = iTotalPages > 0 ? (int)Math.Floor(Math.Log10(iTotalPages)) + 1 : 1;
            return iTotalPages;
        }

        public bool CheckCurPage() {
            bool bError = true;
            int iPage;
            if (!int.TryParse(this.TxtCurPage.Text, out iPage))
                iPage = 1;
            else {
                int iTotalPages;
                if (iPage < 1)
                    iPage = 1;
                else if (iPage > (iTotalPages = this.GetTotalPages()))
                    iPage = iTotalPages;
                else
                    bError = false;
            }
            
            this.CurrentPage = iPage;
            this.TxtCurPage.Text = iPage.ToString();
            return bError;
        }

        protected void Fill() {
            if (this.SourceQuery == null)
                return;

            int iFirstItem = (this.CurrentPage - 1) * this.ItemsFit;
            this.DGV.DataSource = this.SourceQuery(iFirstItem, this.ItemsFit);
        }


        [Browsable(false)]
        public override Color BackColor {
            set => RefreshTheme();
        }

        protected void RefreshTheme() {
            base.BackColor = ColorHelper.RemoveAlpha(
                this.DGV.StateCommon.HeaderColumn.Back.Color1,
                Color.Black
            );

            Control oParent = this.Parent != null ? this.Parent : this.FindForm();
            this.BtnFirst.SBackColor =
            this.BtnPrev.SBackColor =
            this.BtnNext.SBackColor =
            this.BtnLast.SBackColor =
            this.TxtCurPage.BackColor =
            this.TxtTotalPages.BackColor = oParent != null ? ColorHelper.RemoveAlpha(this.BackColor, oParent.BackColor)
                                                           : this.BackColor;
        }

        protected override void OnGotFocus(EventArgs e) {
            base.OnGotFocus(e);
            RefreshTheme();
        }

        protected override void OnLostFocus(EventArgs e) {
            base.OnLostFocus(e);
            RefreshTheme();
        }

        protected override void OnMouseHover(EventArgs e) {
            base.OnMouseHover(e);
            RefreshTheme();
        }

        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if (this.Parent != null)
                RefreshTheme();
        }
    }
}
