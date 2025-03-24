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

            _userDb = new UserDb("Data Source=pica.db");

            try
            {
                _userDb.CreateUser("raganubeka",
                        Hashing.GeneratePasswordHash("123"));
            }
            catch (Exception e)
            {
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = unameTxt.Text;
            var password = passTxt.Text;

            (string username, string password) user = _userDb.GetUser(username);
            
            if (Hashing.CheckPasswordHash(password, user.password))
            {
                MessageBox.Show("Logged in");
            } else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
