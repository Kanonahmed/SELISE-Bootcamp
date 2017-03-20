﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FGenericRepository
{
   public class Repository: IRepoInterface
    {
      Dictionary<Type, Collection<object> > store=new Dictionary<Type, Collection<object> >();

      public void insert<T>(T entity) where T : BaseClass
      {
          Collection<object> value;
          if (store.TryGetValue(typeof(T), out value))
          {
              value.Add(entity);
          }
          else
          {
                Collection<object>value1=new Collection<object>();
                value1.Add(entity);
                store.Add(typeof(T), value1);
          }
      }

       public void delete<T>(T entity) where T : BaseClass
       {
           Collection<object> value;
           if (store.TryGetValue(typeof(T), out value))
           {
               // var something = value.FirstOrDefault((r => ((BaseClass)r).id == entity.id));
               // value.Remove(something);

                 value.Remove(entity);
            }

       }

        public void deleteById<T>(int id) where T : BaseClass
        {
            Collection<object> value;
            if (store.TryGetValue(typeof(T), out value))
            {
                var something = value.FirstOrDefault((r => ((BaseClass)r).id == id));
                value.Remove(something);
            }

        }

        public void update<T>(T x, T y) where T : BaseClass
       {
            Collection<object> value;
            if (store.TryGetValue(typeof(T), out value))
            {
                // var something = value.FirstOrDefault((r => ((BaseClass)r).id == entity.id));
                // value.Remove(something);

                value.Remove(x);
                value.Add(y);
            }
        }

       public IList GetAll<T>() where T : BaseClass
       {
           Collection<object> value;
           if (store.TryGetValue(typeof(T), out value))
           {
               return value;
           }
           return null;
       }


        public object GetById<T>(int ind) where T : BaseClass
        {
            Collection<object> value;
            if (store.TryGetValue(typeof(T), out value))
            {
                 var something = value.FirstOrDefault((r => ((BaseClass)r).id ==ind));
                return something;
            }
            return null;
        }


    }
}
