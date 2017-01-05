using System.Drawing;

namespace WinApp150604215
{
    partial class FrmMouse_chs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMouse_chs));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "你能抓住我吗？";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(129, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "恭喜你";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmMouseMove_chs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMouseMove_chs";
            this.Text = "来抓我";
            this.Load += new System.EventHandler(this.mouseMove_chs_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FrmMouseMove_chs_ClientSizeChanged);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmMouseMove_chs_MouseDoubleClick);
            this.ResumeLayout(false);

        }
        

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}