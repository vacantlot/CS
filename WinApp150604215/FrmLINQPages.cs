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
    public partial class FrmLINQPages : Form
    {
        DataSet dataset;
        public FrmLINQPages()
        {
            InitializeComponent();
        }

        private void FrmLINQPages_Load(object sender, EventArgs e)
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

       
    }
}
