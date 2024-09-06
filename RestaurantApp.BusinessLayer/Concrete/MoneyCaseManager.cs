using RestaurantApp.BusinessLayer.Abstract;
using RestaurantApp.DataAccessLayer.Abstract;
using RestaurantApp.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.BusinessLayer.Concrete
{
	public class MoneyCaseManager : IMoneyCaseService
	{

		readonly IMoneyCaseDal _moneyCaseDal;

		public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
		{
			_moneyCaseDal = moneyCaseDal;
		}

		public void TAdd(MoneyCase entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(MoneyCase entity)
		{
			throw new NotImplementedException();
		}

		public MoneyCase TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<MoneyCase> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public decimal TTotalMonetCaseAmount()
		{
			return _moneyCaseDal.TotalMoneyCaseAmount();
		}

		public void TUpdate(MoneyCase entity)
		{
			throw new NotImplementedException();
		}
	}
}
