using System.Net.Mail;

namespace Zookeeper.Tools;

public class EmailService
{
    public static void SendMail(string recipient)
    {
        SmtpClient smtpClient = new SmtpClient("127.0.0.1", 125);
        smtpClient.Send("pr@zoo.com", recipient, "Wanna see something cute?", "Then come to our zoo!" );
    }

    public static bool IsValidEmailAddress(string emailAddress)
    {
        return emailAddress.Contains("@");
    }
}