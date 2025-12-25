using System.Collections.Generic;

namespace _01_ShopQuery.Contract.Article
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> LatestArticles();
        ArticleQueryModel GetArticleDetails(string slug);
    }
}
