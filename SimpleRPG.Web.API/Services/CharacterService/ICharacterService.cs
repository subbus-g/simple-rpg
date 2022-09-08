using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character character);

    }
}
