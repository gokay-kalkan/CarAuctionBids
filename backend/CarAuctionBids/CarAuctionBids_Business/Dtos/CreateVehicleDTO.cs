﻿using Microsoft.AspNetCore.Http;

namespace CarAuctionBids_Business.Dtos
{
    public class CreateVehicleDTO
    {
        public string BrandAndModel { get; set; }
        public int ManufacturingYear { get; set; }
        public string Color { get; set; }
        public decimal EngineCapacity { get; set; }
        public decimal Price { get; set; }

        public int Millage { get; set; }
        public string PlateNumber { get; set; }

        public double AuctionPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }
        public string SellerId { get; set; }
        public IFormFile File { get; set; }
    }
}
