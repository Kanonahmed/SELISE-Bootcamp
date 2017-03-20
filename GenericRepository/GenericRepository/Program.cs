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

            Repository<Book> obj = new Repository<Book>();
            obj.insert(new Book { id = Guid.NewGuid(), author = "kanon",price=100 });
            obj.insert(new Book { id = Guid.NewGuid(), author = "kanon", price = 500 });
            obj.insert(new Book { id=Guid.NewGuid(),author="nahid",price=200});
            obj.insert(new Book { id = Guid.NewGuid(), author = "rasel", price=300 });

            //var pp=obj.GetById(new Guid("c262e47c-7ed7-4ece-a4f3-2fc5dacb9e5c"));
            //Console.WriteLine(pp.author);

            var result = obj.GetAll();

            foreach(var x in result)
            {
                Console.WriteLine("{0} {1} {2} ",x.id,x.author,x.price);
            }

            Console.WriteLine("After Grouping.....");
            var ans = obj.Group();
            foreach(var x in ans)
            {
               Console.WriteLine(x.Key);
                foreach (var p in x.Value)
                    Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
