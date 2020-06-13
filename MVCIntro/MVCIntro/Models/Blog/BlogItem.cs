using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCIntro.Models.Blog
{
	public class BlogItem
	{
		[Display (Name = "تیتر")]
		public string Title { get; set; }
		[Display (Name ="لینک")]
		public string Link { get; set; }
		[Display (Name = "متن پست")]
		public string Description { get; set; }
	}
}