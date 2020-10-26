using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCIntro.Models.Blog
{
	public class BlogDBcontext:DbContext
	{
		public DbSet<BlogItem> Blogitems { get; set; }
		public BlogDBcontext() : 
			base("Persist Security Info=False;Initial Catalog=MvcIntorDb;Data Source=.;User ID=sa;Password=axim@95661;")
		{
			
		}
	}
}