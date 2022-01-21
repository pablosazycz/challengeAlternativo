
using Microsoft.EntityFrameworkCore;
using challengeAlternativo.Entities;
namespace challengeAlternativo.Entities
{
    public class GeographicIcon
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }

       public DateTime CreationDate { get; set; }
        public int Height  { get; set; }

        public string History { get; set; }
        //relacion con ciudad
        public City City { get; set; }

    }
}
