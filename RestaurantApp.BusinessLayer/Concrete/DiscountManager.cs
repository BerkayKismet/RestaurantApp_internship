using RestaurantApp.BusinessLayer.Abstract;
using RestaurantApp.DataAccessLayer.Abstract;
using RestaurantApp.EntityLayer.Entities;


namespace RestaurantApp.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal= discountDal;
        }

        public void TAdd(Discount entity)
        {
           _discountDal.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public Discount TGetById(int id)
        {
           return _discountDal.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
          return  _discountDal.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }

	}
}
