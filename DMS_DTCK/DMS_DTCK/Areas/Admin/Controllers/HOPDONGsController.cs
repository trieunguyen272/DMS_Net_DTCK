﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models.Framework;

namespace DMS_DTCK.Areas.Admin.Controllers
{
    public class HOPDONGsController : Controller
    {
        private QLKTXDbContext db = new QLKTXDbContext();

        // GET: Admin/HOPDONGs
        public ActionResult Index()
        {
            var hOPDONGs = db.HOPDONGs.Include(h => h.PHONG).Include(h => h.SINHVIEN);
            return View(hOPDONGs.ToList());
        }

        // GET: Admin/HOPDONGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOPDONG hOPDONG = db.HOPDONGs.Find(id);
            if (hOPDONG == null)
            {
                return HttpNotFound();
            }
            return View(hOPDONG);
        }

        // GET: Admin/HOPDONGs/Create
        public ActionResult Create()
        {
            ViewBag.MAPHONG = new SelectList(db.PHONGs, "MAPHONG", "MAKHU");
            ViewBag.MASV = new SelectList(db.SINHVIENs, "MASV", "MATKHAU");
            return View();
        }

        // POST: Admin/HOPDONGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAHOPDONG,MASV,MAPHONG,NGAYLAP,NGAYBATDAU,NGAYKETTHUC,HIEULUCHD")] HOPDONG hOPDONG)
        {
            if (ModelState.IsValid)
            {
                db.HOPDONGs.Add(hOPDONG);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            ViewBag.MAPHONG = new SelectList(db.PHONGs, "MAPHONG", "MAKHU", hOPDONG.MAPHONG);
            ViewBag.MASV = new SelectList(db.SINHVIENs, "MASV", "MATKHAU", hOPDONG.MASV);
            return View(hOPDONG);
        }

        // GET: Admin/HOPDONGs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOPDONG hOPDONG = db.HOPDONGs.Find(id);
            if (hOPDONG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MAPHONG = new SelectList(db.PHONGs, "MAPHONG", "MAKHU", hOPDONG.MAPHONG);
            ViewBag.MASV = new SelectList(db.SINHVIENs, "MASV", "MATKHAU", hOPDONG.MASV);
            return View(hOPDONG);
        }

        // POST: Admin/HOPDONGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAHOPDONG,MASV,MAPHONG,NGAYLAP,NGAYBATDAU,NGAYKETTHUC,HIEULUCHD")] HOPDONG hOPDONG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hOPDONG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MAPHONG = new SelectList(db.PHONGs, "MAPHONG", "MAKHU", hOPDONG.MAPHONG);
            ViewBag.MASV = new SelectList(db.SINHVIENs, "MASV", "MATKHAU", hOPDONG.MASV);
            return View(hOPDONG);
        }

        // GET: Admin/HOPDONGs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOPDONG hOPDONG = db.HOPDONGs.Find(id);
            if (hOPDONG == null)
            {
                return HttpNotFound();
            }
            return View(hOPDONG);
        }

        // POST: Admin/HOPDONGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HOPDONG hOPDONG = db.HOPDONGs.Find(id);
            db.HOPDONGs.Remove(hOPDONG);
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