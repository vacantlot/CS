using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Testconsole
{
    class Program
    {
        static public void getText()
        {
            DateTime datatime = new DateTime();
            datatime = DateTime.Now;
            int startsec = datatime.Millisecond;
            Console.WriteLine(startsec);
            for (int i = 0; i <150000000; i++)
            {
                
            }
            
            int endsec = datatime.Millisecond;
            Console.WriteLine(endsec);
        }
        static void Main()
        {
            getText();
            
        }
    }
    
}
