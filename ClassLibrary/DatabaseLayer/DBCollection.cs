using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DBCollection
    {

        public DBCollection()
        {

        }

        public DataSet Collection(string Username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spGetCollection", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Username", Username);

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

        public DataSet Achievements(string Username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spAchievements", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Username", Username);

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

        public void InsertCollection(string Username, int Id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spInsertCollection", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public DataSet GetEggs(string Username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spGetEggs", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Username", Username);

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

        public void AddFriend(string Username, string FriendUsername)
        {


            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spAddFriend", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Customer_Us1", Username);
                cmd.Parameters.AddWithValue("@Customer_Us2", FriendUsername);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

    }



}
