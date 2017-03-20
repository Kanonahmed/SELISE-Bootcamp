using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IRepository<T> where T: AllClass
    {
        void insert(T entity);
        void delete(T entity);
        void update(T entity, T nxt);
        T GetById(Guid ind);
        IList<T> GetAll();
    }
    public class Repository<T> : IRepository<T> where T : AllClass
    {
        protected readonly Dictionary<Guid, T> store = new Dictionary<Guid, T>();
       public void insert(T entity)
        {
            store.Add(entity.id,entity);
        }
      public  void delete (T entity)
        {
            store.Remove(entity.id);
        }
       public void update(T entity, T nxt)
        {
            //store[entity.id] = nxt;
            store.Remove(entity.id);
            store.Add(nxt.id,nxt);
        }
      public  IList<T> GetAll()
        {
            return new List<T>(store.Values);
        }

      public  T  GetById(Guid ind)
        {
            return store[ind];
        }   
        public Dictionary<string,IEnumerable<Guid >>   Group()
        {
            var dic = store.GroupBy(pair => pair.Value.author)
                .ToDictionary(group=>group.Key,group=>group.Select(pair=>pair.Key));

            return dic;
        }
    }
}
