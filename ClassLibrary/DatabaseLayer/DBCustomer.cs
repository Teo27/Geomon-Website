using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.ModelLayer;

namespace ClassLibrary
{
    public class DBCustomer
    {


        public DBCustomer()
        {

        }
        public List<Geomon> GetCollection(string Username)
        {
            List<Geomon> lg = new List<Geomon>();
            return lg;
        }
        public int Login(string Username, string Password)
        {
            string salt = "";
            int i = 0;
            if (ReadCustomer(Username) != 0)
                i = -1;
            else
            {


                salt = GetSalt(Username);
                Password = Password + salt;
                Password = HashPass(Password);
                if (CheckPass(Username, Password) != 0)
                    i = -2;

            }
            return i;
        }

        public void DeleteCustomer(string Username)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }

        private string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[20];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }
        private string GetSalt(string Username)
        {
            string salt = "";
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spReadCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        salt = (string)reader[3];
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                return salt;
            }
        }
        private string HashPass(string Password)
        {

            HashAlgorithm algorithm = SHA384CryptoServiceProvider.Create();
            byte[] bytePassword = algorithm.ComputeHash(Encoding.UTF8.GetBytes(Password));
            return Convert.ToBase64String(bytePassword);

        }
        public int CreateCustomer(string ScrName, string Username, string Password, string Email, DateTime DateOfCreation)
        {
            int i = 0;
            bool rowsEmail = false;
            bool rowsScrName = false;
            bool rowsUsername = false;
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                string strEmail = "Select * from Customer where Email=@Email ";
                SqlCommand cmdEmail = new SqlCommand(strEmail, conn);
                cmdEmail.Parameters.AddWithValue("@Email", Email);

                try
                {
                    SqlDataReader reader = cmdEmail.ExecuteReader();
                    rowsEmail = reader.HasRows;
                    reader.Close();


                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }

                string strScrName = "Select * from Customer where ScrName=@ScrName ";
                SqlCommand cmdScrName = new SqlCommand(strScrName, conn);
                cmdScrName.Parameters.AddWithValue("@ScrName", ScrName);

                try
                {
                    SqlDataReader reader = cmdScrName.ExecuteReader();
                    rowsScrName = reader.HasRows;
                    reader.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }

                string strUsername = "Select * from Customer where [Username]=@Username ";
                SqlCommand cmdUsername = new SqlCommand(strUsername, conn);
                cmdUsername.Parameters.AddWithValue("@Username", Username);

                try
                {
                    SqlDataReader reader = cmdUsername.ExecuteReader();
                    rowsUsername = reader.HasRows;
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                if (rowsEmail == true) i = -1;
                if (rowsScrName == true) i = -2;
                if (rowsUsername == true) i = -3;

                if (i == 0)
                {

                    string Salt = CreateSalt();
                    Password = Password + Salt;
                    Password = HashPass(Password);
                    //   string str = "Insert into Customer( ScrName,  Username,  Password,  Salt,  Email,  Steps,  Score,  DateOfCreation) Values( @ScrName,  @Username,  @Password,  @Salt,  @Email, @Steps,  @Score,  @DateOfCreation)";
                    SqlCommand cmd = new SqlCommand("spInsertNewCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ScrName", ScrName);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Salt", Salt);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    //    cmd.Parameters.AddWithValue("@Steps", Steps);
                    //    cmd.Parameters.AddWithValue("@Score", Score);
                    cmd.Parameters.AddWithValue("@DateOfCreation", DateOfCreation);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        i = -4;
                        Console.WriteLine(e.ToString());
                    }
                }
            }

            return i;
        }
        public void UpdateCustomer(string ScrName, string Username, string Password, string Salt, string Email)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ScrName", ScrName);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Salt", Salt);
                cmd.Parameters.AddWithValue("@Email", Email);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }
        public int ReadCustomer(string Username)
        {
            int i = 0;
            bool rows = false;
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spReadCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    rows = reader.HasRows;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            if (rows == false) i = -1;
            return i;
        }
        public int CheckPass(string Username, string Password)
        {
            int i = 0;
            bool rows = false;
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spCheckCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    rows = reader.HasRows;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            if (rows == false) i = -1;
            return i;
        }

        public void LoginCustomer(string Username, string Password)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spLoginCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }

        public DataSet Highscore()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spHighscore", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;


                    DataSet ds = new DataSet();
                    cmd.Fill(ds);

                    return ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public string[] isFriend(string Username)
        {
            //CustomerModel[] dbc = null;
            string[] friendsList = null;
            int i = 0;
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                string sqlString2 = "SELECT * FROM [Customer] ORDER BY [Score] DESC";
                SqlCommand cmd2 = new SqlCommand(sqlString2, conn);
                try
                {
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                string sqlString = "Select Customer_Us2 from Friends_List where Customer_Us1=@Username";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            friendsList[i] = reader.GetString(0);
                        }
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return friendsList;
        }

        public DataSet ProfileViev(string Username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spProfile", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Clicked", Username);

                    DataSet ds = new DataSet();
                    cmd.Fill(ds);
                    return ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }


        public DataSet Users()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spGetAllUsers", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;


                    DataSet ds = new DataSet();
                    cmd.Fill(ds);
                    return ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

    }
}






