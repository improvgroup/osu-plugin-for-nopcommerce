using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Nop.Plugin.Payments.Osu.Services;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.Osu.Components
{
    /// <summary>
    /// Represents a view component to generate the Osu widget script
    /// </summary>
    [ViewComponent(Name = Defaults.OsuWidget.SCRIPT_VIEW_COMPONENT_NAME)]
    public class WidgetScriptViewComponent : NopViewComponent
    {
        #region Fields

        private readonly IWidgetScriptFactory _widgetScriptFactory;

        #endregion

        #region Ctor

        public WidgetScriptViewComponent(IWidgetScriptFactory widgetScriptFactory)
        {
            _widgetScriptFactory = widgetScriptFactory;
        }

        #endregion

        #region Methods

        public IViewComponentResult Invoke()
        {
            var scriptContent = _widgetScriptFactory.CreateWidgetScript();
            if (scriptContent == null)
                return Content(string.Empty);

            return new HtmlContentViewComponentResult(scriptContent);
        }

        #endregion
    }
}
