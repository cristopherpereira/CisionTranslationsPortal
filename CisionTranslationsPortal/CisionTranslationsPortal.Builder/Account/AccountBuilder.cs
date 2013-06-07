using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountAssistant = CisionTranslationsPortal.Assistant.Contract.Account;
using BuilderContract = CisionTranslationsPortal.Web.Builder.Contract.Account;
using CisionTranslationsPortal.DataTransferObject.Account; 

namespace CisionTranslationsPortal.Web.Builder.Account
{
    public class AccountBuilder : BuilderContract.IAccountBuilder
    {
        public AccountAssistant.IAccountAssistant accountAssistant { get; set; }

        public bool Login(string username, string password)
        {
            SessionDTO a = accountAssistant.Login(username, password);
            return true;
        }
    }
}
