using Zookeeper.Enums;

namespace Zookeeper.Models;

public class Giraffe : IAnimal
{
    public Giraffe()
    {
        Name = "anonymous";
    }

    public int? Children { get; set; } =  null;

    public int Age { get; set; }

    public string? Name { get; set; }
    public Size Size => Size.Large;
    public bool IsDangerous()
    {
        return false;
    }

    public int GetNumberOfChildren()
    {
        if (Children.HasValue || Children != null)
            return Children.Value;

        return Children.GetValueOrDefault(-1);
    }

    public string GetNameToUpper()
    {
        if (Name == null)
            return null;
        else 
            return Name.ToUpper();

        // same as:
        // return Name?.ToUpper();
    }
}