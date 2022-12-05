using System;
using Microsoft.AspNetCore.Mvc;

namespace Zookeeper.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsletterController
{
    [HttpGet(nameof(Subscribe))]
    public void Subscribe(string emailAddress)
    {
        throw new NotImplementedException();
    }
}