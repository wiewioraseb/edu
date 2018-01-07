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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Equals("123") && passTextBox.Text.Equals("123"))
            {
                MessageBox.Show("Logowanie powiodło się!");
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
            }
        }
    }
}
