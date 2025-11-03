using System.Collections.Generic;

namespace _01_ShopQuery.Contract.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetProductDetails(string slug);
        List<ProductQueryModel> GetLatestArrivals();
        List<ProductQueryModel> Search(string value);
        //List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
