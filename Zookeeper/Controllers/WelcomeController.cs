using System;
using Microsoft.AspNetCore.Mvc;

namespace Zookeeper.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet(Name = "GetWelcome")]
        public string Get()
        {
            return "Welcome to the Zoo!";
        }
    }
}
/*
[HttpGet("Feed")]
public string Feed(string animal)
{
    try
    {
        throw new TooDangerousException();
    }
    catch (ZookeeperException e)
    {
        Console.WriteLine(e);
    }
    catch (Exception e)
    {
    }

    return "Animal is no longer hungry.";
}
}

public class Car
{
private class Engine
{
    public void Start()
    {
    }
}

public void Move()
{
    Engine engine = new Engine();
    engine.Start();
}
}

public class MyAttribute : Attribute
{

}

public class TooDangerousException : ZookeeperException, IUserError
{
}

public interface IUserError
{
}

public class ZookeeperException : Exception
{
public string InfoStuff = "Meine Exception";
}
*/
