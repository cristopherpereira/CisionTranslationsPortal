using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CisionTranslationsPortal.DataTransferObject.Key
{
    public class TranslationDTO
    {
        public int TranslationId {get; set;}
        public string TranslationValue { get; set; }
        public string LanguageCode { get; set; }
    }
}
