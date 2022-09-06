  using Microsoft.AspNetCore.Mvc;
using SimpleRPG.Web.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRPG.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character
            {
                Name="Bahu",
                Id=1
            }
        };


        // GET: api/<CharacterController>
        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters); 
        }

        // GET api/<CharacterController>/5
        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        // POST api/<CharacterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CharacterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
