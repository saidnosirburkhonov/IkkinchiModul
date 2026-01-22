using Dars2._8.Models;
using Dars2._8.Services;

namespace Dars2._8;

public class Program
{
    static void Main(string[] args)
    {
        INotificationService notification = new EmailService();
        INotificationService notification1 = new TeamsService();
        INotificationService notification2 = new AccountService();

        notification.SendNotification();
        notification1.SendNotification();
        notification2.SendNotification();
    }
}
