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
    public partial class MainForm : Form
    {
        private PizzaDb _pizzaDb;

        public MainForm()
        {
            InitializeComponent();

            _pizzaDb = new PizzaDb("Data Source=pizza.db");
            UpdatePizzaComboBox();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePizzaComboBox()
        {
            var pizzas = _pizzaDb.ReadPizzas();
            var pizzasDesc = pizzas.Select(x => x.Description).ToList();

            pizzaList.DataSource = pizzasDesc;
        }
    }
}
