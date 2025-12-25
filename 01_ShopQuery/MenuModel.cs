using _01_ShopQuery.Contract.ArticleCategory;
using _01_ShopQuery.Contract.ProductCategory;
using System.Collections.Generic;

namespace _01_ShopQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
