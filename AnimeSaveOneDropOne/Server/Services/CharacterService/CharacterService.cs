using AnimeSaveOneDropOne.Server.Services.AnimeService;
using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IAnimeService _animeService;

        public CharacterService(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        public async Task<List<AnimeCharacter>> GetAllAnimeCharacters()
        {
            return AnimeCharacters;
        }

        public async Task<AnimeCharacter> GetAnimeCharacter(int Id)
        {
            AnimeCharacter animeCharacter = AnimeCharacters.FirstOrDefault(c => c.MalId == Id);
            return animeCharacter;
        }
        public List<AnimeCharacter> AnimeCharacters { get; set; } = new List<AnimeCharacter>
            {
                new AnimeCharacter
                {
                    MalId = 1,
                    Name = "AMN",
                    ImageUrl = "https://fiverr-res.cloudinary.com/images/q_auto,f_auto/gigs/149470781/original/cf87ada92b21431ab6418eeae2aac47aa6502d56/draw-cool-anime-or-manga-style-characters-fan-art-or-oc.png",
                    Points = 0,
                    Rank = 1,
                    PreviousRank = 2,
                    AnimeMalId = 1
                },
                new AnimeCharacter
                {
                    MalId = 2,
                    Name = "Naruto",
                    ImageUrl = "https://cdn.myanimelist.net/images/characters/2/284121.jpg",
                    Points = 0,
                    Rank = 2,
                    PreviousRank = 2,
                    AnimeMalId = 1
                }
            };

    }
}
