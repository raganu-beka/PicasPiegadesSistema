using Microsoft.Data.Sqlite;
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

        public void CreateOrder(Order order)
        {

        }
    }

    class Order
    {
        public bool IsPaid;
        public string CreatedAt;
        public int UserId;
    }
}
