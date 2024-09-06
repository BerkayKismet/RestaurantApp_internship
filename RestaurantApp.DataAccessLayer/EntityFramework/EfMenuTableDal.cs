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
	public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
	{
		public EfMenuTableDal(SignalRContext context) : base(context)
		{
		}

		public int MenuTableCount()
		{
			using var context = new SignalRContext();
			return context.MenuTables.Count();
		}
	}
}