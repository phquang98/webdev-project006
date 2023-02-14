using testDelAPI.Models;

namespace testDelAPI.Repositories
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemonClt();
    }
}
