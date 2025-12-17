using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();

            var provider = collection.BuildServiceProvider();

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();

            displayCommands.DisplayAllAdults();
            displayCommands.DisplayAllChildren();
        }
    }
}
