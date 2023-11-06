using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public  class Book
    {
        public string  NameOfBook { get; set; }
        public string Author { get; set; }
        public string State { get; set; }
        public Book (string nameOfBook, string auther, string state)
        {
            this.NameOfBook = nameOfBook;
            this.Author = auther;
            this.State = state;
        }
    }
}
