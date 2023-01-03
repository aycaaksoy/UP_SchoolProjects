using BaseIdentity.Entity.Layer.Concrete;
using BaseIdentity.Presentation.Layer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BaseIdentity.Presentation.Layer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(RegisterViewModel z)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = z.Name,
                    Surname = z.Surname,
                    Email = z.Email,
                    UserName = z.Username
                };

                if(z.Password== z.ConfirmPassword)
                {
                    var result = await userManager.CreateAsync(appUser, z.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach(var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Passwords do not match");
                }

            }
            return View(); 
        }
    }
}
