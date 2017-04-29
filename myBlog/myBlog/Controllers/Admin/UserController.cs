using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using myBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace myBlog.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        //
        

        private HashSet<string> GetAdmins(List<ApplicationUser> users, ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var admins = new HashSet<string>();

            foreach (var item in users)
            {
                if (userManager.IsInRole(item.Id, "Admin"))
                {
                    admins.Add(item.UserName);
                }
            }
            return admins;
        }

        public ActionResult List()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.Users.ToList();

                var admins = GetAdmins(users, db);

                ViewBag.Admins = admins;

                return View(users);
            }


        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id.Equals(id));

                
            }

            return View();
        }
    }
}