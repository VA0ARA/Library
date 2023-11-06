using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public static  class DataBase
    {
        //public static int ID = 0;
        public static MembersOflibrary[] ListofAllTheMembers=new MembersOflibrary[0];
        public static MembersOflibrary WasSelectedMember;
        public static int WasSelectedMemberID;
        public static  List<Book> ListOfClientBook = new List<Book>();
        public static void   intilazingListBook()
        {
            ListOfClientBook.Add(new Book("Clean Code", "rabert philips", "available"));
            ListOfClientBook.Add(new Book("Fundemental of C#", "jim rohe", "available"));
            ListOfClientBook.Add(new Book("Maktab book", "jordan person", "available"));
            ListOfClientBook.Add(new Book("Design pattern", "mikel lele", "available"));
           ListOfClientBook.Add(new Book("tecnology", "mike  aj", "available"));
            
        }






    }
}
