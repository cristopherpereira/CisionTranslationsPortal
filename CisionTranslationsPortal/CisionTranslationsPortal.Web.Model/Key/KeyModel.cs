using System;
using System.Collections.Generic;

namespace CisionTranslationsPortal.Model.Account
{
    public class KeyModel
    {
        public long KeyId { get; set; }
        public string KeyValue { get; set; }
        public Dictionary<long, string> Translations { get; set; }
        public KeyDetailModel KeyDetail { get; set; }

    }
}
