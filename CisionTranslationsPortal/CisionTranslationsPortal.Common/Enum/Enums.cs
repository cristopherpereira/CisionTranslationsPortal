using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CisionTranslationsPortal.Common.Enum
{
    [Serializable]
    public enum Languages
    {
        [Description("English (US)")]
        en_US = 0,
        [Description("German")]
        de_DE = 1,
        [Description("English (UK)")]
        en_GB = 2,
        [Description("Finnish")]
        fi_FI = 3,
        [Description("French (France)")]
        fr_FR = 4,
        [Description("French (Canada)")]
        fr_CA = 5,
        [Description("Swedish")]
        sv_SE = 6,
        [Description("Spanish")]
        es_ES = 7,
        [Description("English (Canada)")]
        en_CA = 8,
        [Description("Russian")]
        ru_RU = 9
    }

    [Serializable]
    public enum Role
    {
        Developer = 0,
        Translator = 1,
        Admin = 2
    }

    [Serializable]
    public enum DataSource
    {
        [Description("Cision Point Dev1 Data Base")]
        CP_DEV1 = 0,
        [Description("Cision Point Dev2 Data Base")]
        CP_DEV2 = 1,
        [Description("Cision Point Dev3 Data Base")]
        CP_DEV3 = 2,
        [Description("Cision Point Dev4 Data Base")]
        CP_DEV4 = 3,
        [Description("Cision Point Dev5 Data Base")]
        CP_DEV5 = 4,
        [Description("Cision Point INT Data Base")]
        CP_INT = 5,
        [Description("CODS Data Base")]
        CODS = 6
    }
}
