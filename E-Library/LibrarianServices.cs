using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public class LibrarianServices : IlibraryService
    {
        string InputBookTitleBorrowBook;
        string InputBookTitlereturnBook;
        Client client;
        public void BorrowBook(int ID)
        {
            GetListOfLibraryBooks();
             client = (Client)DataBase.ListofAllTheMembers[ID];
            Console.WriteLine("please Select Book from above List");
            InputBookTitleBorrowBook = Console.ReadLine();

            for (int i = 0; i < DataBase.ListOfClientBook.Count; i++)
            {
                if (InputBookTitleBorrowBook == DataBase.ListOfClientBook[i].NameOfBook && DataBase.ListOfClientBook[i].State == "available")
                {
                    client.listOfBook.Add(DataBase.ListOfClientBook[i]);
                    DataBase.ListOfClientBook[i].State = "Was Borrowed";
                    break;
                }
            }
        }
        public void ReturnBook()
        {
            Console.WriteLine("please Select Book for removing");
            InputBookTitlereturnBook = Console.ReadLine();
            for (int i = 0; i < client.listOfBook.Count; i++)
            {
                if (InputBookTitlereturnBook == client.listOfBook[i].NameOfBook)
                {
                    client.listOfBook.Remove(client.listOfBook[i]);
                    DataBase.ListOfClientBook[i].State = "available";
                    break;
                }
            }

        }
        public void GetListOfLibraryBooks()
        {
            //DataBase.intilazingListBook();
        }
        public void GetListOfUserBooks()
        {
            throw new NotImplementedException();
        }

        public void ShowListOfLibraryBooks()
        {
            Console.WriteLine("---------ListOfBook--------------");
            foreach (Book book in DataBase.ListOfClientBook)
            {
                Console.WriteLine($"the Name of Book is {book.NameOfBook}\n the Auther is {book.Author}");
                Console.WriteLine("------------------------------------------");
            }
        }

 




    }
}
