﻿namespace testDelAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Country? Country { get; set; }
        public string? Gym { get; set; }
        public ICollection<PokemonOwner> PokemonOwnerClt { get; set; }
    }

}
