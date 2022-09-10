using SimpleRPG.Web.API.DTOs.Character;
using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API.Services.CharacterService
{
    public interface ICharacterService
    {
        List<GETCharacterDTO> GetAllCharacters();
        GETCharacterDTO GetCharacterById(int id);
        List<GETCharacterDTO> AddCharacter(POSTCharacterDTO character);

    }
}
