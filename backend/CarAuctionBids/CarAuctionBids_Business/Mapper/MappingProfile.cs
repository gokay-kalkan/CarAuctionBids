using AutoMapper;
using CarAuctionBids_Business.Dtos;
using CarAuctionBids_DataAccess.Domain;
using CarAuctionBids_DataAccess.Models;


namespace CarAuctionBids_Business.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterRequestDTO, ApplicationUser>().ReverseMap();
            CreateMap<CreateVehicleDTO, Vehicle>().ReverseMap();
            CreateMap<UpdateVehicleDTO, Vehicle>().ReverseMap();
            CreateMap<UpdateBidDTO, Bid>().ReverseMap();
            CreateMap<CreateBidDTO, Bid>().ReverseMap();
            CreateMap<CreatePaymentHistoryDTO, PaymentHistory>().ReverseMap();
        }
    }
}
