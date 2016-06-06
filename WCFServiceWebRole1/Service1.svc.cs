using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.ServiceModel.Channels;
using System.IO;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public int CreateCustomer(string ScrName, string Username, string Password, string Email, DateTime DateOfCreation)
        {
            DBCustomer dbc = new DBCustomer();
            Console.WriteLine();
            Console.WriteLine("CreateCustomer() " + GetExecutionThreadTime());
            return dbc.CreateCustomer(ScrName, Username, Password, Email, DateOfCreation);

        }

        public void ReadCustomer(string Username)
        {
            DBCustomer dbc = new DBCustomer();
            Console.WriteLine();
            Console.WriteLine("ReadCustomer() " + GetExecutionThreadTime());
            dbc.ReadCustomer(Username);
        }

        public void UpdateCustomer(string ScrName, string Username, string Password, string Salt, string Email)
        {
            DBCustomer dbc = new DBCustomer();
            Console.WriteLine();
            Console.WriteLine("UpdateCustomer() " + GetExecutionThreadTime());
            dbc.UpdateCustomer(ScrName, Username, Password, Salt, Email);
        }

        public void DeleteCustomer(string Username)
        {
            DBCustomer dbc = new DBCustomer();
            Console.WriteLine();
            Console.WriteLine("DeleteCustomer() " + GetExecutionThreadTime());
            dbc.DeleteCustomer(Username);
        }

        public int Login(string Username, string Password)
        {
            DBCustomer dbc = new DBCustomer();
            Console.WriteLine();
            Console.WriteLine("Login() " + GetExecutionThreadTime());
            return dbc.Login(Username, Password);
        }

        public void CreateGeomon(string Name, int Rarity, string Type, string Image)
        {
            DBGeomon dbg = new DBGeomon();
            Console.WriteLine();
            Console.WriteLine("CreateGeomon() " + GetExecutionThreadTime());
            dbg.CreateGeomon(Name, Rarity, Type, Image);
        }


        // public Geomon ReadGeomon(string Name)
        // {
        //     DBGeomon dbg = new DBGeomon();
        //    return dbg.ReadGeomon(Name);
        // }

        public void UpdateGeomon(string Name, int Rarity, string Type, string Image, int Evo)
        {
            DBGeomon dbg = new DBGeomon();
            Console.WriteLine();
            Console.WriteLine("UpdateGeomon() " + GetExecutionThreadTime());
            dbg.UpdateGeomon(Name, Rarity, Type, Image, Evo);
        }

        public void DeleteGeomon(string Name)
        {
            DBGeomon dbg = new DBGeomon();
            Console.WriteLine();
            Console.WriteLine("DeleteGeomon() " + GetExecutionThreadTime());
            dbg.DeleteGeomon(Name);
        }

        public DataSet Highscore()
        {
            DBCustomer dbc = new DBCustomer();
            DataSet ds = dbc.Highscore();
            Console.WriteLine();
            Console.WriteLine("Highscore() " + GetExecutionThreadTime());
            return ds;
        }

        public Stream HighscoreJson()
        {
            DBCustomer dbc = new DBCustomer();
            DataSet ds = dbc.Highscore();

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("HighscoreJson() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }

        public DataSet Collection(string Username)
        {
            DBCollection dbc = new DBCollection();
            DataSet ds = dbc.Collection(Username);
            Console.WriteLine();
            Console.WriteLine("Collection() " + GetExecutionThreadTime());
            return ds;
        }

        public Stream CollectionJson(string Username)
        {
            DBCollection dbc = new DBCollection();
            DataSet ds = dbc.Collection(Username);

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("CollectionJson() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }

        public DataSet Geomon(string Name)
        {
            DBGeomon dbc = new DBGeomon();
            DataSet ds = dbc.Geomon(Name);
            Console.WriteLine();
            Console.WriteLine("Geomon() " + GetExecutionThreadTime());
            return ds;
        }

        public Stream GeomonJson(string Name)
        {
            DBGeomon dbc = new DBGeomon();
            DataSet ds = dbc.Geomon(Name);

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("GeomonJson() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }

        public DataSet Achievements(string Username)
        {
            DBCollection dbc = new DBCollection();
            DataSet ds = dbc.Achievements(Username);
            Console.WriteLine();
            Console.WriteLine("Achievements() " + GetExecutionThreadTime());
            return ds;
        }

        public Stream AchievementsJson(string Username)
        {
            DBCollection dbc = new DBCollection();
            DataSet ds = dbc.Achievements(Username);

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("AchievementsJson() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
        }

        public DataSet GetEggs(string Username)
        {
            DBCollection dbc = new DBCollection();
            DataSet ds = dbc.GetEggs(Username);
            Console.WriteLine();
            Console.WriteLine("GetEggs() " + GetExecutionThreadTime());
            return ds;
        }

        public Stream GetEggsJson(string Username)
        {
            DBCollection dbc = new DBCollection();
            DataSet ds = dbc.GetEggs(Username);

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("GetEggsJson() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }

        public DataSet ProfileView(string Username)
        {
            DBCustomer dbc = new DBCustomer();
            DataSet ds = dbc.ProfileViev(Username);
            Console.WriteLine();
            Console.WriteLine("ProfileView() " + GetExecutionThreadTime());
            return ds;
        }

        public Stream ProfileViewJson(string Username)
        {
            DBCustomer dbc = new DBCustomer();
            DataSet ds = dbc.ProfileViev(Username);

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("ProfileViewJson() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }
        public Stream LocalGeomon()
        {
            DBGeomon dbg = new DBGeomon();
            DataSet ds = dbg.LocalGeomon();

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("LocalGeomon() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }
        public DataSet Users()
        {
            DBCustomer dbc = new DBCustomer();
            DataSet ds = dbc.Users();
            Console.WriteLine();
            Console.WriteLine("Users() " + GetExecutionThreadTime());
            return ds;
        }
        public string[] isFriend(string Username)
        {
            DBCustomer dbc = new DBCustomer();
            Console.WriteLine();
            Console.WriteLine("isFriend() " + GetExecutionThreadTime());
            return dbc.isFriend(Username);
        }

        public void AddFriend(string Username, string FriendUsername)
        {
            DBCollection dbc = new DBCollection();
            dbc.AddFriend(Username, FriendUsername);
            Console.WriteLine();
            Console.WriteLine("AddFriend() " + GetExecutionThreadTime());
        }

        public Stream LocalCollection(String Username)
        {
            DBGeomon dbg = new DBGeomon();
            DataSet ds = dbg.LocalCollection(Username);

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(ds);

            Console.WriteLine();
            Console.WriteLine("LocalCollection() " + GetExecutionThreadTime());

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

        }

        public void InsertCollection(string Username, string Id)
        {
            DBCollection dbc = new DBCollection();
            dbc.InsertCollection(Username, Int32.Parse(Id));

            Console.WriteLine();
            Console.WriteLine("InsertCollection() " + GetExecutionThreadTime());
        }


        private string GetExecutionThreadTime()
        {
            string message = " executed by Thread: " + Thread.CurrentThread.ManagedThreadId.ToString() +
                " at : " + DateTime.Now.ToString();
            return message;
        }
    }
}
