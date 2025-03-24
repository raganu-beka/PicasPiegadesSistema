using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace PicasPiegadesSistema
{
    class UserDb
    {
        private readonly string connectionString;

        public UserDb(string connectionString)
        {
            this.connectionString = connectionString;

            CreateUserTable();
        }

        public void CreateUserTable()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL
                    ) 
                ";

                createTableCommand.ExecuteNonQuery();
            }
        }

        public void CreateUser(string username, string password)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createUserCommand = connection.CreateCommand();
                createUserCommand.CommandText = @"
                    INSERT INTO Users(Username, Password)
                    VALUES (@username, @password)
                ";

                createUserCommand.Parameters.AddWithValue("username", username);
                createUserCommand.Parameters.AddWithValue("password", password);

                createUserCommand.ExecuteNonQuery();
            }
        }

        public (string, string) GetUser(string username)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var selectUserCommand = connection.CreateCommand();
                selectUserCommand.CommandText = @"
                    SELECT Username, Password FROM Users
                    WHERE Username = @username
                ";
                selectUserCommand.Parameters.AddWithValue("username", username);

                using (var reader = selectUserCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (reader["Username"].ToString(), reader["Password"].ToString());
                    }
                }

                throw new Exception("User not found");
            }
        }
    }
}
