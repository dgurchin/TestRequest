namespace TestGate
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMain_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFile_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainFile_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.imlMain = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grbRequestType = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.rdbDDos_Attack = new System.Windows.Forms.RadioButton();
            this.rdbRequest = new System.Windows.Forms.RadioButton();
            this.grbDDos_Parametr = new System.Windows.Forms.GroupBox();
            this.prgDDos_Parametr = new System.Windows.Forms.PropertyGrid();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grbTemplateHeader = new System.Windows.Forms.GroupBox();
            this.tspTemplateRequest = new System.Windows.Forms.ToolStrip();
            this.tspTemplateRequest_Add = new System.Windows.Forms.ToolStripButton();
            this.tspTemplateRequest_Del = new System.Windows.Forms.ToolStripButton();
            this.tspTemplateRequest_Edit = new System.Windows.Forms.ToolStripButton();
            this.lsvHeader_Result = new System.Windows.Forms.ListView();
            this.lsvMain_Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbBody = new System.Windows.Forms.GroupBox();
            this.rtxtPAYLOAD = new System.Windows.Forms.RichTextBox();
            this.llblPAYLOAD = new System.Windows.Forms.LinkLabel();
            this.btnDel_PAYLOAD = new System.Windows.Forms.Button();
            this.cmbPAYLOAD = new System.Windows.Forms.ComboBox();
            this.btnSave_PAYLOAD = new System.Windows.Forms.Button();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.tspDDos_Attack = new System.Windows.Forms.ToolStrip();
            this.tspDDos_Attack_History = new System.Windows.Forms.ToolStripButton();
            this.tspDDos_Attack_NameResult = new System.Windows.Forms.ToolStripTextBox();
            this.tspDDos_Attack_Save = new System.Windows.Forms.ToolStripButton();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grbRequestType.SuspendLayout();
            this.grbDDos_Parametr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.grbTemplateHeader.SuspendLayout();
            this.tspTemplateRequest.SuspendLayout();
            this.grbBody.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.tspDDos_Attack.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain_File,
            this.mnuHistory});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1123, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuMain_File
            // 
            this.mnuMain_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile_Create,
            this.mnuMainFile_Open,
            this.toolStripMenuItem2,
            this.mnuMainFile_Close});
            this.mnuMain_File.Name = "mnuMain_File";
            this.mnuMain_File.Size = new System.Drawing.Size(37, 20);
            this.mnuMain_File.Text = "File";
            // 
            // mnuMainFile_Create
            // 
            this.mnuMainFile_Create.Image = global::TestRequest.Properties.Resources.New;
            this.mnuMainFile_Create.Name = "mnuMainFile_Create";
            this.mnuMainFile_Create.Size = new System.Drawing.Size(117, 22);
            this.mnuMainFile_Create.Text = "Create...";
            // 
            // mnuMainFile_Open
            // 
            this.mnuMainFile_Open.Image = global::TestRequest.Properties.Resources.Open;
            this.mnuMainFile_Open.Name = "mnuMainFile_Open";
            this.mnuMainFile_Open.Size = new System.Drawing.Size(117, 22);
            this.mnuMainFile_Open.Text = "Open...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 6);
            // 
            // mnuMainFile_Close
            // 
            this.mnuMainFile_Close.Name = "mnuMainFile_Close";
            this.mnuMainFile_Close.Size = new System.Drawing.Size(117, 22);
            this.mnuMainFile_Close.Text = "Close";
            this.mnuMainFile_Close.Click += new System.EventHandler(this.mnuMainFile_Close_Click);
            // 
            // mnuHistory
            // 
            this.mnuHistory.Name = "mnuHistory";
            this.mnuHistory.Size = new System.Drawing.Size(134, 20);
            this.mnuHistory.Text = "History DDos Attack...";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "db";
            this.dlgSave.Filter = "SQLite Database|*.db";
            this.dlgSave.RestoreDirectory = true;
            this.dlgSave.SupportMultiDottedExtensions = true;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "SQLite Database|*.db";
            this.dlgOpen.RestoreDirectory = true;
            this.dlgOpen.SupportMultiDottedExtensions = true;
            // 
            // imlMain
            // 
            this.imlMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMain.ImageStream")));
            this.imlMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMain.Images.SetKeyName(0, "BadTest.png");
            this.imlMain.Images.SetKeyName(1, "GoodTest.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbResult);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 530);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grbRequestType);
            this.splitContainer2.Panel1.Controls.Add(this.grbDDos_Parametr);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1099, 316);
            this.splitContainer2.SplitterDistance = 242;
            this.splitContainer2.TabIndex = 0;
            // 
            // grbRequestType
            // 
            this.grbRequestType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRequestType.Controls.Add(this.btnTest);
            this.grbRequestType.Controls.Add(this.rdbDDos_Attack);
            this.grbRequestType.Controls.Add(this.rdbRequest);
            this.grbRequestType.Location = new System.Drawing.Point(9, 3);
            this.grbRequestType.Name = "grbRequestType";
            this.grbRequestType.Size = new System.Drawing.Size(224, 126);
            this.grbRequestType.TabIndex = 7;
            this.grbRequestType.TabStop = false;
            this.grbRequestType.Text = "Request Type";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Enabled = false;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.Location = new System.Drawing.Point(178, 44);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(35, 32);
            this.btnTest.TabIndex = 9;
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // rdbDDos_Attack
            // 
            this.rdbDDos_Attack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDDos_Attack.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbDDos_Attack.Location = new System.Drawing.Point(17, 63);
            this.rdbDDos_Attack.Name = "rdbDDos_Attack";
            this.rdbDDos_Attack.Size = new System.Drawing.Size(155, 24);
            this.rdbDDos_Attack.TabIndex = 8;
            this.rdbDDos_Attack.Text = "DDos Attack";
            this.rdbDDos_Attack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDDos_Attack.UseVisualStyleBackColor = true;
            // 
            // rdbRequest
            // 
            this.rdbRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbRequest.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbRequest.Checked = true;
            this.rdbRequest.Location = new System.Drawing.Point(17, 33);
            this.rdbRequest.Name = "rdbRequest";
            this.rdbRequest.Size = new System.Drawing.Size(155, 24);
            this.rdbRequest.TabIndex = 7;
            this.rdbRequest.TabStop = true;
            this.rdbRequest.Text = "Request";
            this.rdbRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbRequest.UseVisualStyleBackColor = true;
            this.rdbRequest.CheckedChanged += new System.EventHandler(this.rdbRequest_CheckedChanged);
            // 
            // grbDDos_Parametr
            // 
            this.grbDDos_Parametr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDDos_Parametr.Controls.Add(this.prgDDos_Parametr);
            this.grbDDos_Parametr.Location = new System.Drawing.Point(6, 135);
            this.grbDDos_Parametr.Name = "grbDDos_Parametr";
            this.grbDDos_Parametr.Size = new System.Drawing.Size(233, 172);
            this.grbDDos_Parametr.TabIndex = 3;
            this.grbDDos_Parametr.TabStop = false;
            this.grbDDos_Parametr.Text = "DDos Parametr";
            this.grbDDos_Parametr.Visible = false;
            // 
            // prgDDos_Parametr
            // 
            this.prgDDos_Parametr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgDDos_Parametr.Location = new System.Drawing.Point(6, 19);
            this.prgDDos_Parametr.Name = "prgDDos_Parametr";
            this.prgDDos_Parametr.Size = new System.Drawing.Size(221, 147);
            this.prgDDos_Parametr.TabIndex = 1;
            this.prgDDos_Parametr.ToolbarVisible = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grbTemplateHeader);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grbBody);
            this.splitContainer3.Size = new System.Drawing.Size(853, 316);
            this.splitContainer3.SplitterDistance = 478;
            this.splitContainer3.TabIndex = 0;
            // 
            // grbTemplateHeader
            // 
            this.grbTemplateHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTemplateHeader.Controls.Add(this.tspTemplateRequest);
            this.grbTemplateHeader.Controls.Add(this.lsvHeader_Result);
            this.grbTemplateHeader.Location = new System.Drawing.Point(3, 3);
            this.grbTemplateHeader.Name = "grbTemplateHeader";
            this.grbTemplateHeader.Size = new System.Drawing.Size(472, 310);
            this.grbTemplateHeader.TabIndex = 6;
            this.grbTemplateHeader.TabStop = false;
            this.grbTemplateHeader.Text = "Template Request";
            // 
            // tspTemplateRequest
            // 
            this.tspTemplateRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspTemplateRequest_Add,
            this.tspTemplateRequest_Del,
            this.tspTemplateRequest_Edit});
            this.tspTemplateRequest.Location = new System.Drawing.Point(3, 16);
            this.tspTemplateRequest.Name = "tspTemplateRequest";
            this.tspTemplateRequest.Size = new System.Drawing.Size(466, 25);
            this.tspTemplateRequest.TabIndex = 8;
            // 
            // tspTemplateRequest_Add
            // 
            this.tspTemplateRequest_Add.Image = ((System.Drawing.Image)(resources.GetObject("tspTemplateRequest_Add.Image")));
            this.tspTemplateRequest_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspTemplateRequest_Add.Name = "tspTemplateRequest_Add";
            this.tspTemplateRequest_Add.Size = new System.Drawing.Size(58, 22);
            this.tspTemplateRequest_Add.Text = "Add...";
            // 
            // tspTemplateRequest_Del
            // 
            this.tspTemplateRequest_Del.Enabled = false;
            this.tspTemplateRequest_Del.Image = ((System.Drawing.Image)(resources.GetObject("tspTemplateRequest_Del.Image")));
            this.tspTemplateRequest_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspTemplateRequest_Del.Name = "tspTemplateRequest_Del";
            this.tspTemplateRequest_Del.Size = new System.Drawing.Size(44, 22);
            this.tspTemplateRequest_Del.Text = "Del";
            // 
            // tspTemplateRequest_Edit
            // 
            this.tspTemplateRequest_Edit.Enabled = false;
            this.tspTemplateRequest_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tspTemplateRequest_Edit.Image")));
            this.tspTemplateRequest_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspTemplateRequest_Edit.Name = "tspTemplateRequest_Edit";
            this.tspTemplateRequest_Edit.Size = new System.Drawing.Size(56, 22);
            this.tspTemplateRequest_Edit.Text = "Edit...";
            // 
            // lsvHeader_Result
            // 
            this.lsvHeader_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvHeader_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lsvMain_Command});
            this.lsvHeader_Result.FullRowSelect = true;
            this.lsvHeader_Result.GridLines = true;
            this.lsvHeader_Result.HideSelection = false;
            this.lsvHeader_Result.Location = new System.Drawing.Point(6, 44);
            this.lsvHeader_Result.MultiSelect = false;
            this.lsvHeader_Result.Name = "lsvHeader_Result";
            this.lsvHeader_Result.Size = new System.Drawing.Size(460, 260);
            this.lsvHeader_Result.TabIndex = 7;
            this.lsvHeader_Result.UseCompatibleStateImageBehavior = false;
            this.lsvHeader_Result.View = System.Windows.Forms.View.Details;
            this.lsvHeader_Result.SelectedIndexChanged += new System.EventHandler(this.lsvTemplateRequest_SelectedIndexChanged);
            // 
            // lsvMain_Command
            // 
            this.lsvMain_Command.Text = "Запрос";
            this.lsvMain_Command.Width = 449;
            // 
            // grbBody
            // 
            this.grbBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBody.Controls.Add(this.rtxtPAYLOAD);
            this.grbBody.Controls.Add(this.llblPAYLOAD);
            this.grbBody.Controls.Add(this.btnDel_PAYLOAD);
            this.grbBody.Controls.Add(this.cmbPAYLOAD);
            this.grbBody.Controls.Add(this.btnSave_PAYLOAD);
            this.grbBody.Enabled = false;
            this.grbBody.Location = new System.Drawing.Point(3, 3);
            this.grbBody.Name = "grbBody";
            this.grbBody.Size = new System.Drawing.Size(363, 310);
            this.grbBody.TabIndex = 1;
            this.grbBody.TabStop = false;
            this.grbBody.Text = "Body";
            // 
            // rtxtPAYLOAD
            // 
            this.rtxtPAYLOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtPAYLOAD.Location = new System.Drawing.Point(6, 66);
            this.rtxtPAYLOAD.Name = "rtxtPAYLOAD";
            this.rtxtPAYLOAD.Size = new System.Drawing.Size(351, 209);
            this.rtxtPAYLOAD.TabIndex = 25;
            this.rtxtPAYLOAD.Text = "";
            // 
            // llblPAYLOAD
            // 
            this.llblPAYLOAD.AutoSize = true;
            this.llblPAYLOAD.Location = new System.Drawing.Point(6, 23);
            this.llblPAYLOAD.Name = "llblPAYLOAD";
            this.llblPAYLOAD.Size = new System.Drawing.Size(46, 13);
            this.llblPAYLOAD.TabIndex = 24;
            this.llblPAYLOAD.TabStop = true;
            this.llblPAYLOAD.Text = "BODY...";
            // 
            // btnDel_PAYLOAD
            // 
            this.btnDel_PAYLOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel_PAYLOAD.Location = new System.Drawing.Point(268, 281);
            this.btnDel_PAYLOAD.Name = "btnDel_PAYLOAD";
            this.btnDel_PAYLOAD.Size = new System.Drawing.Size(89, 23);
            this.btnDel_PAYLOAD.TabIndex = 23;
            this.btnDel_PAYLOAD.Text = "Del PayLoad";
            this.btnDel_PAYLOAD.UseVisualStyleBackColor = true;
            // 
            // cmbPAYLOAD
            // 
            this.cmbPAYLOAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPAYLOAD.FormattingEnabled = true;
            this.cmbPAYLOAD.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.cmbPAYLOAD.Location = new System.Drawing.Point(6, 39);
            this.cmbPAYLOAD.Name = "cmbPAYLOAD";
            this.cmbPAYLOAD.Size = new System.Drawing.Size(351, 21);
            this.cmbPAYLOAD.TabIndex = 21;
            this.cmbPAYLOAD.SelectedIndexChanged += new System.EventHandler(this.cmbPAYLOAD_SelectedIndexChanged);
            this.cmbPAYLOAD.TextChanged += new System.EventHandler(this.cmbPAYLOAD_TextChanged);
            // 
            // btnSave_PAYLOAD
            // 
            this.btnSave_PAYLOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave_PAYLOAD.Location = new System.Drawing.Point(173, 281);
            this.btnSave_PAYLOAD.Name = "btnSave_PAYLOAD";
            this.btnSave_PAYLOAD.Size = new System.Drawing.Size(89, 23);
            this.btnSave_PAYLOAD.TabIndex = 20;
            this.btnSave_PAYLOAD.Text = "Save PayLoad";
            this.btnSave_PAYLOAD.UseVisualStyleBackColor = true;
            // 
            // grbResult
            // 
            this.grbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbResult.Controls.Add(this.tspDDos_Attack);
            this.grbResult.Controls.Add(this.rtxtResult);
            this.grbResult.Enabled = false;
            this.grbResult.Location = new System.Drawing.Point(3, 9);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(1091, 193);
            this.grbResult.TabIndex = 1;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Result";
            // 
            // tspDDos_Attack
            // 
            this.tspDDos_Attack.Enabled = false;
            this.tspDDos_Attack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspDDos_Attack_History,
            this.tspDDos_Attack_NameResult,
            this.tspDDos_Attack_Save});
            this.tspDDos_Attack.Location = new System.Drawing.Point(3, 16);
            this.tspDDos_Attack.Name = "tspDDos_Attack";
            this.tspDDos_Attack.Size = new System.Drawing.Size(1085, 25);
            this.tspDDos_Attack.TabIndex = 6;
            this.tspDDos_Attack.Text = "toolStrip1";
            // 
            // tspDDos_Attack_History
            // 
            this.tspDDos_Attack_History.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspDDos_Attack_History.Image = ((System.Drawing.Image)(resources.GetObject("tspDDos_Attack_History.Image")));
            this.tspDDos_Attack_History.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDDos_Attack_History.Name = "tspDDos_Attack_History";
            this.tspDDos_Attack_History.Size = new System.Drawing.Size(58, 22);
            this.tspDDos_Attack_History.Text = "History...";
            // 
            // tspDDos_Attack_NameResult
            // 
            this.tspDDos_Attack_NameResult.Name = "tspDDos_Attack_NameResult";
            this.tspDDos_Attack_NameResult.Size = new System.Drawing.Size(200, 25);
            this.tspDDos_Attack_NameResult.TextChanged += new System.EventHandler(this.tspDDos_Attack_NameResult_TextChanged);
            // 
            // tspDDos_Attack_Save
            // 
            this.tspDDos_Attack_Save.Enabled = false;
            this.tspDDos_Attack_Save.Image = ((System.Drawing.Image)(resources.GetObject("tspDDos_Attack_Save.Image")));
            this.tspDDos_Attack_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDDos_Attack_Save.Name = "tspDDos_Attack_Save";
            this.tspDDos_Attack_Save.Size = new System.Drawing.Size(180, 22);
            this.tspDDos_Attack_Save.Text = "Save Result Testing in History";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtResult.BackColor = System.Drawing.SystemColors.Info;
            this.rtxtResult.Enabled = false;
            this.rtxtResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtResult.ForeColor = System.Drawing.Color.Gray;
            this.rtxtResult.Location = new System.Drawing.Point(6, 48);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ReadOnly = true;
            this.rtxtResult.Size = new System.Drawing.Size(1079, 133);
            this.rtxtResult.TabIndex = 5;
            this.rtxtResult.Text = "";
            this.rtxtResult.TextChanged += new System.EventHandler(this.rtxtResult_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Test Gate";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grbRequestType.ResumeLayout(false);
            this.grbDDos_Parametr.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.grbTemplateHeader.ResumeLayout(false);
            this.grbTemplateHeader.PerformLayout();
            this.tspTemplateRequest.ResumeLayout(false);
            this.tspTemplateRequest.PerformLayout();
            this.grbBody.ResumeLayout(false);
            this.grbBody.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.tspDDos_Attack.ResumeLayout(false);
            this.tspDDos_Attack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMain_File;
        public System.Windows.Forms.SaveFileDialog dlgSave;
        public System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ImageList imlMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.GroupBox grbDDos_Parametr;
        private System.Windows.Forms.ToolStrip tspDDos_Attack;
        public System.Windows.Forms.ToolStripButton tspDDos_Attack_Save;
        private System.Windows.Forms.GroupBox grbRequestType;
        public System.Windows.Forms.ToolStripMenuItem mnuMainFile_Create;
        public System.Windows.Forms.ToolStripMenuItem mnuMainFile_Open;
        public System.Windows.Forms.ToolStripMenuItem mnuMainFile_Close;
        public System.Windows.Forms.PropertyGrid prgDDos_Parametr;
        public System.Windows.Forms.RichTextBox rtxtResult;
        public System.Windows.Forms.ToolStripButton tspDDos_Attack_History;
        public System.Windows.Forms.ToolStripTextBox tspDDos_Attack_NameResult;
        public System.Windows.Forms.Button btnTest;
        public System.Windows.Forms.RadioButton rdbDDos_Attack;
        public System.Windows.Forms.RadioButton rdbRequest;
        public System.Windows.Forms.ToolStripMenuItem mnuHistory;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox grbTemplateHeader;
        private System.Windows.Forms.ToolStrip tspTemplateRequest;
        public System.Windows.Forms.ToolStripButton tspTemplateRequest_Add;
        public System.Windows.Forms.ToolStripButton tspTemplateRequest_Del;
        public System.Windows.Forms.ToolStripButton tspTemplateRequest_Edit;
        public System.Windows.Forms.ListView lsvHeader_Result;
        private System.Windows.Forms.ColumnHeader lsvMain_Command;
        public System.Windows.Forms.GroupBox grbResult;
        public System.Windows.Forms.GroupBox grbBody;
        public System.Windows.Forms.ComboBox cmbPAYLOAD;
        public System.Windows.Forms.Button btnSave_PAYLOAD;
        public System.Windows.Forms.Button btnDel_PAYLOAD;
        public System.Windows.Forms.LinkLabel llblPAYLOAD;
        public System.Windows.Forms.RichTextBox rtxtPAYLOAD;
    }
}

