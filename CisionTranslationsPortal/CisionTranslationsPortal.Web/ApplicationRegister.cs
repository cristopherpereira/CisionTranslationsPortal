using StructureMap.Configuration.DSL;
using Cision.CisionPoint.Common.StructureMap.Conventions;

namespace CisionTranslationsPortal
{
    public class ApplicationRegistry : Registry
    {
        public ApplicationRegistry()
        {
            Scan(asmScanner =>
            {
                asmScanner.Assembly("CisionTranslationsPortal.Assistant");
                asmScanner.Assembly("CisionTranslationsPortal.Web.Builder");
                asmScanner.With(new AssistantConvention());
                //asmScanner.With(new BusinessComponentConvention());
                //asmScanner.With(new LoggingConvention());
                asmScanner.WithDefaultConventions();
                asmScanner.TheCallingAssembly();


                // For now we will register adapter like this:
                //For<IUserCacheManager>().Use<UserCacheManagerAdapter>();
                //For<IApplicationCacheManager>().Use<AppCacheManagerAdapter>();
                //For<ICryptoProvider>().Use<CryptoProvider>();
                //For<Cision.CisionPoint.Cache.ICacheProvider>().Use<Cision.CisionPoint.Cache.Memcached.MemcachedCacheProvider>();

                SetAllProperties(s =>
                {
                    s.WithAnyTypeFromNamespace("CisionTranslationsPortal.Assistant.Contract");
                    s.WithAnyTypeFromNamespace("CisionTranslationsPortal.Builder.Contract");
                    //s.WithAnyTypeFromNamespace("Cision.CisionPoint.Assistant.Helper.Contract");
                    //s.WithAnyTypeFromNamespace("Cision.CisionPoint.Database.Helper.Contract");
                    //s.WithAnyTypeFromNamespace("Cision.CisionPoint.Service.Contract");
                    //s.WithAnyTypeFromNamespace("Cision.Enterprise.API.Helper.Contract");
                    //s.WithAnyTypeFromNamespace("Cision.Enterprise.Assistant.Contract");
                    //s.WithAnyTypeFromNamespace("Cision.Framework.Logging.Interface");
                    //s.OfType<IUserCacheManager>();
                    //s.OfType<ICryptoProvider>();
                    //s.OfType<IApplicationCacheManager>();
                    //s.OfType<Cision.CisionPoint.Cache.ICacheProvider>();
                });
            });
        }
    }
}