using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // provides the business logic for the app by creating an insurance quote based on a set list of factors.
                int baseQuote = 50;
                int baseQuote1;
                int baseQuote2;
                int baseQuote3;
                int baseQuote4;
                int baseQuote5;
                int baseQuote6;
                if (insuree.DateOfBirth.Year >= 2002) { baseQuote1 = baseQuote + 100; }
                else if (insuree.DateOfBirth.Year >= 2001 || insuree.DateOfBirth.Year >= 1995) { baseQuote1 = baseQuote + 50; }
                else { baseQuote1 = baseQuote + 25; }      
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015) { baseQuote2 = baseQuote1 + 25; }
                else { baseQuote2 = baseQuote1; }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") { baseQuote3 = baseQuote2 + 50; }
                else if (insuree.CarMake == "Porsche") { baseQuote3 = baseQuote2 + 25; }
                else { baseQuote3 = baseQuote2; }
                if (insuree.SpeedingTickets > 0) { baseQuote4 = baseQuote3 + (insuree.SpeedingTickets * 10); }
                else { baseQuote4 = baseQuote3; }
                if (insuree.DUI == true) { baseQuote5 = baseQuote4 + (baseQuote4 / 4); }
                else { baseQuote5 = baseQuote4; }
                if (insuree.CoverageType == true) { baseQuote6 = (baseQuote5 + (baseQuote5 / 2)); }
                else { baseQuote6 = baseQuote5; }
                insuree.Quote = baseQuote6;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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
