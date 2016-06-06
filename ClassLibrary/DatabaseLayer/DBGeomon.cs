using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary.ModelLayer;

namespace ClassLibrary
{
    public class DBGeomon
    {
        public DBGeomon()
        {

        }

        public void DeleteGeomon(string Name)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteGeomon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }


        public void CreateGeomon(string Name, int Rarity, string Type, string Image)
        {


            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertNewGeomon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Rarity", Rarity);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Image", Image);
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
        public void UpdateGeomon(string Name, int Rarity, string Type, string Image, int Evo)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateGeomon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Rarity", Rarity);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Image", Image);
                cmd.Parameters.AddWithValue("@Evo", Evo);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }
        public Geomon ReadGeomon(string Name)
        {
            Geomon g = null;
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spReadGeomon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = (int)reader[0];
                        string name = (string)reader[1];
                        int rarity = (int)reader[2];
                        string type = (string)reader[3];
                        string image = (string)reader[4];
                        int level = (int)reader[5];
                        int evo = (int)reader[6];
                        g = new Geomon(id, name, rarity, type, image, level, evo);
                    }
                }
                catch
                {

                }
            }
            return g;

        }
        public Geomon[] ReturnGeomons()
        {
            Geomon g = null;
            Geomon[] geoList = null;
            int i = 0;
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spReadAllGeomon", conn);


                try
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = (int)reader[0];
                        string name = (string)reader[1];
                        int rarity = (int)reader[2];
                        string type = (string)reader[3];
                        string image = (string)reader[4];
                        int level = (int)reader[5];
                        int evo = (int)reader[6];
                        g = new Geomon(id, name, rarity, type, image, level, evo);
                        geoList[i++] = g;
                    }
                }
                catch

                {

                }
            }
            return geoList;
        }

        public DataSet Geomon(string Name)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spGetGeomon", conn);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@Name", Name);

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
        public DataSet LocalGeomon()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spLocalGeomon", conn);
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
        public DataSet LocalCollection(String Username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("spLocalCollection", conn);
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

    }
}

