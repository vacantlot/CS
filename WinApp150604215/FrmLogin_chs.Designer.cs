namespace WinApp150604215
{
    partial class FrmLogin_chs
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
            this.userNameLaber = new System.Windows.Forms.Label();
            this.passWordLabel = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLaber
            // 
            this.userNameLaber.AutoSize = true;
            this.userNameLaber.Location = new System.Drawing.Point(36, 39);
            this.userNameLaber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLaber.Name = "userNameLaber";
            this.userNameLaber.Size = new System.Drawing.Size(53, 12);
            this.userNameLaber.TabIndex = 0;
            this.userNameLaber.Text = "用户名：";
            // 
            // passWordLabel
            // 
            this.passWordLabel.AutoSize = true;
            this.passWordLabel.Location = new System.Drawing.Point(36, 79);
            this.passWordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passWordLabel.Name = "passWordLabel";
            this.passWordLabel.Size = new System.Drawing.Size(53, 12);
            this.passWordLabel.TabIndex = 1;
            this.passWordLabel.Text = "密  码：";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(110, 37);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(68, 21);
            this.TxtName.TabIndex = 2;
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Location = new System.Drawing.Point(110, 77);
            this.TxtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.PasswordChar = '*';
            this.TxtPassWord.Size = new System.Drawing.Size(68, 21);
            this.TxtPassWord.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(35, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(123, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLogin_chs
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(214, 194);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPassWord);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.passWordLabel);
            this.Controls.Add(this.userNameLaber);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin_chs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLaber;
        private System.Windows.Forms.Label passWordLabel;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}