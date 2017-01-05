using System;
using System.Windows.Forms;
using System.IO;

namespace WinApp150604215
{
    public partial class FrmIntegrated_chs : Form
    {
        public FrmIntegrated_chs()
        {
            InitializeComponent();
        }

        private void FrmIntegrated_chs_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            OptLog(lsv,"启动程序",DateTime.Now.ToString());
            toolStripLabel1.Text = "Windows应用程序";        
        }

        private void OptLog(ListView lv , string optStr , string OptTime)
        {
            lv.BeginUpdate();
            ListViewItem item = new ListViewItem();
            item.Text = optStr;
            ListViewItem.ListViewSubItem Subitem = new ListViewItem.ListViewSubItem();
            Subitem.Text = OptTime;
            item.SubItems.Add(Subitem);
            lv.Items.Add(item);
            lv.EndUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel2.Text = "当前日期: " + DateTime.Now.ToLongDateString();
            toolStripLabel3.Text = "当前时间: " + DateTime.Now.ToLongTimeString();

        }

        private void bt_AddTo_Click(object sender, EventArgs e)
        {
            if (txtbo_AddCityName.Text != "")
            {
                comboBox1.Items.Add(txtbo_AddCityName.Text);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                OptLog(lsv , "添加内容：" + txtbo_AddCityName.Text + "到ComboBox当中" , DateTime.Now.ToString());
            }
            else
            {
                MessageBox.Show("不能添加空白！");
            }
            txtbo_AddCityName.Clear();
        }

        private void bt_reMove_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                lstBox.Items.Add(comboBox1.SelectedItem);
                OptLog(lsv, "从ComBoBox中删除内容：" + comboBox1.Text, DateTime.Now.ToString());
                comboBox1.Items.Remove(comboBox1.SelectedItem);

                if (comboBox1.SelectedIndex == -1)
                {
                    comboBox1.Text = "";
                }
                if (comboBox1.Items.Count != 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void rdB_singleChoose_CheckedChanged(object sender, EventArgs e)
        {
            lstBox.SelectionMode = SelectionMode.One;
        }

        private void rdB_MultiChoose_CheckedChanged(object sender, EventArgs e)
        {
            lstBox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void bt_reduce_Click(object sender, EventArgs e)
        {
            for (int i = lstBox.SelectedItems.Count; i > 0; i--)
            {
                string item = lstBox.SelectedItem.ToString();
                comboBox1.Items.Add(lstBox.SelectedItem);             
                OptLog(lsv, "从ListBox中恢复内容：" + item , DateTime.Now.ToString());
                lstBox.Items.Remove(lstBox.SelectedItem);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;         //确保combobox显示的是恢复项
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            for (int i = lstBox.SelectedItems.Count; i > 0 ; i--)
            {
                string item = lstBox.SelectedItem.ToString();
                lstBox.Items.Remove(lstBox.SelectedItem);
                OptLog(lsv, "从ListBox中删除:" + item, DateTime.Now.ToString());
            }            
        }

        private void bt_clearAll_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            OptLog(lsv, "清空ListBox操作！", DateTime.Now.ToString());
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("ZhongheLog.txt"))
                {
                    File.Create("ZhongheLog.txt");
                }
                using (StreamWriter writerLog = new StreamWriter("ZhongheLog.txt", true))
                {
                    for (int i = 0; i < lsv.Items.Count; i++)
                    {
                        writerLog.WriteLine(lsv.Items[i].SubItems[0].Text + "\t" + lsv.Items[i].SubItems[1].Text);
                    }
                    writerLog.Close();
                }
                MessageBox.Show("保存成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_loadLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("ZhongheLog.txt"))
                {

                    using (StreamReader readerLog = new StreamReader("ZhongheLog.txt", true))
                    {
                        string strLine = string.Empty;
                        while ((strLine = readerLog.ReadLine()) != null)
                        {
                            ListViewItem item = new ListViewItem(strLine.Split('\t'));
                            lsv.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("读取文件出错，请确认文件是否存在！？","出错啦"  ,MessageBoxButtons.OK ,MessageBoxIcon.Warning );
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_openLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("ZhongheLog.txt"))
                {
                    System.Diagnostics.Process.Start("ZhongheLog.txt");
                }
                else
                {
                    MessageBox.Show("读取文件出错，请确认文件是否存在！？", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_colorBackground_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lsv.BackColor = colorDialog1.Color;
            OptLog(lsv, "修改ListView背景颜色！", DateTime.Now.ToString());
        }

        private void bt_deleteLog_Click(object sender, EventArgs e)
        {
            for (int i = lsv.SelectedItems.Count ; i > 0; i--)
            {
                lsv.Items.Remove(lsv.SelectedItems[i - 1]);
            }
        }

        private void bt_clearAllLog_Click(object sender, EventArgs e)
        {
            lsv.Items.Clear();
            OptLog(lsv, "清空了日志", DateTime.Now.ToString());
        }

        private void 重新加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtbo_AddCityName.Text = "";
            pictureBox1.Visible = true;
            comboBox1.Items.Clear();
            lsv.Items.Clear();
            lstBox.Items.Clear();
            txtbo_AddCityName.Focus();
            OptLog(lsv, "重新加载程序", DateTime.Now.ToString());
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lsv.Font = fontDialog1.Font;
            OptLog(lsv, "修改ListView字体！", DateTime.Now.ToString());
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAboutMe()).ShowDialog();
        }

        private void toolStrip2_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripLabel1.Text = "状态栏";
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Windows应用程序";
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripLabel1.Text = "菜单栏";

        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripLabel1.Text = "工具栏";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
