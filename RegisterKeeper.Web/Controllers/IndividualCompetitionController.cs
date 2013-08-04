using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegisterKeeper.Web.Models;

namespace RegisterKeeper.Web.Controllers
{
    public class IndividualCompetitionController : Controller
    {
        private RegisterKeeperDb db = new RegisterKeeperDb();

        //
        // GET: /IndividualCompetition/

        public ActionResult Index()
        {
            return View(db.IndividualCompetitions.ToList());
        }

        //
        // GET: /IndividualCompetition/Details/5

        public ActionResult Details(int id = 0)
        {
            IndividualCompetition individualcompetition = db.IndividualCompetitions.Find(id);
            if (individualcompetition == null)
            {
                return HttpNotFound();
            }
            return View(individualcompetition);
        }

        //
        // GET: /IndividualCompetition/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /IndividualCompetition/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IndividualCompetition individualcompetition)
        {
            if (ModelState.IsValid)
            {
                db.Competitions.Add(individualcompetition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(individualcompetition);
        }

        //
        // GET: /IndividualCompetition/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IndividualCompetition individualcompetition = db.IndividualCompetitions.Find(id);
            if (individualcompetition == null)
            {
                return HttpNotFound();
            }
            return View(individualcompetition);
        }

        //
        // POST: /IndividualCompetition/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IndividualCompetition individualcompetition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(individualcompetition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(individualcompetition);
        }

        //
        // GET: /IndividualCompetition/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IndividualCompetition individualcompetition = db.IndividualCompetitions.Find(id);
            if (individualcompetition == null)
            {
                return HttpNotFound();
            }
            return View(individualcompetition);
        }

        //
        // POST: /IndividualCompetition/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IndividualCompetition individualcompetition = db.IndividualCompetitions.Find(id);
            db.Competitions.Remove(individualcompetition);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}