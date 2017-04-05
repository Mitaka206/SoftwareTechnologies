using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myMag.Models;

namespace myMag.Controllers
{
    public class AdsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ads
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            using(var database = new ApplicationDbContext())
            {
                var ads = database.Ads.Include(ad => ad.Seller).ToList();
                return View(ads);
            }
            
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new ApplicationDbContext())
            {
                var ad = database.Ads
                    .Where(a => a.Id == id)
                    .Include(a => a.Seller).First();
                
                if (ad == null)
                {
                    return HttpNotFound();
                }
                


                return View(ad);
            }
        }



    }
}
