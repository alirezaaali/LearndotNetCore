using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Priciples
{
	public interface INewsDB
	{
		//void Save();
		void AddNews();
		void UpdateNews();
		void GetAll();
		void GetLatest();
	}

	public class NewsTDB : INewsDB
	{
		public void AddNews()
		{
			//
		}

		public void GetAll()
		{
			throw new NotImplementedException();
		}

		public void GetLatest()
		{
			throw new NotImplementedException();
		}

		public void UpdateNews()
		{
			//
		}
	}

	public class NewsUI : INewsDB
	{
		public void AddNews()
		{
			throw new NotImplementedException();
		}

		public void GetAll()
		{
			//
		}

		public void GetLatest()
		{
			//
		}

		public void UpdateNews()
		{
			throw new NotImplementedException();
		}
	}







	class ISP
	{
	}
}
