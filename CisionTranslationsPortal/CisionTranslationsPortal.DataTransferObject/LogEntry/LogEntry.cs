using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CisionTranslationsPortal.DataTransferObject.LogEntry
{
    class LogEntry
    {
        public int Id { get; set; }
        public int KeyId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string LanguageId { get; set; }
        public string Value { get; set; }
       
    }
}
