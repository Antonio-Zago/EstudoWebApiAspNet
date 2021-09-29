using EstudoWebApiAspNet.Models;
using EstudoWebApiAspNet.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personservice;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personservice = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personservice.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personservice.FindById(id);
            if(person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Person person) //Pega o json do corpo da requisição e transforma em person
        {

            if (person == null)
            {
                return BadRequest();
            }
            return Ok(_personservice.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person) //Pega o json do corpo da requisição e transforma em person
        {

            if (person == null)
            {
                return BadRequest();
            }
            return Ok(_personservice.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personservice.Delete(id);
            return NoContent();
        }



    }
}
