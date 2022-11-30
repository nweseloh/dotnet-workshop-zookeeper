using Microsoft.AspNetCore.Mvc;
using Zookeeper.Models;

namespace Zookeeper.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    //private IEnumerable<IAnimal> GetAllAnimals()
    //{
    //    return new List<IAnimal>
    //    {
    //        new Lion { Age = 1, Name = "Simba" },
    //        new Lion { Age = 10, Name = "Mufasa" },
    //        new Lion { Age = 20, Name = "Scar"},
    //        new Giraffe { Age = 1, Name = "Shorty"},
    //        new Giraffe { Age = 7, Name = "Lady Long Leg"},
    //        new Giraffe { Age = 10, Name = "Mister Long Neck"},
    //        new Tortoise{ Age = 50, Name = "Young Boy Johnny"},
    //        new Tortoise{ Age = 120, Name = "Grandma Georgia"}
    //    };
    //}


    //[HttpGet(Name = nameof(GetOldestAnimal))]
    //public IAnimal GetOldestAnimal()
    //{
    //    throw new NotImplementedException();
    //}

    
    //[HttpGet(Name = nameof(GetBabyAnimals))]
    //public IEnumerable<IAnimal> GetBabyAnimals()
    //{
    //    throw new NotImplementedException();
    //}


    //[HttpGet(Name = nameof(GetDangerousAnimals))]
    //public IEnumerable<IAnimal> GetDangerousAnimals()
    //{
    //    throw new NotImplementedException();
    //}


    //[HttpGet(Name = nameof(Search))]
    //public IEnumerable<IAnimal> Search(string name)
    //{
    //    throw new NotImplementedException();
    //}


    //[HttpGet(Name = nameof(GetCuteAnimals))]
    //public IEnumerable<IAnimal> GetCuteAnimals(string name)
    //{
    //    // small or very young
    //    throw new NotImplementedException();
    //}


    //[HttpGet(Name = nameof(GetAnimalsOrderedByName))]
    //public Dictionary<int, IEnumerable<string>> GetAnimalsOrderedByName(int offset, int limit)
    //{
    //    throw new NotImplementedException();
    //}

    //[HttpGet(Name = nameof(GetAnimalNamesPerAgeOrderedByAge))]
    //public Dictionary<int, IEnumerable<string>> GetAnimalNamesPerAgeOrderedByAge()
    //{
    //    throw new NotImplementedException();
    //}
}
