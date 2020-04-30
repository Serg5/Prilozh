using System.Collections.Generic;
using Prj.Entities;

namespace Prj.Repositories
{
    public class InMemoryZarpRepository : IZarpRepository
    {
        private List<MinZar> _zarp = new List<MinZar>{
             new MinZar {
                        MinZarId = 1,
                        Date = new Date{
                            DateId = 1,
                            Year = "2002",
                            month = Monthn.January
                        },
                        Act = new Act { Actname = "\"Московское трехстороннее соглашение на 2002 год между Правительством Москвы, московскими объединениями профсоюзов и московскими объединениями промышленников и предпринимателей (работодателей)\" от 04.12.2001",
                                         ActId = 1
                                        },
                        Zarplata = 1100
                    },
                    new MinZar {
                        MinZarId = 2,
                        Date = new Date{
                            DateId = 2,
                            Year = "2002",
                            month = Monthn.September
                        },
                        Act = new Act { Actname = "\"Московское трехстороннее соглашение на 2003 год между Правительством Москвы, московскими объединениями профсоюзов и московскими объединениями промышленников и предпринимателей (работодателей)\" от 13.12.2002",
                                         ActId = 2
                                        },
                        Zarplata = 1270
                    }
        };
      public IEnumerable<MinZar> GetAllZarps()
      {
          return _zarp;
      }
    }
}