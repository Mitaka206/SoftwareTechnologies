using Microsoft.AspNet.Identity;
using SellPlaceBg.Data;
using SellPlaceBg.Models;
using SellPlaceBg.Models.Ads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace SellPlaceBg.Controllers
{
    public class AdsController : Controller
    {
        public ActionResult AllAds(
            int page = 1,
            string user = null,
            string search = null,
            string category = null
            )
        {
            var db = new SellPlaceDbContext();

            var pageSize = 3;

            var adsQuery = db.Ads.AsQueryable();

            if (search != null)
            {
                adsQuery = adsQuery
                    .Where(a => a.Title.ToLower().Contains(search.ToLower()) 
                    || a.Discription.Contains(search.ToLower()) 
                    || a.Category.ToString().Contains(search.ToLower()));
            }

            if (category != null)
            {
                adsQuery = adsQuery
                    .Where(a => a.Title.ToLower().Contains(category.ToLower())
                    || a.Discription.Contains(category.ToLower())
                    || a.Category.ToString().Contains(category.ToLower()));
            }

            if (user != null)
            {
                adsQuery = adsQuery
                    .Where(a => a.Seller.Email == user);
            }

            var ads = adsQuery
                //.Where(a => !a.IsSold)
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
                    ImgUrl = a.ImgURL,
                    IsSold = a.IsSold
                })
            .ToList();

            ViewBag.CurrentPage = page;

            return View(ads);
        }
        
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAdModel model)
        {
            if (this.ModelState.IsValid)
            {
                var sellerId = this.User
                    .Identity
                    .GetUserId();

                var ad = new Ad
                {
                    Title = model.Title,
                    Category = model.Category,
                    Discription = model.Discription,
                    Price = model.Price,
                    Town = model.Town,
                    ImgURL = model.ImgUrl,
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
                    SellerId = a.SellerId,
                    Title = a.Title,
                    Category = a.Category,
                    Discription = a.Discription,
                    Town = a.Town,
                    Date = a.Date,
                    Price = a.Price,
                    ImgUrl = a.ImgURL,
                    IsSold = a.IsSold,
                    ContactInformation = a.Seller.UserName

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
        [ValidateAntiForgeryToken]
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
                    ImgUrl = ad.ImgURL,
                    SellerId = ad.SellerId,
                };
                return View(editAdModel);
            }
        }

        [Authorize]
        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
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
                    ad.ImgURL = model.ImgUrl;
                    
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
                    a.ImgURL,
                    a.Price
                })
                .FirstOrDefault();

            if (ad == null || ad.IsSold)
            {
                return HttpNotFound();
            }

            cartModel.Title = ad.Title;
            cartModel.ImgUrl = ad.ImgURL;
            cartModel.Price = ad.Price;
            cartModel.TotalPrice = ad.Price * (decimal)(1.2);

            return View(cartModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Cart(int adId, decimal totalPrice)
        {
            var db = new SellPlaceDbContext();

            var ad = db.Ads
                .Where(a => a.Id == adId)
                .FirstOrDefault();

            var userId = this.User.Identity.GetUserId();

            if (ad == null || ad.IsSold || ad.SellerId == userId)
            {
                return HttpNotFound();
            }

            var cart = new Cart
            {
                AdId = adId,
                TotalPrice = totalPrice,
                UserId = userId,
                BuyOn = DateTime.Now
            };

            ad.IsSold = true;

            db.Carts.Add(cart);
            db.SaveChanges();

            return RedirectToAction("Details", new { id = ad.Id });
        }
        
        private bool IsAutorized(Ad ad)
        {
            var isAdmin = this.User.IsInRole("Admin");
            var isSeller = ad.IsSeller(this.User.Identity.GetUserId());

            return isAdmin || isSeller;
        }
    }
}