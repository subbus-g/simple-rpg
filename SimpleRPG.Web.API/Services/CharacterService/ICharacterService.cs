using SimpleRPG.Web.API.DTOs.Character;
using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API.Services.CharacterService
{
    public interface ICharacterService
    {
        GETCharacterDTO GetCharacterById(int id);
        List<GETCharacterDTO> GetAllCharacters();
        List<GETCharacterDTO> AddCharacter(POSTCharacterDTO character);
        GETCharacterDTO UpdateCharacter(PUTCharacterDTO updatedCharacter);
        void DeleteCharacter(int id);


    }
}
