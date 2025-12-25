using _0_FreamWork.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Application.Contract
{
    public interface ICommentApplication
    {
        OperationResult Add(AddComment command);
        OperationResult Confirm(long id);
        OperationResult Cancel(long id);
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
