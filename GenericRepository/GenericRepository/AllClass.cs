using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
   public abstract class AllClass
    {
        public Guid id;
        public string author;
    }

    public class Book: AllClass
    {

        public int price;
    }

    public class Transaction: AllClass
    {
        public int transactionprice;
    }
}
