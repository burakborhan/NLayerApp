using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Core.DTO_s
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı giriniz.")]
        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Telefon numarası giriniz.")]
        [RegularExpression(@"^(0(\d{3}) (\d{3}) (\d{2}) (\d{2}))$", ErrorMessage = "Yanlış Format: xxxx xxx xx xx")]
        [Display(Name = "Telefon Numarası")]
        [Phone]
        public string? PhoneNumber { get; set; }


        [Display(Name = "E-mail")]
        [EmailAddress]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Şifre giriniz.")]
        [Display(Name = "Şifre")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Minimum length 6 and must contain  1 Uppercase,1 lowercase, 1 special character and 1 digit")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Kurum adı gereklidir.")]
        [Display(Name ="Kurum Adı")]
        public string? CompanyName { get; set; }
    }
}
