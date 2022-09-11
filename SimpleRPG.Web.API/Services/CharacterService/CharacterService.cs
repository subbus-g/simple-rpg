using SimpleRPG.Web.API.DTOs.Character;
using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<GETCharacterDTO> characters = new List<GETCharacterDTO>
        {
            new GETCharacterDTO(),
            new GETCharacterDTO
            {
                Name="Bahu",
                Id=1
            }
        };

        
        public List<GETCharacterDTO> GetAllCharacters()
        {
            return characters;
        }
       

        GETCharacterDTO ICharacterService.GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }

        List<GETCharacterDTO> ICharacterService.AddCharacter(POSTCharacterDTO postCharacterDTO)
        {
            GETCharacterDTO character = new();
            character.Id = 999;
            character.Name = postCharacterDTO.Name;
            character.Strength = postCharacterDTO.Strength;
            character.Class = postCharacterDTO.Class;
            character.HitPoints = postCharacterDTO.HitPoints;
            character.Defence = postCharacterDTO.Defence;
            character.Intelligence = postCharacterDTO.Intelligence;


            characters.Add(character);
            return characters;
        }
    }
}
