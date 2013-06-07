using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CisionTranslationsPortal.DataTransferObject.Account;

namespace CisionTranslationsPortal.Assistant.Contract.Account
{
    public interface IAccountAssistant
    {
        void CreateAccount();
        SessionDTO Login(string username, string password);
    }
}
