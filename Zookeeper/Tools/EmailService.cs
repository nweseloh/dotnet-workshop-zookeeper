using System.Data;
using System.Net.Mail;

namespace Zookeeper.Tools;

public class EmailService : IEmailService
{
    public void SendMail(string recipient)
    {
        SmtpClient smtpClient = CreateSmtpClient();
        smtpClient.Send("marketing@zoo.com", recipient, 
            "Visit our zoo!", "We have lots of animals." );
    }

    private static SmtpClient CreateSmtpClient()
    {
        return new SmtpClient("127.0.0.1", 125);
    }

    public bool IsValidEmailAddress(string emailAddress)
    {
        return emailAddress.Contains("@");
    }
}