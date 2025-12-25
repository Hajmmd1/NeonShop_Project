using _01_LampshadeQuery;
using _01_ShopQuery;
using _01_ShopQuery.Contract.ArticleCategory;
using _01_ShopQuery.Contract.ProductCategory;
using _01_ShopQuery.Query;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponent
{
    public class MenuViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly IProductCategoryQuery _productCategoryQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public MenuViewComponent(IProductCategoryQuery productCategoryQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _articleCategoryQuery = articleCategoryQuery;
            _productCategoryQuery = productCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = new MenuModel
            {
                ArticleCategories = _articleCategoryQuery.GetArticleCategories(),
                ProductCategories = _productCategoryQuery.GetProductCategories()
            };
            return View(result);
        }
    }
}
