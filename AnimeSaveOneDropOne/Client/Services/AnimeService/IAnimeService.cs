using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Client.Services.AnimeService
{
    interface IAnimeService
    {
        public List<AnimeMe> Animes { get; set; }

        Task LoadAnimes();
    }
}
