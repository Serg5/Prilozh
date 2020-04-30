using System.Collections.Generic;
using Prj.Entities;

namespace Prj.Repositories
{
    public interface IZarpRepository
    {
        IEnumerable <MinZar> GetAllZarps();
    }
}