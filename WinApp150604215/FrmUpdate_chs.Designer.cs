namespace WinApp150604215
{
    partial class FrmUpdate_chs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_xuehao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Picdialog = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_major = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdB_girl = new System.Windows.Forms.RadioButton();
            this.rdB_boy = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Mod = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_xuehao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_Picdialog);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_major);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdB_girl);
            this.groupBox1.Controls.Add(this.rdB_boy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // txt_xuehao
            // 
            this.txt_xuehao.Location = new System.Drawing.Point(92, 73);
            this.txt_xuehao.Name = "txt_xuehao";
            this.txt_xuehao.ReadOnly = true;
            this.txt_xuehao.Size = new System.Drawing.Size(100, 21);
            this.txt_xuehao.TabIndex = 1;
            this.txt_xuehao.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "学  号:";
            // 
            // btn_Picdialog
            // 
            this.btn_Picdialog.Location = new System.Drawing.Point(274, 166);
            this.btn_Picdialog.Name = "btn_Picdialog";
            this.btn_Picdialog.Size = new System.Drawing.Size(75, 23);
            this.btn_Picdialog.TabIndex = 6;
            this.btn_Picdialog.Text = "浏览图片";
            this.btn_Picdialog.UseVisualStyleBackColor = true;
            this.btn_Picdialog.Click += new System.EventHandler(this.btn_Picdialog_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_major
            // 
            this.txt_major.Location = new System.Drawing.Point(92, 195);
            this.txt_major.Name = "txt_major";
            this.txt_major.ReadOnly = true;
            this.txt_major.Size = new System.Drawing.Size(100, 21);
            this.txt_major.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "专  业";
            // 
            // rdB_girl
            // 
            this.rdB_girl.AutoSize = true;
            this.rdB_girl.Location = new System.Drawing.Point(157, 162);
            this.rdB_girl.Name = "rdB_girl";
            this.rdB_girl.Size = new System.Drawing.Size(35, 16);
            this.rdB_girl.TabIndex = 4;
            this.rdB_girl.TabStop = true;
            this.rdB_girl.Text = "女";
            this.rdB_girl.UseVisualStyleBackColor = true;
            // 
            // rdB_boy
            // 
            this.rdB_boy.AutoSize = true;
            this.rdB_boy.Location = new System.Drawing.Point(92, 162);
            this.rdB_boy.Name = "rdB_boy";
            this.rdB_boy.Size = new System.Drawing.Size(35, 16);
            this.rdB_boy.TabIndex = 3;
            this.rdB_boy.TabStop = true;
            this.rdB_boy.Text = "男";
            this.rdB_boy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性  别";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 124);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(92, 118);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "个人照片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(37, 321);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Mod
            // 
            this.btn_Mod.Location = new System.Drawing.Point(155, 321);
            this.btn_Mod.Name = "btn_Mod";
            this.btn_Mod.Size = new System.Drawing.Size(75, 23);
            this.btn_Mod.TabIndex = 2;
            this.btn_Mod.Text = "修改";
            this.btn_Mod.UseVisualStyleBackColor = true;
            this.btn_Mod.Click += new System.EventHandler(this.btn_Mod_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(275, 321);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 3;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // FrmUpdate_chs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 368);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Mod);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmUpdate_chs";
            this.ShowIcon = false;
            this.Text = "FrmUpdate_chs";
            this.Load += new System.EventHandler(this.FrmUpdate_chs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Mod;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txt_major;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdB_girl;
        private System.Windows.Forms.RadioButton rdB_boy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Picdialog;
        private System.Windows.Forms.TextBox txt_xuehao;
        private System.Windows.Forms.Label label6;
    }
}