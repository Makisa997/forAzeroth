using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using forAzeroth.Models;

namespace forAzeroth.Controllers
{
    public class WoWsController : Controller
    {
        private WoWBaseEntities db = new WoWBaseEntities();

        // GET: WoWs
        public ActionResult Index()
        {
            return View(db.WoWs.ToList());
        }

        // GET: WoWs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WoW woW = db.WoWs.Find(id);
            if (woW == null)
            {
                return HttpNotFound();
            }
            return View(woW);
        }

        // GET: WoWs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WoWs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,CharacterName,Class")] WoW woW)
        {
            if (ModelState.IsValid)
            {
                db.WoWs.Add(woW);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(woW);
        }

        // GET: WoWs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WoW woW = db.WoWs.Find(id);
            if (woW == null)
            {
                return HttpNotFound();
            }
            return View(woW);
        }

        // POST: WoWs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,CharacterName,Class")] WoW woW)
        {
            if (ModelState.IsValid)
            {
                db.Entry(woW).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(woW);
        }

        // GET: WoWs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WoW woW = db.WoWs.Find(id);
            if (woW == null)
            {
                return HttpNotFound();
            }
            return View(woW);
        }

        // POST: WoWs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WoW woW = db.WoWs.Find(id);
            db.WoWs.Remove(woW);
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
