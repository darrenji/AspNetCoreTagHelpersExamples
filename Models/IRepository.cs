using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTagHelpersExamples.Models
{
    public interface IRepository
    {
        IEnumerable<City> Cites { get; }
        void AddCity(City newCity);
    }
}
