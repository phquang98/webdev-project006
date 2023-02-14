using Microsoft.AspNetCore.Mvc;

using testDelAPI.Models;
using testDelAPI.Repositories;

namespace testDelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController: Controller
    {
        private readonly IPokemonRepository _pokeRepo;
        public PokemonController(IPokemonRepository pokeRepoHere)
        {
            _pokeRepo = pokeRepoHere;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemonClt()
        {
            var queryRes = _pokeRepo.GetPokemonClt();
            Console.WriteLine(queryRes);
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            return Ok(queryRes);
        }
    }
}
