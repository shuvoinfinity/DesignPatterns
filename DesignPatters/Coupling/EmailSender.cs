namespace DesignPatterns.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine($"Sending email: {message}");
        }
    }

    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine($"Sending sms: {message}");
        }
    }
}