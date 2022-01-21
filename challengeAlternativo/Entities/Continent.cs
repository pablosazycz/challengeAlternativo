using Microsoft.EntityFrameworkCore;
using challengeAlternativo.Entities;
namespace challengeAlternativo.Entities
{
    public class Continent
    {
        public int id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }

        //relacion con ciudad

        public ICollection<City> Cities { get; set; }

    }
}
