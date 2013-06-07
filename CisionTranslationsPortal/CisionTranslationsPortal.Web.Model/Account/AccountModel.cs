using System;
using Enums = CisionTranslationsPortal.Common.Enum;

namespace CisionTranslationsPortal.Model.Account
{
    class AccountModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Enums.Role Role { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
