using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<AnimeCharacter>> GetAllAnimeCharacters();

        Task<AnimeCharacter> GetAnimeCharacter(int MalId);
    }
}
