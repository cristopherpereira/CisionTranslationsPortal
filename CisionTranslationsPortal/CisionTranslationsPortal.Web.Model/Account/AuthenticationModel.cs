using System;

namespace CisionTranslationsPortal.Model.Account
{
    class AuthenticationModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RememberUser { get; set; } //Possibly remove --
    }
}
