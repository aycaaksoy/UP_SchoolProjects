using CRM.Entity.Layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using CRM.UI.Layer.Areas.Employee.Models;

namespace CRM.UI.Layer.Areas.Employee.Controllers
{
    [Area("Employee")]

    public class EmployeeProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public EmployeeProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditProfileViewModel userEditProfileViewModel = new UserEditProfileViewModel();
            userEditProfileViewModel.Name = values.Name;
            userEditProfileViewModel.Surname = values.Surname;
            userEditProfileViewModel.PhoneNumber = values.PhoneNumber;
            userEditProfileViewModel.Email = values.Email;
            return View(userEditProfileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditProfileViewModel userEditProfileViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditProfileViewModel.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditProfileViewModel.Image.FileName);
                var ImageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserImages/" + ImageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEditProfileViewModel.Image.CopyToAsync(stream);
                user.ImageURL = ImageName;
            }
            user.Name = userEditProfileViewModel.Name;
            user.Surname = userEditProfileViewModel.Surname;
            user.PhoneNumber = userEditProfileViewModel.PhoneNumber;
            user.Email = userEditProfileViewModel.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditProfileViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            
            if (result.Succeeded)
            {
                
               return RedirectToAction("Index", "Login");

            }
            return View();
        }
    }
}

