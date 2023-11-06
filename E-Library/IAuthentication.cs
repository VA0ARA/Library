using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library
{
    public  interface IAuthentication
    {

        bool Login(string username, int password, MembersOflibrary[] membersOflibrary);
        void Register(MembersOflibrary member);
    }
}
