using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public class Client : MembersOflibrary
    {
        //public Book[] listOfBook=new Book[0];
       public  List<Book> listOfBook = new List<Book>();
        public Client()
        {

        }
        public Client(string name, string familyname, int password, string username, Role role, List<Book>book) : base(name, familyname, password,  username, role)
        {
           this.listOfBook = book;
        }
        public Client(string name, string familyname, int password, string username, Role role) : base(name, familyname, password, username, role)
        {
            
        }
    }
}
