using System.Collections.Generic;
using Zookeeper.Models;

namespace Zookeeper.Repositories;

public class AnimalRepository : IAnimalRepository
{
    public IEnumerable<IAnimal> GetAllAnimals()
    {
        // TODO:  query database
        return new List<IAnimal>
        {
            new Lion { Age = 1, Name = "Simba" },
            new Lion { Age = 10, Name = "Mufasa" },
            new Lion { Age = 20, Name = "Scar"},
            new Giraffe { Age = 1, Name = "Shorty"},
            new Giraffe { Age = 7, Name = "Lady Long Leg"},
            new Giraffe { Age = 10, Name = "Mister Long Neck"},
            new Tortoise{ Age = 50, Name = "Young Boy Johnny"},
            new Tortoise{ Age = 120, Name = "Grandma Georgia"}
        };
    }
}