using Microsoft.AspNetCore.Mvc;
using System.Data;
using Zookeeper.Tools;

namespace Zookeeper.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsletterController
{
    private readonly IEmailService _emailService;
    public NewsletterController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpGet(nameof(Subscribe))]
    public void Subscribe(string emailAddress)
    {
        _emailService.SendMail(emailAddress);
    }
}