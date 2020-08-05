using Nop.Core;
using Nop.Services.Common;

namespace Nop.Plugin.Payments.Osu.Services
{
    /// <summary>
    /// Provides an default implementation to manage the Osu payment workflow
    /// </summary>
    public class DefaultOsuPaymentService : IOsuPaymentService
    {
        #region Fields

        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        #endregion

        #region Ctor

        public DefaultOsuPaymentService(
            IGenericAttributeService genericAttributeService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _genericAttributeService = genericAttributeService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Captures the payment transaction id for current user
        /// </summary>
        /// <param name="transactionId">The payment transaction id</param>
        public virtual void CaptureTransactionId(string transactionId)
        {
            var customer = _workContext.CurrentCustomer;
            var store = _storeContext.CurrentStore;

            _genericAttributeService.SaveAttribute(customer, Defaults.PaymentTransactionIdAttribute, transactionId, store.Id);
        }

        /// <summary>
        /// Gets the captured payment transaction id for current user
        /// </summary>
        /// <returns>The payment transaction id</returns>
        public virtual string GetCapturedTransactionId()
        {
            var customer = _workContext.CurrentCustomer;
            var store = _storeContext.CurrentStore;

            return _genericAttributeService.GetAttribute<string>(customer, Defaults.PaymentTransactionIdAttribute, store.Id);
        }

        #endregion
    }
}
