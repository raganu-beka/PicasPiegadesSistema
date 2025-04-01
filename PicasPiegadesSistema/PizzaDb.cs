using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PicasPiegadesSistema
{
    class PizzaDb
    {
        private readonly string connectionString;

        public PizzaDb(string connectionString)
        {
            this.connectionString = connectionString;

            CreatePizzaTable();
        }

        private void CreatePizzaTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Pizzas (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Size INTEGER,
                        Price NUMBER,
                        Description TEXT UNIQUE
                    ) 
                ";

                createTableCommand.ExecuteNonQuery();
            }
        }

        public void CreatePizza(Pizza pizza)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = @"
                    INSERT INTO Users(Size, Price, Description)
                    VALUES (@size, @price, @description)
                ";

                createUserCommand.Parameters.AddWithValue("size", pizza.Size);
                createUserCommand.Parameters.AddWithValue("price", pizza.Price);
                createUserCommand.Parameters.AddWithValue("description", pizza.Description);

                createUserCommand.ExecuteNonQuery();
            }
        }

        public List<Pizza> ReadPizzas()
        {
            var pizzaList = new List<Pizza>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Pizzas";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pizza = new Pizza()
                        {
                            Description = reader["Description"].ToString(),
                            Price = Convert.ToDouble(reader["Price"]),
                            Size = Convert.ToInt32(reader["Size"])
                        };
                        pizzaList.Add(pizza);
                    }
                }
            }

            return pizzaList;
        }
        
        public void DeletePizza(Pizza pizza)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = @"DELETE FROM Pizza
                    WHERE Description = @description";

                deleteCmd.Parameters.AddWithValue("description", pizza.Description);

                deleteCmd.ExecuteNonQuery();
            }
        }
    }
}
