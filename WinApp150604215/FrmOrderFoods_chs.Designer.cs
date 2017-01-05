namespace WinApp150604215
{
    partial class FrmOrderFoods_chs
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
            this.lab1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsb_Meun = new System.Windows.Forms.ListBox();
            this.lsb_OrderedMeun = new System.Windows.Forms.ListBox();
            this.bt_AddSeleted = new System.Windows.Forms.Button();
            this.bt_AddAllSeleted = new System.Windows.Forms.Button();
            this.bt_cancelSeleted = new System.Windows.Forms.Button();
            this.bt_cancelAllSeleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(78, 43);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(29, 12);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "菜单";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择的菜";
            // 
            // lsb_Meun
            // 
            this.lsb_Meun.ColumnWidth = 10;
            this.lsb_Meun.FormattingEnabled = true;
            this.lsb_Meun.ItemHeight = 12;
            this.lsb_Meun.Location = new System.Drawing.Point(12, 83);
            this.lsb_Meun.Name = "lsb_Meun";
            this.lsb_Meun.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsb_Meun.Size = new System.Drawing.Size(146, 256);
            this.lsb_Meun.Sorted = true;
            this.lsb_Meun.TabIndex = 2;
            this.lsb_Meun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Meun_MouseMove);
            // 
            // lsb_OrderedMeun
            // 
            this.lsb_OrderedMeun.FormattingEnabled = true;
            this.lsb_OrderedMeun.ItemHeight = 12;
            this.lsb_OrderedMeun.Location = new System.Drawing.Point(287, 83);
            this.lsb_OrderedMeun.Name = "lsb_OrderedMeun";
            this.lsb_OrderedMeun.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsb_OrderedMeun.Size = new System.Drawing.Size(146, 256);
            this.lsb_OrderedMeun.Sorted = true;
            this.lsb_OrderedMeun.TabIndex = 3;
            // 
            // bt_AddSeleted
            // 
            this.bt_AddSeleted.Location = new System.Drawing.Point(185, 110);
            this.bt_AddSeleted.Name = "bt_AddSeleted";
            this.bt_AddSeleted.Size = new System.Drawing.Size(75, 23);
            this.bt_AddSeleted.TabIndex = 4;
            this.bt_AddSeleted.Text = "添加选择";
            this.bt_AddSeleted.UseVisualStyleBackColor = true;
            this.bt_AddSeleted.Click += new System.EventHandler(this.bt_AddSeleted_Click);
            // 
            // bt_AddAllSeleted
            // 
            this.bt_AddAllSeleted.Location = new System.Drawing.Point(185, 157);
            this.bt_AddAllSeleted.Name = "bt_AddAllSeleted";
            this.bt_AddAllSeleted.Size = new System.Drawing.Size(75, 23);
            this.bt_AddAllSeleted.TabIndex = 5;
            this.bt_AddAllSeleted.Text = "添加所有";
            this.bt_AddAllSeleted.UseVisualStyleBackColor = true;
            this.bt_AddAllSeleted.Click += new System.EventHandler(this.bt_AddAllSeleted_Click);
            // 
            // bt_cancelSeleted
            // 
            this.bt_cancelSeleted.Location = new System.Drawing.Point(185, 252);
            this.bt_cancelSeleted.Name = "bt_cancelSeleted";
            this.bt_cancelSeleted.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelSeleted.TabIndex = 6;
            this.bt_cancelSeleted.Text = "取消选择";
            this.bt_cancelSeleted.UseVisualStyleBackColor = true;
            this.bt_cancelSeleted.Click += new System.EventHandler(this.bt_cancelSeleted_Click);
            // 
            // bt_cancelAllSeleted
            // 
            this.bt_cancelAllSeleted.Location = new System.Drawing.Point(185, 298);
            this.bt_cancelAllSeleted.Name = "bt_cancelAllSeleted";
            this.bt_cancelAllSeleted.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelAllSeleted.TabIndex = 7;
            this.bt_cancelAllSeleted.Text = "取消所有";
            this.bt_cancelAllSeleted.UseVisualStyleBackColor = true;
            this.bt_cancelAllSeleted.Click += new System.EventHandler(this.bt_cancelAllSeleted_Click);
            // 
            // FrmOrderFoods_chs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 390);
            this.Controls.Add(this.bt_cancelAllSeleted);
            this.Controls.Add(this.bt_cancelSeleted);
            this.Controls.Add(this.bt_AddAllSeleted);
            this.Controls.Add(this.bt_AddSeleted);
            this.Controls.Add(this.lsb_OrderedMeun);
            this.Controls.Add(this.lsb_Meun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab1);
            this.Name = "FrmOrderFoods_chs";
            this.Text = "电子菜单";
            this.Load += new System.EventHandler(this.FrmOrderFoods_chs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsb_Meun;
        private System.Windows.Forms.ListBox lsb_OrderedMeun;
        private System.Windows.Forms.Button bt_AddSeleted;
        private System.Windows.Forms.Button bt_AddAllSeleted;
        private System.Windows.Forms.Button bt_cancelSeleted;
        private System.Windows.Forms.Button bt_cancelAllSeleted;
    }
}