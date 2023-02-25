using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Concrete
{
    public class CitiesManager : ICitiesService
    {
        ICitiesDAL _citiesDAL;

        public CitiesManager(ICitiesDAL citiesDAL)
        {
            _citiesDAL = citiesDAL;
        }

        public void CitiesAdd(Cities cities)
        {
            throw new NotImplementedException();
        }

        public void CitiesDelete(Cities cities)
        {
            throw new NotImplementedException();
        }

        public void CitiesUpdate(Cities cities)
        {
            throw new NotImplementedException();
        }

        public Cities GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cities> GetList()
        {
            return _citiesDAL.GetListAll();
        }
    }
}
