using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp150604215
{
    public abstract class PShape_chs
    {
        public abstract void area_chs();
        public abstract void girth_chs();
        
    }



    public class circle : PShape_chs
    {
        private double r_chs;
        public double R_chs
        {
            get { return r_chs; }
            set { r_chs = value; }                                
        }

        public override void area_chs()
        {
            Console.WriteLine( "圆的面积为："+r_chs * r_chs * Math.PI);
        }
        public override void girth_chs()
        {
            Console.WriteLine( "圆的周长为:"+2 * Math.PI * r_chs);
        }
    }




    public class rectAngle : PShape_chs
    {
        private double length_chs;

        public double Length_chs
        {
            get { return length_chs; }
            set { length_chs = value; }
        }

        private double width_chs;

        public double Width_chs
        {
            get { return width_chs; }
            set { width_chs = value; }
        }

        public override void area_chs()
        {
            Console.WriteLine("矩形的面积为：" + length_chs * width_chs);
        }
        public override void girth_chs()
        {
            Console.WriteLine("矩形的周长为：" + 2 * (length_chs + width_chs));
        }

    }

}
