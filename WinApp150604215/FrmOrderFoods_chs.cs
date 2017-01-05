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
    public partial class FrmOrderFoods_chs : Form
    {       
        public string itemName;
        public FrmOrderFoods_chs()
        {
            InitializeComponent();
        }

        private void FrmOrderFoods_chs_Load(object sender, EventArgs e)
        {
            string[] str = { "麻婆豆腐", "回锅肉", "酥肉", "锅盔", "毛血旺", "夫妻肺片", "干锅", "土豆烧牛肉" , "水煮肉片" };
            for (int i = 0; i < str.Length; i++)
            {
                lsb_Meun.Items.Add(str[i]);
            }
        }
        private void lb_Meun_MouseMove(object sender, MouseEventArgs e)
        {
           int AIndex = ((ListBox)sender).IndexFromPoint(e.Location);
            if (AIndex < 0) return;
            itemName = ((ListBox)sender).Items[AIndex].ToString();
           // FrmShowPicture frmpicture =new FrmShowPicture(this);     
            new FrmShowPicture(this).Show();                          //新建一个窗体用于显示菜品                     
        }

        private void bt_AddSeleted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsb_Meun.SelectedItems.Count; i++)
            {
                if (!lsb_OrderedMeun.Items.Contains(lsb_Meun.SelectedItems[i]))
                {
                    lsb_OrderedMeun.Items.Add(lsb_Meun.SelectedItems[i]);
                }
                else
                {
                    MessageBox.Show("你已经选择了"+lsb_Meun.SelectedItems[i] + ", 不能重复选择！");
                }
            }
        }

        private void bt_AddAllSeleted_Click(object sender, EventArgs e)
        {
            lsb_OrderedMeun.Items.Clear();
            lsb_OrderedMeun.Items.AddRange(lsb_Meun.Items);
        }

        private void bt_cancelSeleted_Click(object sender, EventArgs e)
        {
            while (!(lsb_OrderedMeun.SelectedItems.Count == 0))
            {
                lsb_OrderedMeun.Items.Remove(lsb_OrderedMeun.SelectedItem);
            }
        }

        private void bt_cancelAllSeleted_Click(object sender, EventArgs e)
        {
            lsb_OrderedMeun.Items.Clear();
        }
    }
}
