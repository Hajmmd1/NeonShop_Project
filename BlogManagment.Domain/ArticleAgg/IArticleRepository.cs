using System.Collections.Generic;
using _0_FreamWork.Dimain;
using BlogManagement.Application.Contracts.Article;

namespace BlogManagment.Domain.ArticleAgg
{
    public interface IArticleRepository : IRepository<long, Article>
    {
        EditArticle GetDetails(long id);
        Article GetWithCategory(long id);
        List<ArticleViewModel> Search(ArticleSearchModel searchModel);
    }
}
