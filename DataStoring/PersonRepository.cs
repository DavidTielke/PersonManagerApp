
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository
{
    private readonly PersonParser _personParser;
    private readonly FileReader _fileReader;

    public PersonRepository()
    {
        _personParser = new PersonParser();
        _fileReader = new FileReader();
    }

    public IQueryable<Person> Load()
    {
        var lines = _fileReader.ReadLines("data.csv");
        var persons = lines.Select(_personParser.Parse);
        return persons.AsQueryable();
    }
}