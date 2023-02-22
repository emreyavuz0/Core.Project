using Core.DataAccessLayer.Abstract;
using Core.DataAccessLayer.Repository;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessLayer.EntityFramework
{
    public class EfContactRepository:GenericRepository<Contact>,IContactDAL
    {
    }
}
