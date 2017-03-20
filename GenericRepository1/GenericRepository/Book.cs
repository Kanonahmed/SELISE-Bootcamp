using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public  class Book
    {
        public string author;
        public int id;

        public Book(string x, int y)
        {
            this.author = x;
            this.id = y;
        }
    }
}
