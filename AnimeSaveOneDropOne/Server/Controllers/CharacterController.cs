using AnimeSaveOneDropOne.Server.Services.CharacterService;
using AnimeSaveOneDropOne.Shared;
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
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AnimeCharacter>>> GetAllAnimeCharacters()
        {
            return Ok(await _characterService.GetAllAnimeCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AnimeCharacter>> GetAnimeCharacter(int Id)
        {
            return Ok(await _characterService.GetAnimeCharacter(Id));
        }
    }
}
