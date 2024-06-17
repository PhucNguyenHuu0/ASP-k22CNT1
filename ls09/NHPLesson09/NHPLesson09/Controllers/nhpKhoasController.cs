using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NHPLesson09.Models;

namespace NHPLesson09.Controllers
{
    public class nhpKhoasController : Controller
    {
        private NHPK22CNT1Ls09Entities db = new NHPK22CNT1Ls09Entities();

        // GET: nhpKhoas
        public ActionResult NhpIndex()
        {
            return View(db.nhpKhoa.ToList());
        }

        // GET: nhpKhoas/Details/5
        public ActionResult NhpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhpKhoa nhpKhoa = db.nhpKhoa.Find(id);
            if (nhpKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nhpKhoa);
        }

        // GET: nhpKhoas/Create
        public ActionResult NhpCreate()
        {
            return View();
        }

        // POST: nhpKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhpCreate([Bind(Include = "NhpMaKH,NhpTenKH,NhpTrangthai")] nhpKhoa nhpKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nhpKhoa.Add(nhpKhoa);
                db.SaveChanges();
                return RedirectToAction("NhpIndex");
            }

            return View(nhpKhoa);
        }

        // GET: nhpKhoas/Edit/5
        public ActionResult NhpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhpKhoa nhpKhoa = db.nhpKhoa.Find(id);
            if (nhpKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nhpKhoa);
        }

        // POST: nhpKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhpEdit([Bind(Include = "NhpMaKH,NhpTenKH,NhpTrangthai")] nhpKhoa nhpKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhpKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NhpIndex");
            }
            return View(nhpKhoa);
        }

        // GET: nhpKhoas/Delete/5
        public ActionResult NhpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhpKhoa nhpKhoa = db.nhpKhoa.Find(id);
            if (nhpKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nhpKhoa);
        }

        // POST: nhpKhoas/Delete/5
        [HttpPost, ActionName("NhpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nhpKhoa nhpKhoa = db.nhpKhoa.Find(id);
            db.nhpKhoa.Remove(nhpKhoa);
            db.SaveChanges();
            return RedirectToAction("NhpIndex");
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
