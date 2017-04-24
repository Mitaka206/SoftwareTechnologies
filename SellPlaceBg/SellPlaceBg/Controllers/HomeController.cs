using SellPlaceBg.Data;
using SellPlaceBg.Models.Ads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellPlaceBg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new SellPlaceDbContext();

            var ads = db.Ads
                //.Where(a => !a.IsSold)
                .OrderByDescending(a => a.Date)
                .Take(6)
                .Select(a => new AllAdModel
                {
                    Id =a.Id,
                    Title = a.Title,
                    Category = a.Category,
                    Discription = a.Discription,
                    Price = a.Price,
                    ImgUrl = a.ImgUrl
                })
                .ToList();
                

            return View(ads);
        }
        
    }
}