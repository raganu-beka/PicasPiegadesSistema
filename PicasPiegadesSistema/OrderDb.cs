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
    }
}
