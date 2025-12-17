
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _personParser;
    private readonly IFileReader _fileReader;

    public PersonRepository(IPersonParser personParser, IFileReader fileReader)
    {
        _personParser = personParser;
        _fileReader = fileReader;
    }

    public IQueryable<Person> Load()
    {
        var lines = _fileReader.ReadLines("data.csv");
        var persons = lines.Select(_personParser.Parse);
        return persons.AsQueryable();
    }
}