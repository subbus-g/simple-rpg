using AutoMapper;
using SimpleRPG.Web.API.DTOs.Character;
using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GETCharacterDTO>();
            CreateMap<POSTCharacterDTO, Character>();
        }
    }
}
