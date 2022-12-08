
using System;
using System.Timers;
using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Lion : IAnimal
{
    private int _age;
    private bool _isHungry;
    private readonly Timer _timer;

    public Lion()
    {
        _timer = new Timer();
        _timer.Interval = TimeSpan.FromHours(1).Milliseconds; 
        _timer.Elapsed += TimerOnElapsed;
        _timer.Start();
        
    }

    private void TimerOnElapsed(object? sender, ElapsedEventArgs e)
    {
        _isHungry = true;
    }

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
        _isHungry = false;
    }
}