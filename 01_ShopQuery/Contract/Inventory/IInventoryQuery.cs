using _01_LampshadeQuery.Contracts.Inventory;

namespace _01_ShopQuery.Contract.Inventory
{
    public interface IInventoryQuery
    {
        StockStatus CheckStock(IsInStock command);
    }
}
