
using CarAuctionBids_Business.Dtos;
using CarAuctionBids_Core.Models;

namespace CarAuctionBids_Business.Abstraction
{
    public interface IPaymentHistoryService
    {
        Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDTO model);
        Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId);
    }
}
