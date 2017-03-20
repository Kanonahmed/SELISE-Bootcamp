using CodeFirstModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataAccess
{
   public class DemoEntityContext:DbContext
    {
        public DemoEntityContext() 
            : base("name=DbConnectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
