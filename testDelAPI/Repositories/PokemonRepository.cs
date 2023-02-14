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

        public ICollection<Pokemon> GetPokemonClt()
        {
            var a = _dataCtx.PokemonTable.OrderBy(p => p.Id).ToList();
            return a;
        }
    }
}
