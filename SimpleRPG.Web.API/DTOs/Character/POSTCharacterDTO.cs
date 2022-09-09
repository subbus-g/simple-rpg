using SimpleRPG.Web.API.Models;

namespace SimpleRPG.Web.API.DTOs.Character
{
    public class POSTCharacterDTO
    {
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public CharacterClass Class { get; set; } = CharacterClass.Knight;
    }
}
