using CarAuctionBids.Hubs.ConnectionManagament;
using CarAuctionBids_Business.Abstraction;
using CarAuctionBids_Business.Concrete;
using CarAuctionBids_Core.Models;

namespace CarAuctionBids.Extensions
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IBidService, BidService>();
            //services.AddScoped<IMailService, MailService>();
            services.AddScoped<IPaymentHistoryService, PaymentHistoryService>();
            services.AddScoped<IConnectionManager, ConnectionManager>();
            services.AddScoped(typeof(ApiResponse));
            #endregion
            return services;
        }
    }
}
