using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_FreamWork.Dimain;

namespace ShopManagment.Domain.ProdctCategoryAgg
{
    public class ProductCategory:EntityBase
    {
        public ProductCategory(string name, string description, string picture, string pictureAlt,
            string pictureTitle, string keyWords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            Slug = slug;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string KeyWords { get; set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }


        public void Edit(string name, string description, string picture,
            string pictureAlt, string pictureTitle, string keyWords, string metaDescription, string slug)
        {

            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            Slug = slug;

        }
    }
}
