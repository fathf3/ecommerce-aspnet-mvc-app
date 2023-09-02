using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = " Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = " Email adress is required")]
        public string EmailAdress { get; set; }
        
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = " Password is required")]
        public string Password { get; set; }


        [Display(Name = "Comfirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Comfirm Password is required")]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ComfirmPassword { get; set; }
    }
}
