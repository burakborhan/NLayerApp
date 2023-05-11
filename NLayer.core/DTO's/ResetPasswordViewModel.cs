using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Core.DTO_s
{
    public class ResetPasswordViewModel
    {
        [Display(Name = "E-mail Adresi")]
        [Required(ErrorMessage = "E-mail adresinizi giriniz.")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Yeni Şifre")]
        [Required(ErrorMessage = " Şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Minimum length 6 and must contain  1 Uppercase,1 lowercase, 1 special character and 1 digit")]
        public string NewPassword { get; set; }
    }
}
