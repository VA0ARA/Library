using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public  class ImplimentingLoginandRegister : IAuthentication
    {
        
        public bool Login(string username, int password, MembersOflibrary[] membersOflibrary)
        {
            
            int Lenght = membersOflibrary.Length;
            bool CheckData=false;
            for (int i=0;i< Lenght; i++)
            {
                if ((membersOflibrary[i].PassWord==password) && (membersOflibrary[i].UserName == username))
                {
                    //if (membersOflibrary[i].Role == Role.Client)
                   // {
                        Console.WriteLine($" Welcome to E-Library {membersOflibrary[i].Name} {membersOflibrary[i].LastName} ");
                         DataBase.WasSelectedMember= membersOflibrary[i];
                         DataBase.WasSelectedMemberID = i;
      
                        CheckData= true;
                        break;
                            // call ClientMenu
                   // }

                   
                }
                else
                {
                    
                    CheckData = false;
                    //call register process
                }
            }
            return CheckData;
        }

        public void Register(MembersOflibrary member)
        {
            DataBase.ListofAllTheMembers=DataBase.ListofAllTheMembers.Append(member).ToArray();
        }
    }
}
