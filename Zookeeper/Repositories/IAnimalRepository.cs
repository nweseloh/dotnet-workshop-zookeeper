using System.Collections.Generic;
using Zookeeper.Models;

namespace Zookeeper.Repositories;

public interface IAnimalRepository
{
    IEnumerable<IAnimal> GetAllAnimals();
}