using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer.security
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Equals("123") && passTextBox.Text.Equals("123"))
            {
                Authentication.Authorized = true;
                MessageBox.Show("Logowanie powiodło się!");
                this.Close();
            } 
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
            }
        }
    }

    public class Authentication
    {
        private static bool authorized = false;

        public static bool Authorized { get => authorized; set => authorized = value; }
    }
}
