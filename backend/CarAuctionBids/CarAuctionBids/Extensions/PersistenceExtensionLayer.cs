using CarAuctionBids_DataAccess.Context;
using CarAuctionBids_DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionBids.Extensions
{
    public static class PersistenceExtensionLayer
    {
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {

            #region Context
            services.AddDbContext<DataContext>(options => { options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); });
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<DataContext>();
            #endregion
            return services;

        }
    }
}
