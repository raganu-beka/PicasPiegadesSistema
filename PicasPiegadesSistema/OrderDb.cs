using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicasPiegadesSistema
{
    class OrderDb
    {
        private readonly string connectionString;

        public OrderDb(string connectionString)
        {
            this.connectionString = connectionString;

            CreateOrderTable();
            CreateOrderPizzaTable();
        }

        private void CreateOrderTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Orders (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        IsPaid BOOLEAN REQUIRED,
                        CreatedAt TEXT REQUIRED,
                        OrderUser INTEGER REQUIRED,
                        FOREIGN KEY (OrderUser) REFERENCES Users(Id)
                    ) 
                ";

                createTableCommand.ExecuteNonQuery();
            }
        }

        private void CreateOrderPizzaTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS OrderPizza (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        OrderId INTEGER REQUIRED,
                        PizzaId INTEGER REQUIRED,
                        FOREIGN KEY (OrderId) REFERENCES Orders(Id),
                        FOREIGN KEY (PizzaId) REFERENCES Pizzas(Id)
                    ) 
                ";

                createTableCommand.ExecuteNonQuery();
            }
        }

        public void AddPizzasToOrder(int orderId, List<Pizza> pizzas)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                StringBuilder sb = new StringBuilder("INSERT INTO OrderPizza (OrderId, PizzaId) VALUES ");
                List<string> values = new List<string>();

                foreach (var pizza in pizzas)
                {
                    values.Add($"({orderId}, {pizza.Id})");
                }

                sb.Append(string.Join(", ", values));

                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = sb.ToString();

                createUserCommand.ExecuteNonQuery();
            }
        }

        public int CreateOrder(int userId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = @"
                    INSERT INTO Orders(IsPaid, CreatedAt, OrderUser)
                    VALUES (@isPaid, @createdAt, @orderUser)
                ";

                createUserCommand.Parameters.AddWithValue("isPaid", false);
                createUserCommand.Parameters.AddWithValue("createdAt", DateTime.UtcNow.ToLongTimeString());
                createUserCommand.Parameters.AddWithValue("orderUser", userId);

                createUserCommand.ExecuteNonQuery();

                var getIdCommand = connection.CreateCommand();
                getIdCommand.CommandText = "SELECT last_insert_rowid()";

                long lastId = (Int64) getIdCommand.ExecuteScalar();
                return (int) lastId;
            }
        }

        public double GetOrderTotalPrice(int orderId)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = @"
                    SELECT SUM(P.Price)
                    FROM Orders O
                    JOIN OrderPizza OP ON O.Id = OP.OrderId
                    JOIN Pizzas P ON OP.PizzaId = P.Id
                    WHERE O.Id = @orderId
                ";

                createUserCommand.Parameters.AddWithValue("orderId", orderId);

                var price = Convert.ToDecimal(createUserCommand.ExecuteScalar());
                return (double) price;
            }
        }
    }
}
