using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_FreamWork.Application;
using ShopManagment.Application.Contracts.ProdctCategory;

namespace ShopManagment.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategory command);
        OperationResult Edit(EditProductCategory command);
       EditProductCategory GetDetails(long  id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
