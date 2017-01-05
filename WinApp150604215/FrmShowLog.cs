using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinApp150604215
{
    public partial class FrmShowLog : Form
    {
        public FrmShowLog()
        {
            InitializeComponent();
        }

        private void FrmShowLog_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Log.txt"))
            {
                File.Create("Log.txt").Close();
            }
            string strLine = string.Empty;
            using(StreamReader sReader = new StreamReader("Log.txt" , true))
            {
                while ((strLine = sReader.ReadLine()) != null)
                {
                    string[] strLogs = strLine.Split('\t');
                    listView1.BeginUpdate();
                    ListViewItem item = new ListViewItem();
                    item.Text = strLogs[0];               
                    ListViewItem.ListViewSubItem Subitem = new ListViewItem.ListViewSubItem();
                    Subitem.Text = strLogs[1];
                    listView1.Items.Add(item);
                    item.SubItems.Add(Subitem);                   
                    listView1.EndUpdate();
                }
                sReader.Close();
            }
        }
    }
}
