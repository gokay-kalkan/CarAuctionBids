

namespace CarAuctionBids_Core.MailHelper
{
    public interface IMailService
    {
        public void SendEmail(string subject, string body, string email);
    }
}
