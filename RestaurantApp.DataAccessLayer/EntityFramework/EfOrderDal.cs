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
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(SignalRContext context) : base(context)
		{
		}

        public int ActiveOrderCount()
        {
            using var context = new SignalRContext();
            return context.Orders.Where(x => x.Description == "Client at a table").Count();
        }

       

        public decimal TodayTotalPrice()
        {
            using var context = new SignalRContext();
            DateTime NowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            return context.Orders.Where(x => x.Date == NowDate && x.Description == "Hesap Kapatıldı").Sum(x => x.TotalPrice);

        }

        public int TotalOrderCount()
        {
            using var context = new SignalRContext();
            return context.Orders.Count();
        }
    }
}
