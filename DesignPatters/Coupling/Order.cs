namespace DesignPatterns.Coupling
{
    public class Order
    {
        private readonly INotificationService _notificationService;

        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            _notificationService.SendNotification("Order placed successfully.");
        }
    }
}