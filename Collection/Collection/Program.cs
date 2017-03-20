using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Car car1 = new Car();
            car1.name = "BMW";
            car1.id = 416;

            //object initializer
            Car car2 = new Car() { name = "Toyota",id=124 };

              List<Car> mylist = new List<Car>();
            mylist.Add(car1);
            mylist.Add(car2);
            */
            Book book1 = new Book();
            book1.price = "451";
            book1.id = 7854;

            Book book2 = new Book();
            book2.price = "748";
            book2.id = 145;

            // collection initializer 
            List<Car> mylist = new List<Car>() { new Car { name = "BMW", id = 416 }, new Car { name = "Toyota", id = 1245 } };

            Dictionary<string, Book> mydictionary = new Dictionary<string, Book>();
            mydictionary.Add("kanon",book1);
            mydictionary.Add("nahid",book2);

            foreach (Car item in mylist)
            {
                Console.WriteLine("{0} {1}",item.name,item.id);
            }
            Console.WriteLine("next then ........... ");
            Console.WriteLine(mydictionary["kanon"].price);


            foreach (KeyValuePair<string,Book> item in mydictionary)
            {
                Console.WriteLine("{0} {1} {2}",item.Key,item.Value.price,item.Value.id);
            }
            Console.ReadLine();
        }
    }

    class Car
    {
        public string name;
        public int id;
    }

    class Book
    {
        public string price;
        public int id;
    }
}
