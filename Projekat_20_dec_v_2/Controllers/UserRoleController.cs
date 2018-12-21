using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Projekat_20_dec_v_2.Migrations;
using Projekat_20_dec_v_2.Models;

namespace Projekat_20_dec_v_2.Controllers
{

    // samo za admina unos, novih clanova sa poljem pristupa, i prikazivanje detalja o useru
  
    public class UserRoleController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;
        private ApplicationDbContext context;
        public UserRoleController() { }


        public UserRoleController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            RoleManager = roleManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().Get<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public static string GetMD5Hash(string  input)
        {
            string izlaz;
            if (input != null)
            {
                izlaz = Crypto.HashPassword(input);
            }
            else
                izlaz = "Greska";
            return izlaz;
        
    }
       [CustomAuthorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            List<UserViewModel> list = new List<UserViewModel>();
            foreach (var user in UserManager.Users)
                list.Add(new UserViewModel(user));
            return View(list);
        }

        [CustomAuthorize(Roles = "Administrator")]
        public async Task<ActionResult> Create(UserViewModel model)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var role in RoleManager.Roles)
                list.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            ViewBag.Roles = list;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email,  PasswordHash =GetMD5Hash(model.Password )};
                var result = await UserManager.CreateAsync( user );
                if (result.Succeeded)
                {
                    result = await UserManager.AddToRoleAsync(user.Id, model.RoleName );
                    

                    return RedirectToAction("Index", "UserRole");
                }
                // AddErrors(result);
            }           
            return View(model);
        }
    }
}