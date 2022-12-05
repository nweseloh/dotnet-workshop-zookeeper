using Zookeeper.Enums;

namespace Zookeeper.Models;

public interface IAnimal
{
    int Age { get; set; }

    string Name { get; set; }

    Size Size { get; }

    bool IsDangerous();
}