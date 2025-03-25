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
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!passTxt.Text.Equals(pass2Txt.Text))
            {
                MessageBox.Show("Parolēm ir jāsakrīt!");
                return;
            }

            var username = unameTxt.Text;
            var password = Hashing.GeneratePasswordHash(passTxt.Text);
        }
    }
}
