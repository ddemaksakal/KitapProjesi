using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KubbeAlti.Models.Entity;

namespace KubbeAlti.Controllers
{
    public class HesapController : Controller
    {
        // GET: Hesap
        DBKubbeAltiEntities db = new DBKubbeAltiEntities();
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            var uyemail = (string)Session["Mail"];
            var degerler = db.TBLMUSTERI.FirstOrDefault(x => x.MAIL == uyemail);
            return View(degerler);
        }

        [HttpPost]
        public ActionResult BilgiGuncelle(TBLMUSTERI p)
        {
            var kullanici = (string)Session["Mail"];
            var uye = db.TBLMUSTERI.FirstOrDefault(x => x.MAIL == kullanici);
            uye.AD = p.AD;
            uye.SOYAD = p.SOYAD;
            uye.TELEFON = p.TELEFON;
            uye.ADRES = p.ADRES;
            uye.SIFRE = p.SIFRE;
            db.SaveChanges();
            return View("Index");
        }
    }
}
