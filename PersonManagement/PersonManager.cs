
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke;

public class PersonValidator
{
    public bool IsValid()
    {
        return default;
    }
}
public class PersonManager
{
    private readonly PersonRepository _personRepository;

    public PersonManager()
    {
        _personRepository = new PersonRepository();
    }

    public void Copy()
    {

    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _personRepository.Load().Where(p => p.Age >= 18);
        return adults;
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _personRepository.Load().Where(p => p.Age < 18);
        return children;
    }
}