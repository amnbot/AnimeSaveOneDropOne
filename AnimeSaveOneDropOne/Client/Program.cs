using AnimeSaveOneDropOne.Client.Services.AnimeService;
using AnimeSaveOneDropOne.Client.Services.CharacterService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<ICharacterService, CharacterService>();
            builder.Services.AddScoped<IAnimeService, AnimeService>();

            await builder.Build().RunAsync();
        }
    }
}
