using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_views_lab.Models.ViewModel
{
    public class EditCustomerViewModel
    {
        [DisplayName("Namn")]
        [Required(ErrorMessage = "Ange ett namn")]
        public string? Name { get; set; }
        [DisplayName("E-post")]
        [Required(ErrorMessage = "Ange en e-post")]
        public string? Email { get; set; }
    }
}
