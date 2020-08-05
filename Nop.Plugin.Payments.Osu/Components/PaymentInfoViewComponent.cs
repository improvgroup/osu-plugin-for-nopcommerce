using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Payments.Osu.Services;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.Osu.Components
{
    /// <summary>
    /// Represents a view component to display payment info in public store
    /// </summary>
    [ViewComponent(Name = Defaults.PAYMENT_INFO_VIEW_COMPONENT_NAME)]
    public class PaymentInfoViewComponent : NopViewComponent
    {
        #region Fields

        private readonly IOsuPaymentService _osuPaymentService;
        private readonly IPaymentInfoFactory _paymentInfoFactory;

        #endregion

        #region Ctor

        public PaymentInfoViewComponent(
            IOsuPaymentService osuPaymentService,
            IPaymentInfoFactory paymentInfoFactory)
        {
            _osuPaymentService = osuPaymentService;
            _paymentInfoFactory = paymentInfoFactory;
        }

        #endregion

        #region Methods

        public IViewComponentResult Invoke()
        {
            _osuPaymentService.CaptureTransactionId(null);

            var model = _paymentInfoFactory.CreatePaymentInfo();
            return View("~/Plugins/Payments.Osu/Views/PaymentInfo.cshtml", model);
        } 

        #endregion
    }
}
