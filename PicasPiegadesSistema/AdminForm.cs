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
    public partial class AdminForm : Form
    {
        PizzaDb _pizzaDb;

        public AdminForm()
        {
            InitializeComponent();

            _pizzaDb = new PizzaDb("Data Source=pizza.db");
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
