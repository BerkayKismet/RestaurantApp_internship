using RestaurantApp.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DataAccessLayer.Abstract
{
	public interface IOrderDal : IGenericDal<Order>
	{
        int TotalOrderCount();
        int ActiveOrderCount();
        decimal TodayTotalPrice();
    }
}
