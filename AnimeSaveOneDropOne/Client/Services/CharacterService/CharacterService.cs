using AnimeSaveOneDropOne.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Client.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly HttpClient _http;

        public List<AnimeCharacter> AnimeCharacters { get; set; } = new List<AnimeCharacter>();

        public CharacterService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadAnimeCharacters()
        {
            AnimeCharacters = await _http.GetFromJsonAsync<List<AnimeCharacter>>("api/Character");
        }
        public async Task<AnimeCharacter> GetAnimeCharacter(int Id)
        {
            return await _http.GetFromJsonAsync<AnimeCharacter>($"api/Character/{Id}");
        }

        public async Task CreateAnimeCharacter(AnimeCharacter animeCharacter)
        {
            await _http.PostAsJsonAsync("api/Character", animeCharacter);
        }

        public async Task UpdateAnimeCharacter(AnimeCharacter animeCharacter)
        {
            await _http.PutAsJsonAsync("api/Character", animeCharacter);
        }
    }
}
