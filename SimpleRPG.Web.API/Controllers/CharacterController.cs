  using Microsoft.AspNetCore.Mvc;
using SimpleRPG.Web.API.DTOs.Character;
using SimpleRPG.Web.API.Models;
using SimpleRPG.Web.API.Services.CharacterService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRPG.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService; 
        }

        // GET: api/<CharacterController>
        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return Ok(_characterService.GetAllCharacters()); 
        }

        // GET api/<CharacterController>/5
        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        // POST api/<CharacterController>
        [HttpPost]
        public ActionResult Post([FromBody] POSTCharacterDTO character)
        {
           _characterService.AddCharacter(character);
            return Ok();
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
