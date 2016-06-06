using System;
using System.Runtime.Serialization;


namespace ClassLibrary.ModelLayer
{

    [DataContract]
    public class CustomerModel
    {

        //wrote stometin :3


        public CustomerModel() { }
        public CustomerModel(int Id, string ScrName, string Username, string Password, string Salt, string Email, int Steps, int Score, DateTime DateOfCreation)
        {
            this.Id = Id;
            this.ScrName = ScrName;
            this.Username = Username;
            this.Password = Password;
            this.Salt = Salt;
            this.Email = Email;
            this.Steps = Steps;
            this.Score = Score;
            this.DateOfCreation = DateOfCreation;

        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ScrName { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Salt { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Steps { get; set; }
        [DataMember]
        public int Score { get; set; }
        [DataMember]
        public DateTime DateOfCreation { get; set; }
    }
}
