using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopingManagment.Infarastructure.Efcore;
using ShopingManagment.Infarastructure.Efcore.Repository;
using ShopManagment.Application.Contracts.ProductCategory;
using ShopManagment.Domain.ProductCategoryAgg;
using ShopMnagagment.Application1;

namespace ShopManagement.Configuration
{
    public class ShopManagementBoostrapper
    {
        public static void Configure(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));

        }

    }
}
