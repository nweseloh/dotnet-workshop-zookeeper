using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Tortoise : IAnimal
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Size Size => Size.Small;
    public bool IsDangerous()
    {
        return false;
    }
}