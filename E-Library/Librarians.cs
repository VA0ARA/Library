using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public class Librarians : MembersOflibrary
    {
        public Librarians(string name, string familyname, int password, string username, Role role) : base(name, familyname, password,  username, role)
        {
        }
    }
}
