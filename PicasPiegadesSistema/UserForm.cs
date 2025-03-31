using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicasPiegadesSistema
{
    public partial class UserForm : Form
    {
        UserDb _userDb;

        public UserForm()
        {
            InitializeComponent();

            _userDb = new UserDb("Data Source=pizza.db");

            try
            {
                _userDb.CreateUser("raganubeka",
                        Hashing.GeneratePasswordHash("123"),
                        true);
            }
            catch (Exception e)
            {
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = unameTxt.Text;
            var password = passTxt.Text;

            (string username, string password, bool isAdmin) user;
            try
            {
                user = _userDb.GetUser(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (Hashing.CheckPasswordHash(password, user.password))
            {
                if (user.isAdmin)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }

                MessageBox.Show("Logged in");
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
        }
    }
}
