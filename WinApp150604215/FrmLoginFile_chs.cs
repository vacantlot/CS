using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WinApp150604215
{
    public partial class FrmLoginFile_chs : Form
    {
        private FrmMain_chs frmMain;
        struct User
        {
            internal string Name;
            internal string Xuehao;
            internal string Nianji;
            internal string Zhuanye;
            internal string School;
            internal string passWord;
        };
        private User[] users = new User[5];
        public FrmLoginFile_chs()
        {
            InitializeComponent();
        }
        public FrmLoginFile_chs(FrmMain_chs frmMian)
        {
            InitializeComponent();
            frmMain = frmMian;             //将传过来的FormMain全部赋值给frmMain，这样就可以在这FrmLogin中调用FormMain了
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            if (button2.Text == "退出")
            {
                this.Close();
            }
            else if (button2.Text == "注销")
            {
                TxtName.Focus();
                label1.Text = "";
                button1.Visible = true;
                button2.Text = "退出";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int i = 0;

            if (TxtName.Text == "" && TxtPassWord.Text == "")
            {
                MessageBox.Show("请输入账号！");
                TxtName.Focus();
            }
            else if (TxtName.Text != "" && TxtPassWord.Text == "")
            {
                MessageBox.Show("请输入密码…");
                TxtPassWord.Focus();
            }
            else
            {
                while (true)
                {
                    if (TxtName.Text == users[i].Name && TxtPassWord.Text == users[i].passWord)
                    {
                        label1.Text = "用户:" + users[i].Name + " 已登录";
                        button1.Visible = false;
                        button2.Text = "注销";
                        TxtName.Clear();
                        TxtPassWord.Clear();                        
                        if (!File.Exists("Log.txt"))
                        {
                            File.Create("Log.txt").Close();
                        }
                        string strLog = users[i].Name +"\t"+ DateTime.Now.ToString();
                        StreamWriter sWriter = new StreamWriter("Log.txt", true);                       
                        sWriter.WriteLine(strLog);
                        sWriter.Close();                       
                    }
                    i++;
                    if (i > 4)
                    {
                        if (label1.Text == "")
                        {
                            MessageBox.Show("账号或密码错误！");
                            TxtName.Focus();
                            TxtName.SelectAll();
                        }
                        break;
                    }
                }
            }
            

        }

        private void FrmLoginFile_chs_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(@"..\..\Resources\UserName.txt"))
                {
                    MessageBox.Show("文件不存在！");
                }
                else
                {
                    using (StreamReader sReaderName = new StreamReader(@"..\..\Resources\UserName.txt", true))
                    {
                        string[] str = sReaderName.ReadLine().Split('\t');//过滤表头
                        for (int i = 0; i < 5; i++)
                        {
                            str = sReaderName.ReadLine().Split('\t');
                            users[i].Name = str[0];
                            users[i].Xuehao = str[1];
                            users[i].Nianji = str[2];
                            users[i].Zhuanye = str[3];
                            users[i].School = str[4];
                        }
                        sReaderName.Close();
                        if (!File.Exists(@"..\..\Resources\UserPassword.txt"))
                        {
                            MessageBox.Show("文件不存在！");
                        }
                        else
                        {
                            using (StreamReader sReaderPassword = new StreamReader(@"..\..\Resources\UserPassword.txt", true))
                            {
                                string[] str2 = sReaderPassword.ReadLine().Split('\t');//过滤表头
                                for (int i = 0; i < 5; i++)
                                {
                                    str2 = sReaderPassword.ReadLine().Split('\t');
                                    users[i].passWord = str2[1];
                                }
                                sReaderPassword.Close();
                            }

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
