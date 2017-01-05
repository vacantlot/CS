namespace WinApp150604215
{
    partial class FrmIntegrated_chs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntegrated_chs));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回收处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_tslab = new System.Windows.Forms.ToolStripLabel();
            this.SaveFile_tslab = new System.Windows.Forms.ToolStripLabel();
            this.openFile_tslab = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_AddTo = new System.Windows.Forms.Button();
            this.bt_reMove = new System.Windows.Forms.Button();
            this.groupBox_recoveryANDhandle = new System.Windows.Forms.GroupBox();
            this.bt_openLogFile = new System.Windows.Forms.Button();
            this.bt_loadLogFile = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_clearAll = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_reduce = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.rdB_MultiChoose = new System.Windows.Forms.RadioButton();
            this.rdB_singleChoose = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsv = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_clearAllLog = new System.Windows.Forms.Button();
            this.bt_deleteLog = new System.Windows.Forms.Button();
            this.bt_Font = new System.Windows.Forms.Button();
            this.bt_colorBackground = new System.Windows.Forms.Button();
            this.txtbo_AddCityName = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox_recoveryANDhandle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.回收处理ToolStripMenuItem,
            this.操作记录ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新加载ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 重新加载ToolStripMenuItem
            // 
            this.重新加载ToolStripMenuItem.Name = "重新加载ToolStripMenuItem";
            this.重新加载ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新加载ToolStripMenuItem.Text = "重新加载";
            this.重新加载ToolStripMenuItem.Click += new System.EventHandler(this.重新加载ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加到ToolStripMenuItem,
            this.移除ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 添加到ToolStripMenuItem
            // 
            this.添加到ToolStripMenuItem.Name = "添加到ToolStripMenuItem";
            this.添加到ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.添加到ToolStripMenuItem.Text = "添加到...";
            this.添加到ToolStripMenuItem.Click += new System.EventHandler(this.bt_AddTo_Click);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.移除ToolStripMenuItem.Text = "移除";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.bt_reMove_Click);
            // 
            // 回收处理ToolStripMenuItem
            // 
            this.回收处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.还原ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.回收处理ToolStripMenuItem.Name = "回收处理ToolStripMenuItem";
            this.回收处理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.回收处理ToolStripMenuItem.Text = "回收处理";
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.还原ToolStripMenuItem.Text = "还原";
            this.还原ToolStripMenuItem.Click += new System.EventHandler(this.bt_reduce_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.bt_clearAll_Click);
            // 
            // 操作记录ToolStripMenuItem
            // 
            this.操作记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景颜色ToolStripMenuItem,
            this.记录字体ToolStripMenuItem,
            this.删除记录ToolStripMenuItem,
            this.清空记录ToolStripMenuItem});
            this.操作记录ToolStripMenuItem.Name = "操作记录ToolStripMenuItem";
            this.操作记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.操作记录ToolStripMenuItem.Text = "操作记录";
            // 
            // 背景颜色ToolStripMenuItem
            // 
            this.背景颜色ToolStripMenuItem.Name = "背景颜色ToolStripMenuItem";
            this.背景颜色ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.背景颜色ToolStripMenuItem.Text = "背景颜色...";
            this.背景颜色ToolStripMenuItem.Click += new System.EventHandler(this.bt_colorBackground_Click);
            // 
            // 记录字体ToolStripMenuItem
            // 
            this.记录字体ToolStripMenuItem.Name = "记录字体ToolStripMenuItem";
            this.记录字体ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.记录字体ToolStripMenuItem.Text = "记录字体...";
            this.记录字体ToolStripMenuItem.Click += new System.EventHandler(this.bt_Font_Click);
            // 
            // 删除记录ToolStripMenuItem
            // 
            this.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem";
            this.删除记录ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.删除记录ToolStripMenuItem.Text = "删除记录";
            this.删除记录ToolStripMenuItem.Click += new System.EventHandler(this.bt_deleteLog_Click);
            // 
            // 清空记录ToolStripMenuItem
            // 
            this.清空记录ToolStripMenuItem.Name = "清空记录ToolStripMenuItem";
            this.清空记录ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.清空记录ToolStripMenuItem.Text = "清空记录";
            this.清空记录ToolStripMenuItem.Click += new System.EventHandler(this.bt_clearAllLog_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_tslab,
            this.SaveFile_tslab,
            this.openFile_tslab});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            // 
            // Add_tslab
            // 
            this.Add_tslab.AutoSize = false;
            this.Add_tslab.Image = ((System.Drawing.Image)(resources.GetObject("Add_tslab.Image")));
            this.Add_tslab.Name = "Add_tslab";
            this.Add_tslab.Size = new System.Drawing.Size(28, 22);
            this.Add_tslab.Click += new System.EventHandler(this.bt_AddTo_Click);
            // 
            // SaveFile_tslab
            // 
            this.SaveFile_tslab.AutoSize = false;
            this.SaveFile_tslab.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile_tslab.Image")));
            this.SaveFile_tslab.Name = "SaveFile_tslab";
            this.SaveFile_tslab.Size = new System.Drawing.Size(30, 22);
            this.SaveFile_tslab.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // openFile_tslab
            // 
            this.openFile_tslab.AutoSize = false;
            this.openFile_tslab.Image = ((System.Drawing.Image)(resources.GetObject("openFile_tslab.Image")));
            this.openFile_tslab.Name = "openFile_tslab";
            this.openFile_tslab.Size = new System.Drawing.Size(30, 22);
            this.openFile_tslab.Click += new System.EventHandler(this.bt_openLogFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "添加城市：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(329, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // bt_AddTo
            // 
            this.bt_AddTo.Location = new System.Drawing.Point(223, 66);
            this.bt_AddTo.Name = "bt_AddTo";
            this.bt_AddTo.Size = new System.Drawing.Size(75, 23);
            this.bt_AddTo.TabIndex = 2;
            this.bt_AddTo.Text = "添加到->";
            this.bt_AddTo.UseVisualStyleBackColor = true;
            this.bt_AddTo.Click += new System.EventHandler(this.bt_AddTo_Click);
            // 
            // bt_reMove
            // 
            this.bt_reMove.Location = new System.Drawing.Point(475, 66);
            this.bt_reMove.Name = "bt_reMove";
            this.bt_reMove.Size = new System.Drawing.Size(75, 23);
            this.bt_reMove.TabIndex = 3;
            this.bt_reMove.Text = "移除";
            this.bt_reMove.UseVisualStyleBackColor = true;
            this.bt_reMove.Click += new System.EventHandler(this.bt_reMove_Click);
            // 
            // groupBox_recoveryANDhandle
            // 
            this.groupBox_recoveryANDhandle.Controls.Add(this.pictureBox1);
            this.groupBox_recoveryANDhandle.Controls.Add(this.bt_openLogFile);
            this.groupBox_recoveryANDhandle.Controls.Add(this.bt_loadLogFile);
            this.groupBox_recoveryANDhandle.Controls.Add(this.bt_Save);
            this.groupBox_recoveryANDhandle.Controls.Add(this.bt_clearAll);
            this.groupBox_recoveryANDhandle.Controls.Add(this.bt_delete);
            this.groupBox_recoveryANDhandle.Controls.Add(this.bt_reduce);
            this.groupBox_recoveryANDhandle.Controls.Add(this.lstBox);
            this.groupBox_recoveryANDhandle.Controls.Add(this.rdB_MultiChoose);
            this.groupBox_recoveryANDhandle.Controls.Add(this.rdB_singleChoose);
            this.groupBox_recoveryANDhandle.Location = new System.Drawing.Point(12, 101);
            this.groupBox_recoveryANDhandle.Name = "groupBox_recoveryANDhandle";
            this.groupBox_recoveryANDhandle.Size = new System.Drawing.Size(561, 169);
            this.groupBox_recoveryANDhandle.TabIndex = 4;
            this.groupBox_recoveryANDhandle.TabStop = false;
            this.groupBox_recoveryANDhandle.Text = "回收处理";
            // 
            // bt_openLogFile
            // 
            this.bt_openLogFile.Location = new System.Drawing.Point(423, 122);
            this.bt_openLogFile.Name = "bt_openLogFile";
            this.bt_openLogFile.Size = new System.Drawing.Size(75, 23);
            this.bt_openLogFile.TabIndex = 6;
            this.bt_openLogFile.Text = "打开记录";
            this.bt_openLogFile.UseVisualStyleBackColor = true;
            this.bt_openLogFile.Click += new System.EventHandler(this.bt_openLogFile_Click);
            // 
            // bt_loadLogFile
            // 
            this.bt_loadLogFile.Location = new System.Drawing.Point(423, 83);
            this.bt_loadLogFile.Name = "bt_loadLogFile";
            this.bt_loadLogFile.Size = new System.Drawing.Size(75, 23);
            this.bt_loadLogFile.TabIndex = 5;
            this.bt_loadLogFile.Text = "加载记录";
            this.bt_loadLogFile.UseVisualStyleBackColor = true;
            this.bt_loadLogFile.Click += new System.EventHandler(this.bt_loadLogFile_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(423, 41);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 4;
            this.bt_Save.Text = "保存";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_clearAll
            // 
            this.bt_clearAll.Location = new System.Drawing.Point(287, 122);
            this.bt_clearAll.Name = "bt_clearAll";
            this.bt_clearAll.Size = new System.Drawing.Size(75, 23);
            this.bt_clearAll.TabIndex = 3;
            this.bt_clearAll.Text = "清空";
            this.bt_clearAll.UseVisualStyleBackColor = true;
            this.bt_clearAll.Click += new System.EventHandler(this.bt_clearAll_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(287, 83);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_reduce
            // 
            this.bt_reduce.Location = new System.Drawing.Point(287, 41);
            this.bt_reduce.Name = "bt_reduce";
            this.bt_reduce.Size = new System.Drawing.Size(75, 23);
            this.bt_reduce.TabIndex = 1;
            this.bt_reduce.Text = "还原";
            this.bt_reduce.UseVisualStyleBackColor = true;
            this.bt_reduce.Click += new System.EventHandler(this.bt_reduce_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 12;
            this.lstBox.Location = new System.Drawing.Point(96, 30);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(168, 124);
            this.lstBox.TabIndex = 7;
            // 
            // rdB_MultiChoose
            // 
            this.rdB_MultiChoose.AutoSize = true;
            this.rdB_MultiChoose.Location = new System.Drawing.Point(27, 104);
            this.rdB_MultiChoose.Name = "rdB_MultiChoose";
            this.rdB_MultiChoose.Size = new System.Drawing.Size(47, 16);
            this.rdB_MultiChoose.TabIndex = 5;
            this.rdB_MultiChoose.Text = "多选";
            this.rdB_MultiChoose.UseVisualStyleBackColor = true;
            this.rdB_MultiChoose.CheckedChanged += new System.EventHandler(this.rdB_MultiChoose_CheckedChanged);
            // 
            // rdB_singleChoose
            // 
            this.rdB_singleChoose.AutoSize = true;
            this.rdB_singleChoose.Checked = true;
            this.rdB_singleChoose.Location = new System.Drawing.Point(27, 61);
            this.rdB_singleChoose.Name = "rdB_singleChoose";
            this.rdB_singleChoose.Size = new System.Drawing.Size(47, 16);
            this.rdB_singleChoose.TabIndex = 0;
            this.rdB_singleChoose.TabStop = true;
            this.rdB_singleChoose.Text = "单选";
            this.rdB_singleChoose.UseVisualStyleBackColor = true;
            this.rdB_singleChoose.CheckedChanged += new System.EventHandler(this.rdB_singleChoose_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsv);
            this.groupBox2.Controls.Add(this.bt_clearAllLog);
            this.groupBox2.Controls.Add(this.bt_deleteLog);
            this.groupBox2.Controls.Add(this.bt_Font);
            this.groupBox2.Controls.Add(this.bt_colorBackground);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 166);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作记录";
            // 
            // lsv
            // 
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.lsv.Location = new System.Drawing.Point(6, 14);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(446, 146);
            this.lsv.TabIndex = 20;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "操作";
            this.ColumnHeader1.Width = 200;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "时间";
            this.ColumnHeader2.Width = 200;
            // 
            // bt_clearAllLog
            // 
            this.bt_clearAllLog.Location = new System.Drawing.Point(463, 137);
            this.bt_clearAllLog.Name = "bt_clearAllLog";
            this.bt_clearAllLog.Size = new System.Drawing.Size(75, 23);
            this.bt_clearAllLog.TabIndex = 4;
            this.bt_clearAllLog.Text = "清空记录";
            this.bt_clearAllLog.UseVisualStyleBackColor = true;
            this.bt_clearAllLog.Click += new System.EventHandler(this.bt_clearAllLog_Click);
            // 
            // bt_deleteLog
            // 
            this.bt_deleteLog.AutoSize = true;
            this.bt_deleteLog.Location = new System.Drawing.Point(463, 97);
            this.bt_deleteLog.Name = "bt_deleteLog";
            this.bt_deleteLog.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteLog.TabIndex = 3;
            this.bt_deleteLog.Text = "删除记录";
            this.bt_deleteLog.UseVisualStyleBackColor = true;
            this.bt_deleteLog.Click += new System.EventHandler(this.bt_deleteLog_Click);
            // 
            // bt_Font
            // 
            this.bt_Font.AutoSize = true;
            this.bt_Font.Location = new System.Drawing.Point(463, 59);
            this.bt_Font.Name = "bt_Font";
            this.bt_Font.Size = new System.Drawing.Size(81, 23);
            this.bt_Font.TabIndex = 2;
            this.bt_Font.Text = "记录字体...";
            this.bt_Font.UseVisualStyleBackColor = true;
            this.bt_Font.Click += new System.EventHandler(this.bt_Font_Click);
            // 
            // bt_colorBackground
            // 
            this.bt_colorBackground.AutoSize = true;
            this.bt_colorBackground.Location = new System.Drawing.Point(463, 20);
            this.bt_colorBackground.Name = "bt_colorBackground";
            this.bt_colorBackground.Size = new System.Drawing.Size(81, 23);
            this.bt_colorBackground.TabIndex = 1;
            this.bt_colorBackground.Text = "颜色背景...";
            this.bt_colorBackground.UseVisualStyleBackColor = true;
            this.bt_colorBackground.Click += new System.EventHandler(this.bt_colorBackground_Click);
            // 
            // txtbo_AddCityName
            // 
            this.txtbo_AddCityName.Location = new System.Drawing.Point(93, 68);
            this.txtbo_AddCityName.Name = "txtbo_AddCityName";
            this.txtbo_AddCityName.Size = new System.Drawing.Size(100, 21);
            this.txtbo_AddCityName.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowMerge = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 447);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(584, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.toolStrip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip2_MouseMove);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 22);
            this.toolStripLabel1.Text = "...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel3.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 143);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // FrmIntegrated_chs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 472);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtbo_AddCityName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_recoveryANDhandle);
            this.Controls.Add(this.bt_reMove);
            this.Controls.Add(this.bt_AddTo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmIntegrated_chs";
            this.ShowIcon = false;
            this.Text = "多控件综合应用";
            this.Load += new System.EventHandler(this.FrmIntegrated_chs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_recoveryANDhandle.ResumeLayout(false);
            this.groupBox_recoveryANDhandle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回收处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Add_tslab;
        private System.Windows.Forms.ToolStripLabel SaveFile_tslab;
        private System.Windows.Forms.ToolStripLabel openFile_tslab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_AddTo;
        private System.Windows.Forms.Button bt_reMove;
        private System.Windows.Forms.GroupBox groupBox_recoveryANDhandle;
        private System.Windows.Forms.Button bt_openLogFile;
        private System.Windows.Forms.Button bt_loadLogFile;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_clearAll;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_reduce;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.RadioButton rdB_MultiChoose;
        private System.Windows.Forms.RadioButton rdB_singleChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.Button bt_clearAllLog;
        private System.Windows.Forms.Button bt_deleteLog;
        private System.Windows.Forms.Button bt_Font;
        private System.Windows.Forms.Button bt_colorBackground;
        private System.Windows.Forms.TextBox txtbo_AddCityName;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}