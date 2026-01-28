using Dars2._8.Models;
using Dars2._8.Services;

namespace Dars2._8;

public class Program
{
    static void Main(string[] args)
    {
        
        Notification notification1 = new Notification();
        INotificationService notificationService = GetSocialMedia();


        
    }
    public static INotificationService GetSocialMedia()
    {
        //INotificationService notification = new EmailService();
        //INotificationService notification = new TeamsService();
        INotificationService notification = new   AccountService();
        return notification;
    }
}
