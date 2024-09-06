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
    public class SocialMediaManager : ISocialMediaService
    {
        readonly ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void TAdd(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
           _socialMediaDal.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
           return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetListAll()
        {
           return _socialMediaDal.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
