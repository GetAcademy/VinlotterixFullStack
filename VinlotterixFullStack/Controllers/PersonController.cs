using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqlTestVinlotterix;
using VinlotterixFullStack.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VinlotterixFullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private PersonRepository _personRepository;

        public PersonController()
        {
            _personRepository = new PersonRepository();
        }

        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personRepository.Get();
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _personRepository.Create(person);
        }

        // PUT api/<PersonController>
        [HttpPut]
        public void Put([FromBody] Person person)
        {
            _personRepository.Update(person);
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete([FromBody] Person person)
        {
            _personRepository.Delete(person);
        }
    }
}
