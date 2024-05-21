using System.ComponentModel.DataAnnotations;

namespace WebApplicationFirstTry.Domain.ViewModel.EntityViewModels
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Enter the name")]
        [MaxLength(50, ErrorMessage = "Length cannot be more than 50 symbols")]

        public string? UserName { get; set; }

        [Range(1, 110, ErrorMessage = "Unallowed age")]

        public int Age { get; set; }
    }
}