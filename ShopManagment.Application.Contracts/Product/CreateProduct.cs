using _0_FreamWork.Application;
using Microsoft.AspNetCore.Http;
using ShopManagment.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagment.Application.Contracts.Product
{
    public class CreateProduct
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Code { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [MaxFileSize(3 * 1204 * 1204,ErrorMessage = ValidationMessages.MaxFileSize)]
        [FileExtentionLimitation(new string[]{"jpeg","jpg","png"})]
        public IFormFile Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }

        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}
