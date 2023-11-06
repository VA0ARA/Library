using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public  class IntialazingDataBase
    {
        public bool IsItRegisterBefore;
        ImplimentingLoginandRegister im=new ImplimentingLoginandRegister();
        public string InputRoles;
        public bool test = true;


        // MainMenu objOfMaunmenu=new MainMenu();
        public void  GetInformationForLogin()
        {
            Console.WriteLine("Please Enter your 'UserName'");
            string username = Console.ReadLine();
            Console.WriteLine("Please Enter your 'pasword'");
            int password = int.Parse(Console.ReadLine());

            IsItRegisterBefore = im.Login(username, password, DataBase.ListofAllTheMembers);

        }
        public  void GetInformationForRegister()
        {
            Console.WriteLine("It is  pleasure!! you choose us for expanding your Skilles!!!!!");
            Console.WriteLine("Please Enter your 'Name'");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter your 'FamilyName'");
            string familyname = Console.ReadLine();

            Console.WriteLine("Please Enter your 'Password'just use intiger numbers");
            int password = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your 'username'just use string");
            string username = Console.ReadLine();
            do
            {
                Console.WriteLine("Please Enter your 'Role'just use Exactly these are words 'Client' -'librarian'");
                InputRoles = Console.ReadLine();
     
                if((InputRoles == "Client" )|| (InputRoles == "librarian"))
                {
                    
                    test= false;
                }
            } while (test);

            Enum.TryParse(InputRoles, out Role role);
            if (role == Role.Client)
            {
                MembersOflibrary clint = new Client(name, familyname, password, username, role);
                im.Register(clint);
            }else if(role == Role.librarian)
            {
                MembersOflibrary Librarian = new Librarians(name, familyname, password, username, role);
                im.Register(Librarian);
            }
           
           

            
        }
        // public  void GetBook() { }
    }
}
