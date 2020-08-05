using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.Osu
{
    /// <summary>
    /// Represents a settings of the Osu payment plugin
    /// </summary>
    public class OsuPaymentSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a widget url
        /// </summary>
        public string WidgetUrl { get; set; }

        /// <summary>
        /// Gets or sets a API key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets an additional fee
        /// </summary>
        public decimal AdditionalFee { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
        /// </summary>
        public bool AdditionalFeePercentage { get; set; }
    }
}
