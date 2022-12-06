using NUnit.Framework;
using Zookeeper.Controllers;
using Zookeeper.Tools;

namespace Zookeeper.Tests.Controllers;

[TestFixture]
public class NewsletterControllerTests
{
    private NewsletterController _newsletterController;

    [SetUp]
    public void SetUp()
    {
        // arrange
        _newsletterController = new NewsletterController(new MockEmailService());
    }

    [Test]
    public void SubscribeSendsMail()
    {
        // act
        _newsletterController.Subscribe("n.weseloh@neusta.de");

        // assert
        /// ???
    }
}

public class MockEmailService : IEmailService
{
    public void SendMail(string recipient)
    {
        // do nothing
    }
}