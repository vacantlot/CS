using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace VSTimer
{
    public partial class Form1 : Form
    {
        Timer timer1;
        Timer timer2;
        Timer timer3;
        Timer timer4;
        TimeSpan Temp_time;
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            timer1 = new Timer();
            timer2 = new Timer();
            timer3 = new Timer();
            timer4 = new Timer();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Tick += Timer2_Tick;
            timer2.Interval = 1000 ;
            timer2.Start();
            timer3.Tick += Timer3_Tick;
            timer3.Interval = 1000;
            timer3.Start();
            timer4.Tick += Timer4_Tick;
            timer4.Interval = 1000;
            timer4.Enabled = false;
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            textBox1.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            //if (textBox1.Text != "")
            //{
            //    textBox1.Text = (DateTime.Now.TimeOfDay.Subtract(Temp_time)).ToString(@"hh\:mm\:ss");

            //}
            //else
            //{
            //    textBox1.Text = DateTime.Now.TimeOfDay.Subtract(Temp_time).ToString(@"hh\:mm\:ss");
            //}
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            int i = -1;
            foreach (Process P_item in Process.GetProcesses())
            {
                if (P_item.ProcessName == "devenv")
                {
                    i++;
                }
            }
            if (i == -1)
            {
                timer4.Enabled = false;
                listBox1.Items.Add(DateTime.Now + "：Visio Studio未开启，等待中...");
                timer3.Stop();
                stopwatch.Stop();
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {            
            foreach (Process P_item in Process.GetProcesses())
            {
                if (P_item.ProcessName == "devenv")
                {
                    listBox1.Items.Add(DateTime.Now + " : Visio Studio已开启");
                    Temp_time = DateTime.Now.TimeOfDay;
                    stopwatch.Start();
                    timer2.Stop();
                    timer4.Start();
                }
            }           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前时间 : " + DateTime.Now.ToString();
            int i = -1;
            foreach (Process P_item in Process.GetProcesses())
            {
                if (P_item.ProcessName == "devenv")
                {
                    timer3.Start();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("统计Visio Studio的开启时长");
        }
    }
}
