namespace TestGate
{
    partial class frmServerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerInfo));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtSelectFile = new System.Windows.Forms.TextBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.cmdMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.txt_IP_Server = new System.Windows.Forms.TextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chbPort = new System.Windows.Forms.CheckBox();
            this.lbl_IP_Server = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSelectFile.Location = new System.Drawing.Point(24, 133);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(86, 22);
            this.btnSelectFile.TabIndex = 41;
            this.btnSelectFile.Text = "Сертификат...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // txtSelectFile
            // 
            this.txtSelectFile.Location = new System.Drawing.Point(122, 135);
            this.txtSelectFile.Name = "txtSelectFile";
            this.txtSelectFile.ReadOnly = true;
            this.txtSelectFile.Size = new System.Drawing.Size(367, 20);
            this.txtSelectFile.TabIndex = 40;
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(21, 27);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(56, 13);
            this.lblProtocol.TabIndex = 39;
            this.lblProtocol.Text = "Протокол";
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Items.AddRange(new object[] {
            "HTTP",
            "HTTPS"});
            this.cmbProtocol.Location = new System.Drawing.Point(122, 24);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(393, 21);
            this.cmbProtocol.TabIndex = 38;
            // 
            // cmdMethod
            // 
            this.cmdMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdMethod.FormattingEnabled = true;
            this.cmdMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.cmdMethod.Location = new System.Drawing.Point(122, 105);
            this.cmdMethod.Name = "cmdMethod";
            this.cmdMethod.Size = new System.Drawing.Size(393, 21);
            this.cmdMethod.TabIndex = 37;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(21, 108);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(39, 13);
            this.lblMethod.TabIndex = 36;
            this.lblMethod.Text = "Метод";
            // 
            // numPort
            // 
            this.numPort.Enabled = false;
            this.numPort.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPort.Location = new System.Drawing.Point(122, 79);
            this.numPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(393, 20);
            this.numPort.TabIndex = 35;
            this.numPort.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(359, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 42;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(440, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClearFile
            // 
            this.btnClearFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFile.Enabled = false;
            this.btnClearFile.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFile.Image")));
            this.btnClearFile.Location = new System.Drawing.Point(494, 135);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(21, 21);
            this.btnClearFile.TabIndex = 44;
            this.btnClearFile.UseVisualStyleBackColor = true;
            // 
            // txt_IP_Server
            // 
            this.txt_IP_Server.Location = new System.Drawing.Point(122, 52);
            this.txt_IP_Server.Name = "txt_IP_Server";
            this.txt_IP_Server.Size = new System.Drawing.Size(393, 20);
            this.txt_IP_Server.TabIndex = 46;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Multiselect = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 165);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(393, 22);
            this.txtPassword.TabIndex = 47;
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Пароль";
            // 
            // chbPort
            // 
            this.chbPort.AutoSize = true;
            this.chbPort.Location = new System.Drawing.Point(24, 80);
            this.chbPort.Name = "chbPort";
            this.chbPort.Size = new System.Drawing.Size(51, 17);
            this.chbPort.TabIndex = 49;
            this.chbPort.Text = "Порт";
            this.chbPort.UseVisualStyleBackColor = true;
            this.chbPort.CheckedChanged += new System.EventHandler(this.chbPort_CheckedChanged);
            // 
            // lbl_IP_Server
            // 
            this.lbl_IP_Server.AutoSize = true;
            this.lbl_IP_Server.Location = new System.Drawing.Point(21, 55);
            this.lbl_IP_Server.Name = "lbl_IP_Server";
            this.lbl_IP_Server.Size = new System.Drawing.Size(62, 13);
            this.lbl_IP_Server.TabIndex = 52;
            this.lbl_IP_Server.Text = "IP сервера";
            // 
            // frmServerInfo
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(544, 244);
            this.Controls.Add(this.lbl_IP_Server);
            this.Controls.Add(this.chbPort);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txt_IP_Server);
            this.Controls.Add(this.btnClearFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtSelectFile);
            this.Controls.Add(this.lblProtocol);
            this.Controls.Add(this.cmbProtocol);
            this.Controls.Add(this.cmdMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.numPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Добавить сервер";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblProtocol;
        public System.Windows.Forms.ComboBox cmbProtocol;
        public System.Windows.Forms.ComboBox cmdMethod;
        private System.Windows.Forms.Label lblMethod;
        public System.Windows.Forms.NumericUpDown numPort;
        public System.Windows.Forms.TextBox txtSelectFile;
        public System.Windows.Forms.Button btnClearFile;
        public System.Windows.Forms.TextBox txt_IP_Server;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.OpenFileDialog dlgOpen;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.CheckBox chbPort;
        private System.Windows.Forms.Label lbl_IP_Server;
    }
}