using DTOLayer.DTOs.UserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserSignInValidator:AbstractValidator<UserSignInDTOs>
    {
        public UserSignInValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez");
        }
    }
}
