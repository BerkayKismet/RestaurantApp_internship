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
    public class ContactManager : IContactService
    {
         readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal= contactDal;
        }
        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
