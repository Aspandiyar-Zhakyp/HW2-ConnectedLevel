using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET_ConnectedLevel_HW_2.Data
{
    public abstract class DbDataAccess : IDisposable
    {
        protected readonly SqlConnection sqlConnection;
        public DbDataAccess()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=ASTCMT002/MSSQL; Database=ConnectedLevelLesson; Trusted_Connection=true;";
            sqlConnection.Open();
        }

        public void Dispose()
        {
            sqlConnection.Close();
        }
        public abstract void Table();
    }
}
