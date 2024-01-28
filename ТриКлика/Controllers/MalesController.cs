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
    public class MalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Males
        public ActionResult Index()
        {
            return View(db.Males.ToList());
        }

        //GET :Males/Shoes
        public ActionResult Shoes()
        {
            return View(db.Males.ToList());
        }

        //GET :Males/Clothes
        public ActionResult Clothes()
        {
            return View(db.Males.ToList());
        }

        //GET :Males/Accesories
        public ActionResult Accesories()
        {
            return View(db.Males.ToList());
        }

        // GET: Males/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Male male = db.Males.Find(id);
            if (male == null)
            {
                return HttpNotFound();
            }
            return View(male);
        }

        // GET: Males/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Males/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,productName,productPrice,productDescription,discountPrice,productCategory,productImageOne,productImageTwo,productImageThree")] Male male)
        {
            if (ModelState.IsValid)
            {
                db.Males.Add(male);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(male);
        }

        // GET: Males/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Male male = db.Males.Find(id);
            if (male == null)
            {
                return HttpNotFound();
            }
            return View(male);
        }

        // POST: Males/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,productName,productDescription,productImageOne,productImageTwo,productImageThree")] Male male)
        {
            if (ModelState.IsValid)
            {
                db.Entry(male).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(male);
        }

        // GET: Males/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Male male = db.Males.Find(id);
            if (male == null)
            {
                return HttpNotFound();
            }
            return View(male);
        }

        // POST: Males/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Male male = db.Males.Find(id);
            db.Males.Remove(male);
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
