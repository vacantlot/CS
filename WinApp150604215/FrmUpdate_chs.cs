using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WinApp150604215
{
    public partial class FrmUpdate_chs : Form
    {
        string FILENAME = string.Empty;
        public FrmUpdate_chs()
        {
            InitializeComponent();
        }
        private void FrmUpdate_chs_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            List<string> ID = (new DataBase()).GetUserLoginID();
            for (int i = 0; i < ID.Count; i++)
            {
                this.comboBox1.Items.Add(ID[i]);
            }
            this.comboBox1.SelectedIndex = 0;
            btn_Picdialog.Visible = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text.Trim(), "^\\d+$"))
            {
                ((TextBox)sender).Text = "";
            }
        }

        /// <summary>
        /// 读取信息填入到各控件中
        /// </summary>
        private void fillInfo()
        {
            try
            {

                ArrayList userInfo = new DataBase().GetOneInfo(this.comboBox1.Text);
                if (userInfo.Count != 0)
                {
                    txt_name.Text = userInfo[0].ToString();
                    txt_major.Text = userInfo[1].ToString();
                    txt_xuehao.Text = userInfo[4].ToString();
                    if (userInfo[2].ToString() == "True")
                    {
                        rdB_boy.Checked = true;
                    }
                    else
                    {
                        rdB_girl.Checked = true;
                    }

                    if (userInfo[3].ToString() != string.Empty)
                    {
                        this.pictureBox1.Image = Image.FromFile(@"..\..\Resources\images\" + userInfo[3].ToString() + ".bmp");
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        this.pictureBox1.Image = Image.FromFile(@"..\..\Resources\images\" + "00" + ".bmp"); 
                    }
                }
                else
                {
                    this.txt_name.Text = "";
                    this.txt_major.Text = "";
                    this.rdB_boy.Checked = false;
                    this.rdB_girl.Checked = false;
                    this.pictureBox1.Image = null;
                }
            }
            catch (System.Exception ex)
            {
                this.pictureBox1.Image = Image.FromFile(@"..\..\Resources\images\" + "00" + ".bmp"); ;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fillInfo();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text == "增加")
            {
                btn_Mod.Visible = false;
                btn_Del.Visible = false;
                comboBox1.Visible = false;
                btn_Picdialog.Visible = true;
                btn_Add.Text = "完成";
                this.txt_name.ReadOnly = false;
                this.txt_name.Text = "";
                this.txt_major.ReadOnly = false;
                this.txt_major.Text = "";
                this.txt_xuehao.Text = "";
                this.txt_xuehao.ReadOnly = false;
                this.rdB_boy.Checked = false;
                this.rdB_girl.Checked = false;
                this.pictureBox1.Image = null;
            }
            else
            {
                btn_Mod.Visible = true;
                btn_Del.Visible = true;
                btn_Picdialog.Visible = false;
                comboBox1.Visible = true;
                this.txt_name.ReadOnly = false;               
                this.txt_major.ReadOnly = false;                
                this.txt_xuehao.ReadOnly = false;
                this.txt_name.ReadOnly = false;              
                this.txt_major.ReadOnly = false;               
                this.txt_xuehao.ReadOnly = false;
                string SEX = "True";
                if (!rdB_boy.Checked)
                {
                    SEX = "False";
                }
                (new DataBase()).InsertUser(txt_name.Text, txt_xuehao.Text, txt_major.Text, SEX, FILENAME);
                btn_Add.Text = "增加";
                System.Threading.Thread.Sleep(1000);
                FrmUpdate_chs_Load(sender, e);
            }

        }
        private void btn_Picdialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"..\..\Resources\images";
            dialog.RestoreDirectory = true;
            dialog.Filter = "bmp文件(*.bmp)|*.bmp|jpg文件(*.jpg)|*.jpg";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(dialog.FileName);
                FILENAME = dialog.FileName.Substring(dialog.FileName.LastIndexOf("images\\")).Substring(7, 2);             
            }

        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认要删除该用户记录？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                (new DataBase()).DeleteUserInfo(comboBox1.Text);
            }
            System.Threading.Thread.Sleep(500);
            FrmUpdate_chs_Load(sender, e);
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            if (btn_Mod.Text == "修改")
            {
                btn_Mod.Text = "确定";
                btn_Add.Visible = false;
                btn_Del.Visible = false;
                comboBox1.Visible = false;
                btn_Picdialog.Visible = true;
                this.txt_name.ReadOnly = false;               
                this.txt_major.ReadOnly = false;               
                this.txt_xuehao.ReadOnly = false;
            }
            else
            {
                btn_Mod.Text = "修改";
                btn_Add.Visible = true;
                btn_Del.Visible = true;
                btn_Picdialog.Visible = false;
                comboBox1.Visible = true;
                this.txt_name.ReadOnly = false;
                this.txt_major.ReadOnly = false;
                this.txt_xuehao.ReadOnly = false;
                string SEX = "True";
                if (!rdB_boy.Checked)
                {
                    SEX = "False";
                }
                //FILENAME = pictureBox1.ImageLocation;
                //MessageBox.Show(FILENAME);
                (new DataBase()).ModifyUserInfo(comboBox1.Text, txt_name.Text, txt_xuehao.Text, txt_major.Text, SEX, FILENAME);
                btn_Add.Text = "增加";
                System.Threading.Thread.Sleep(500);
                FrmUpdate_chs_Load(sender, e);
            }
        }
    }
}
