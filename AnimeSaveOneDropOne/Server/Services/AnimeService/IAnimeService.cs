using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Services.AnimeService
{
    public interface IAnimeService
    {
        Task<List<AnimeMe>> GetAnimes();
    }
}
