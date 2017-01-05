using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp150604215
{
    public partial class FrmSX_chs : Form
    {
        char[] arr_chs = new char[] { '猴', '鸡', '狗', '猪', '鼠', '牛', '虎', '兔', '龙', '蛇', '马', '羊' };
        ArrayList arrlist = new ArrayList();
        public FrmSX_chs()
        {
            InitializeComponent();
        }

        private void FrmSX_chs_Load(object sender, EventArgs e)
        {
            
            for (int i = DateTime.Now.Year - 80 ; i <= DateTime.Now.Year + 30; i++)
            {
                arrlist.Add(i.ToString());    
            }
            cmbYear.DataSource = arrlist;
            cmbYear.SelectedIndex = 80;
            txt1.ReadOnly = true;        
        }      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            char SX = arr_chs[(cmbYear.SelectedIndex+4) % 12];
            foreach (RadioButton RDB in gbSX.Controls)
            {
                if (RDB.Text == SX.ToString())
                {
                    RDB.CheckedChanged -= rdb_CheckedChanged;       //取消RadioButton的事件订阅，防止选定年份的后年龄再“乱跳”
                    RDB.Checked = true;
                }
            }
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txt1.Refresh();
        }

        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            foreach (CheckBox CKB in this.gbAH.Controls)
            {
                if (CKB.Checked)
                {
                    txt1.Text = CKB.Text + "、" +txt1.Text;
                }
            }
            if (txt1.Text == "")
            {
                txt1.Text = "一个也不喜欢？";
            }
            else
            {
                this.txt1.Text = txt1.Text.Substring(0, txt1.Text.Length - 1); // 处理“、”  ——当选好又清空时，再选时会多出个“、” 
            }
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton RDB in this.gbSX.Controls)
            {
                for (int i = 0 ; i < arr_chs.Length ; i++)
                {
                    if (RDB.Checked && RDB.Text == arr_chs[i].ToString())
                    {
                        if (i > 3)
                            cmbYear.SelectedIndex = 68 + i;
                        else
                            cmbYear.SelectedIndex = 80 + i;                       
                    }
                }
            }
        }

        private void rdb_MouseDown(object sender, MouseEventArgs e)
        {          
          ((RadioButton)sender).CheckedChanged += rdb_CheckedChanged;          //当点击了RadioButton后订阅RadioButton的CheckedChanged事件
        }
    }
}
