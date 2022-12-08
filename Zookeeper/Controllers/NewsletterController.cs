using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Zookeeper.Exceptions;
using Zookeeper.Tools;

namespace Zookeeper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsletterController
    {
        private readonly IEmailService _emailService;
        private readonly IMyLogger _logger;

        public NewsletterController(IEmailService emailService, IMyLogger  logger)
        {
            _emailService = emailService;
            _logger = logger;
        }

        [HttpGet(nameof(Subscribe))]
        public void Subscribe(string emailAddress)
        {
            if (!_emailService.IsValidEmailAddress(emailAddress))
                throw new InvalidEmailException();

            try
            {
                _emailService.SendMail(emailAddress);
            }
            catch (SmtpException e)
            {
                _logger.Log(e, "Send mail failed");
            }
        }
    }
}