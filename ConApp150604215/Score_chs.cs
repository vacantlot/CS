using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604215
{
    class Score_chs
    {
        private String name_chs;
        private int classRoomNumber_chs;
        private double score_chs;
        private String subject_chs;
        public string Name_chs
        {
            get
            {
                return name_chs;
            }

            set
            {
                name_chs = value;
            }
        }

        public int ClassRoomNumber_chs
        {
            get
            {
                return classRoomNumber_chs;
            }

            set
            {
                classRoomNumber_chs = value;
            }
        }

        public double SCore_chs
        {
            get
            {
                return score_chs;
            }

            set
            {
                score_chs = value;
            }
        }

        public string Subject_chs
        {
            get
            {
                return subject_chs;
            }

            set
            {
                subject_chs = value;
            }
        }
        public void display_chs()
        {
            Console.WriteLine("姓名:"+name_chs+" 班级："+classRoomNumber_chs+" 科目："+subject_chs+" 成绩："+score_chs);
        }
        
        public void inPut_chs()
        {
            Console.WriteLine("输入姓名：");
            Name_chs = Console.ReadLine();
            Console.WriteLine("输入班级：");
            string s = Console.ReadLine();
            ClassRoomNumber_chs =int.Parse(Program.judgeInput(s));
            Console.WriteLine("输入科目：");
            Subject_chs = Console.ReadLine();
            Console.WriteLine("输入成绩：");
           
            while (true)
            {
                String score = Console.ReadLine();
                SCore_chs = double.Parse(Program.judgeInput(score));
                if (score_chs > 100 || score_chs < 0)
                {
                    score_chs = 0;
                    Console.WriteLine("输入错误！重新输入……");
                }
                else
                    break;
            }
        }

        public void modifyScore_chs()
        {
            Console.WriteLine("输入欲更改的成绩：");
            while (true)
            {
                String score = Console.ReadLine();
                SCore_chs = double.Parse(Program.judgeInput(score));
                if (score_chs > 100 || score_chs < 0)
                {
                    score_chs = 0;
                    Console.WriteLine("输入错误！重新输入……");
                }
                else
                    break;
            }
        }
    }
}
