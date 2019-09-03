using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeddingWebsiteStandard.Models;

namespace WeddingWebsiteStandard.Controllers
{
    public class GiftsController : Controller
    {
        private WeddingWebsiteDB db = new WeddingWebsiteDB();

        // GET: Gifts
        public ActionResult Index()
        {
            return View(db.GiftModels.ToList());
        }

        // GET: Gifts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftModel giftModel = db.GiftModels.Find(id);
            if (giftModel == null)
            {
                return HttpNotFound();
            }
            return View(giftModel);
        }

        // GET: Gifts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gifts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,description,numberAvailable")] GiftModel giftModel)
        {
            if (ModelState.IsValid)
            {
                db.GiftModels.Add(giftModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giftModel);
        }

        // GET: Gifts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftModel giftModel = db.GiftModels.Find(id);
            if (giftModel == null)
            {
                return HttpNotFound();
            }
            return View(giftModel);
        }

        // POST: Gifts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,description,numberAvailable")] GiftModel giftModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giftModel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giftModel);
        }

        // GET: Gifts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftModel giftModel = db.GiftModels.Find(id);
            if (giftModel == null)
            {
                return HttpNotFound();
            }
            return View(giftModel);
        }

        // POST: Gifts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GiftModel giftModel = db.GiftModels.Find(id);
            db.GiftModels.Remove(giftModel);
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
