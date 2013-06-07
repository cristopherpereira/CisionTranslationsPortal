using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

using AssistantContract = CisionTranslationsPortal.Assistant.Contract;
using CisionTranslationsPortal.DataTransferObject.Account; 

namespace CisionTranslationsPortal.Assistant.Account
{
    public class AccountAssistant : AssistantContract.Account.IAccountAssistant
    {

        public void CreateAccount()
        {
            //var objectUser1 = new Login()
            //{
            //    FirstName = "Tiago",
            //    LastName = "Nunes",
            //    UserName = "capoitas",
            //    Password = "tiago1",
            //    RememberMe = "0"
            //};

            //loginCol.Save(objectUser1);
            throw new NotImplementedException();
        }

        public SessionDTO Login(string username, string password)
        {

            var connectionString = "mongodb://CBRINFPOR33:27017";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            //server.

            var database = server.GetDatabase("translationsTest");

            var loginCol = database.GetCollection("Login");

            

            var query = Query<LogInDTO>.EQ(e => e.Username, username);
            var entity = loginCol.FindOne(query);

            return new SessionDTO();
            //if (username.Equals("a") && password.Equals("a"))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
