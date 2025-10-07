using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _0_FreamWork.Application;
using ShopManagment.Application.Contracts.ProdctCategory;
using ShopManagment.Application.Contracts.ProductCategory;
using ShopManagment.Domain.ProdctCategoryAgg;
using ShopManagment.Domain.ProductCategoryAgg;

namespace ShopMnagagment.Application1
{
    internal class ProductCategoryApplication: IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var opration = new OperationResult();
            if (_productCategoryRepository.Exists(x=>x.Name==command.Name))
                return opration.Failed("امکان ثبت رکورد تکراری وجود ندارد");

            var slug = command.Slug.Slugify();
            var ProductCategory = new ProductCategory(command.Name, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle, command.KeyWords, command.MetaDescription,slug);
            _productCategoryRepository.Create(ProductCategory);
            _productCategoryRepository.SaveChanges();
            return opration.Succedded();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var opration = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);
            if (productCategory != null)
            {
                return opration.Failed("رکورد مورد نظر یافت نشد");
                
            }

            if (_productCategoryRepository.Exists(x=>x.Name==command.Name&&x.Id!=command.Id))
            {
                return opration.Failed("امکان ثبت رکورد تکراری وجود ندارد");
            }
            var slug = command.Slug.Slugify();
            productCategory.Edit(command.Name, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle, command.KeyWords, command.MetaDescription,slug);
            _productCategoryRepository.SaveChanges();
            return opration.Succedded();
        }

        public EditProductCategory GetDetail(long id)
        {
            return _productCategoryRepository.GetDetails( id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}
