using Microsoft.EntityFrameworkCore;
using testDelAPI.Models;

// brings in all the info, tied the db together -> ctx obj ->? quickyly access all the table
namespace testDelAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> sqlServerOpts) : base(sqlServerOpts) { }


        // tell DbContext what is the name of the tables, will be used by Tools Add-Migrations for the names
        public DbSet<Category> CategoryTable { get; set; }
        public DbSet<Country> CountryTable { get; set; }
        public DbSet<Owner> OwnerTable { get; set; }
        public DbSet<Pokemon> PokemonTable { get; set; }
        public DbSet<PokemonOwner> PokemonOwnerTable { get; set; }
        public DbSet<PokemonCategory> PokemonCategoryTable { get; set; }
        public DbSet<Review> ReviewTable { get; set; }
        public DbSet<Reviewer> ReviewerTable { get; set; }

        // in m-m, have to manipulate tables in certain ways, customize tables sometimes -> this make it works
        // in times, need tables customization in code
        protected override void OnModelCreating(ModelBuilder mBuilder)
        {
            mBuilder.Entity<PokemonCategory>().
                HasKey(pokeCate => new { pokeCate.PokemonId, pokeCate.CategoryId });
            mBuilder.Entity<PokemonCategory>()
                .HasOne(poke => poke.Pokemon)
                .WithMany(pokeCate => pokeCate.PokemonCategoryClt)
                .HasForeignKey(poke => poke.PokemonId);
            mBuilder.Entity<PokemonCategory>()
                .HasOne(poke => poke.Category)
                .WithMany(pokeCate => pokeCate.PokemonCategoryClt)
                .HasForeignKey(poke => poke.CategoryId);

            mBuilder.Entity<PokemonOwner>()
                .HasKey(pokeOwn => new { pokeOwn.PokemonId, pokeOwn.OwnerId });
            mBuilder.Entity<PokemonOwner>()
                .HasOne(poke => poke.Pokemon)
                .WithMany(pokeCate => pokeCate.PokemonOwnerClt)
                .HasForeignKey(poke => poke.PokemonId);
            mBuilder.Entity<PokemonOwner>()
                .HasOne(poke => poke.Owner) 
                .WithMany(pokeCate => pokeCate.PokemonOwnerClt)
                .HasForeignKey(poke => poke.OwnerId);

        }

        


    }
}
