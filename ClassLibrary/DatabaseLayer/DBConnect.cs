using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DbConnection
    {
        // public static readonly string connectionString = @"Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=GeomonLocal;Integrated Security=True";
        //public static readonly string connectionString = @"Server=tcp:geomon.database.windows.net,1433;Database=Geomon;User ID = geoadmin@geomon;Password=GeoPassword1; Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public static readonly string connectionString = @"Data Source=kraka.ucn.dk;Initial Catalog=dmaj0914_2Sem_4;Persist Security Info=True;User ID=dmaj0914_2Sem_4;Password=IsAllowed";


        //    Server=tcp:geomon.database.windows.net,1433;
        //        Database=Geomon;
        //        User ID = geoadmin@geomon;
        //        Password={your_password_here };
        //Encrypt=True;
        //    TrustServerCertificate=False;
        //    Connection Timeout = 30;




        public static readonly SqlConnection dbconn = new SqlConnection(connectionString);
        private static SqlCommand dbCmd;

        public static void Open()
        {
            if (dbconn.State.ToString().CompareTo("Open") != 0)
                dbconn.Open();
        }

        public static SqlCommand GetDbCommand(string sql)
        {
            if (dbconn.State.ToString().CompareTo("Open") != 0)
                Open();
            if (dbCmd == null)
            {
                dbCmd = new SqlCommand(sql, dbconn);
            }
            dbCmd.CommandText = sql;
            return dbCmd;
        }

        public static void Close()
        {
            dbconn.Close();
        }
    }
}
