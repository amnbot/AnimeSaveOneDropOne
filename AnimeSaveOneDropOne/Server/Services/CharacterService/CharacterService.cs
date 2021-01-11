using AnimeSaveOneDropOne.Server.Data;
using AnimeSaveOneDropOne.Server.Services.AnimeService;
using AnimeSaveOneDropOne.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IAnimeService _animeService;
        private readonly DataContext _context;

        public CharacterService(IAnimeService animeService, DataContext context)
        {
            _animeService = animeService;
            _context = context;
        }

        public async Task<AnimeCharacter> CreateAnimeCharacter(AnimeCharacter animeCharacter)
        {
            var result = await _context.AnimeCharacters.AddAsync(animeCharacter);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<AnimeCharacter>> GetAllAnimeCharacters()
        {
            return await _context.AnimeCharacters.ToListAsync();
        }

        public async Task<AnimeCharacter> GetAnimeCharacter(int Id)
        {
            AnimeCharacter animeCharacter = await _context.AnimeCharacters.FirstOrDefaultAsync(c => c.MalId == Id);
            return animeCharacter;
        }

        public async Task<AnimeCharacter> UpdateAnimeCharacter(AnimeCharacter animeCharacter)
        {
            var result = await _context.AnimeCharacters
                .FirstOrDefaultAsync(c => c.MalId == animeCharacter.MalId);

            if(result != null)
            {
                result.MalId = animeCharacter.MalId;
                result.Name = animeCharacter.Name;
                result.ImageUrl = animeCharacter.ImageUrl;
                result.Points = animeCharacter.Points;
                result.Rank = animeCharacter.Rank;
                result.PreviousRank = animeCharacter.PreviousRank;
                result.AnimeMalId = animeCharacter.AnimeMalId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
