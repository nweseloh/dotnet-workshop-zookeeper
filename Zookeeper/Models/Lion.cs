
using System;
using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Lion : IAnimal
{
    private int _age;
    private bool _isHungry;

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            _age = value;
        }
    }

    public string Name { get; set; }

    public Size Size => Size.Medium;

    public virtual bool IsDangerous()
    {
        return _isHungry;
    }

    public string Roar()
    {
        return "Roaaaarrrrrrr!";
    }

    public void Feed()
    {
        // do nothing
    }
}