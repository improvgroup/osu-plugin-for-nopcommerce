using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.Osu.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute(
                Defaults.ConfigurationRouteName, 
                "Plugins/Osu/Configure",
                new 
                { 
                    controller = "OsuConfiguration", 
                    action = "Configure", 
                    area = AreaNames.Admin 
                });

            endpointRouteBuilder.MapControllerRoute(
                Defaults.WebHooks.SuccessRouteName, 
                "Plugins/Osu/WebHook/Success",
                new 
                { 
                    controller = "OsuWebHook", 
                    action = "HandleSuccess" 
                });

            endpointRouteBuilder.MapControllerRoute(
                Defaults.WebHooks.FailureRouteName,
                "Plugins/Osu/WebHook/Failure",
                new
                {
                    controller = "OsuWebHook",
                    action = "HandleFailure"
                });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}