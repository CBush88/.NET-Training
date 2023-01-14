using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProgrammingPractice_EF_CodeFirst.DAL;
using ProgrammingPractice_EF_CodeFirst.Models;

namespace ProgrammingPractice_EF_CodeFirst.Controllers
{
    public class GradeCriteriaController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: GradeCriteria
        public ActionResult Index()
        {
            return View(db.GradeCriteria.ToList());
        }

        // GET: GradeCriteria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeCriteria gradeCriteria = db.GradeCriteria.Find(id);
            if (gradeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(gradeCriteria);
        }

        // GET: GradeCriteria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GradeCriteria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GradeName,MinPercentage,MaxPercentage")] GradeCriteria gradeCriteria)
        {
            if (ModelState.IsValid)
            {
                db.GradeCriteria.Add(gradeCriteria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gradeCriteria);
        }

        // GET: GradeCriteria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeCriteria gradeCriteria = db.GradeCriteria.Find(id);
            if (gradeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(gradeCriteria);
        }

        // POST: GradeCriteria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GradeName,MinPercentage,MaxPercentage")] GradeCriteria gradeCriteria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gradeCriteria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gradeCriteria);
        }

        // GET: GradeCriteria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeCriteria gradeCriteria = db.GradeCriteria.Find(id);
            if (gradeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(gradeCriteria);
        }

        // POST: GradeCriteria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GradeCriteria gradeCriteria = db.GradeCriteria.Find(id);
            db.GradeCriteria.Remove(gradeCriteria);
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
