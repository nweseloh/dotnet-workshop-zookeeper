using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Zookeeper.Enums;
using Zookeeper.Models;

namespace Zookeeper.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private static IEnumerable<IAnimal> GetAllAnimals()
    {
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


    [HttpGet(nameof(GetOldestAnimal))]
    public IAnimal? GetOldestAnimal()
    {
        return GetAllAnimals().MaxBy(x => x.Age);
    }


    [HttpGet( nameof(GetBabyAnimals))]
    public IEnumerable<IAnimal> GetBabyAnimals()
    {
        return GetAllAnimals().Where(x => x.Age <= 1);
    }


    [HttpGet(nameof(GetDangerousAnimals))]
    public IEnumerable<IAnimal> GetDangerousAnimals()
    {
        return GetAllAnimals().Where(x => x.IsDangerous());
    }


    [HttpGet(nameof(Search))]
    public IEnumerable<IAnimal> Search(string name)
    {
        return GetAllAnimals().Where(x => x.Name.StartsWith(name, StringComparison.CurrentCultureIgnoreCase));
    }


    [HttpGet(nameof(GetCuteAnimals))]
    public IEnumerable<IAnimal> GetCuteAnimals()
    {
        // small or very young
        return GetAllAnimals().Where(x => x.Size == Size.Small || x.Age <= 1);
    }


    [HttpGet(nameof(GetAnimalsOrderedByName))]
    public IEnumerable<string> GetAnimalsOrderedByName(int offset, int limit)
    {
        return GetAllAnimals().OrderBy(x => x.Name).Skip(offset).Take(limit).Select(x => x.Name);
    }

    [HttpGet(nameof(GetAnimalNamesPerAgeOrderedByAge))]
    public Dictionary<int, IEnumerable<string>> GetAnimalNamesPerAgeOrderedByAge()
    {
        var animalsGroupedByAge = GetAllAnimals().GroupBy(x => x.Age).OrderBy(grouping => grouping.Key);

        var result = animalsGroupedByAge.ToDictionary(group => group.Key, group => group.Select(animal => animal.Name));

        return result; 
    }
}
