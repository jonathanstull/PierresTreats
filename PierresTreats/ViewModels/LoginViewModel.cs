using System.ComponentModel.DataAnnotations;

namespace PierresTreats.ViewModels
{
  public class LoginViewModel
  {
    [Display(Name = "Username")]
    public string UserName { get; set; }
    public string Password { get; set; }
  }
}