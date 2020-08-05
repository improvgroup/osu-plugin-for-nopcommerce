using Microsoft.AspNetCore.Html;

namespace Nop.Plugin.Payments.Osu.Services
{
    /// <summary>
    /// Provides an default implementation for factory to create the Osu widget script
    /// </summary>
    public class DefaultWidgetScriptFactory : IWidgetScriptFactory
    {
        #region Fields

        private readonly OsuPaymentSettings _osuPaymentSettings;

        #endregion

        #region Ctor

        public DefaultWidgetScriptFactory(OsuPaymentSettings osuPaymentSettings)
        {
            _osuPaymentSettings = osuPaymentSettings;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates the Osu widget script
        /// </summary>
        /// <returns>The Osu widget script</returns>
        public IHtmlContent CreateWidgetScript()
        {
            var url = _osuPaymentSettings.WidgetUrl;
            if (string.IsNullOrWhiteSpace(url))
                return new HtmlString(string.Empty);

            url = url.TrimEnd('/');

            var script = $@"<script src=""{url}/index.js"" type=""application/javascript""></script>";

            return new HtmlString(script);
        }

        #endregion
    }
}
