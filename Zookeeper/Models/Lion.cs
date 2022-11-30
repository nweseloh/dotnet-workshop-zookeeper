
using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Lion : IAnimal
{
    public int Age { get; set; }

    public string Name { get; set; }

    public Size Size => Size.Medium;
    public bool IsDangerous()
    {
        return true;
    }
}