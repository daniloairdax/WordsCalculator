using Services.ServiceContracts;
using Services.ServiceImplementation;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace WordsCalculatorApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ITextService, TextService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}