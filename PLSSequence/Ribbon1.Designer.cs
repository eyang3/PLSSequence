namespace PLSSequence
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.PLS = this.Factory.CreateRibbonGroup();
            this.runPLS = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.PLS.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.PLS);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // PLS
            // 
            this.PLS.Items.Add(this.runPLS);
            this.PLS.Label = "Sequence Activity";
            this.PLS.Name = "PLS";
            // 
            // runPLS
            // 
            this.runPLS.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.runPLS.Image = ((System.Drawing.Image)(resources.GetObject("runPLS.Image")));
            this.runPLS.Label = "PLS";
            this.runPLS.Name = "runPLS";
            this.runPLS.ShowImage = true;
            this.runPLS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.runPLS_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.PLS.ResumeLayout(false);
            this.PLS.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PLS;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton runPLS;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
