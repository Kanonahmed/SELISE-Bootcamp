using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
   public class TransactionModel
   {
       public int id;
       public int transactionprice;
       public string name;

       public TransactionModel(int x, int y, string nm)
       {
           this.id = x;
           this.transactionprice=y;
           this.name = nm;
       }
   }
}
