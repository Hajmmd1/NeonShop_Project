using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _0_FreamWork.Dimain;
using ShopManagment.Application.Contracts.Product;

namespace ShopManagment.Domain.ProductAgg
{
    public interface IProductRepository:IRepository<long,Product>
    {
        EditProduct GetDetails(long id);
        Product GetProductWithCategory(long id);
        List<ProductViewModel> GetProducts();
        List<ProductViewModel> Search(ProductSearchModel searchModel);
    }
}
