using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactPhone).MinimumLength(9).WithMessage("9 karakterden fazla olamaz");
        }

    }
}
