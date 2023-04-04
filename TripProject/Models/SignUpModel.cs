using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage ="Ad Boş Geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Boş Geçilemez")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail Adı Boş Geçilemez")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Adı Boş Geçilemez")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Boş Geçilmemsi lazım")]
        public string Password2 { get; set; }
    }
}
