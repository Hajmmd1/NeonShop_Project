using _0_FreamWork.Application;
using Microsoft.AspNetCore.Http;
using ShopManagment.Application.Contracts.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagment.Application.Contracts.ProductPicture
{
    public class CreateProductPicture
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long ProductId { get; set; }

        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
