using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NHPLS11.Models;

namespace NHPLS11.Controllers
{
    public class NhpTaiKhoansController : Controller
    {
        private NhpLesson11DbEntities db = new NhpLesson11DbEntities();

        // GET: NhpTaiKhoans
        public ActionResult Index()
        {
            return View(db.NhpTaiKhoan.ToList());
        }

        // GET: NhpTaiKhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhpTaiKhoan nhpTaiKhoan = db.NhpTaiKhoan.Find(id);
            if (nhpTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(nhpTaiKhoan);
        }

        // GET: NhpTaiKhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhpTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhpId,NhpUserName,NhpPassword,NhpFullName,NhpAge,NhpEmail,NhpPhone,NhpStatus")] NhpTaiKhoan nhpTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.NhpTaiKhoan.Add(nhpTaiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhpTaiKhoan);
        }

        // GET: NhpTaiKhoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhpTaiKhoan nhpTaiKhoan = db.NhpTaiKhoan.Find(id);
            if (nhpTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(nhpTaiKhoan);
        }

        // POST: NhpTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhpId,NhpUserName,NhpPassword,NhpFullName,NhpAge,NhpEmail,NhpPhone,NhpStatus")] NhpTaiKhoan nhpTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhpTaiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhpTaiKhoan);
        }

        // GET: NhpTaiKhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhpTaiKhoan nhpTaiKhoan = db.NhpTaiKhoan.Find(id);
            if (nhpTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(nhpTaiKhoan);
        }

        // POST: NhpTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhpTaiKhoan nhpTaiKhoan = db.NhpTaiKhoan.Find(id);
            db.NhpTaiKhoan.Remove(nhpTaiKhoan);
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
