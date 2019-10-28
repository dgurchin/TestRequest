namespace TestGate
{
    partial class frmHeaderTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeaderTemplate));
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tspHeader_Result_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspHeader_Result_cmbServers = new System.Windows.Forms.ToolStripComboBox();
            this.tspHeader_Result = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspHeader_LoadOriginal = new System.Windows.Forms.ToolStripButton();
            this.tspHeader_Result_bntServers = new System.Windows.Forms.ToolStripButton();
            this.grbHeaderParams = new System.Windows.Forms.GroupBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tspHeaderParams = new System.Windows.Forms.ToolStrip();
            this.tspHeaderParams_btnHedears = new System.Windows.Forms.ToolStripButton();
            this.tspHeaderParams_cmbHedearsNames = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tspHeaderParams_Add = new System.Windows.Forms.ToolStripButton();
            this.tspHeaderParams_NameParam = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tspHeaderParams_Save = new System.Windows.Forms.ToolStripButton();
            this.tspHeader_Result.SuspendLayout();
            this.grbHeaderParams.SuspendLayout();
            this.tspHeaderParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // tspHeader_Result_Save
            // 
            this.tspHeader_Result_Save.Image = ((System.Drawing.Image)(resources.GetObject("tspHeader_Result_Save.Image")));
            this.tspHeader_Result_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeader_Result_Save.Name = "tspHeader_Result_Save";
            this.tspHeader_Result_Save.Size = new System.Drawing.Size(143, 22);
            this.tspHeader_Result_Save.Text = "Save Template Header";
            this.tspHeader_Result_Save.ToolTipText = "Save Header Result";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // tspHeader_Result_cmbServers
            // 
            this.tspHeader_Result_cmbServers.Name = "tspHeader_Result_cmbServers";
            this.tspHeader_Result_cmbServers.Size = new System.Drawing.Size(500, 25);
            // 
            // tspHeader_Result
            // 
            this.tspHeader_Result.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHeader_Result_Save,
            this.toolStripSeparator2,
            this.tspHeader_LoadOriginal,
            this.toolStripSeparator1,
            this.tspHeader_Result_bntServers,
            this.tspHeader_Result_cmbServers});
            this.tspHeader_Result.Location = new System.Drawing.Point(0, 0);
            this.tspHeader_Result.Name = "tspHeader_Result";
            this.tspHeader_Result.Size = new System.Drawing.Size(856, 25);
            this.tspHeader_Result.TabIndex = 3;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspHeader_LoadOriginal
            // 
            this.tspHeader_LoadOriginal.Image = ((System.Drawing.Image)(resources.GetObject("tspHeader_LoadOriginal.Image")));
            this.tspHeader_LoadOriginal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeader_LoadOriginal.Name = "tspHeader_LoadOriginal";
            this.tspHeader_LoadOriginal.Size = new System.Drawing.Size(98, 22);
            this.tspHeader_LoadOriginal.Text = "Load Original";
            this.tspHeader_LoadOriginal.Visible = false;
            // 
            // tspHeader_Result_bntServers
            // 
            this.tspHeader_Result_bntServers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspHeader_Result_bntServers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeader_Result_bntServers.Name = "tspHeader_Result_bntServers";
            this.tspHeader_Result_bntServers.Size = new System.Drawing.Size(57, 22);
            this.tspHeader_Result_bntServers.Text = "Servers...";
            // 
            // grbHeaderParams
            // 
            this.grbHeaderParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbHeaderParams.Controls.Add(this.panelHeader);
            this.grbHeaderParams.Controls.Add(this.tspHeaderParams);
            this.grbHeaderParams.Location = new System.Drawing.Point(12, 28);
            this.grbHeaderParams.Name = "grbHeaderParams";
            this.grbHeaderParams.Size = new System.Drawing.Size(832, 358);
            this.grbHeaderParams.TabIndex = 4;
            this.grbHeaderParams.TabStop = false;
            this.grbHeaderParams.Text = "Header";
            // 
            // panelHeader
            // 
            this.panelHeader.AutoScroll = true;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(3, 41);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(826, 314);
            this.panelHeader.TabIndex = 33;
            // 
            // tspHeaderParams
            // 
            this.tspHeaderParams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHeaderParams_btnHedears,
            this.tspHeaderParams_cmbHedearsNames,
            this.toolStripSeparator5,
            this.tspHeaderParams_Add,
            this.tspHeaderParams_NameParam,
            this.toolStripSeparator6,
            this.tspHeaderParams_Save});
            this.tspHeaderParams.Location = new System.Drawing.Point(3, 16);
            this.tspHeaderParams.Name = "tspHeaderParams";
            this.tspHeaderParams.Size = new System.Drawing.Size(826, 25);
            this.tspHeaderParams.TabIndex = 32;
            // 
            // tspHeaderParams_btnHedears
            // 
            this.tspHeaderParams_btnHedears.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspHeaderParams_btnHedears.Image = ((System.Drawing.Image)(resources.GetObject("tspHeaderParams_btnHedears.Image")));
            this.tspHeaderParams_btnHedears.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeaderParams_btnHedears.Name = "tspHeaderParams_btnHedears";
            this.tspHeaderParams_btnHedears.Size = new System.Drawing.Size(63, 22);
            this.tspHeaderParams_btnHedears.Text = "Headers...";
            // 
            // tspHeaderParams_cmbHedearsNames
            // 
            this.tspHeaderParams_cmbHedearsNames.Name = "tspHeaderParams_cmbHedearsNames";
            this.tspHeaderParams_cmbHedearsNames.Size = new System.Drawing.Size(200, 25);
            this.tspHeaderParams_cmbHedearsNames.TextChanged += new System.EventHandler(this.tspHeaderParams_cmbHedearsNames_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tspHeaderParams_Add
            // 
            this.tspHeaderParams_Add.Enabled = false;
            this.tspHeaderParams_Add.Image = ((System.Drawing.Image)(resources.GetObject("tspHeaderParams_Add.Image")));
            this.tspHeaderParams_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeaderParams_Add.Name = "tspHeaderParams_Add";
            this.tspHeaderParams_Add.Size = new System.Drawing.Size(86, 22);
            this.tspHeaderParams_Add.Text = "Add Param";
            // 
            // tspHeaderParams_NameParam
            // 
            this.tspHeaderParams_NameParam.Name = "tspHeaderParams_NameParam";
            this.tspHeaderParams_NameParam.Size = new System.Drawing.Size(200, 25);
            this.tspHeaderParams_NameParam.TextChanged += new System.EventHandler(this.tspHeader_NameParam_TextChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tspHeaderParams_Save
            // 
            this.tspHeaderParams_Save.Enabled = false;
            this.tspHeaderParams_Save.Image = ((System.Drawing.Image)(resources.GetObject("tspHeaderParams_Save.Image")));
            this.tspHeaderParams_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHeaderParams_Save.Name = "tspHeaderParams_Save";
            this.tspHeaderParams_Save.Size = new System.Drawing.Size(119, 22);
            this.tspHeaderParams_Save.Text = "Save New Header";
            // 
            // frmHeaderTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 413);
            this.Controls.Add(this.grbHeaderParams);
            this.Controls.Add(this.tspHeader_Result);
            this.MinimizeBox = false;
            this.Name = "frmHeaderTemplate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Header Template";
            this.tspHeader_Result.ResumeLayout(false);
            this.tspHeader_Result.PerformLayout();
            this.grbHeaderParams.ResumeLayout(false);
            this.grbHeaderParams.PerformLayout();
            this.tspHeaderParams.ResumeLayout(false);
            this.tspHeaderParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        public System.Windows.Forms.ToolStripButton tspHeader_Result_Save;
        public System.Windows.Forms.ToolStripComboBox tspHeader_Result_cmbServers;
        private System.Windows.Forms.ToolStrip tspHeader_Result;
        public System.Windows.Forms.ToolStripButton tspHeader_Result_bntServers;
        private System.Windows.Forms.GroupBox grbHeaderParams;
        public System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ToolStrip tspHeaderParams;
        public System.Windows.Forms.ToolStripButton tspHeaderParams_btnHedears;
        public System.Windows.Forms.ToolStripComboBox tspHeaderParams_cmbHedearsNames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tspHeaderParams_Add;
        public System.Windows.Forms.ToolStripTextBox tspHeaderParams_NameParam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripButton tspHeaderParams_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tspHeader_LoadOriginal;
    }
}