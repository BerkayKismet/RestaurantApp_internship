using RestaurantApp.DataAccessLayer.Abstract;
using RestaurantApp.DataAccessLayer.Concrete;
using RestaurantApp.DataAccessLayer.Repositories;
using RestaurantApp.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DataAccessLayer.EntityFramework
{
	public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
	{
		public EfMoneyCaseDal(SignalRContext context) : base(context)
		{
		}

		public decimal TotalMoneyCaseAmount()
		{
			using var contex = new SignalRContext();
			return contex.MoneyCases.Select(x=>x.TotalAmount).FirstOrDefault();
		}
	}
}
