using CarAuctionBids_Business.Dtos;
using CarAuctionBids_Core.Models;

namespace CarAuctionBids_Business.Abstraction
{
    public interface IVehicleService
    {
        Task<ApiResponse> CreateVehicle(CreateVehicleDTO model);
        Task<ApiResponse> GetVehicles();
        Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDTO model);
        Task<ApiResponse> DeleteVehicle(int vehicleId);
        Task<ApiResponse> GetVehicleById(int vehicleId);
        Task<ApiResponse> ChangeVehicleStatus(int vehicleId);
    }
}
