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
		public ActionResult List()
		{

			return View(new BlogDBcontext().Blogitems.ToList());
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


		[HttpGet]
		public ActionResult Save()
		{
			return View();

		}
		[HttpPost]
		public ActionResult Save(BlogItem blogitem)
		{

			if (ModelState.IsValid)
			{
				using (BlogDBcontext Dbcontext = new BlogDBcontext())
				{
					Dbcontext.Blogitems.Add(new BlogItem
					{
						Title = blogitem.Title,
						Description = blogitem.Description,
						Link = blogitem.Link,

					}
					);
					Dbcontext.SaveChanges();
				}
			}
			return RedirectToAction("List");

		}
	}
}