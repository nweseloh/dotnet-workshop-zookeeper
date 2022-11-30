using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Giraffe : IAnimal
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Size Size => Size.Large;
    public bool IsDangerous()
    {
        return false;
    }
}