using System.Collections.Generic;
using Prj.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Prj.Repositories
{
    public class DatabaseZarpRepository : IZarpRepository
    {
       private readonly ZarpsContext _zarps;

       public DatabaseZarpRepository(ZarpsContext zarps)
       {
           _zarps = zarps;
       }
      public IEnumerable<MinZar> GetAllZarps()
      {
          return _zarps.Zarps.ToList();
      }
    }

    public class ZarpsContext : DbContext
    {
        public DbSet<MinZar> Zarps {get; set; }

        public ZarpsContext (DbContextOptions options)
                :base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Act>().HasData(
                new Act{ActId = 1, Actname = "\"Московское трехстороннее соглашение на 2002 год между Правительством Москвы, московскими объединениями профсоюзов и московскими объединениями промышленников и предпринимателей (работодателей)\" от 04.12.2001"},
                new Act{ActId = 2, Actname = "\"Московское трехстороннее соглашение на 2003 год между Правительством Москвы, московскими объединениями профсоюзов и московскими объединениями промышленников и предпринимателей (работодателей)\" от 15.12.2002"}
            );

            modelBuilder.Entity<Date>().HasData(
                new Date{DateId = 1,
                            Year = "2002",
                            month = Monthn.January},
                 new Date{DateId = 2,
                            Year = "2002",
                            month = Monthn.September}
            );

            modelBuilder.Entity<MinZar>().HasOne(z => z.Act);

            modelBuilder.Entity<MinZar>().HasData(
                new MinZar {
                    MinZarId = 1,
                        DateId = 1,
                        ActId = 1,
                        Zarplata = 1100
                },
                new MinZar {
                        MinZarId = 2,
                       DateId = 2,
                        ActId = 2,
                        Zarplata = 1270
                    }
                );

        }
    }
}