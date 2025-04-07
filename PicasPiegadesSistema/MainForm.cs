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
        private List<Pizza> _pizzaList = new List<Pizza>();

        public MainForm()
        {
            InitializeComponent();

            _pizzaDb = new PizzaDb("Data Source=pizza.db");
            UpdatePizzaComboBox();
            UpdatePizzaDataGrid();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var selectedName = pizzaList.Text;
            var pizzas = _pizzaDb.ReadPizzas();

            var selectedPizza = pizzas.Find(x => x.Description == selectedName);
            if (selectedPizza != null)
            {
                _pizzaList.Add(selectedPizza);
            }

            UpdatePizzaDataGrid();
        }

        private void UpdatePizzaDataGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Pizza name", typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Price", typeof(double));


            foreach (var pizza in _pizzaList)
            {
                table.Rows.Add(new object[]
                {
                    pizza.Description,
                    pizza.Size,
                    pizza.Price,
                });
            }

            cartGrid.DataSource = table;
        }

        private void UpdatePizzaComboBox()
        {
            var pizzas = _pizzaDb.ReadPizzas();
            var pizzasDesc = pizzas.Select(x => x.Description).ToList();

            pizzaList.DataSource = pizzasDesc;
        }
    }
}
