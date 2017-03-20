using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            /*LINQ QUERY PROCESS
            var BMWS = from car in myCars where car.Make == "BMW" && car.StickerPrice<=55000  select car;

               

            // LINQ METHOD PROCESS  
            var BMWS = myCars.Where(p=> p.Make=="BMW" && p.StickerPrice<=55000);

            foreach (var item in BMWS)
            {
                Console.WriteLine("{0} {1}",item.Model, item.StickerPrice);
            }
            Console.ReadLine();

        */

            /* LINQ QUERY PROCESS
            var orderCars = from car in myCars orderby car.Year descending select car;
            

            //LINQ METHOD PROCESS
            var orderCars = myCars.OrderByDescending(p=> p.Year);

            foreach (var item in orderCars)
            {
                Console.WriteLine("{0} {1}", item.Year,item.Model);
            }

        */

            // var firstcar = myCars.First(p=> p.Make=="BMW");
            //after sorting
            //var firstcar = myCars.OrderByDescending(p => p.Year).First(p=> p.Make=="BMW");
            // Console.WriteLine(firstcar.Model);

            //Console.WriteLine(myCars.TrueForAll(p=> p.Year>=2007));   //just checking


            //printing using another way.....

            myCars.ForEach(p=>  Console.WriteLine("{0}     {1:C}",p.Make,p.StickerPrice));

            myCars.ForEach(p=> p.StickerPrice-=30000);  //subtract 3000 from each element
            myCars.ForEach(p=> Console.WriteLine("{0}",p.StickerPrice));
            Console.WriteLine(myCars.Exists(p=> p.StickerPrice==-500)); // CHECHING EXISTENCE OF ELEMENT

            Console.WriteLine(myCars.Sum(p=> p.StickerPrice));   // sum up all price 

            var BMWS = from car in myCars orderby car.Year descending select car;
            var bmws = myCars.Where(p=> p.Year>=2009);
            var vmws = from car in myCars where car.Year == 2010 select new { car.Make, car.Model };

            Console.WriteLine(BMWS.GetType());
            Console.WriteLine(bmws.GetType());
            Console.WriteLine(vmws.GetType());
            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN;
        public string Make;
        public string Model;
        public int Year;
        public double StickerPrice;
    }
}
