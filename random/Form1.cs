using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace random
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1, timer2;
        //private delegate void ReadText();      //定义一个线程委托
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer2 = new System.Windows.Forms.Timer();
            
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox5.Clear();
            button3.Visible = true;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                MessageBox.Show("输入参数错误!");
                textBox2.Text = "0";
                textBox1.Text = "0";
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("请输入抽取个数！");
            }
            else
            {
                timer1.Tick += new EventHandler(Sendmessage);
                timer1.Start();
                timer1.Interval = 50;

                timer2.Tick += new EventHandler(readText4);
                timer2.Start();
                if (timer2.Interval == 100)
                {
                    timer2.Interval = 1000 * 10;
                }
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text == "暂停")
            {
                this.button3.Text = "继续";
                this.timer1.Stop();
                this.timer2.Stop();

            }else

            if (this.button3.Text == "继续")
            {
                this.button3.Text = "暂停";
                this.timer1.Start();
                this.timer2.Start();
            }
        }

        public void Sendmessage(object source, EventArgs e)
        {
            Random ra = new Random();
            textBox4.Text =
            ra.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text) + 1).ToString();
        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (textBox1.Text == "")
        //    {
        //    }
        //    else             
        //    {
        //        if (!Regex.IsMatch(textBox1.Text, "^\\d+$"))
        //        //textBox1.Text = "";               
        //        {
        //            this.textBox4.Clear();
        //            MessageBox.Show("只能输入数字！");
        //        }
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text.Trim(), "^\\d+$"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox2.Text.Trim(), "^\\d+$"))
            {
                textBox2.Text = "";
                textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text.Trim(), "^\\d+$"))
            {
                textBox3.Text = "";
                textBox3.Clear();
            }
            if (textBox3.Text != "")
                if (int.Parse(textBox2.Text)+1 - int.Parse(textBox1.Text) < int.Parse(textBox3.Text))
                {
                    MessageBox.Show("抽取个数超限！");
                    textBox3.Clear();
                }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "点击开始运行计数器");
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox5, "随机抽取出的序号");            
        }

       

        

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 2 * 1000;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer2.Interval = 5 * 1000;

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer2.Interval = 10 * 1000;

        }

        private void readText4(object sender, EventArgs e)
        {
            count++;
            if (count == int.Parse(textBox3.Text))
            {
                timer1.Stop();
                timer2.Stop();
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button1.Enabled = true;
                
                button3.Visible = false;
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = textBox4.Text + " ";
            }
            else
            {
                Random ra = new Random();
                while (true)
                {
                    int temp = ra.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text) + 1);
                    if (textBox5.Text.Contains(temp.ToString()))   //新生成的随机数是否已存在textBox5.Text中
                        continue;
                    else
                    {
                        textBox5.Text += temp.ToString() + " ";
                        break;
                    }
                }
            }
        }

    }
}
