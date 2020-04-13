using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectTry1.Controllers
{
    public class BlogController : Controller
    {
        CRUD_try_1Entities nd = new CRUD_try_1Entities();

        // GET: Blog
        public ActionResult Index()
        {
            var blogdetails = nd.Blogs.ToList();
            return View(blogdetails);
        }

        public ActionResult Uploadblog()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Uploadblog(Blog bg)
        {
            nd.Blogs.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog Details Are Saved Successfully.......";
            return View();
        }

        public ActionResult Food()
        {
            var foodarticale = nd.Blogs.Where(x => x.BCategory == "Food");
            return View(foodarticale);
        }

        public ActionResult Sports()
        {
            var sportsarticale = nd.Blogs.Where(x => x.BCategory == "Sports");
            return View(sportsarticale);
        }

        public ActionResult Movies()
        {
            var moviesarticale = nd.Blogs.Where(x => x.BCategory == "Movies");
            return View(moviesarticale);
        }

        public ActionResult Recipesworld()
        {
            return View();
        }
    }
}