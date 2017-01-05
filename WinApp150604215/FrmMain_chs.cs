using System;
using System.Windows.Forms;

namespace WinApp150604215
{
    public partial class FrmMain_chs : Form
    {
        public FrmMain_chs()
        {
            InitializeComponent();
        }

        private void tsmiYl3_2_Click(object sender, EventArgs e)
        {
            FrmLoginFile_chs frmlogin = new FrmLoginFile_chs(this);
            frmlogin.MdiParent = this;
            frmlogin.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {          
            ShiYan_chs3_3.Enabled = false;
            ShiYan_chs3_4.Enabled = false;
            ShiYan4_1.Enabled = false;
            ShiYan4_2.Enabled = false;
            ShiYan4_3.Enabled = false;
            var frmlogin = new FrmLogin_chs(this);
            frmlogin.MdiParent = this;                       
            frmlogin.Show();
        }

        public void showShiYanOrder()
        {
            if (ShiYan_chs3_3.Enabled == false)
            {
                ShiYan_chs3_3.Enabled = true;
                ShiYan_chs3_4.Enabled = true;
                ShiYan4_1.Enabled = true;
                ShiYan4_2.Enabled = true;
                ShiYan4_3.Enabled = true;
            }      
        }

        private void ShiYan_chs3_3_Click(object sender, EventArgs e)
        {
            FrmDoubleColorBall_chs frmdoublecolorball = new FrmDoubleColorBall_chs();
            frmdoublecolorball.MdiParent = this;
            frmdoublecolorball.Show();
        }

        private void ShiYan_chs3_4_Click(object sender, EventArgs e)
        {
            FrmMouse_chs frmmousemove = new FrmMouse_chs();
            frmmousemove.MdiParent = this;
            frmmousemove.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TSMSYAH_Click(object sender, EventArgs e)
        {
            FrmSX_chs frmSX_chs = new FrmSX_chs();
            frmSX_chs.MdiParent = this;
            frmSX_chs.Show();
        }

        private void TlSMMeun_Click(object sender, EventArgs e)
        {
            FrmOrderFoods_chs frmfoods = new FrmOrderFoods_chs();
            frmfoods.MdiParent = this;
            frmfoods.Show();
        }

        private void ShiYan4_3_Click(object sender, EventArgs e)
        {
            FrmIntegrated_chs frmIntegrated = new FrmIntegrated_chs();
            frmIntegrated.MdiParent = this;
            frmIntegrated.Show();
        }

        private void 登录日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowLog frmshowlog = new FrmShowLog();
            frmshowlog.MdiParent = this;
            frmshowlog.Show();
        }

        private void 登录文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginFile_chs frmlogFile = new FrmLoginFile_chs();
            frmlogFile.MdiParent = this;
            frmlogFile.Show();
        }

        private void 信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdate_chs frmup = new FrmUpdate_chs();
            frmup.MdiParent = this;
            frmup.Show();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuery_chs frmq = new FrmQuery_chs();
            frmq.MdiParent = this;
            frmq.Show();
        }
    }
}
