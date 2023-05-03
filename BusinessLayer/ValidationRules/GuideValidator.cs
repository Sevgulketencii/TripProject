using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.GuideName).NotEmpty().WithMessage("Rehber Adı Boş Geçilemez");
            RuleFor(x => x.GuideDescription).NotEmpty().WithMessage("Rehber Açıklaması Boş Geçilemez");
            RuleFor(x => x.GuideImage).NotEmpty().WithMessage("Rehber Görseli Boş Geçilemez");
            RuleFor(x => x.GuideDescription).MaximumLength(150).WithMessage("Rehber Açıklaması Boş Geçilemez");
            RuleFor(x => x.GuideDescription).MinimumLength(10).WithMessage("Rehber Açıklaması Boş Geçilemez");
        }
    }
}
