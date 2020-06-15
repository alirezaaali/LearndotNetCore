using MVCIntro.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			using (BlogDBcontext Dbcontext = new BlogDBcontext())
			{
				Dbcontext.Blogitems.Add(new BlogItem
				{
					Title = "عنوان تست",
					Description = "متن تستس",
					Link = "wwww.com",

				}
					);
				Dbcontext.SaveChanges();

			}


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
	}
}