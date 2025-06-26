using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LMSv2
{
    public class DatabaseConnection
    {
        
        private string connectionString = "Server=localhost;Database=c#library_db;User=root;Password=;";

       
        public int ExecuteInsert(string query, MySqlParameter[] parameters)
        {
            return ExecuteNonQuery(query, parameters);
        }

       
        public DataTable ExecuteSelect(string query, MySqlParameter[] parameters)
        {
            return ExecuteQuery(query, parameters);
        }

        
        public int ExecuteUpdate(string query, MySqlParameter[] parameters)
        {
            return ExecuteNonQuery(query, parameters);
        }

        
        public int ExecuteDelete(string query, MySqlParameter[] parameters)
        {
            return ExecuteNonQuery(query, parameters);
        }

        
        private int ExecuteNonQuery(string query, MySqlParameter[] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing non-query: {ex.Message}");
                    return 0;
                }
            }
        }

        
        private DataTable ExecuteQuery(string query, MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
            }
            return dt;
        }
    }
}
