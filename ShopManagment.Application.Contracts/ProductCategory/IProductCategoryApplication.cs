using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagment.Application.Contracts.ProdctCategory;

namespace ShopManagment.Application.Contracts.ProductCategory
{
    internal interface IProductCategoryApplication
    {
        void Create(CreateProductCategory command);
        void Edit(EditProductCategory command);
        Domain.ProdctCategoryAgg.ProductCategory GetDetail(long  id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
