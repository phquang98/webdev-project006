using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using testDelAPI.DTO;
using testDelAPI.Models;
using testDelAPI.Repositories;

namespace testDelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController: Controller
    {
        private readonly IPokemonRepository _pokeRepo;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokeRepoHere, IMapper mapperHere)
        {
            _pokeRepo = pokeRepoHere;
            _mapper = mapperHere;
        }

        // ---
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemonClt()
        {
            // NOTE: example using autoMapper
            // before autoMapper
            //var queryRslt = _pokeRepo.GetPokemonClt();

            // after autoMapper
            var queryRslt = _mapper.Map<List<PokemonDto>>(_pokeRepo.GetPokemonClt());

            // Console.WriteLine(queryRslt);
            //if (!ModelState.IsValid) {
            //    return BadRequest(ModelState);
            //}

            return Ok(queryRslt);
        }

        [HttpGet("{pokeIdHere}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetPokemon(int pokeIdHere)
        {
            if (!_pokeRepo.IsPokemonExists(pokeIdHere))
            {
                return NotFound();
            }

            var getOneRslt = _mapper.Map<PokemonDto>(_pokeRepo.GetPokemon(pokeIdHere));

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            return Ok(getOneRslt);
             
        }

        [HttpGet("{pokeIdHere}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetPokemonRating(int pokeIdHere)
        {
            if (!_pokeRepo.IsPokemonExists(pokeIdHere))
            {
                return NotFound();
            }

            var queryRslt = _pokeRepo.GetPokemonRating(pokeIdHere);

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}

            return Ok(queryRslt);
        }

    }
}
