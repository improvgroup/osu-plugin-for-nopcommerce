using Nop.Plugin.Payments.Osu.Models;

namespace Nop.Plugin.Payments.Osu.Services
{
    /// <summary>
    /// Provides an abstraction for factory to create the Osu payment info model
    /// </summary>
    public interface IPaymentInfoFactory
    {
        /// <summary>
        /// Creates the Osu payment info model
        /// </summary>
        /// <returns>The Osu payment info model</returns>
        PaymentInfoModel CreatePaymentInfo();
    }
}
