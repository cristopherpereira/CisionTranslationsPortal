using System;
using System.Collections.Generic;

namespace CisionTranslationsPortal.Model.Account
{
    public class LogEntryModel
    {
        public string User { get; set; }
        public string DatePosted { get; set; }
        public Dictionary<long, string> Translations { get; set; }
    }
}
