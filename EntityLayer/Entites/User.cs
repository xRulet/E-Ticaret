using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Entites
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [MaxLength(50, ErrorMessage = "Max 50 Karakter olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyad")]
        [MaxLength(50, ErrorMessage = "Max 50 Karakter olmalıdır.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [MaxLength(50, ErrorMessage = "Max 50 Karakter olmalıdır.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "E-Posta")]
        [MaxLength(50, ErrorMessage = "Max 50 Karakter olmalıdır.")]
        [EmailAddress(ErrorMessage = "E-mail formatı şeklinde giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Şifre")]
        [MaxLength(10, ErrorMessage = "Max 10 Karakter olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre doğrulama alanı zorunludur.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        [NotMapped]
        [Display(Name = "Şifre Doğrulama")]
        public string RePassword { get; set; }

        [StringLength(10,ErrorMessage ="Max 10 Karakter Olmalıdır.")]
        public string Role { get; set; }

    }
}
