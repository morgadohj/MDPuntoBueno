using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using DataAcces;

namespace dominio
{
    public class UserModel
    {
        UsaerMD usaerMD = new UsaerMD();
        public bool LoginUser(String user, String pass)
        {
            return usaerMD.Login(user,pass);
        }
            }
}
