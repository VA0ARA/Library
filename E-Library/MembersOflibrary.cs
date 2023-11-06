using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public abstract class MembersOflibrary
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set;}
        public int PassWord { get; set; }
        public Role Role { get; set; }
        public MembersOflibrary()
        {

        }

        public MembersOflibrary(string name,string familyname,int password, string username , Role role)
        {
            this.Name = name;
            this.LastName = familyname;
            this.PassWord = password;
            this.UserName = username;
            this.Role = role;
        }

        public virtual void ShowDetailOfMember()
        {
            Console.WriteLine($"your Name is {Name}\n " +
            $"your Last Name is {LastName}\n your Role are {Role}\n");
            Console.WriteLine("********");
        }

    }
}
