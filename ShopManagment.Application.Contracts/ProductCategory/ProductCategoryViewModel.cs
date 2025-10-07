namespace ShopManagment.Application.Contracts.ProdctCategory
{
    public class ProductCategoryViewModel
    {

        public long Id { get; set; }
        public long ProductCount { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }

    }
}