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
    public partial class FrmShowPicture : Form
    {
        FrmOrderFoods_chs frmfoods;
        public FrmShowPicture()
        {
            InitializeComponent();
        }
        public FrmShowPicture(FrmOrderFoods_chs frmorderfoods)
        {
            InitializeComponent();
            frmfoods = frmorderfoods;
        }

        private void FrmShowPicture_Load(object sender, EventArgs e)
        {
            if (frmfoods.itemName == "夫妻肺片")
            {
                pictureBox1.Image = Properties.Resources.夫妻肺片;
            }
            if (frmfoods.itemName == "干锅")
            {
                pictureBox1.Image = Properties.Resources.干锅牛蛙;
            }
            if (frmfoods.itemName == "锅盔")
            {
                pictureBox1.Image = Properties.Resources.锅盔;
            }
            if (frmfoods.itemName == "回锅肉")
            {
                pictureBox1.Image = Properties.Resources.回锅肉;
            }
            if (frmfoods.itemName == "麻婆豆腐")
            {
                pictureBox1.Image = Properties.Resources.麻婆豆腐;
            }
            if (frmfoods.itemName == "酥肉")
            {
                pictureBox1.Image = Properties.Resources.酥肉;
            }
            if (frmfoods.itemName == "土豆烧牛肉")
            {
                pictureBox1.Image = Properties.Resources.土豆烧牛肉;
            }
            if (frmfoods.itemName == "毛血旺")
            {
                pictureBox1.Image = Properties.Resources.毛血旺;
            }
            if (frmfoods.itemName == "水煮肉片")
            {
                pictureBox1.Image = Properties.Resources.水煮肉片;
            }

        }
    }
}
