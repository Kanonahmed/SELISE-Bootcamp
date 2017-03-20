using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y, sum;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            sum = x + y;
            string name;
            name = Console.ReadLine();
            Console.WriteLine("{0} {1}",name, sum);
            Console.WriteLine("Next i am gonna declare a array");

            int[] a=new int[10];    // the size of array is 100
            int[,] twod = new int[50,10];  //2d array
            int[,,] trd = new int[2, 3, 5];//3d array


            int[] b = new int[] { 1, 2, 3 };   // i would not declare size but i need as needed.

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]+ " ");
            }
            Console.WriteLine();
            //Console.ReadLine();
            int len = int.Parse(Console.ReadLine());
            for (int i = 0; i <len ; i++)
            {
                 a[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("After scanning the array.....");
            for (int i=0;i< len;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            string st;
            st = Console.ReadLine();
            Console.WriteLine(st);
            Console.WriteLine(st.Length);
            char[] arr = st.ToCharArray();
            Console.WriteLine(arr.Length);
            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.WriteLine("String array.......");

            string[] str = new string[10];
            int p;
            p = int.Parse(Console.ReadLine());

            for(int i=0;i<p;i++)
            {
                str[i] = Console.ReadLine();
            }


            for (int i = 0; i < p; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
