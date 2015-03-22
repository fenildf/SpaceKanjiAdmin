using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
using Models;

namespace SpaceKanjiAdmin.Controllers
{
    public class KanjisController : Controller
    {
        private SpaceKanjiDB db = new SpaceKanjiDB();

        // GET: Kanjis
        public ActionResult Index()
        {
            return View(db.Kanjis.ToList());
        }

        // GET: Kanjis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kanji kanji = db.Kanjis.Find(id);
            if (kanji == null)
            {
                return HttpNotFound();
            }
            return View(kanji);
        }

        // GET: Kanjis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kanjis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Character,Meaning")] Kanji kanji)
        {
            if (ModelState.IsValid)
            {
                db.Kanjis.Add(kanji);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kanji);
        }

        // GET: Kanjis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kanji kanji = db.Kanjis.Find(id);
            if (kanji == null)
            {
                return HttpNotFound();
            }
            return View(kanji);
        }

        // POST: Kanjis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Character,Meaning")] Kanji kanji)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kanji).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kanji);
        }

        // GET: Kanjis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kanji kanji = db.Kanjis.Find(id);
            if (kanji == null)
            {
                return HttpNotFound();
            }
            return View(kanji);
        }

        // POST: Kanjis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kanji kanji = db.Kanjis.Find(id);
            db.Kanjis.Remove(kanji);
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
