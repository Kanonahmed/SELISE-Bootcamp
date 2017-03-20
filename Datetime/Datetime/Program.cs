using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime mystring = DateTime.Now;
            Console.WriteLine(mystring);
            Console.WriteLine(mystring.ToShortDateString());
            Console.WriteLine(mystring.ToShortTimeString());
            Console.WriteLine(mystring.ToLocalTime());
            Console.WriteLine(mystring.ToLongDateString());
            Console.WriteLine(mystring.ToLongTimeString());
            // Console.Clear();
            // Console.WriteLine(mystring.AddDays(3).ToLongDateString());
            Console.WriteLine(mystring.Month);
            Console.WriteLine(mystring.Year);
            Console.WriteLine(mystring.Day);
            Console.Clear();
            DateTime brithday = new DateTime(1992,04,06);
            Console.WriteLine(brithday.ToLongDateString());

            DateTime mybirthday = DateTime.Parse("4/6/1992");
            Console.WriteLine(mybirthday.ToLongDateString());
            TimeSpan myage = DateTime.Now.Subtract(mybirthday);
            Console.WriteLine(myage.TotalHours);



            Console.ReadLine();
        }
    }
}
