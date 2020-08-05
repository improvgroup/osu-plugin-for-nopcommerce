namespace Nop.Plugin.Payments.Osu.Services
{
    /// <summary>
    /// Provides a abstraction to manage the Osu payment workflow
    /// </summary>
    public interface IOsuPaymentService
    {
        /// <summary>
        /// Captures the payment transaction id for current user
        /// </summary>
        /// <param name="transactionId">The payment transaction id</param>
        void CaptureTransactionId(string transactionId);

        /// <summary>
        /// Gets the captured payment transaction id for current user
        /// </summary>
        /// <returns>The payment transaction id</returns>
        string GetCapturedTransactionId();
    }
}
