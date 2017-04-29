using myBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            
            var post = db.Articles
                .OrderByDescending(a => a.Date)
                .ThenBy(a => a.Date.Hour)
                .Take(4)
                .ToList();

            return View(post);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
    }
}