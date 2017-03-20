using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            //go(ref x);
            go(out x);
            Console.WriteLine(x);
        }

       /* public static void go(ref int vl)
        {
            vl = vl + 1;
        }
        */

        public static void go(out int vl )
        {
            vl = 0;
            vl = vl + 1;
        }
    }
}
