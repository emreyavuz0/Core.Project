using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert (T t);
        void Update (T t);
        void Delete (T t);
        List<T> GetListAll();
        T GetByID(int id);
    }
}
