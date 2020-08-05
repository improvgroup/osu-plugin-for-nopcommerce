using Microsoft.AspNetCore.Html;

namespace Nop.Plugin.Payments.Osu.Services
{
    /// <summary>
    /// Provides an abstraction for factory to create the Osu widget script
    /// </summary>
    public interface IWidgetScriptFactory
    {
        /// <summary>
        /// Creates the Osu widget script
        /// </summary>
        /// <returns>The Osu widget script</returns>
        IHtmlContent CreateWidgetScript();
    }
}
