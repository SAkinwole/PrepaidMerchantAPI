namespace PrepaidMerchantAPI.DTOs
{
    public class DashboardResponse
    {
        public int TotalCards { get; set; }
        public int ActiveCards { get; set; }
        public int InactiveCards { get; set; }
        public int ExpiredCards { get; set; }

    }
}
