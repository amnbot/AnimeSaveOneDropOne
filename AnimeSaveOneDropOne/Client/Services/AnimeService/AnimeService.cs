using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Client.Services.AnimeService
{
    public class AnimeService : IAnimeService
    {
        private readonly HttpClient _http;

        public List<AnimeMe> Animes { get; set; } = new List<AnimeMe>();

        public AnimeService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadAnimes()
        {
            Animes = await _http.GetFromJsonAsync<List<AnimeMe>>("api/Anime");
        }
    }
}
