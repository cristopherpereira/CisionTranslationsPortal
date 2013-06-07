using System;

namespace CisionTranslationsPortal.Model.Account
{
    public class SearchRequestModel
    {
        public string SearchTerm { get; set; }
        public bool KeysSelected { get; set; }
        public bool TranslationsSelected { get; set; }
    }
}
