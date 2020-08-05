namespace Nop.Plugin.Payments.Osu.Models
{
    /// <summary>
    /// Represents a payment info model
    /// </summary>
    public class PaymentInfoModel
    {
        /// <summary>
        /// Gets or sets the buyer email
        /// </summary>
        /// <remarks>
        /// Mandatory parameter
        /// </remarks>
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Gets or sets the payment currency, 3 letter code e.g: GBP
        /// </summary>
        /// <remarks>
        /// Mandatory parameter
        /// </remarks>
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// Gets or sets the API key
        /// </summary>
        /// <remarks>
        /// Mandatory parameter
        /// </remarks>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the success url
        /// </summary>
        /// <remarks>
        /// Mandatory parameter
        /// </remarks>
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Gets or sets the payment amount, denoted in cents. e.g: for a 100 GBP the value of this field will be 10000
        /// </summary>
        /// <remarks>
        /// Mandatory parameter
        /// </remarks>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the payment reference
        /// </summary>
        /// <remarks>
        /// Mandatory parameter
        /// </remarks>
        public string PaymentReference { get; set; }

        /// <summary>
        /// Gets or sets the buyer first name
        /// </summary>
        /// <remarks>
        /// Optional parameter
        /// </remarks>
        public string BuyerFirstName { get; set; }

        /// <summary>
        /// Gets or sets the buyer last name
        /// </summary>
        /// <remarks>
        /// Optional parameter
        /// </remarks>
        public string BuyerLastName { get; set; }

        /// <summary>
        /// Gets or sets the buyer post code
        /// </summary>
        /// <remarks>
        /// Optional parameter
        /// </remarks>
        public string BuyerPostCode { get; set; }

        /// <summary>
        /// Gets or sets the buyer address
        /// </summary>
        /// <remarks>
        /// Optional parameter
        /// </remarks>
        public string BuyerAddress { get; set; }

        /// <summary>
        /// Gets or sets the failure url, if not provided <see cref="SuccessUrl"/> will be called
        /// </summary>
        /// <remarks>
        /// Optional parameter
        /// </remarks>
        public string FailureUrl { get; set; }
    }
}
