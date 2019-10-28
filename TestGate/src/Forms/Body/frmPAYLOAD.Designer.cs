namespace TestGate
{
    partial class frmPAYLOAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPAYLOAD));
            this.tspPayload = new System.Windows.Forms.ToolStrip();
            this.tspPayload_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspPayload_lblNamePayload = new System.Windows.Forms.ToolStripLabel();
            this.tspPayload_NamePayload = new System.Windows.Forms.ToolStripTextBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.tspPayload.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspPayload
            // 
            this.tspPayload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPayload_Save,
            this.toolStripSeparator2,
            this.tspPayload_lblNamePayload,
            this.tspPayload_NamePayload});
            this.tspPayload.Location = new System.Drawing.Point(0, 0);
            this.tspPayload.Name = "tspPayload";
            this.tspPayload.Size = new System.Drawing.Size(772, 25);
            this.tspPayload.TabIndex = 4;
            // 
            // tspPayload_Save
            // 
            this.tspPayload_Save.Image = ((System.Drawing.Image)(resources.GetObject("tspPayload_Save.Image")));
            this.tspPayload_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspPayload_Save.Name = "tspPayload_Save";
            this.tspPayload_Save.Size = new System.Drawing.Size(154, 22);
            this.tspPayload_Save.Text = "Save Changes PAYLOAD";
            this.tspPayload_Save.ToolTipText = "Save Changes and Close";
            this.tspPayload_Save.Click += new System.EventHandler(this.tspHeader_Result_Save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspPayload_lblNamePayload
            // 
            this.tspPayload_lblNamePayload.Name = "tspPayload_lblNamePayload";
            this.tspPayload_lblNamePayload.Size = new System.Drawing.Size(144, 22);
            this.tspPayload_lblNamePayload.Text = "Name Template PAYLOAD";
            // 
            // tspPayload_NamePayload
            // 
            this.tspPayload_NamePayload.BackColor = System.Drawing.SystemColors.Window;
            this.tspPayload_NamePayload.Name = "tspPayload_NamePayload";
            this.tspPayload_NamePayload.Size = new System.Drawing.Size(300, 25);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContent.Location = new System.Drawing.Point(12, 43);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(748, 406);
            this.rtxtContent.TabIndex = 5;
            this.rtxtContent.Text = "";
            // 
            // frmPAYLOAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 461);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.tspPayload);
            this.MinimizeBox = false;
            this.Name = "frmPAYLOAD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmPAYLOAD";
            this.tspPayload.ResumeLayout(false);
            this.tspPayload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPayload;
        public System.Windows.Forms.ToolStripButton tspPayload_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripLabel tspPayload_lblNamePayload;
        public System.Windows.Forms.ToolStripTextBox tspPayload_NamePayload;
        public System.Windows.Forms.RichTextBox rtxtContent;
    }
}