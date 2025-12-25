using System.Collections.Generic;
using _0_FreamWork.Dimain;
using BlogManagement.Application.Contracts.ArticleCategory;

namespace BlogManagment.Domain.ArticleCategory.Agg
{
    public interface IArticleCategoryRepository : IRepository<long, ArticleCategory>
    {
        string GetSlugBy(long id);
        EditArticleCategory GetDetails(long id);
        List<ArticleCategoryViewModel> GetArticleCategories();
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);
    }
}
