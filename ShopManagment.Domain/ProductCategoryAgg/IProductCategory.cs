using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagment.Domain.ProdctCategoryAgg;

namespace ShopManagment.Domain.ProductCategoryAgg
{
    public interface IProductCategory
    {
        void Create(ProductCategory entity);
        ProductCategory Get(int id);
        List<ProductCategory> GetAll();

    }
}
