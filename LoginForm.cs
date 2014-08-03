using System;
using System.Windows.Forms;
using turtle.Utils;

namespace turtle
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserAndPassword(userTextBox.Text, passwordTextBox.Text))
            {
                Login(userTextBox.Text, passwordTextBox.Text);
            }
            else
            {
                MessageBox.Show("El nombre de usuario y/o contraseña contienen caracteres no válidos", "Error de Validación");
            }
        }

        private bool ValidateUserAndPassword(string user, string password)
        {
            return Validator.IsAlphanumeric(user) && Validator.IsAlphanumeric(password);
        }

        private void Login(string user, string password)
        {
            if (Model.Login.Authenticate(user, password)) {
                new MenuForm().Show();
                return;
            }
            MessageBox.Show("Nombre de usuario y/o contraseña incorrectos", "Error de Autenticación");
        }
    }
}