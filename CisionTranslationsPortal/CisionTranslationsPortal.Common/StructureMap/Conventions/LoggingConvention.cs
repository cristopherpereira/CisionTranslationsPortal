using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Graph;
using System.Diagnostics;
using StructureMap.Configuration.DSL;

namespace Cision.CisionPoint.Common.StructureMap.Conventions
{
    public class LoggingConvention : IRegistrationConvention
    {
        #region IRegistrationConvention Members

        public void Process(Type type, Registry registry)
        {
            if (type != null && !string.IsNullOrEmpty(type.Namespace) && type.Namespace.Contains("Cision.Framework.Logging"))
            {
                Type[] contractTypes = type.GetInterfaces();
                if (contractTypes.Length > 0)
                {
                    Type contractType = contractTypes[0];

                    registry.For(contractType).Use(type);
                }
            }
        }

        #endregion
    }
}
