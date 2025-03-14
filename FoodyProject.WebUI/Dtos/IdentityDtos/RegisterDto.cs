using System.ComponentModel.DataAnnotations;

namespace FoodyProject.WebUI.Dtos.IdentityDtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        public string Mail { get; set; }


        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
