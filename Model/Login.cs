using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace turtle.Model
{
    class Login
    {
        public static Boolean userFinder(String user, String password)
        {
            //Implementar el codigo para buscar el usuario en base de datos o WebService
            if(user.Equals("Admin")&&password.Equals("Admin01")){
                return true;
            }
            return false;
        }
    }
}
