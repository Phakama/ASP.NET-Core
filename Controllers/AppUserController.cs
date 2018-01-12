using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp.Controllers
{
    [Authorize]
    public class AppUserController : Controller
    {
        private readonly UserRepository _userRepository;
        public AppUserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ApplicationUser AppUser)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddUser(AppUser);
                return RedirectToAction("UsersList");
            }
            return View(AppUser);
        }

        [HttpGet]
        public IActionResult UsersList()
        {
            IEnumerable<ApplicationUser> users = _userRepository.ListUsers;
            return View(users);
        }
    }
}
