using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi giriniz")]
        public string Password { get; set; }


    }
}
