using _0_FreamWork.Dimain;
using CM.Application.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Domain
{
    public interface ICommentRepository : IRepository<long, Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
