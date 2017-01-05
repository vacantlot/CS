using System;
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
    public partial class FrmQuery_chs : Form
    {
        DataSet dataset;       
        public FrmQuery_chs()
        {
            InitializeComponent();
        }

        private void FrmQuery_chs_Load(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbDataAdapter oleda = new DataBase().GetAllUserInfo();
                dataset = new DataSet();
                oleda.Fill(dataset, "AllUserInfo");
                dataGridView1.DataSource = dataset.Tables["AllUserInfo"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            try
            {                
                if (txt_Query.Text != string.Empty && comboBox1.Text != string.Empty)
                {
                    for (int i = 0; i < dataset.Tables["AllUserInfo"].Rows.Count; i++)
                    {
                        if (dataset.Tables["AllUserInfo"].Rows[i][0].ToString() == txt_Query.Text)
                        {
                            
                            System.Data.OleDb.OleDbDataAdapter oleda = new DataBase().QueryUserinfo(comboBox1.Text , txt_Query.Text);
                            dataset = new DataSet();
                            oleda.Fill(dataset, "AllUserInfo");
                            dataGridView1.DataSource = dataset.Tables["AllUserInfo"];
                        }
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex != 0)
                    {
                        MessageBox.Show("请选择要查询的方式!");
                    }
                    else
                    {
                        MessageBox.Show("请输入要查询的 "+comboBox1.Text);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
