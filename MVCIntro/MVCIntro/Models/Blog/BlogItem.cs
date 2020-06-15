using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCIntro.Models.Blog
{
	public class BlogItem
	{
		[Required(ErrorMessage ="لطفاً تير را وارد نماييد")]
		[Display (Name = "تیتر")]
		public string Title { get; set; }
		[Required(ErrorMessage = "لطفاً لينك را وارد نماييد")]
		[Display (Name ="لینک")]
		public string Link { get; set; }
		[Required(ErrorMessage = "لطفاً متن را وارد نماييد")]
		[Display (Name = "متن پست")]
		public string Description { get; set; }
		public int Id { get; set; }
	}
}