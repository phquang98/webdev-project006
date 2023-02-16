using testDelAPI.Models;

namespace testDelAPI.Repositories
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemonClt();

        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);

        bool IsPokemonExists(int pokeId);
    }
}
