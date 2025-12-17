using DavidTielke;
using DavidTielke.PMA.CrossCutting.DataClasses;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonManager _personManager;

        public PersonController()
        {
            _personManager = new PersonManager();
        }

        [HttpGet()]
        [Route("/Person/Adults")]
        public IEnumerable<Person> GetAllAdults()
        {
            return _personManager.GetAllAdults();
        }

        [HttpGet()]
        [Route("/Person/Children")]
        public IEnumerable<Person> GetAllChildren()
        {
            return _personManager.GetAllChildren();
        }
    }
}
