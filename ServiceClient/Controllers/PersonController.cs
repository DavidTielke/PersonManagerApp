using DavidTielke;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager _personManager;

        public PersonController(IPersonManager personManager)
        {
            _personManager = personManager;
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
