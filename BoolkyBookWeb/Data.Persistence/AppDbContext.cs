using BoolkyBookWeb.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BoolkyBookWeb.Data.Persistence
{
    public class AppDbContext : DbContext
    {
        /*public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }*/

        private static string connectionString = @"Server=TXBBNUEYVAZOV\TXBBNUEYVAZOV;Database=BulkyMvc;Encrypt=false;Trusted_Connection=True;";
        private static SqlConnection? sqlConnection;
        private static SqlCommand? sqlCommand;

        public static DataTable Execute(string sql)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("CONNECTION NOT found");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static SqlDataReader ExecuteRead(string sql)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                throw new Exception("CONNECTION NOT found");
            }
        }

    }
}
