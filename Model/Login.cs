namespace turtle.Model
{
    class Login
    {
        public static bool Authenticate(string user, string password)
        {
            //Implementar el codigo para buscar el usuario en base de datos o WebService
            if (user.Equals("Admin") && password.Equals("Admin01"))
            {
                return true;
            }
            return false;
        }
    }
}