using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name ="Email")]
        [Required(ErrorMessage =" Email adress is required")]
        public string EmailAdress { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        

        [Required(ErrorMessage = " Password is required")]
        public string Password { get; set; }
    }
}
