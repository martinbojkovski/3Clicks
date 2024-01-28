using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ТриКлика.Models;

namespace ТриКлика.Controllers
{
    public class FemalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Females
        public ActionResult Index()
        {
            return View(db.Females.ToList());
        }

        // GET: Females/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Female female = db.Females.Find(id);
            if (female == null)
            {
                return HttpNotFound();
            }
            return View(female);
        }

        // GET: Females/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Females/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,productName,productDescription,productPrice,discountPrice,productCategory,productImageOne,productImageTwo,productImageThree")] Female female)
        {
            if (ModelState.IsValid)
            {
                db.Females.Add(female);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(female);
        }

        // GET: Females/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Female female = db.Females.Find(id);
            if (female == null)
            {
                return HttpNotFound();
            }
            return View(female);
        }

        // POST: Females/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,productName,productDescription,productImageOne,productImageTwo,productImageThree")] Female female)
        {
            if (ModelState.IsValid)
            {
                db.Entry(female).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(female);
        }

        // GET: Females/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Female female = db.Females.Find(id);
            if (female == null)
            {
                return HttpNotFound();
            }
            return View(female);
        }

        // POST: Females/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Female female = db.Females.Find(id);
            db.Females.Remove(female);
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
