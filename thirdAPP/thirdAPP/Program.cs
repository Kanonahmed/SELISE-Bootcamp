using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "kanon is a \"good\" boy ";
            string value = "nahid\nkanon\nrasel";
            string vl = @"C:\drive";
            Console.WriteLine(name);
            Console.WriteLine(value);
            Console.WriteLine(vl);
            string kk = string.Format("{1}={0}", "First", "Second");
            Console.WriteLine(kk);
            string cur = string.Format("{0:c}", 123.4523);
            Console.WriteLine(cur);
            string taka = string.Format("{0:N}", 1234567890);
            Console.WriteLine(taka);
            string parsentage = string.Format("{0:P}", .123);
            Console.WriteLine(parsentage);
            string mobile = string.Format("{0:#####-######}", 01827597823);
            Console.WriteLine(mobile);
            String song = " Kanon is good boy you know that ?";
            song = song.Substring(7, 10);
            Console.WriteLine(song);
            string kra = "kanon is a good boy";
            kra = kra.ToUpper();
            Console.WriteLine(kra);
            kra = kra.Replace(" ", "--");
            Console.WriteLine(kra);
            string rmv = "kanon is best boy";
            rmv = rmv.Remove(0, 2);
            Console.WriteLine(rmv);
            string kanon = "    kanon is a best boy   ";
            kanon = string.Format("{0} {1}", kanon.Length, kanon.Trim().Length);
            Console.WriteLine(kanon);
            string bal = "";
            for (int i = 0; i < 11; i++)
            {
                bal += "--" + i.ToString();
            }
            Console.WriteLine(bal);

            Random myrandom = new Random();
            int vlue = myrandom.Next(1, 11);
            while (vlue < 10) { 
                vlue = myrandom.Next(1, 11);
            Console.WriteLine(vlue);
            }


            StringBuilder mystring = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                mystring.Append("--");
                mystring.Append(i);
            }
            //Console.Clear();
            Console.WriteLine(mystring);
            Console.ReadLine();
        }
    }
}
