using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Zookeeper.Enums;
using Zookeeper.Models;
using Zookeeper.Repositories;

namespace Zookeeper.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalsController(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
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
        IEnumerable<string> animalNames = GetAnimalNames(offset, limit);

        Console.WriteLine($"We found {animalNames.Count()} animals");

        return animalNames;
    }

    private List<string> GetAnimalNames(int offset, int limit)
    {
        IEnumerable<IAnimal> animals = GetAllAnimals();

        IOrderedEnumerable<IAnimal> orderedAnimals = animals.OrderBy(x => x.Name);

        IEnumerable<IAnimal> selectedAnimals = orderedAnimals.Skip(offset).Take(limit);

        IEnumerable<string> animalNames = selectedAnimals.Select(x => x.Name).ToList();
        
        return animalNames.ToList();
    }

    [HttpGet(nameof(GetAnimalNamesPerAgeOrderedByAge))]
    public Dictionary<int, IEnumerable<string>> GetAnimalNamesPerAgeOrderedByAge()
    {
        IOrderedEnumerable<IGrouping<int, IAnimal>> animalsGroupedByAge = GetAllAnimals().GroupBy(x => x.Age).OrderBy(grouping => grouping.Key);

        var result = animalsGroupedByAge.ToDictionary(group => group.Key, group => group.Select(animal => animal.Name));

        return result; 
    }

    private IEnumerable<IAnimal> GetAllAnimals()
    {
        return _animalRepository.GetAllAnimals();
    }

}
