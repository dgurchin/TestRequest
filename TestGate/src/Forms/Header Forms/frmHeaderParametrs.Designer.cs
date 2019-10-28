namespace TestGate
{
    partial class frmHeaderParametrs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeaderParametrs));
            this.tspHeaderTemplate = new System.Windows.Forms.ToolStrip();
            this.tspHeaderTemplate_lblNameTemplate = new System.Windows.Forms.ToolStripLabel();
            this.tspHeaderTemplate_txtNameTemplate = new System.Windows.Forms.ToolStripTextBox();
            this.tspHeaderTemplate_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.grbListParametrs = new System.Windows.Forms.GroupBox();
            this.tspParametrs = new System.Windows.Forms.ToolStrip();
            this.tspParametrs_Add = new System.Windows.Forms.ToolStripButton();
            this.pnlParametrs = new System.Windows.Forms.Panel();
            this.tspHeaderTemplate.SuspendLayout();
            this.grbListParametrs.SuspendLayout();
            this.tspParametrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspHeaderTemplate
            // 
            this.tspHeaderTemplate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHeaderTemplate_lblNameTemplate,
            this.tspHeaderTemplate_txtNameTemplate,
            this.tspHeaderTemplate_Save,
            this.toolStripSeparator1});
            this.tspHeaderTemplate.Location = new System.Drawing.Point(0, 0);
            this.tspHeaderTemplate.Name = "tspHeaderTemplate";
            this.tspHeaderTemplate.Size = new System.Drawing.Size(580, 25);
            this.tspHeaderTemplate.TabIndex = 0;
            this.tspHeaderTemplate.Text = "toolStrip1";
            // 
            // tspHeaderTemplate_lblNameTemplate
            // 
            this.tspHeaderTemplate_lblNameTemplate.Name = "tspHeaderTemplate_lblNameTemplate";
            this.tspHeaderTemplate_lblNameTemplate.Size = new System.Drawing.Size(131, 22);
            this.tspHeaderTemplate_lblNameTemplate.Text = "Name Header Template";
            // 
            // tspHeaderTemplate_txtNameTemplate
            // 
            this.tspHeaderTemplate_txtNameTemplate.Name = "tspHeaderTemplate_txtNameTemplate";
            this.tspHeaderTemplate_txtNameTemplate.Size = new System.Drawing.Size(200, 25);
            this.tspHeaderTemplate_txtNameTemplate.TextChanged += new System.EventHandler(this.tspHeaderTemplate_txtNameTemplate_TextChanged);
            // 
            // tspHeaderTemplate_Save
            // 
            this.tspHeaderTemplate_Save.Image = ((System.Drawing.Image)(resources.GetObject("tspHeaderTemplate_Save.Image")));
            this.tspHeaderTemplate_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeaderTemplate_Save.Name = "tspHeaderTemplate_Save";
            this.tspHeaderTemplate_Save.Size = new System.Drawing.Size(107, 22);
            this.tspHeaderTemplate_Save.Text = "Save Parametrs";
            this.tspHeaderTemplate_Save.Click += new System.EventHandler(this.tspHeaderInfo_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // grbListParametrs
            // 
            this.grbListParametrs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbListParametrs.Controls.Add(this.tspParametrs);
            this.grbListParametrs.Controls.Add(this.pnlParametrs);
            this.grbListParametrs.Location = new System.Drawing.Point(12, 40);
            this.grbListParametrs.Name = "grbListParametrs";
            this.grbListParametrs.Size = new System.Drawing.Size(556, 287);
            this.grbListParametrs.TabIndex = 1;
            this.grbListParametrs.TabStop = false;
            this.grbListParametrs.Text = "List of Parametrs";
            // 
            // tspParametrs
            // 
            this.tspParametrs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspParametrs_Add});
            this.tspParametrs.Location = new System.Drawing.Point(3, 16);
            this.tspParametrs.Name = "tspParametrs";
            this.tspParametrs.Size = new System.Drawing.Size(550, 25);
            this.tspParametrs.TabIndex = 1;
            this.tspParametrs.Text = "toolStrip1";
            // 
            // tspParametrs_Add
            // 
            this.tspParametrs_Add.Image = ((System.Drawing.Image)(resources.GetObject("tspParametrs_Add.Image")));
            this.tspParametrs_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspParametrs_Add.Name = "tspParametrs_Add";
            this.tspParametrs_Add.Size = new System.Drawing.Size(86, 22);
            this.tspParametrs_Add.Text = "Add Param";
            // 
            // pnlParametrs
            // 
            this.pnlParametrs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParametrs.AutoScroll = true;
            this.pnlParametrs.Location = new System.Drawing.Point(3, 47);
            this.pnlParametrs.Name = "pnlParametrs";
            this.pnlParametrs.Size = new System.Drawing.Size(547, 234);
            this.pnlParametrs.TabIndex = 0;
            // 
            // frmHeaderParametrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 344);
            this.Controls.Add(this.grbListParametrs);
            this.Controls.Add(this.tspHeaderTemplate);
            this.MinimizeBox = false;
            this.Name = "frmHeaderParametrs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Header Parametrs";
            this.tspHeaderTemplate.ResumeLayout(false);
            this.tspHeaderTemplate.PerformLayout();
            this.grbListParametrs.ResumeLayout(false);
            this.grbListParametrs.PerformLayout();
            this.tspParametrs.ResumeLayout(false);
            this.tspParametrs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspHeaderTemplate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tspHeaderTemplate_Save;
        public System.Windows.Forms.ToolStripLabel tspHeaderTemplate_lblNameTemplate;
        public System.Windows.Forms.ToolStripTextBox tspHeaderTemplate_txtNameTemplate;
        public System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.GroupBox grbListParametrs;
        public System.Windows.Forms.Panel pnlParametrs;
        private System.Windows.Forms.ToolStrip tspParametrs;
        public System.Windows.Forms.ToolStripButton tspParametrs_Add;
    }
}