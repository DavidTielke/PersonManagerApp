using DavidTielke;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands
{
    public readonly PersonManager _personManager;

    public PersonDisplayCommands()
    {
        _personManager = new PersonManager();
    }

    public void DisplayAllAdults()
    {
        var adults = _personManager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        foreach (var adult in adults)
        {
            Console.WriteLine($"Name: {adult.Name}, Age: {adult.Age}, Id: {adult.Id}");
        }
    }
    public void DisplayAllChildren()
    {
        var children = _personManager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        foreach (var child in children)
        {
            Console.WriteLine($"Name: {child.Name}, Age: {child.Age}, Id: {child.Id}");
        }
    }
}