﻿using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment category);
        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
        List<Comment> GetList(int id);
        //Category GetById(int id);
    }
}
