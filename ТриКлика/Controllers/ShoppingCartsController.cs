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
    public class ShoppingCartsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCarts
        public ActionResult Index()
        {
            return View(db.ShoppingCarts.ToList());
        }

        // GET: ShoppingCarts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            if (shoppingCart == null)
            {
                return HttpNotFound();
            }
            return View(shoppingCart);
        }

        // GET: ShoppingCarts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingCarts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShoppingCart shoppingCart)
        {
            if (ModelState.IsValid)
            {
                db.ShoppingCarts.Add(shoppingCart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoppingCart);
        }

        // GET: ShoppingCarts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            if (shoppingCart == null)
            {
                return HttpNotFound();
            }
            return View(shoppingCart);
        }

        // POST: ShoppingCarts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,productQuantity,products")] ShoppingCart shoppingCart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoppingCart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoppingCart);
        }

        public ActionResult Delete(int id)
        {
            Product product = db.Products.Find(id);
            db.ShoppingCarts.Find(1).products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("/Details/1");
        }

        public ActionResult Confirm(int id)
        {
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            return View(shoppingCart);

        }

        [HttpPost]
        public ActionResult Confirm(ShoppingCart model)
        {
            db.ShoppingCarts.Find(model.ID).products.Clear();
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        public ActionResult AddProduct(int id)
        {
            ProductToCart model = new ProductToCart();
            model.productID = id;
            model.product = db.Products.Find(id);
            model.shoppingCartID = 1;
            return View(model);
        }

        [HttpPost]
        public ActionResult AddProduct(ProductToCart model)
        {
            var product = db.Products.Find(model.productID);
            var shoppingCart = db.ShoppingCarts.Find(1);
            shoppingCart.products.Add(product);
            db.SaveChanges();
            return RedirectToAction("/Details/1");
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
