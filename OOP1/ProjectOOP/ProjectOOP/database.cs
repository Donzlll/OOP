
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ProjectOOP
{
    public static class Database
    {
        private static readonly string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;
              Database=BarangayElectionDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable GetData(string query)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command =
                new SqlCommand(query, connection))
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public static int GetCount(string query)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                connection.Open();

                return Convert.ToInt32(
                    command.ExecuteScalar());
            }
        }

        public static bool TestConnection()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                return true;
            }
        }
    }
}
