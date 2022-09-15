using AutoMapper;
using SimpleRPG.Web.API.DTOs.Character;
using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API.Services.CharacterService
{
    public class CharacterService : ICharacterService
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
        private readonly IMapper _mapper;



        List<GETCharacterDTO> ICharacterService.AddCharacter(POSTCharacterDTO postCharacterDTO)
        {
            //GETCharacterDTO character = new();
            //character.Id = 999;
            //character.Name = postCharacterDTO.Name;
            //character.Strength = postCharacterDTO.Strength;
            //character.Class = postCharacterDTO.Class;
            //character.HitPoints = postCharacterDTO.HitPoints;
            //character.Defence = postCharacterDTO.Defence;
            //character.Intelligence = postCharacterDTO.Intelligence;


            //characters.Add(character);
            //return characters;

            Character character = _mapper.Map<Character>(postCharacterDTO);
            character.Id=characters.Max(c=> c.Id) + 1;
            //converting from POSTCharacterDTO to Character
            characters.Add(character);

            //converting each of character in characters to  GETCharacterDTO and returning the list
            return characters.Select(c => _mapper.Map<GETCharacterDTO>(c)).ToList();

        }

        public CharacterService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public List<GETCharacterDTO> GetAllCharacters()
        {
            return characters.Select(c => _mapper.Map<GETCharacterDTO>(c)).ToList();
        }
       

        GETCharacterDTO ICharacterService.GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            return _mapper.Map<GETCharacterDTO>(character);
            //return characters.FirstOrDefault(c => c.Id == id);
        }
          
     
    }
}
