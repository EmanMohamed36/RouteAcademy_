namespace Part02_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("eman@example.com", "Welcome to our service!");
            smsService.SendNotification("+01273191052", "Your code is 1234.");
            pushService.SendNotification("emanDeviceId", "You have a new message.");
        }
    }
}
