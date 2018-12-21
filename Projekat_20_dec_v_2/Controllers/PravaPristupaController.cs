using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Projekat_20_dec_v_2.Models;

namespace Projekat_20_dec_v_2.Controllers
{

    //kreiranje nove korisnicke role tipa kao pravo prisupa!

    [Authorize(Roles ="Administrator")]
    public class PravaPristupaController : Controller
    {

        private ApplicationRoleManager  _roleManager;

        public  PravaPristupaController()
        {
        }

        public PravaPristupaController(ApplicationRoleManager  roleManager)
        {

            RoleManager = roleManager;

        }

        public ApplicationRoleManager  RoleManager
        {
            get
            {
                return _roleManager  ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        // GET: PravaPristupa
        public ActionResult Index()
        {
            List<PravaPristupa> list = new List<PravaPristupa>();
            foreach (var role in RoleManager.Roles)
                list.Add(new PravaPristupa(role));
            return View(list);
   
        }

       

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(PravaPristupa model)
        {
            var role = new ApplicationRole() {Name = model.Name};
            await RoleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new PravaPristupa(role));
        }

        [HttpPost]
        public async Task<ActionResult> Edit(PravaPristupa model)
        {
            var role = new ApplicationRole() {Id = model.Id, Name = model.Name};
            await RoleManager.UpdateAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new PravaPristupa(role));
        }

        public async Task<ActionResult> Delete(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new PravaPristupa(role));
        }

       

        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            await RoleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }
    }
}