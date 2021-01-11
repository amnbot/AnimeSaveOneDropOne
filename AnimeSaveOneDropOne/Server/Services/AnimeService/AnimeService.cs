using AnimeSaveOneDropOne.Server.Data;
using AnimeSaveOneDropOne.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Services.AnimeService
{
    public class AnimeService : IAnimeService
    {
        private readonly DataContext _context;

        public AnimeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<AnimeMe>> GetAnimes()
        {
            return await _context.Animes.ToListAsync();
        }
    }
}
