using System;
using System.Windows.Forms;

namespace WinApp150604215
{
    public partial class FrmMouse_chs : Form
    {
        private int location;
        Random ra = new Random();
        public FrmMouse_chs()
        {
            InitializeComponent();
        }

        private void mouseMove_chs_Load(object sender, EventArgs e)
        {
            location = 0;      
            label3.Visible = false;
        }

        private void FrmMouseMove_chs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (e.Clicks == 2))
            {
                location = 1;
                label3.Location = label1.Location;
            }
            else if((e.Button == MouseButtons.Left) && (e.Clicks == 2))
            {
                location = 0;
                label3.Visible = false;
                label1.Visible = true;
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if (location == 1)
            {
                label1.Visible = false;
                label3.Visible = true;               
            }
            else
            {
                label1.SetBounds(
                    ra.Next(0,ClientRectangle.Width - label1.Width),
                    ra.Next(0,ClientRectangle.Height - label1.Height),
                    label1.Width ,
                   label1.Height);                
            }
        }

        private void FrmMouseMove_chs_ClientSizeChanged(object sender, EventArgs e)
        {
            label1.SetBounds(
                    ra.Next(0, ClientRectangle.Width - label1.Width),
                    ra.Next(0, ClientRectangle.Height - label1.Height),
                    label1.Width,
                    label1.Height);
        }
    }
}
