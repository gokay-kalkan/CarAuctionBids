

using CarAuctionBids_DataAccess.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CarAuctionBids_DataAccess.Domain
{
    public class Bid
    {
        [Key]
        public int BidId { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime BidDate { get; set; }
        public string BidStatus { get; set; } = CarAuctionBids_DataAccess.Enums.BidStatus.Pending.ToString();
        public string? UserId { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        public int VehicleId { get; set; }
        [JsonIgnore]

        public virtual Vehicle Vehicle { get; set; }
    }
}
