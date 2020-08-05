using FluentValidation;
using Nop.Plugin.Payments.Osu.Models;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Plugin.Payments.Osu.Validators
{
    /// <summary>
    /// Represents a validator for <see cref="ConfigurationModel"/>
    /// </summary>
    public class ConfigurationModelValidator : BaseNopValidator<ConfigurationModel>
    {
        #region Ctor

        public ConfigurationModelValidator(ILocalizationService localizationService)
        {
            RuleFor(model => model.WidgetUrl)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Plugins.Payments.Osu.Fields.WidgetUrl.Required"));

            RuleFor(model => model.ApiKey)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Plugins.Payments.Osu.Fields.ApiKey.Required"));

            RuleFor(model => model.AdditionalFee)
                .GreaterThanOrEqualTo(0)
                .WithMessage(localizationService.GetResource("Plugins.Payments.Osu.Fields.AdditionalFee.ShouldBeGreaterThanOrEqualZero"));
        }

        #endregion
    }
}
