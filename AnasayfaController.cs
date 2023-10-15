using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KubbeAlti.Models.Entity;
using KubbeAlti.Models.Siniflar;

namespace KubbeAlti.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        DBKubbeAltiEntities db = new DBKubbeAltiEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            //cs.Deger1 = db.TBLKITAP.Where(x => x.YAZARID == 2).ToList();
            cs.Deger1 = db.TBLKITAP.Where(x => x.ONECIKAN == true).ToList();
            cs.Deger2 = db.TBLKATEGORI.ToList();
            
            return View(cs);
        }
    }
}
