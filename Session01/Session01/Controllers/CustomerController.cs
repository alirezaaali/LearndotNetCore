using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session01.Models;

namespace Session01.Controllers
{
	public class CustomerController : Controller
	{
		private readonly Models.Customer.ICustomerRepo _repo;
		public CustomerController(Models.Customer.ICustomerRepo repo)
		{
			_repo = repo;

		}
		public IActionResult Index()
		{
			return View(_repo.GetAll());
		}

		public	IActionResult Save()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Save(Customer customer)
		{
			_repo.Add(customer);

			return RedirectToAction("Index");
		}

	}
}
