using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Services.AnimeService
{
    public class AnimeService : IAnimeService
    {
        public List<AnimeMe> Animes { get; set; } = new List<AnimeMe>
            {
                new AnimeMe {MalId = 1, Name = "NDL Universe", Url = "ndl-universe", ImageUrl = "book", Description="best anime"},
                new AnimeMe {MalId = 2, Name = "Naruto", Url = "naruto", ImageUrl = "leaf", Description="dats my nindo"},
            };
        public async Task<List<AnimeMe>> GetAnimes()
        {
            return Animes;
        }
    }
}
