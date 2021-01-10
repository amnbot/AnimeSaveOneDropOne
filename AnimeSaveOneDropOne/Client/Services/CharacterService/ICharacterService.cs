using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Client.Services.CharacterService
{
    public interface ICharacterService
    {
        List<AnimeCharacter> AnimeCharacters { get; set; }
        Task LoadAnimeCharacters();

        Task<AnimeCharacter> GetAnimeCharacter(int Id);
    }
}
