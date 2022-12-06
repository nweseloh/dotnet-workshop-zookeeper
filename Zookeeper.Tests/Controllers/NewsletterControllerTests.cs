using System.Net.Mail;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Zookeeper.Controllers;
using Zookeeper.Exceptions;
using Zookeeper.Tools;

namespace Zookeeper.Tests.Controllers;

[TestFixture]
public class NewsletterControllerTests
{
    private NewsletterController _newsletterController;
    private Mock<IEmailService> _emailServiceMock;
    private Mock<IMyLogger> _logger;

    [SetUp]
    public void SetUp()
    {
        _emailServiceMock = new Mock<IEmailService>();
        _logger = new Mock<IMyLogger>();

        _newsletterController = new NewsletterController(_emailServiceMock.Object, _logger.Object );

        _emailServiceMock.Setup(x => x.IsValidEmailAddress(It.IsAny<string>())).Returns(true);
    }

    [Test]
    public void SubscribeSendsMail()
    {
        // act
        _newsletterController.Subscribe("n.weseloh@neusta.de");

        // assert
        _emailServiceMock.Verify(x => x.SendMail("n.weseloh@neusta.de"));
    }


    [Test]
    public void Subscribe_ValidatesMail()
    {
        _newsletterController.Subscribe("test");
        
        _emailServiceMock.Verify(x => x.IsValidEmailAddress("test"));

    }

    [Test]
    public void Subscribe_ThrowsException_IfMailIsNotValid()
    {
        _emailServiceMock.Setup(x => x.IsValidEmailAddress("invalid@email.com")).Returns(false);

        // (prepare) act
        TestDelegate testDelegate = () => _newsletterController.Subscribe("invalid@email.com");

        // assert
        Assert.Throws<InvalidEmailException>(testDelegate);
    }

    [Test]
    public void Subscribe_Logs_SmtpException_FromDependency()
    {
        SmtpException ex = new SmtpException();
        _emailServiceMock.Setup(x => x.SendMail(It.IsAny<string>())).Throws(ex);

        _newsletterController.Subscribe("n.weseloh@neusta.de");
        
        _logger.Verify(x => x.Log(ex, "Send mail failed"));
    }
}