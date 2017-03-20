using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    class Program
    {
        static void Main(string[] args)
        {

            GRepository<Book> obj=new GRepository<Book>();
            obj.insert(new Book("kanon",5));
            obj.insert(new Book("nahid", 5));
            obj.insert(new Book("Rasel", 4));
            obj.insert(new Book("kanon",6));
            obj.insert(new Book("Rahim", 10));



            //obj.delete(new Book("nahid",5));

            //obj.update(new Book("nahid",5),new Book("himel",5));
           // var result=obj.GetbyId(5);
          //  foreach (var hala in result)
       //     {
          //      Console.WriteLine("{0} and {1}", hala.id, hala.author);
       //     }

            var ans=obj.sortBygroup();
            foreach (var hh in ans)
            {
                Console.WriteLine(hh);
            }




             Console.ReadLine();

        }
    }
}
