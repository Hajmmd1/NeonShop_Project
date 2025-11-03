using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_FreamWork.Application;
using ShopManagment.Application.Contracts.Product;

namespace InventoryManagement.Application.Contract._2.Inventory
{
    public class CreateInventory
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long ProductId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public double UnitPrice { get; set; }

        public List<ProductViewModel> Products { get; set; }
    }
}
