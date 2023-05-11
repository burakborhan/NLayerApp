using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Core.DTO_s
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = " Kullanıcı adınızı giriniz.")]
        [Display(Name = "Kullanıcı adı")]
        public string userName { get; set; }


        [Required(ErrorMessage = " Şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
