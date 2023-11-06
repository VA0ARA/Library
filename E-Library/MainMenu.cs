using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace E_Library
{
    public  class MainMenu
    {
        IntialazingDataBase objintialazingDataBase = new IntialazingDataBase();
        LibrarianServices objibrarianServices=new LibrarianServices();
        public Client c;
        public string EndOfRegister;
        public int Counter=1;


        public string Input;
        public void WelcomMenu()
        {

            #region Input
            //DataBase.intilazingListBook();
            Console.WriteLine(" ");
            Console.WriteLine(" ****************************************");
            Console.WriteLine(" welcom to MainMenu");
            Console.WriteLine(" ****************************************");
            Console.WriteLine("we are happy to help you*** please be careful about Spelling words****");
            Console.WriteLine("You have two choice 'login' or 'register'? just choose " +
                "one of them and go ahead for Exist press 'e'");
            Input = Console.ReadLine();
            #endregion

            if (Input== "register")
            { 
                do
                {
                    objintialazingDataBase.GetInformationForRegister();
                    Console.WriteLine("Do you want to register another person  press 'Y'-- if you do not press 'N'");
                    EndOfRegister = Console.ReadLine();
                } while (EndOfRegister != "n");
                foreach (MembersOflibrary c in DataBase.ListofAllTheMembers)
                {
                    c.ShowDetailOfMember();

                }
                Console.WriteLine("your register is successfull");
                Console.WriteLine("if you want to login please enter 'login' if you want to go out please enter 'E'");
                Input=Console.ReadLine();
                if (Input== "e")
                {
                    Console.WriteLine("Thanks for spending Time we us!!!!");
                }else if(Input== "login")
                {

                    LoginInfo();
                }
            }
            else if(Input == "login")
            {
                LoginInfo();
            }
            else if(Input == "e")
            {
                Console.WriteLine("SEE YOU SOON");
            }  
            else 
            {
                Console.WriteLine("you choose wrong option please try again");
                WelcomMenu();
            }
        }
        public void LoginInfo()
        {
            objintialazingDataBase.GetInformationForLogin();
            if (objintialazingDataBase.IsItRegisterBefore == true)
            {
                if (DataBase.WasSelectedMember.Role == Role.Client)
                {
                    ClientMenu();

                }
                else if (DataBase.WasSelectedMember.Role == Role.librarian)
                {
                    librarianMenu();
                }

            }
            else
            {
                Console.WriteLine("you are not still register");
                WelcomMenu();

            }

        }
        public void ClientMenu() {
            Console.WriteLine(" ");
            Console.WriteLine(" ****************************************");
            Console.WriteLine(" welcom to ClientMenu");
            Console.WriteLine(" ****************************************");

            objibrarianServices.ShowListOfLibraryBooks();

            //Console.WriteLine(DataBase.WasSelectedMemberID);
            Console.WriteLine("if you want to Borrow boo k please Enter 'B' bottom and if you want " +
                "to retun book please enter 'R' if type 'go back'  you can come bake mainmenu for show" +
                " your listof book write 'list of Book' ");
            string borrowOrReturnBook=Console.ReadLine();
            if (borrowOrReturnBook == "b")
            {
                objibrarianServices.BorrowBook(DataBase.WasSelectedMemberID);
                 c = (Client)DataBase.ListofAllTheMembers[DataBase.WasSelectedMemberID];
                foreach (var book in c.listOfBook)
                {
                    Console.WriteLine($"The list of this your book is {book.NameOfBook}");
                    
                }
                WelcomMenu();
            }
            else if (borrowOrReturnBook == "r")
            {
                objibrarianServices.ReturnBook();
                foreach (var book in c.listOfBook)
                {
                    Console.WriteLine($"The list of this your book is {book.NameOfBook}");
                    
                }
                WelcomMenu();
            }
            else if(borrowOrReturnBook == "go back") {

                WelcomMenu();
            }
            else if (borrowOrReturnBook == "list of Book")
            {
                foreach (var book in c.listOfBook)
                {
                    Console.WriteLine($"The list of this your book is {book.NameOfBook}");
                    
                }

                WelcomMenu();
            }

        }
        public void librarianMenu() {

            Console.WriteLine(" ****************************************");
            Console.WriteLine(" welcom to ClientMenu");
            Console.WriteLine(" ****************************************");
            Console.WriteLine("We are still working on it................... if type 'go back'  you can come bake mainmenu");
            WelcomMenu();

        }
    }
}
