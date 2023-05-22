using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        public ActionResult TotalQuote(Table model)
        {
            decimal monthlyTotal = 50;
            int age = Age(model.DateOfBirth);
            //If the person is less than 18 years of age, add 100 to their total
            if(age <= 18)
            {
                monthlyTotal += 100;
            }
            //If they are between 19 and 25, add 50
            else if (age >= 19 && age <= 25)
            {
                monthlyTotal += 50;
            }
            //If neither, add 25
            else
            {
                monthlyTotal += 25;
            }


            //If car year is below 2000, add 25 to the total. If it is after 2015, add 25.
            if (model.CarYear < 2000)
            {
                monthlyTotal += 25;
            }
            else if (model.CarYear > 2015)
            {
                monthlyTotal += 25;
            }


            //If the car is a Porsche and a 011 Carrera, add to the total
            if (model.CarMake == "Porsche")
            {
                if (model.CarModel == "911 Carrera")
                {
                    monthlyTotal += 25;
                }
            }

            //This will take the amount of speeding tickets, times them by 10 and add them to the total
            monthlyTotal += 10 * model.SpeedingTickets;

            //If the person has had a dui add 25% to the total. 
            if (model.DUI)
            {
                monthlyTotal *= 1.25m;
            }


            //If the person has full coverage add 50% to the total
            if (model.CoverageType)
            {
                monthlyTotal *= 1.5m;
            }

            model.FirstName = model.FirstName;
            model.LastName = model.LastName;
            model.EmailAddress = model.EmailAddress;
            model.Quote = monthlyTotal;
            return View();
        }

        //
        private int Age(DateTime DateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (today < DateOfBirth.AddYears(age))
            {
                age--;
            }
            return age;
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }

            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
