using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Family { get; set; }

		public interface ICustomerRepo
		{
			void Add(Customer customer);
			List<Customer> GetAll();
			List<Customer> Search(string Name);
			string GetForExport();
		}
		public class CustomerRepo : ICustomerRepo
		{
			private readonly List<Customer> _db = new List<Customer>
			{
				new Customer{Id=1,Name="Ali",Family="AAli"},
				new Customer{Id=2,Name="BBB",Family="ABBB"},
				new Customer{Id=3,Name="CCC",Family="ACCC"}
			};

			public void Add(Customer customer)
			{
				customer.Id = _db.Count + 1;
				_db.Add(customer);
			
			}

			public List<Customer> GetAll()
			{
				return _db;
			}

			public string GetForExport()
			{
				StringBuilder sb = new StringBuilder();
				foreach (var item in _db)
				{
					sb.Append($"{item.Id},{item.Name},{item.Family}");
				}
				return sb.ToString();
			}

			public List<Customer> Search(string Name)
			{
				return _db.Where(c => c.Name == Name).ToList();
			}
		}

	}
}
