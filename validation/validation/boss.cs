using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validation
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class MyValidator : Attribute
    {
        public bool depend(List<TransactionModel> padaisi)
        {
            foreach (TransactionModel x in padaisi)
            {
                if (x.transactionid=="") return false;
                else if (x.transactionprice=="") return false;
                else if (x.name == "") return false;
                else if (x.name.Length > 50) return false;
                else
                {
                    int vuya=1;
                }
            }
            return true;
        }

    }
}
