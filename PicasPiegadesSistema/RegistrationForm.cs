using Microsoft.Data.Sqlite;
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
    public partial class RegistrationForm : Form
    {
        UserDb _userDb;

        public RegistrationForm()
        {
            InitializeComponent();

            _userDb = new UserDb("Data Source=pica.db");
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
          
            if (!passTxt.Text.Equals(pass2Txt.Text))
            {
                MessageBox.Show("Parolēm ir jāsakrīt!");
                return;
            }

            if (passTxt.Text.Length < 3)
            {
                MessageBox.Show("Parolei jābūt vismaz 3 simbolu garai");
                return;
            }

            var username = unameTxt.Text;
            var password = Hashing.GeneratePasswordHash(passTxt.Text);

            try
            {
                _userDb.CreateUser(username, password);
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lietotājs ar šādu lietotājvārdu jau eksistē!");
                return;
            }

            this.Hide();
            var userForm = new UserForm();
            userForm.Show();

            MessageBox.Show("Konts tika izveidots!");
        }
    }
}
