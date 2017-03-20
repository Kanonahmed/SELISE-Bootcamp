using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace GenericRepository
{

    public interface IRepository<T>
    {
         void insert(T x);
        void delete(T x);
        void update(T x, T y);
        IEnumerable<T> GetbyId(int idx);
    }
    public class GRepository<T>:IRepository<T>
    {

        public List<T> store = new List<T>();

       

        public void insert(T x)
        {
            store.Add(x);
        }

        public void delete(T x)
        {
            var something = store.FirstOrDefault(r => (int)r.GetType().GetField("id").GetValue(r)==(int)x.GetType().GetField("id").GetValue(x));

            if (something != null)
                store.Remove(something);
            else
            {
                Console.WriteLine("There is no such object");
                Console.ReadLine();
            }

        }

        public void update(T x, T y)
        {
           
            var something = store.Where(r => (int)r.GetType().GetField("id").GetValue(r) == (int)x.GetType().GetField("id").GetValue(x)).First();
            var ind = store.IndexOf(something);

            if(ind!=-1)
            store[ind] = y;

        /*    var t = x.GetType().GetProperties();
            foreach (PropertyInfo u in t)
            {
                string chk = u.Name;
                var dl = y.GetType().GetField("chk").GetValue(y);
                something.GetType().GetField("chk").SetValue(something,dl);
            }

            Console.WriteLine(something.GetType().GetField("author").GetValue(something));
            */


        }

        public IEnumerable<T> GetbyId(int idx)
        {
           // FieldInfo field = typeof(T).GetField("id");
            IEnumerable<T> query = store.Where(pp => (int)pp.GetType().GetField("id").GetValue(pp) == idx);
            return query;
        }

      //  public IEnumerable<T> sortBygroup()
    //    {
    //        IEnumerable<T> query = store.GroupBy(pp => pp.author.ToList();
       //     return query;
     //   }

    }
}
