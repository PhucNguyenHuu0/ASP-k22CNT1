using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NHP_Ontap.Models;

namespace NHP_Ontap.Controllers
{
    public class KetquasController : Controller
    {
        private Entities db = new Entities();

        // GET: Ketquas
        public ActionResult NhpIndex()
        {
            var ketqua = db.Ketqua.Include(k => k.MonHoc).Include(k => k.SinhVien);
            return View(ketqua.ToList());
        }

        // GET: Ketquas/Details/5
        public ActionResult NhpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ketqua ketqua = db.Ketqua.Find(id);
            if (ketqua == null)
            {
                return HttpNotFound();
            }
            return View(ketqua);
        }

        // GET: Ketquas/Create
        public ActionResult NhpCreate()
        {
            ViewBag.MaMH = new SelectList(db.MonHoc, "MaMH", "TenMH");
            ViewBag.MaSV = new SelectList(db.SinhVien, "MaSV", "HoSV");
            return View();
        }

        // POST: Ketquas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhpCreate([Bind(Include = "MaSV,MaMH,Diem")] Ketqua ketqua)
        {
            if (ModelState.IsValid)
            {
                db.Ketqua.Add(ketqua);
                db.SaveChanges();
                return RedirectToAction("NhpIndex");
            }

            ViewBag.MaMH = new SelectList(db.MonHoc, "MaMH", "TenMH", ketqua.MaMH);
            ViewBag.MaSV = new SelectList(db.SinhVien, "MaSV", "HoSV", ketqua.MaSV);
            return View(ketqua);
        }

        // GET: Ketquas/Edit/5
        public ActionResult NhpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ketqua ketqua = db.Ketqua.Find(id);
            if (ketqua == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMH = new SelectList(db.MonHoc, "MaMH", "TenMH", ketqua.MaMH);
            ViewBag.MaSV = new SelectList(db.SinhVien, "MaSV", "HoSV", ketqua.MaSV);
            return View(ketqua);
        }

        // POST: Ketquas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhpEdit([Bind(Include = "MaSV,MaMH,Diem")] Ketqua ketqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ketqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NhpIndex");
            }
            ViewBag.MaMH = new SelectList(db.MonHoc, "MaMH", "TenMH", ketqua.MaMH);
            ViewBag.MaSV = new SelectList(db.SinhVien, "MaSV", "HoSV", ketqua.MaSV);
            return View(ketqua);
        }

        // GET: Ketquas/Delete/5
        public ActionResult NhpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ketqua ketqua = db.Ketqua.Find(id);
            if (ketqua == null)
            {
                return HttpNotFound();
            }
            return View(ketqua);
        }

        // POST: Ketquas/Delete/5
        [HttpPost, ActionName("NhpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ketqua ketqua = db.Ketqua.Find(id);
            db.Ketqua.Remove(ketqua);
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
