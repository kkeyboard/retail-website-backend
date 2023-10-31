using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_app_1.Models;

namespace web_app_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult WeaklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            if (login.Username != null && login.Password != null)
            {
                if (login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "You are successfully logged in";
                    return View();
                }
            }
            ViewBag.Message = "Invalid credentials.";
            // ViewBag.Username = login.Username;
            // ViewBag.Password = login.Password;
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginViewModel(){Username = "Jake", Password = "121212"};
            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {   
                new LoginViewModel(){Username = "Jake", Password = "121212"},
                new LoginViewModel(){Username = "Jorgo", Password = "44444"},
                new LoginViewModel(){Username = "Hanami", Password = "5432"}
            };
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}