using AnimeSaveOneDropOne.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeSaveOneDropOne.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<AnimeMe> Animes { get; set; }

        public DbSet<AnimeCharacter> AnimeCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimeMe>().HasData(
                new AnimeMe { MalId = 1, Name = "NDL Universe", Url = "ndl-universe", ImageUrl = "book", Description = "best anime" },
                new AnimeMe { MalId = 2, Name = "Naruto", Url = "naruto", ImageUrl = "leaf", Description = "dats my nindo" }
            );

            modelBuilder.Entity<AnimeCharacter>().HasData(
                new AnimeCharacter
                {
                    MalId = 1,
                    Name = "AMN",
                    ImageUrl = "https://fiverr-res.cloudinary.com/images/q_auto,f_auto/gigs/149470781/original/cf87ada92b21431ab6418eeae2aac47aa6502d56/draw-cool-anime-or-manga-style-characters-fan-art-or-oc.png",
                    Points = 0,
                    Rank = 1,
                    PreviousRank = 2,
                    AnimeMalId = 1
                },
                new AnimeCharacter
                {
                    MalId = 2,
                    Name = "Naruto",
                    ImageUrl = "https://cdn.myanimelist.net/images/characters/2/284121.jpg",
                    Points = 0,
                    Rank = 2,
                    PreviousRank = 2,
                    AnimeMalId = 1
                }
        );
        }
    }
}
