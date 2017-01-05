using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604215
{
    interface Information
    {
        string Code { get; set; }
        string Name { get; set; }
        void ShowInfo();
    }
    public class Sale : Information
    {
        string code = "";
        string name = "";
        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Sale(string code , string name)
        {
            Code = code;
            Name = name;
        }
        public void ShowInfo(){ }
        public static void ShowInfo(Sale[] sales)
        {
            foreach (Sale s in sales)
                Console.WriteLine("商品编号：" + s.Code + " 商品名称：" + s.Name);
        }

        public static double CaleMoney<T>(T[] items)
        {
            double sum = 0;
            foreach (T item in items)
            {
                sum += Convert.ToDouble(item); 
            }
            return sum;
        }

    }
}
