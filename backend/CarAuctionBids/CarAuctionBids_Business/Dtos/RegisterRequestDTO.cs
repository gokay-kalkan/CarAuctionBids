﻿

namespace CarAuctionBids_Business.Dtos
{
    public class RegisterRequestDTO
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
