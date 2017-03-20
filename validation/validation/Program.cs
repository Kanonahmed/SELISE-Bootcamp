using System;
using System.Collections.Generic;
using System.Reflection;

namespace validation
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TransactionModel> store=new List<TransactionModel>();

            bool ans = false;
            Dosome obj = new Dosome();
            int len;
            len = int.Parse(Console.ReadLine());

            for (int i = 1; i <= len; i++)
            {
                string x, y;
                string nnn;
                x = Console.ReadLine();
                y = Console.ReadLine();
                nnn = Console.ReadLine();
                store.Add(new TransactionModel(x,y,nnn));
            }

            

            MemberInfo info = typeof(Dosome).GetMethod("calculate");

            /*bool isdef = Attribute.IsDefined(info, typeof(MyValidator));
            if (isdef)
            {
                MyValidator vli = (MyValidator)Attribute.GetCustomAttribute(info, typeof(MyValidator));
                ans = vli.depend(store);
            }
            */
            
            MyValidator vli = (MyValidator)Attribute.GetCustomAttribute(info, typeof(MyValidator));
            ans = vli.depend(store);

           

            
            if (ans)
                 {
                int result = obj.calculate(store);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid case is invented");
                Console.ReadLine();
            }
            



        }
        

    }
    
    public class Dosome
    {
        [MyValidator]
        public int calculate( List<TransactionModel> data )
        {

            int sum = 0;
            foreach (TransactionModel x in data)
            {
                sum =sum+ int.Parse( x.transactionprice);
            }
            return sum;
        }
    }
    
    public class TransactionModel
  {
        public string transactionid;
        public string transactionprice;
        public string name;

        public TransactionModel(string x, string y, string nn)
        {
            this.transactionid = x;
            this.transactionprice = y;
            this.name = nn;
        }
    }


}
