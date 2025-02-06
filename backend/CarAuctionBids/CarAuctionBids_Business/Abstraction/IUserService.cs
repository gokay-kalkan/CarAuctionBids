
using CarAuctionBids_Business.Dtos;
using CarAuctionBids_Core.Models;

namespace CarAuctionBids_Business.Abstraction
{
    public interface IUserService
    {
        Task<ApiResponse> Register(RegisterRequestDTO model);
        Task<ApiResponse> Login(LoginRequestDTO model);
    }
}
