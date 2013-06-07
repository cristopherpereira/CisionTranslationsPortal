using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Graph;
using System.Diagnostics;
using StructureMap.Configuration.DSL;

namespace Cision.CisionPoint.Common.StructureMap.Conventions
{
    public class BusinessComponentConvention : IRegistrationConvention
    {
        #region IRegistrationConvention Members
        public void Process(Type type, Registry registry)
        {
            Type contractType = type.GetInterface(string.Format("I{0}", type.Name.Replace("Bc", "BusinessComponent")));
            if (contractType != null)
            {
                registry.For(contractType).Singleton().TheDefaultIsConcreteType(type);
            }
        }
        #endregion
    }
}
