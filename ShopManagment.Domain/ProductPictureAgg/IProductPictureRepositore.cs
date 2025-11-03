using _0_FreamWork.Dimain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagment.Application.Contracts.ProductPicture;

namespace ShopManagment.Domain.ProductPictureAgg
{
    public interface IProductPictureRepository : IRepository<long, ProductPicture>
    {
        EditProductPicture GetDetails(long id);
        ProductPicture GetWithProductAndCategory(long id);
        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);
    }
}
