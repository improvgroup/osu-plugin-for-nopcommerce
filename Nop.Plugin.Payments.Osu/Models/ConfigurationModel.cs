using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Payments.Osu.Models
{
    /// <summary>
    /// Represents a plugin configuration model
    /// </summary>
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a widget url
        /// </summary>
        [NopResourceDisplayName("Plugins.Payments.Osu.Fields.WidgetUrl")]
        public string WidgetUrl { get; set; }
        public bool WidgetUrl_OverrideForStore { get; set; }

        /// <summary>
        /// Gets or sets a API key
        /// </summary>
        [NopResourceDisplayName("Plugins.Payments.Osu.Fields.ApiKey")]
        public string ApiKey { get; set; }
        public bool ApiKey_OverrideForStore { get; set; }

        /// <summary>
        /// Gets or sets an additional fee
        /// </summary>
        [NopResourceDisplayName("Plugins.Payments.Osu.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
        /// </summary>
        [NopResourceDisplayName("Plugins.Payments.Osu.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}