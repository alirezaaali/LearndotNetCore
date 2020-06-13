using MVCIntro.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class BlogAdminController : Controller
    {
        // GET: BlogAdmin
        public ActionResult Insert()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult Save(string Title, string Description, string Link)
        //{
        //    var requset = HttpContext.Request.Form;

        //    BlogItem myitem = new BlogItem();
        //    myitem.Title = requset.Get("Title");
        //    myitem.Description = requset.Get("Description");
        //    myitem.Link = requset.Get("Link");
        //    //save to db
        //    return View("Insert");
        //}
        [HttpPost]
        public ActionResult Save(BlogItem myItem)
        {

            //save to db
            return View("Insert");
        }
    }
}