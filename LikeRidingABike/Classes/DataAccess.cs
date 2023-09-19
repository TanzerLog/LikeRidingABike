using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LikeRidingABike.Classes
{
    public class DataAccess
    {
        private string connectionString;
        private SQLiteConnection connection;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SQLiteConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error opening the database connection: " + e.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error closing the database connection: " + e.Message);
            }
        }
    }
}
