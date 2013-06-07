using StructureMap;

namespace Cision.CisionPoint.Common.StructureMap.Helpers
{
    public class StructureMapHelper
    {
        public static T GetStructureMapInstance<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}
