using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclient
{
    class Program
    {
        static void Main(string[] args)
        {
            scrape how = new scrape();
            string value = how.getstring("https://www.google.com", @"C:\Users\abdul.kuddus\Desktop\data.txt");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
