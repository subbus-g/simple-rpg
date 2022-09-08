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
        public List<Character> AddCharacter(Character character)
        {
            characters.Add(character);
            return characters;
        }


    }
}
