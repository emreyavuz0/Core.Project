using Core.DataAccessLayer.Abstract;
using Core.DataAccessLayer.Repository;
using Core.EntityLayer.Concrete;

namespace Core.DataAccessLayer.EntityFramework
{
    public class EfCommentRepository:GenericRepository<Comment>,ICommentDAL
    {
    }
}
