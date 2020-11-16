using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ORGANISATION_X.Models;

namespace ORGANISATION_X.Controllers
{
    public class AccountController : Controller
    {
        private readonly OrganisationxDBContext AppUser;

        public AccountController(OrganisationxDBContext user)
        {
            AppUser = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(LoginModel reg)
        {
            AppUser.Add(reg);
            AppUser.SaveChanges();
            ViewBag.message = "You have successfully created an account, please use your Username and Password to login";
            return View();
        }
    }
}
