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
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Males
        public ActionResult Males()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Females
        public ActionResult Females()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Kids
        public ActionResult Kids()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Males/Shoes
        public ActionResult MaleShoes ()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Males/Clothes
        public ActionResult MaleClothes()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Males/Accesories
        public ActionResult MaleAccesories()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/FeMales/Shoes
        public ActionResult FemaleShoes()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/FeMales/Clothes
        public ActionResult FemaleClothes()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/FeMales/Accesories
        public ActionResult FemaleAccesories()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/FeMales/Shoes
        public ActionResult KidShoes()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/FeMales/Clothes
        public ActionResult KidClothes()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/FeMales/Accesories
        public ActionResult KidAccesories()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Nike
        public ActionResult Nike()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Adidas
        public ActionResult Adidas()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Puma
        public ActionResult Puma()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/NewCollection
        public ActionResult NewCollection()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Discount
        public ActionResult Discount()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Popular
        public ActionResult Popular()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,productGender,productBrand,productName,productPrice,discountPrice,productCategory,productDescription,productImageOne,productImageTwo,productImageThree")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,productGender,productBrand,productName,productPrice,discountPrice,productCategory,productDescription,productImageOne,productImageTwo,productImageThree")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
