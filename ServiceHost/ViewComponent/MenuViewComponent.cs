using _01_LampshadeQuery;
using _01_ShopQuery;
using _01_ShopQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponent
{
    public class MenuViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly IProductCategoryQuery _productCategoryQuery;
       
        public MenuViewComponent(IProductCategoryQuery productCategoryQuery)
        {
            
            _productCategoryQuery = productCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = new MenuModel
            {
               
                ProductCategories = _productCategoryQuery.GetProductCategories()
            };
            return View(result);
        }
    }
}
