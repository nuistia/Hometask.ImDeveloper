using System.ComponentModel.DataAnnotations;

namespace Hometask.ImDeveloper.Web.Models;

public class WelcomePageForm
{
    [Required(ErrorMessage = "Name should be entered")]
    [MinLength(1, ErrorMessage = "Minimal length is 1")]
    [MaxLength(50, ErrorMessage = "Maximum length is 50")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email should be entered")]
    [EmailAddress(ErrorMessage = "Incorrect email")]
    public string Email { get; set; }
}
