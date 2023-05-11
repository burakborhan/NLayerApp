using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Core.DTO_s
{
    public class PasswordViewModel
    {
        [Display(Name = "Eski Şifre")]
        [Required(ErrorMessage = "Eski şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        public string PasswordOld { get; set; }

        [Display(Name = "Yeni Şifre")]
        [Required(ErrorMessage = "Yeni şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Minimum length 6 and must contain  1 Uppercase,1 lowercase, 1 special character and 1 digit")]
        public string PasswordNew { get; set; }

        [Display(Name = "Şifre Doğrulama")]
        [Required(ErrorMessage = "Doğrulama şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        [Compare("PasswordNew", ErrorMessage = "Doğrulama şifrenizin yeni şifrenizle aynı olduğundan emin olun..")]
        public string PasswordConfirm { get; set; }
    }
}
