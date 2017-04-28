using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using SellPlaceBg.Data;
using SellPlaceBg.Models.Admins;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellPlaceBg.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var db = new SellPlaceDbContext())
            {
                var users = db.Users.ToList();

                return View(users);
            }

        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var db = new SellPlaceDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id.Equals(id));

                var model = new UserViewModel();
                model.Email = user.Email;
                model.FullName = user.FullName;
                model.Roles = GetUserRoles(user, db);

                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Edit(string id, UserViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SellPlaceDbContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == id);

                    if (id == null)
                    {
                        return HttpNotFound();
                    }

                    if (!string.IsNullOrEmpty(viewModel.Password))
                    {
                        var hasher = new PasswordHasher();
                        var passwordHasher = hasher.HashPassword(viewModel.Password);
                        user.PasswordHash = passwordHasher;
                    }

                    user.Email = viewModel.Email;
                    user.FullName = viewModel.FullName;
                    this.SetUserRoles(viewModel, user, db);

                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();


                }
            }

            return RedirectToAction("List");
        }


        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var db = new SellPlaceDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id.Equals(id));

                if (id == null)
                {
                    return HttpNotFound();
                }

                return View(user);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var db = new SellPlaceDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == id);

                var userAds = db.Ads
                    .Where(a => a.Seller.Id == user.Id);

                foreach (var item in userAds)
                {
                    db.Ads.Remove(item);
                }

                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("List");
            }
        }



        private void SetUserRoles(UserViewModel viewModel, ApplicationUser user, SellPlaceDbContext db)
        {
            var userManager = Request
                .GetOwinContext()
                .GetUserManager<ApplicationUserManager>();

            foreach (var item in viewModel.Roles)
            {
                if (item.IsSelected)
                {
                    userManager.AddToRole(user.Id, item.Name);
                }
                else if (!item.IsSelected)
                {
                    userManager.RemoveFromRole(user.Id, item.Name);
                }
            }
        }

        private List<Role> GetUserRoles(ApplicationUser user, SellPlaceDbContext db)
        {
            var rolesInDb = db.Roles
                .Select(r => r.Name)
                .OrderBy(r => r)
                .ToList();

            var userManager = Request
                .GetOwinContext()
                .GetUserManager<ApplicationUserManager>();

            var userRoles = new List<Role>();

            foreach (var item in rolesInDb)
            {
                Role role = new Role()
                {
                    Name = item
                };

                if (userManager.IsInRole(user.Id, item))
                {
                    role.IsSelected = true;
                }

                userRoles.Add(role);
            }

            return userRoles;
        }
    }
}