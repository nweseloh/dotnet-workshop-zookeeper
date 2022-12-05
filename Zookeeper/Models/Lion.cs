
using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Lion : IAnimal
{
    private int _age;

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _age = value;
        }
    }

    public string Name { get; set; }

    public Size Size => Size.Medium;
    public bool IsDangerous()
    {
        return true;
    }
}