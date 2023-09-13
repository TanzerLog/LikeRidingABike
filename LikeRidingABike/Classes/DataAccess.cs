using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LikeRidingABike.Classes
{
    public class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void OpenConnection()
        {
            // Open the SQLite connection here
        }

        public void CloseConnection()
        {
            // Close the SQLite connection here
        }

        // Other methods for executing SQL commands and managing data
    }
}
