namespace EcommerceApp.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<string> PlacerOder();
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
