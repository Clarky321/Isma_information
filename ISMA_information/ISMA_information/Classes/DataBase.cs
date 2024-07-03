using System;
using System.Collections.Generic;
using System.Configuration;
using MySqlConnector;

namespace ISMA_information
{
    class DataBase : IDisposable
    {
        private readonly string connectionString;
        private MySqlConnection mysqlConnection;

        public DataBase(string connectionStringKey)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
            mysqlConnection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection => mysqlConnection;

        public List<string> GetUniqueUserLogins()
        {
            using (UserLogins userLogins = new UserLogins(connectionString))
            {
                return userLogins.GetUniqueUserLogins();
            }
        }

        public void OpenConnection()
        {
            if (mysqlConnection.State == System.Data.ConnectionState.Closed)
            {
                mysqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (mysqlConnection.State == System.Data.ConnectionState.Open)
            {
                mysqlConnection.Close();
            }
        }

        public MySqlCommand CreateCommand(string query)
        {
            OpenConnection();
            return new MySqlCommand(query, mysqlConnection);
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlCommand command = CreateCommand(query))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            mysqlConnection?.Dispose();
        }

        public bool IsConnectionOpen()
        {
            return mysqlConnection != null && mysqlConnection.State == System.Data.ConnectionState.Open;
        }
    }
}