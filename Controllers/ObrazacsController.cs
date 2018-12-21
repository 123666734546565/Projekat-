using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projekat_20_dec_v_2.Models;

namespace Projekat_20_dec_v_2.Controllers
{
    public class ObrazacsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Obrazacs
        public async Task<ActionResult> Index()
        {
            return View(await db.Obrazacs.ToListAsync());
        }

        // GET: Obrazacs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obrazac obrazac = await db.Obrazacs.FindAsync(id);
            if (obrazac == null)
            {
                return HttpNotFound();
            }
            return View(obrazac);
        }

        // GET: Obrazacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Obrazacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdSkole,NazivSkole,Adresa,Opstina,PostanskiBroj,Maticni_Broj_Skole,Pib,BrojRacunaSkole,Website,Beleska,ime,prezime,radno_mesto,broj_telefona,lokal,Email_adresa")] Obrazac obrazac)
        {

            
            if (ModelState.IsValid)
            {
                db.Obrazacs.Add(obrazac);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obrazac);
        }

        // GET: Obrazacs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obrazac obrazac = await db.Obrazacs.FindAsync(id);
            if (obrazac == null)
            {
                return HttpNotFound();
            }
            return View(obrazac);
        }



        // POST: Obrazacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdSkole,NazivSkole,Adresa,Opstina,PostanskiBroj,Maticni_Broj_Skole,Pib,BrojRacunaSkole,Website,Beleska,ime,prezime,radno_mesto,broj_telefona,lokal,Email_adresa")] Obrazac obrazac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obrazac).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obrazac);
        }



        // GET: Obrazacs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obrazac obrazac = await db.Obrazacs.FindAsync(id);
            if (obrazac == null)
            {
                return HttpNotFound();
            }
            return View(obrazac);
        }

        // POST: Obrazacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Obrazac obrazac = await db.Obrazacs.FindAsync(id);
            db.Obrazacs.Remove(obrazac);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
