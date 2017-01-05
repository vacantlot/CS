using System;
using System.Windows.Forms;

namespace WinApp150604215
{

    public partial class FrmStart_chs : Form
    {
        public FrmStart_chs()
        {
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Enabled = true;
            timer1.Interval = 5000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DataBase db = new DataBase();
            if (db.ConIsOpen())
            {
                FrmMain_chs frmMain = new FrmMain_chs();
                Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("连接数据库失败！");
                Application.Exit();
            }
        }
    }
}
