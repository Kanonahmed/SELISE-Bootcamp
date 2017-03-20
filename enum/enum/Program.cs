using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        static void Main(string[] args)
        {

            List<todo> mylist = new List<todo>()
            {
                new todo {name="bmw",price=300000,def=status.Complete },
                new todo {name="toyota",price=200000,def=status.Inprogress },
                new todo {name="vmw",price=50000,def=status.Onhold }
            };

            Console.ForegroundColor = ConsoleColor.Black;
            print(mylist);
            Console.ReadLine();
        }


        public static void print(List<todo> list)
        {
            foreach (todo item in list)
            {
                switch(item.def)
                {
                    case status.Complete:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case status.Inprogress:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                }
                Console.WriteLine("{0} {1} ",item.name,item.price);
            }
        }
    }

    class todo
    {
        public string name;
        public int price;
        public status def;

    }




    enum status
    {
        Nocomplete,
        Inprogress,
        Onhold,
        Complete,
        Hang
    }
}
