using DavidTielke;
using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands : IPersonDisplayCommands
{
    public readonly IPersonManager _personManager;

    public PersonDisplayCommands(IPersonManager personManager)
    {
        _personManager = personManager;
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