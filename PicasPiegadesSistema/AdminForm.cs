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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var pizza = new Pizza()
                {
                    Description = descTxt.Text,
                    Size = Convert.ToInt32(sizeTxt.Text),
                    Price = Convert.ToDouble(priceTxt.Text)
                };


                _pizzaDb.CreatePizza(pizza);
                MessageBox.Show("Pica tika pievienota!");

            } catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda! " + ex.Message);
            }
        }
    }
}
