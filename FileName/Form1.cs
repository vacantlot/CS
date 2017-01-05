using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "请选择欲更改的文件夹";
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                if (folderName != "") { textBox1.Text = folderName; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(textBox1.Text);
            foreach (string str in path)
            {
                FileInfo fi = new FileInfo(str);
                string oldFileName = fi.Name.Substring(0, fi.Name.LastIndexOf("."));//获取文件名并截取
                int pos = oldFileName.IndexOf(Search_key.Text);  //查找关键值,返回有效值的位置
                if (pos < 0)
                {
                    continue;
                }
                string tempFileName = oldFileName.Substring(pos);
                string newFileName = "";
                string classNum = "";
                string name = "";
                foreach (char _classNum in tempFileName)   //读出字符串中的班级
                {
                   
                    if (Regex.Match(_classNum.ToString() , "[\u4e00-\u9fa5]+").Success) break;
                    if (Regex.Match(_classNum.ToString() , "\\d+$").Success)
                    {
                            classNum += _classNum.ToString();
                    }
                    
                }
                newFileName += classNum;

                foreach (char _name in tempFileName)    //读出字符串中的姓名
                {
                    if (Regex.Match(_name.ToString(), "实").Success) break;
                    if (Regex.Match(_name.ToString(), "[\u4e00-\u9fa5]+").Success)
                    {
                        name += _name.ToString();
                    }                   
                }
                newFileName += name;
                //Regex regChinese = new Regex("[\u4e00-\u9fa5]+");
                //foreach (Match name in regChinese.Matches(tempFileName))  //读出字符串中的姓名
                //{
                //    newFileName += name;

                //}
                newFileName += "实验";
                if (!(textBox2.Text == ""))
                {
                    newFileName += textBox2.Text;
                  //newFileName = newFileName.Substring(0, newFileName.Length - 1) + textBox2.Text;//修改将实验“一”修改为实验”1”
                }
               
                newFileName = textBox1.Text + "\\" + newFileName + fi.Extension; //赋值新改的名字                
                fi.MoveTo(newFileName);
            }

            MessageBox.Show("更改成功!");
        }

        

    }
}
