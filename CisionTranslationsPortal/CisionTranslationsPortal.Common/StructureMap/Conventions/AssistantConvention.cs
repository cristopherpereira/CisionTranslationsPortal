using System;
using StructureMap.Graph;
using StructureMap.Configuration.DSL;

namespace Cision.CisionPoint.Common.StructureMap.Conventions
{
    public class AssistantConvention : IRegistrationConvention
    {

        #region IRegistrationConvention Members

        public void Process(Type type, Registry registry)
        {
            if (type != null && !string.IsNullOrEmpty(type.Namespace) && type.Namespace.Contains("CisionTranslationsPortal.Assistant"))
            {
                Type[] contractTypes = type.GetInterfaces();
                if (contractTypes.Length > 0)
                {
                    Type contractType = contractTypes[0];

                    registry.For(contractType).Use(type);
                    //registry.For(contractType).Singleton().TheDefaultIsConcreteType(type);
                }
            }
        }

        #endregion
    }
}
