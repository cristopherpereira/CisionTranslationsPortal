using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CisionTranslationsPortal.DataTransferObject.Account
{
    public class LogInDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SecurityAnswer { get; set; }
    }
}
