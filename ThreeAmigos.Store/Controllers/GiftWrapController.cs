using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThreeAmigos.Store.DAL;
using ThreeAmigos.Store.Models;

namespace ThreeAmigos.Store.Controllers
{
    public class GiftWrapController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: GiftWrap
        public ActionResult Index()
        {
            return View(db.GiftWrap.ToList());
        }

        // GET: GiftWrap/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftWrapModel giftWrapModel = db.GiftWrap.Find(id);
            if (giftWrapModel == null)
            {
                return HttpNotFound();
            }
            return View(giftWrapModel);
        }

        // GET: GiftWrap/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GiftWrap/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GiftWrapID,Name,Price,Active")] GiftWrapModel giftWrapModel)
        {
            if (ModelState.IsValid)
            {
                db.GiftWrap.Add(giftWrapModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giftWrapModel);
        }

        // GET: GiftWrap/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftWrapModel giftWrapModel = db.GiftWrap.Find(id);
            if (giftWrapModel == null)
            {
                return HttpNotFound();
            }
            return View(giftWrapModel);
        }

        // POST: GiftWrap/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GiftWrapID,Name,Price,Active")] GiftWrapModel giftWrapModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giftWrapModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giftWrapModel);
        }

        // GET: GiftWrap/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftWrapModel giftWrapModel = db.GiftWrap.Find(id);
            if (giftWrapModel == null)
            {
                return HttpNotFound();
            }
            return View(giftWrapModel);
        }

        // POST: GiftWrap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GiftWrapModel giftWrapModel = db.GiftWrap.Find(id);
            db.GiftWrap.Remove(giftWrapModel);
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
