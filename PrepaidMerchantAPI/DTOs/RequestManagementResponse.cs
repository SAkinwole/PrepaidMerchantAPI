using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.DTOs
{
    public class RequestManagementResponse
    {
        public List<RequestManagement> Transactions { get; set; } = new List<RequestManagement>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
