using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET_ConnectedLevel_HW_2.Data
{
    public class GroupDataAccess : DbDataAccess
    {
        public override void Table()
        {
            var createSqlScript = $"Create table [gruppa] (id int primary key identity," +
                                  $" [Name]  nvarchar(25) check([Name] <>N'') unique not null," +
                                  $"[SurName]  nvarchar(25) check([SurName] <>N'') not null);";

            using (var command = new SqlCommand(createSqlScript, sqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
