namespace testDelAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Review>? ReviewClt { get; set; }
        public ICollection<PokemonOwner> PokemonOwnerClt { get; set; }
        public ICollection<PokemonCategory> PokemonCategoryClt { get; set; }

    }
}
