using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_views_lab.Models.ViewModel
{
    public class EditCustomerViewModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter name")]
        public string? Name { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter Email")]
        public string? Email { get; set; }
    }
}
