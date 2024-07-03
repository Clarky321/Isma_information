using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ISMA_information
{
    public class UserLogins : IDisposable
    {
        private readonly string connectionString;

        public UserLogins(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<string> GetUniqueUserLogins()
        {
            List<string> logins = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT DISTINCT login_user FROM register WHERE login_user IS NOT NULL";
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            string login = reader.GetString(0);
                            if (!string.IsNullOrEmpty(login))
                            {
                                logins.Add(login);
                            }
                        }
                    }
                }
            }
            return logins;
        }

        public void Dispose()
        {
            // Если в будущем потребуется освобождение ресурсов, то метод требуется доработать.
        }
    }
}