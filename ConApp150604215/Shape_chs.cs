using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604215
{
    class Shape_chs
    {
        private double r_chs;
        private double length_chs;
        private double width_chs;

        public double R_chs
        {
            get
            {
                return r_chs;
            }

            set
            {
                r_chs = value;
            }
        }

        public double Length_chs
        {
            get
            {
                return length_chs;
            }

            set
            {
                length_chs = value;
            }
        }

        public double Width_chs
        {
            get
            {
                return width_chs;
            }

            set
            {
                width_chs = value;
            }
        }

        public void areaOfCircle()
        {
            Console.WriteLine("圆的面积："+r_chs * r_chs * Math.PI);
        }
        public void girthOfCircle()
        {
            Console.WriteLine("圆的周长："+2*Math.PI * r_chs);
        }
        public void areaOfReatangle()
        {
            Console.WriteLine("长方形面积："+length_chs*width_chs);
        }
        public void girthOfReatangle()
        {
            Console.WriteLine("长方形周长："+ 2 * (length_chs + width_chs));
        }
    }
}
