using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using Models.Dao;
using DMS_DTCK.Common;

namespace DMS_DTCK.Areas.Student.Controllers
{
    public class PHONGsController : Controller
    {
        private QLKTXDbContext db = new QLKTXDbContext();

        // GET: Student/PHONGs
        public ActionResult Index()
        {
           
            var pHONGs = db.PHONGs.Include(p => p.KHUNHA);
            return View(pHONGs);
        }

        // GET: Student/PHONGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHONG pHONG = db.PHONGs.Find(id);
            if (pHONG == null)
            {
                return HttpNotFound();
            }
            var ph = db.PHONGs.SingleOrDefault(x => x.MAPHONG.Equals(id));
            var idSession = new RegistrationRoom();
            idSession.ID = ph.MAPHONG;
            Session.Add(CommonConstants.ID_SESSION, idSession);
            return View(pHONG);
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
