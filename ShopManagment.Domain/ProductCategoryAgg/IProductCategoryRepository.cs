using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ShopManagment.Application.Contracts.ProdctCategory;
using ShopManagment.Domain.ProdctCategoryAgg;

namespace ShopManagment.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository

    {
        void Create(ProductCategory entity);
        ProductCategory Get(int id);
        List<ProductCategory> GetAll();
        bool Exists(Expression<Func<ProductCategory,bool>> expression);
        void SaveChanges();
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
