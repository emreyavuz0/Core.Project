using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDal;

        public CommentManager(ICommentDAL commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment category)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }
    }
}
