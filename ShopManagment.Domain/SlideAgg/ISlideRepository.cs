using System.Collections.Generic;
using _0_FreamWork.Dimain;
using ShopManagment.Application.Contracts.Slide;

namespace ShopManagment.Domain.SlideAgg
{
    public interface ISlideRepository : IRepository<long, Slide>
    {
        EditSlide GetDetails(long id);
        List<SlideViewModel> GetList();
    }
}
