using DTOLayer.DTOs.AnnouncementDTOs;
using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTOs>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Mesaj boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık en az 3 harf olmalıdır");
            RuleFor(x => x.Content).MinimumLength(10).WithMessage("Mesaj en az 10 harf olmalıdır");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter olmalıdır");
            RuleFor(x => x.Content).MaximumLength(350).WithMessage("Mesaj en fazla 350 karakter olmalıdır");
        }
    }
}
