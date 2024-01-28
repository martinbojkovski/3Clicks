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
    public class KidsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Kids
        public ActionResult Index()
        {
            return View(db.Kids.ToList());
        }

        //GET :Kids/Shoes
        public ActionResult Shoes()
        {
            return View(db.Kids.ToList());
        }

        //GET :Kids/Clothes
        public ActionResult Clothes()
        {
            return View(db.Kids.ToList());
        }

        //GET :Kids/Accesories
        public ActionResult Accesories()
        {
            return View(db.Kids.ToList());
        }

        // GET: Kids/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kid kid = db.Kids.Find(id);
            if (kid == null)
            {
                return HttpNotFound();
            }
            return View(kid);
        }

        // GET: Kids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kids/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,productName,productDescription,productPrice,discountPrice,productCategory,productImageOne,productImageTwo,productImageThree")] Kid kid)
        {
            if (ModelState.IsValid)
            {
                db.Kids.Add(kid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kid);
        }

        // GET: Kids/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kid kid = db.Kids.Find(id);
            if (kid == null)
            {
                return HttpNotFound();
            }
            return View(kid);
        }

        // POST: Kids/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,productName,productDescription,productImageOne,productImageTwo,productImageThree")] Kid kid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kid);
        }

        // GET: Kids/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kid kid = db.Kids.Find(id);
            if (kid == null)
            {
                return HttpNotFound();
            }
            return View(kid);
        }

        // POST: Kids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kid kid = db.Kids.Find(id);
            db.Kids.Remove(kid);
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
