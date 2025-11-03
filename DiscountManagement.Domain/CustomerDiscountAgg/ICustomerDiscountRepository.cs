using DiscountManagement.Application.Contract.CustomerDiscount;
using System.Collections.Generic;
using _0_FreamWork.Dimain;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public interface ICustomerDiscountRepository : IRepository<long, CustomerDiscount>
    {
        EditCustoemrDiscount GetDetails(long id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}
