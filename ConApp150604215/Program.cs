using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConApp150604215
{

    class Program
    {
 //实验一       
#region 实验一
       
        static public void shiyan1() 
        {
            int an;
            bool An = true;
            do
            {
                an = menu_chs();
                if (an == 0) { An = false; }
                switch (an)
                {
                    case 1: MultiplicationTable_chs(); break;
                    case 2: ShengXiao_chs(); break;
                    case 3: Ticket_chs(); break;
                    case 4: StrEncrypt_chs(); break;
                    case 0: break;
                    default: Console.WriteLine("请重新输入！！"); break;
                }
            } while (An);
        }
        static public int menu_chs()
        {
            System.Console.Clear();
            int demo_chs = 0;
            Console.WriteLine("控制台菜单");
            Console.WriteLine("1.九九乘法表");
            Console.WriteLine("2.生肖查询");
            Console.WriteLine("3.客车售票系统");
            Console.WriteLine("4.字符串加密");
            Console.WriteLine("0.退出");
            Console.WriteLine("请输入对应序号：");
            demo_chs = Convert.ToInt32(Console.ReadLine());
            if (demo_chs > 6 || demo_chs < 0)
            {
                if (demo_chs < 0)
                    Console.WriteLine("你输入的{0}是负数 请按任意键继续……", demo_chs);
                else
                    Console.WriteLine("你输入的{0}超范围 请按任意键继续……", demo_chs);
                Console.ReadLine();
            }
            System.Console.Clear();
            return demo_chs;
        }

        static public void MultiplicationTable_chs()
        {

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} * {1} = {2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("请按任意键继续……");
            Console.ReadLine();
        }

        static public void ShengXiao_chs()
        {
            int demo_chs = 0;
            char[] arr_chs = new char[] { '猴', '鸡', '狗', '猪', '鼠', '牛', '虎', '兔', '龙', '蛇', '马', '羊' };
            Console.Write("请输入你要查询的年份：");
            demo_chs = int.Parse(Console.ReadLine());
            Console.Write("对应的生肖是:" + arr_chs[demo_chs % 12]);
            Console.ReadLine();
        }

        static public void Ticket_chs()
        {
            int rows = 0, cols = 0;
            Console.Write("请输入座位的行数：");
            rows = int.Parse(Console.ReadLine());
            Console.Write("请输入座位的列数：");
            cols = int.Parse(Console.ReadLine());
            string[,] zuo_chs = new string[rows, cols];

            for (int i = 0; i < zuo_chs.GetLength(0); i++)
                for (int j = 0; j < zuo_chs.GetLength(1); j++)
                {
                    zuo_chs[i, j] = "[有票]";
                }

            string s = string.Empty;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n     简单客车售票系统" + "\n");
                for (int i = 0; i < zuo_chs.GetLength(0); i++)
                {
                    for (int j = 0; j < zuo_chs.GetLength(1); j++)
                    {
                        System.Console.Write(zuo_chs[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("请输入座位行号和列号（如1,2）输入q键退出：");
                s = Console.ReadLine();
                if (s == "q") break;
                string[] ss = s.Split(',');
                rows = int.Parse(ss[0]) - 1;
                cols = int.Parse(ss[1]) - 1;
                zuo_chs[rows, cols] = "[已售]";
            }
            Console.WriteLine("请按任意键继续……");
            Console.ReadLine();
        }

        static public void StrEncrypt_chs()
        {
            int i = 0; int[] ss = new int[50];
            Console.Write("请输入需要加密的字符：");
            string str = Console.ReadLine();
            Console.Write("请输入秘钥：");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("加密后的字符为：");
            while (true)
            {
                if (i >= str.Length) break;
                ss[i] = str[i];

                if (ss[i] >= 48 && ss[i] <= 57)
                {
                    ss[i] += (key % 10);
                    if (ss[i] > 57) ss[i] -= 10;
                }

                if (ss[i] >= 65 && ss[i] <= 90)
                {
                    ss[i] += (key % 26);
                    if (ss[i] > 90) ss[i] -= 26;
                }

                if (ss[i] >= 97 && ss[i] <= 122)
                {
                    ss[i] += (key % 26);
                    if (ss[i] > 122) ss[i] -= 26;

                }
                Console.Write((char)ss[i]);
                i++;
            }



            Console.WriteLine();
            Console.WriteLine("请按任意键继续……");
            Console.ReadLine();
        }
        #endregion
//实验2
#region 实验二

        static public void shiyan2()
        {
            
            int an;
            bool An = true;
            do
            {
                an = menuShiyan2_chs();
                if (an == 0) { An = false; }
                switch (an)
                {
                    case 1: shiyan2_1(); break;
                    case 2: shiyan2_2(); break;
                    case 3: shiyan2_3(); break;
                    case 0: break;
                    default: Console.WriteLine("请重新输入！！"); break;
                }
            } while (An);
        }

        static public int menuShiyan2_chs()
        {
            System.Console.Clear();
            int demo_chs = 0;
            Console.WriteLine("控制台菜单");
            Console.WriteLine("1.面积计算");
            Console.WriteLine("2.面积计算（继承）");
            Console.WriteLine("3.学生成绩管理");
            Console.WriteLine("0.退出");
            Console.WriteLine("请输入对应序号：");
            demo_chs = Convert.ToInt32(Console.ReadLine());
            if (demo_chs > 4 || demo_chs < 0)
            {
                if (demo_chs < 0)
                    Console.WriteLine("你输入的{0}是负数 请按任意键继续……", demo_chs);
                else
                    Console.WriteLine("你输入的{0}超范围 请按任意键继续……", demo_chs);
                Console.ReadLine();
            }
            System.Console.Clear();
            return demo_chs;
        }

        static public String judgeInput(String r)
        {

            while (true)
            {
                if (!Regex.Match(r, "^\\d+$").Success)
                {
                    Console.WriteLine("你输入的" + r + "为非数字!请重新输入");
                    r =  Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                    return r;
            }

            //    if (!Regex.Match(s, "^\\d+$").Success)

            //   // else if (Regex.Match(s, "^[a-zA-Z]+$").Success)
            //     //   return "字符";

            //        throw "你输入的为非数字。";
        }

        static public void shiyan2_2()
        {
            rectAngle rectangle = new rectAngle();
            circle cir = new circle();
            Console.WriteLine("请输入圆的半径：");
            String r = Console.ReadLine();
            cir.R_chs = double.Parse(judgeInput(r));
            cir.area_chs();
            cir.girth_chs();
            Console.WriteLine("请输入长方形的长：");
            String length = Console.ReadLine();
            rectangle.Length_chs = double.Parse(judgeInput(length));
            Console.WriteLine("请输入长方形的宽：");
            String width = Console.ReadLine();
            rectangle.Width_chs = double.Parse(judgeInput(width));
            rectangle.area_chs();
            rectangle.girth_chs();
            Console.ReadLine();
        }

        static public void shiyan2_1()
        {
            Shape_chs sh_chs = new Shape_chs();
            Console.WriteLine("输入圆的半径：");
            String r = Console.ReadLine();
            sh_chs.R_chs = double.Parse(judgeInput(r));
            sh_chs.areaOfCircle();
            sh_chs.girthOfCircle();
            Console.WriteLine("请输入长方形的长：");
            String length = Console.ReadLine();
            sh_chs.Length_chs = double.Parse(judgeInput(length));
            Console.WriteLine("请输入长方形的宽：");
            String width = Console.ReadLine();
            sh_chs.Width_chs = double.Parse(judgeInput(width));
            Console.ReadLine();
        }

        static public void shiyan2_3()
        {
            bool A = true;
            Score_chs score = new Score_chs();
            do
            {
                Console.Clear();
                Console.WriteLine("1.录入");
                Console.WriteLine("2.修改");
                Console.WriteLine("0.退出");
                int s = int.Parse(Console.ReadLine());
                if (s == 0) A = false;
                switch (s)
                {
                    case 1: score.inPut_chs(); score.display_chs(); Console.ReadLine(); break;
                    case 2: score.modifyScore_chs(); score.display_chs(); Console.ReadLine(); break;
                }
            } while (A);
        }
        #endregion
//实验7
#region 实验7
        static void shiyan7()
        {
            Console.WriteLine("——————销售明细——————");
            Sale[] salesJan = { new Sale("T0001", "笔记本电脑"), new Sale("T0002", "华为荣耀"), new Sale("T0003", "iPad"), new Sale("T0004", "华为荣耀4X"), new Sale("T0005", "华为荣耀6高配") };
            Sale[] salesFeb = { new Sale("T0006", "笔记本"), new Sale("T0002", "荣耀"), new Sale("T0003", "iPadMini") };
            Sale[] salesMar = { new Sale("T0008", "外星人"), new Sale("T0009", "宝马"), new Sale("T0003", "iPadMini") };
            double[] dbJan = {3500,999,3288,1999,12888 };
            double[] dbFeb = {1499,1699 ,49};
            double[] dbMar = { 3500, 999,1999.9 };
            while (true)
            {
                Console.WriteLine( "\n请输入要查询的月份（比如1、2、3等）：");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    switch (month)
                    {
                        case 1:
                            Console.WriteLine("1月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan);
                            Console.WriteLine("\n1月份闪屏的总销售额：" + Sale.CaleMoney<double>(dbJan));
                            break;
                        case 2:
                            Console.WriteLine("2月份的商品销售明细如下：");
                            Sale.ShowInfo(salesFeb);
                            Console.WriteLine("\n2月份闪屏的总销售额：" + Sale.CaleMoney<double>(dbFeb));
                            break;
                        case 3:
                            Console.WriteLine("3月份的商品销售明细如下：");
                            Sale.ShowInfo(salesFeb);
                            Console.WriteLine("\n3月份闪屏的总销售额：" + Sale.CaleMoney<double>(dbMar));
                            break;
                        default:
                            Console.WriteLine("该月没有销售数据或者输入的月份有误！");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {

            // shiyan1();
            //  shiyan2();
           // shiyan7();
        }
    }
}
