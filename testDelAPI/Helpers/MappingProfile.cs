using AutoMapper;

using testDelAPI.DTO;
using testDelAPI.Models;

namespace testDelAPI.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
