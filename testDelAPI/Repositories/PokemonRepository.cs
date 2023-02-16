using testDelAPI.Data;
using testDelAPI.Models;

namespace testDelAPI.Repositories
{
    public class PokemonRepository: IPokemonRepository
    {

        private readonly DataContext _dataCtx;

        public PokemonRepository(DataContext dataCtxHere)
        {
            _dataCtx = dataCtxHere;
        }

        public Pokemon GetPokemon(int idHere)
        {
            return _dataCtx.PokemonTable.Where(poke => poke.Id == idHere).FirstOrDefault();
        }

        public Pokemon GetPokemon(string nameHere)
        {
            return _dataCtx.PokemonTable.Where(poke => poke.Name == nameHere).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonClt()
        {
            var a = _dataCtx.PokemonTable.OrderBy(p => p.Id).ToList();
            return a;
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var queryRes = _dataCtx.ReviewTable.Where(poke => poke.Pokemon.Id == pokeId);

            if (queryRes.Count() <= 0)
            {
                return 0;
            }

            return ((decimal)queryRes.Sum(ele => ele.Rating) / queryRes.Count());
        }

        public bool IsPokemonExists(int pokeId)
        {
            return _dataCtx.PokemonTable.Any(poke => poke.Id == pokeId);
        }
    }
}
