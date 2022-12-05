using System.Net.Mail;

namespace Zookeeper.Tools;

public class EmailService
{
    public static void SendMail(string recipient)
    {
        SmtpClient smtpClient = new SmtpClient("127.0.0.1", 125);
        smtpClient.Send("marketing@zoo.com", recipient, "Visit our zoo!", "We have lots of animals." );
    }

    public static bool IsValidEmailAddress(string emailAddress)
    {
        return emailAddress.Contains("@");
    }
}