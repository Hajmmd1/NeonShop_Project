using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagment.Application.Contracts.Product;
using ShopManagment.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.AdminStartion.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }
        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Products;
        public SelectList ProductCategoriess;
        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _productCategoryApplication;


        public IndexModel(IProductApplication productApplication, IProductCategoryApplication productCategoryApplication)
        {
            _productApplication = productApplication;
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(ProductSearchModel searchModel)
        {
            ProductCategoriess = new SelectList(_productCategoryApplication.GetProductCategories(),"Id","Name");
            Products=_productApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Categories = _productCategoryApplication.GetProductCategories()
            };
            return Partial("./Create",command );
        }

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productApplication.GetDetails(id);
            productCategory.Categories = _productCategoryApplication.GetProductCategories();
            return Partial("Edit", productCategory);
        }
        public JsonResult OnPostEdit(EditProduct command)
        {
            var resultss = _productApplication.Edit(command);
            return new JsonResult(resultss);
        }

    }
}
