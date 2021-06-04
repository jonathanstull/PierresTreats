using System.ComponentModel.DataAnnotations;

namespace PierresTreats.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [Display(Name = "Username")]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [Display(Name = "First name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last name")]
    public string LastName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The passwords do not match")]
    public string ConfirmPassword { get; set; }
  }
}