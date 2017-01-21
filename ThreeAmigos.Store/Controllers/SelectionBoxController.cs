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
    //SelectionBoxController, is dedicated to the Creating, Editing, Viewing and Deleting Selection Boxes
    public class SelectionBoxController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: SelectionBox
        public ActionResult Index()
        {
            return View(db.SelectionBoxes.ToList());
        }

        // GET: SelectionBox/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SelectionBoxModel selectionBoxModel = db.SelectionBoxes.Find(id);
            if (selectionBoxModel == null)
            {
                return HttpNotFound();
            }
            return View(selectionBoxModel);
        }

        // GET: SelectionBox/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SelectionBox/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SelectionBoxID,ProviderID,Name,Description,Price,Active")] SelectionBoxModel selectionBoxModel)
        {
            if (ModelState.IsValid)
            {
                db.SelectionBoxes.Add(selectionBoxModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(selectionBoxModel);
        }

        // GET: SelectionBox/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SelectionBoxModel selectionBoxModel = db.SelectionBoxes.Find(id);
            if (selectionBoxModel == null)
            {
                return HttpNotFound();
            }
            return View(selectionBoxModel);
        }

        // POST: SelectionBox/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SelectionBoxID,ProviderID,Name,Description,Price,Active")] SelectionBoxModel selectionBoxModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(selectionBoxModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(selectionBoxModel);
        }

        // GET: SelectionBox/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SelectionBoxModel selectionBoxModel = db.SelectionBoxes.Find(id);
            if (selectionBoxModel == null)
            {
                return HttpNotFound();
            }
            return View(selectionBoxModel);
        }

        // POST: SelectionBox/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SelectionBoxModel selectionBoxModel = db.SelectionBoxes.Find(id);
            db.SelectionBoxes.Remove(selectionBoxModel);
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
