using System.Collections.Generic;
using _0_FreamWork.Application;
using ShopManagment.Application.Contracts.Slide;
using ShopManagment.Domain.SlideAgg;

namespace ShopMnagagment.Application1
{
    public class SlideApplication : ISlideApplication
    {
        private readonly IFormUploader _fileUploader;
        private readonly ISlideRepository _slideRepository;

        public SlideApplication(ISlideRepository slideRepository, IFormUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _slideRepository = slideRepository;
        }

        public OperationResult Create(CreateSlide command)
        {
            var operation = new OperationResult();

            var pictureName = _fileUploader.Upload(command.Picture, "slides");

            var slide = new Slide(pictureName, command.PictureAlt, command.PictureTitle,
                command.Heading, command.Title, command.Text, command.Link, command.BtnText);

            _slideRepository.Create(slide);
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditSlide command)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(command.Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var pictureName = _fileUploader.Upload(command.Picture, "slides");

            slide.Edit(pictureName, command.PictureAlt, command.PictureTitle,
                command.Heading, command.Title, command.Text, command.Link, command.BtnText);
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditSlide GetDetails(long id)
        {
            return _slideRepository.GetDetails(id);
        }

        public List<SlideViewModel> GetList()
        {
            return _slideRepository.GetList();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Remove();
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Restore();
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }
    }
}
