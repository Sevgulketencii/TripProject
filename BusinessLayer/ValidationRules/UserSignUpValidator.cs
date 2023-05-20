using DTOLayer.DTOs.UserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserSignUpValidator:AbstractValidator<UserSignUpDTOs>
    {
        public UserSignUpValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adınız Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadınız Boş Geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.Password2).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("En fazla 20 karakter");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("En fazla 20 karakter");
            RuleFor(x => x.Password).Equal(y => y.Password2).WithMessage("Şifreler Uyuşmuyor");

        }
    }
}
