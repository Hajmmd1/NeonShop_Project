using _0_FreamWork.Application;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.AdminStartion.Pages.Blog.Articles
{
    public class CreateModel : PageModel
    {
        public CreateArticle Command;
        public SelectList ArticleCategories;

        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        private readonly IFormUploader _fileUploader;

        public CreateModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication, IFormUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            ArticleCategories = new SelectList(_articleCategoryApplication.GetArticleCategories(), "Id", "Name");
        }

        public IActionResult OnPost(CreateArticle command)
        {
            var result = _articleApplication.Create(command);
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostUploadEditorImage(IFormFile file)
        {
            if (file == null)
                return new JsonResult(new { error = "No file uploaded" });

            var path = "EditorImages";
            var imagePath = _fileUploader.Upload(file, path);

            return new JsonResult(new
            {
                location = $"/ProductPictures/{imagePath}"
            });
        }

    }
}
