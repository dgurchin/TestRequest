namespace TestGate
{
    partial class frmSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelect));
            this.tspSelect = new System.Windows.Forms.ToolStrip();
            this.tspSelect_Select = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspSelect_Add = new System.Windows.Forms.ToolStripButton();
            this.tspSelect_Dublicate = new System.Windows.Forms.ToolStripButton();
            this.tspSelect_Del = new System.Windows.Forms.ToolStripButton();
            this.tspSelect_Edit = new System.Windows.Forms.ToolStripButton();
            this.lsvSelect = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tspSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspSelect
            // 
            this.tspSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSelect_Select,
            this.toolStripSeparator2,
            this.tspSelect_Add,
            this.tspSelect_Dublicate,
            this.tspSelect_Del,
            this.tspSelect_Edit});
            this.tspSelect.Location = new System.Drawing.Point(0, 0);
            this.tspSelect.Name = "tspSelect";
            this.tspSelect.Size = new System.Drawing.Size(743, 25);
            this.tspSelect.TabIndex = 0;
            // 
            // tspSelect_Select
            // 
            this.tspSelect_Select.Enabled = false;
            this.tspSelect_Select.Image = ((System.Drawing.Image)(resources.GetObject("tspSelect_Select.Image")));
            this.tspSelect_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSelect_Select.Name = "tspSelect_Select";
            this.tspSelect_Select.Size = new System.Drawing.Size(58, 22);
            this.tspSelect_Select.Text = "Select";
            this.tspSelect_Select.Click += new System.EventHandler(this.tspSelect_Select_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspSelect_Add
            // 
            this.tspSelect_Add.Image = ((System.Drawing.Image)(resources.GetObject("tspSelect_Add.Image")));
            this.tspSelect_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSelect_Add.Name = "tspSelect_Add";
            this.tspSelect_Add.Size = new System.Drawing.Size(58, 22);
            this.tspSelect_Add.Text = "Add...";
            // 
            // tspSelect_Dublicate
            // 
            this.tspSelect_Dublicate.Enabled = false;
            this.tspSelect_Dublicate.Image = global::TestRequest.Properties.Resources.Duplicate;
            this.tspSelect_Dublicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSelect_Dublicate.Name = "tspSelect_Dublicate";
            this.tspSelect_Dublicate.Size = new System.Drawing.Size(77, 22);
            this.tspSelect_Dublicate.Text = "Dublicate";
            this.tspSelect_Dublicate.Visible = false;
            // 
            // tspSelect_Del
            // 
            this.tspSelect_Del.Enabled = false;
            this.tspSelect_Del.Image = ((System.Drawing.Image)(resources.GetObject("tspSelect_Del.Image")));
            this.tspSelect_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSelect_Del.Name = "tspSelect_Del";
            this.tspSelect_Del.Size = new System.Drawing.Size(44, 22);
            this.tspSelect_Del.Text = "Del";
            this.tspSelect_Del.Click += new System.EventHandler(this.tspSelect_Del_Click);
            // 
            // tspSelect_Edit
            // 
            this.tspSelect_Edit.Enabled = false;
            this.tspSelect_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tspSelect_Edit.Image")));
            this.tspSelect_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSelect_Edit.Name = "tspSelect_Edit";
            this.tspSelect_Edit.Size = new System.Drawing.Size(56, 22);
            this.tspSelect_Edit.Text = "Edit...";
            // 
            // lsvSelect
            // 
            this.lsvSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSelect.FullRowSelect = true;
            this.lsvSelect.GridLines = true;
            this.lsvSelect.HideSelection = false;
            this.lsvSelect.Location = new System.Drawing.Point(0, 25);
            this.lsvSelect.MultiSelect = false;
            this.lsvSelect.Name = "lsvSelect";
            this.lsvSelect.Size = new System.Drawing.Size(743, 358);
            this.lsvSelect.TabIndex = 1;
            this.lsvSelect.UseCompatibleStateImageBehavior = false;
            this.lsvSelect.View = System.Windows.Forms.View.Details;
            this.lsvSelect.SelectedIndexChanged += new System.EventHandler(this.lsvSelect_SelectedIndexChanged);
            this.lsvSelect.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvSelect_MouseDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(376, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(0, 0);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(743, 383);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lsvSelect);
            this.Controls.Add(this.tspSelect);
            this.MinimizeBox = false;
            this.Name = "frmSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select";
            this.tspSelect.ResumeLayout(false);
            this.tspSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton tspSelect_Select;
        public System.Windows.Forms.ToolStripButton tspSelect_Add;
        public System.Windows.Forms.ListView lsvSelect;
        public System.Windows.Forms.ToolStripButton tspSelect_Del;
        public System.Windows.Forms.ToolStripButton tspSelect_Edit;
        public System.Windows.Forms.ToolStripButton tspSelect_Dublicate;
        private System.Windows.Forms.Button btnClose;
    }
}