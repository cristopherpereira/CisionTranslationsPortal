using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CisionTranslationsPortal.DataTransferObject.Key
{
    [Serializable]
    public class KeyDTO
    {
        public int KeyId { get; set; }
        public string KeyValue{ get; set; }
        public string KeyDetail { get; set; }
        public Dictionary<LanguageDTO, TranslationDTO> Translations { get; set; }
    }
}
