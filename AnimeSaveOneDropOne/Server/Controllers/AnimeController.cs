using AnimeSaveOneDropOne.Server.Services.AnimeService;
using AnimeSaveOneDropOne.Shared;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeService _animeService;

        public AnimeController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AnimeMe>>> GetAnimes()
        {
            return Ok(await _animeService.GetAnimes());
        }
    }
}
