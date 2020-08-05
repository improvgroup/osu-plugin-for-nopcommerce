namespace Nop.Plugin.Payments.Osu
{
    /// <summary>
    /// Represents a plugin defaults
    /// </summary>
    public static class Defaults
    {
        /// <summary>
        /// Gets the plugin system name
        /// </summary>
        public static string SystemName => "Payments.Osu";

        /// <summary>
        /// Gets the plugin configuration route name
        /// </summary>
        public static string ConfigurationRouteName => "Plugin.Payments.Osu.Configure";

        /// <summary>
        /// Gets a name of the view component to display payment info in public store
        /// </summary>
        public const string PAYMENT_INFO_VIEW_COMPONENT_NAME = "OsuPaymentInfo";

        /// <summary>
        /// Gets the session key to get process payment request
        /// </summary>
        public static string PaymentRequestSessionKey => "OrderPaymentInfo";

        /// <summary>
        /// Gets the name of attribute to store unique transaction identifier
        /// </summary>
        public static string PaymentTransactionIdAttribute => "OsuPaymentTransactionIdAttribute";

        /// <summary>
        /// Represents a Osu widget defaults
        /// </summary>
        public static class OsuWidget
        {
            /// <summary>
            /// Gets a name of the view component to add script to pages
            /// </summary>
            public const string SCRIPT_VIEW_COMPONENT_NAME = "OsuWidgetScript";

            /// <summary>
            /// Gets the sandbox url
            /// </summary>
            public static string SandboxUrl => "https://widget.sandbox.payosu.com";
        }

        /// <summary>
        /// Represents a web hooks defaults
        /// </summary>
        public static class WebHooks
        {
            /// <summary>
            /// Gets the success route name
            /// </summary>
            public static string SuccessRouteName => "Plugin.Payments.Osu.WebHooks.Success";

            /// <summary>
            /// Gets the failure route name
            /// </summary>
            public static string FailureRouteName => "Plugin.Payments.Osu.WebHooks.Failure";
        }
    }
}
