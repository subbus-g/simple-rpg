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

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
        public List<Character> GetAllCharacters()
        {
            return characters;
        }
        public List<Character> AddCharacter(POSTCharacterDTO postCharacterDTO)
        {
            Character character = new Character();
            character.Id = 99;
            character.Name=postCharacterDTO.Name; 
            character.Strength=postCharacterDTO.Strength;
            character.Class = postCharacterDTO.Class;
            character.HitPoints = postCharacterDTO.HitPoints;
            character.Defence = postCharacterDTO.Defence;
            character.Intelligence = postCharacterDTO.Intelligence;

            
            characters.Add(character);
            return characters;
        }


    }
}
