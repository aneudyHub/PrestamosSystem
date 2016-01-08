using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IAuthU
    {
        bool CheckLogin(String User, String Password);
        bool Logout();
    }
}
