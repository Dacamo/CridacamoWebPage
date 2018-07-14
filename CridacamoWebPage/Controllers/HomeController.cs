
using CridacamoWebPage.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace CridacamoWebPage.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowAllpost()
        {
            var Post = db.Posts.ToList();
            return PartialView("_ShowAllpost", Post);
        }

        public ActionResult Show(string id)
        { 
            var post = db.Posts.SqlQuery("SELECT * FROM dbo.Posts WHERE Author = @value", new SqlParameter("@value", id));
            if (post==null)
            {
                return HttpNotFound();
            }
            return PartialView("_Show", post);
        }

        


    }
}