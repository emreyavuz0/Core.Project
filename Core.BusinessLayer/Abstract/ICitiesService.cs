using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Abstract
{
    public interface ICitiesService
    {
        void CitiesAdd(Cities cities);
        void CitiesDelete(Cities cities);
        void CitiesUpdate(Cities cities);
        List<Cities> GetList();
        Cities GetById(int id);
    }
}
