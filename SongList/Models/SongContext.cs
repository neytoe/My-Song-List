using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongList.Models
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options):
            base(options)
        {

        }

       public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongID =1,
                    Name = "Love is Blind",
                    year=1980,
                    Rating = 5
                },
                 new Song
                 {
                     SongID = 2,
                     Name = "Love is Bitter",
                     year = 1981,
                     Rating = 4
                 },
                  new Song
                  {
                      SongID = 3,
                      Name = "Love is Sour",
                      year = 1983,
                      Rating = 3
                  }
                );
        }
    }
}
