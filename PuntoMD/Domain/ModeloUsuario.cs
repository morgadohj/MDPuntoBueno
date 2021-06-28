using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using AccesoDatos;

namespace Domain
{
    public class ModeloUsuario
    {
         MdUser mdUser = new MdUser();
        public bool LoginUser(String user, String pass)
        {
            return mdUser.Login(user, pass);
        }
    }
       
}
