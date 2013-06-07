using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enums = CisionTranslationsPortal.Common.Enum;

namespace CisionTranslationsPortal.DataTransferObject.Account
{
    public class SessionDTO
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public DateTime LastAccess { get; set; }
        public Enums.Role UserRole { get; set; }
    }
}
