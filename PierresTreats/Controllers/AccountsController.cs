using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierresTreats.Models;
using PierresTreats.ViewModels;
using System.Threading.Tasks;

namespace PierresTreats.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(PierresTreatsContext db, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
      _db = db;
      _userManager = userManager;
      _signInManager = signInManager;
    }
    
    public ActionResult Index()
    {
      return View();
    }
    
    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
      await _userManager.CreateAsync(user, model.Password);
      return RedirectToAction("Index");
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
      return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}