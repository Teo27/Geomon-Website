using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "CreateCustomer?ScrName={ScrName}&Username={Username}&Password={Password}&Email={Email}&DateOfCreation={DateOfCreation}", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        int CreateCustomer(string ScrName, string Username, string Password, string Email, DateTime DateOfCreation);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Login?Username={Username}&Password={Password}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        [OperationContract]
        int Login(string Username, string Password);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Highscore", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        DataSet Highscore();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "HighscoreJson", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        Stream HighscoreJson();

        void UpdateCustomer(string ScrName, string Username, string Password, string Salt, string Email);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Collection?Username={Username}")]
        [OperationContract]
        DataSet Collection(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "CollectionJson?Username={Username}")]
        [OperationContract]
        Stream CollectionJson(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Achievements?Username={Username}")]
        [OperationContract]
        DataSet Achievements(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "AchievementsJson?Username={Username}")]
        [OperationContract]
        Stream AchievementsJson(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetEggs?Username={Username}")]
        [OperationContract]
        DataSet GetEggs(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetEggsJson?Username={Username}")]
        [OperationContract]
        Stream GetEggsJson(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "ProfileView?Username={Username}")]
        [OperationContract]
        DataSet ProfileView(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "ProfileViewJson?Username={Username}")]
        [OperationContract]
        Stream ProfileViewJson(string Username);

        //[OperationContract]
        //DataSet Users();

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Geomon?Name={Name}")]
        [OperationContract]
        DataSet Geomon(string Name);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GeomonJson?Name={Name}")]
        [OperationContract]
        Stream GeomonJson(string Name);

        //[OperationContract]
        //void AddFriend(string Username, string FriendUsername);

        //[OperationContract]
        //string[] isFriend(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "LocalGeomon")]
        [OperationContract]
        Stream LocalGeomon();

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "LocalCollection?Username={Username}")]
        [OperationContract]
        Stream LocalCollection(string Username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "InsertCollection?Username={Username}&Id={Id}")]
        [OperationContract]
        void InsertCollection(string Username, string Id);

        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCollection?Username={Username}")]
        //[OperationContract]
        //List<WCFLib.Serializing.Geomon> GetCollection(string Username);

        //[WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, UriTemplate = "CreateGeomon?Name={Name}&Rarity={Rarity}&Type={Type}&Image={Image}")]
        //[OperationContract]
        //void CreateGeomon(string Name, int Rarity, string Type, string Image);

        ////  [OperationContract]
        ////  Geomon ReadGeomon(string Name);

        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "ReadCustomer?Username={Username}")]
        //[OperationContract]
        //void ReadCustomer(string Username);

        //[WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteCustomer?Username={Username}")]
        //[OperationContract]
        //void DeleteCustomer(string Username);

        //[WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateGeomon?Name={Name}&Rarity={Rarity}&Type={Type}&Image={Image}&Evo={Evo}")]
        //[OperationContract]
        //void UpdateGeomon(string Name, int Rarity, string Type, string Image, int Evo);

        //[WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteGeomon?Name={Name}")]
        //[OperationContract]
        //void DeleteGeomon(string Name);

    }
}
