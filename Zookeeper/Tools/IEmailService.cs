namespace Zookeeper.Tools;

public interface IEmailService
{
    void SendMail(string recipient);

    bool IsValidEmailAddress(string emailAddress);
}