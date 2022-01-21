using Microsoft.EntityFrameworkCore;
using challengeAlternativo.Entities;
namespace challengeAlternativo.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public  string Denomination { get; set; }
        public int Population { get; set; }
        public decimal Area { get; set; }

        //relacion con continente
        public Continent Continent { get; set; }

        //relacion con icono

        public ICollection<GeographicIcon> GeographicIcons { get; set; }

    }
}
