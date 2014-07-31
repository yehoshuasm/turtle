using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



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
            
            if (Model.Login.userFinder(userTextBox.Text, passwordTextBox.Text))
            {
                new InvoicingForm().Show();
              
            }
            else
            {
                MessageBox.Show("Verifique nombre de usuario o contraseña","Error en Autenticacion");
            }
        }
    }
}