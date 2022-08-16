using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vizem.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soy Adınız")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage ="Geçerli Bir E Posta Adresi Girin")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Şifrenizi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreleriniz Uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}