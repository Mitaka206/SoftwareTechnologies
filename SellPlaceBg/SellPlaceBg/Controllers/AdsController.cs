using Microsoft.AspNet.Identity;
using SellPlaceBg.Data;
using SellPlaceBg.Models;
using SellPlaceBg.Models.Ads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellPlaceBg.Controllers
{
    public class AdsController : Controller
    {
        public ActionResult AllAds(int page = 1, string user = null)
        {
            var db = new SellPlaceDbContext();

            var pageSize = 3;

            var adsQuery = db.Ads.AsQueryable();

            if (user != null)
            {
                adsQuery = adsQuery
                    .Where(a => a.Seller.Email == user);
            }

            var ads = adsQuery
                .OrderByDescending(a => a.Date)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(a => new AllAdModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Category = a.Category,
                    Discription = a.Discription,
                    Price = a.Price,
                    ImgUrl = a.ImgUrl,
                    IsSold = a.IsSold
                })
            .ToList();

            ViewBag.CurrentPage = page;

            return View(ads);
        }

        //public ActionResult FromCategory(Ad ad, int page = 1, Category category = null)
        //{
        //    var db = new SellPlaceDbContext();

        //    var pageSize = 3;
            
        //    var ads = db.Ads
        //        .OrderByDescending(a => a.Date)
        //        .Skip((page - 1) * pageSize)
        //        .Take(pageSize)
        //        .Select(a => new CategoryAdModel
        //        {
        //            Ad = a.Category
        //        })
        //    .ToList();

        //    ViewBag.CurrentPage = page;

        //    return View(ads);
        //}

        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateAdModel model)
        {
            if (this.ModelState.IsValid)
            {
                var sellerId = this.User.Identity.GetUserId();

                var ad = new Ad
                {
                    Title = model.Title,
                    Category = model.Category,
                    Discription = model.Discription,
                    Price = model.Price,
                    Town = model.Town,
                    ImgUrl = model.ImgUrl,
                    SellerId = sellerId,
                    Date = DateTime.Now
                };


                var db = new SellPlaceDbContext();
                db.Ads.Add(ad);
                db.SaveChanges();

                return RedirectToAction("Details", new { id = ad.Id });
            }

            return View(model);
        }

        //Details
        public ActionResult Details(int id)
        {
            var db = new SellPlaceDbContext();

            var ad = db.Ads
                .Where(a => a.Id == id)
                .Select(a => new DetailsAdModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Category = a.Category,
                    Discription = a.Discription,
                    Town = a.Town,
                    Date = a.Date,
                    Price = a.Price,
                    ImgUrl = a.ImgUrl,
                    IsSold = a.IsSold,
                    ContactInformation = a.Seller.Email

                })
                .FirstOrDefault();

            if (ad == null)
            {
                return HttpNotFound();
            }


            return View(ad);
        }

        //Delete
        [Authorize]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (var db = new SellPlaceDbContext())
            {
                var ad = db.Ads
                    .Where(a => a.Id == id)
                    .FirstOrDefault();

                if (ad == null || !IsAutorized(ad))
                {
                    return HttpNotFound();
                }

                return View(ad);
            }
        }

        [Authorize]
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            using (var db = new SellPlaceDbContext())
            {
                var ad = db.Ads
                    .Where(a => a.Id == id)
                    .FirstOrDefault();

                if (ad == null || !IsAutorized(ad))
                {
                    return HttpNotFound();
                }

                db.Ads.Remove(ad);
                db.SaveChanges();

                return RedirectToAction("AllAds");
            }
        }

        //Edit
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var db = new SellPlaceDbContext())
            {
                var ad = db.Ads.Find(id);

                if (ad == null || !IsAutorized(ad))
                {
                    return HttpNotFound();
                }

                var editAdModel = new EditAdModel
                {
                    Title = ad.Title,
                    Category = ad.Category,
                    Discription = ad.Discription,
                    Price = ad.Price,
                    ImgUrl = ad.ImgUrl,
                    SellerId = ad.SellerId,
                };
                return View(editAdModel);
            }
        }

        [Authorize]
        [ActionName("Edit")]
        [HttpPost]
        public ActionResult Edit(EditAdModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SellPlaceDbContext())
                {
                    var ad = db.Ads.Find(model.Id);

                    if (ad == null || !IsAutorized(ad))
                    {
                        return HttpNotFound();
                    }

                    ad.Title = model.Title;
                    ad.Category = model.Category;
                    ad.Discription = model.Discription;
                    ad.Price = model.Price;
                    ad.ImgUrl = model.ImgUrl;

                    db.SaveChanges();
                }

                return RedirectToAction("Details", new { id = model.Id });
            }

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Cart(CartModel cartModel)
        {
            var db = new SellPlaceDbContext();

            var ad = db.Ads
                .Where(a => a.Id == cartModel.AdId)
                .Select(a => new
                {
                    a.IsSold,
                    a.Title,
                    a.ImgUrl,
                    a.Price
                })
                .FirstOrDefault();

            if (ad == null || ad.IsSold)
            {
                return HttpNotFound();
            }

            cartModel.Title = ad.Title;
            cartModel.ImgUrl = ad.ImgUrl;
            cartModel.Price = ad.Price;
            cartModel.TotalPrice = ad.Price * (decimal)(1.2);

            return View(cartModel);
        }

        private bool IsAutorized(Ad ad)
        {
            var isAdmin = this.User.IsInRole("Admin");
            var isSeller = ad.IsSeller(this.User.Identity.GetUserId());

            return isAdmin || isSeller;
        }
    }
}