using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public interface IlibraryService
    {
        void BorrowBook(int Id );
        void ReturnBook();
        void GetListOfLibraryBooks();
        void GetListOfUserBooks();
    }
}
