using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CisionTranslationsPortal.Web.Builder.Contract.Account
{
    public interface IAccountBuilder
    {
        bool Login(string username, string password);
    }
}
