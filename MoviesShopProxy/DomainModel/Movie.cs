using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.DomainModel
{
    [Table("MovieIsOverrated")]
    public class Movie
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public double Price { get; set; }
        public string imageURL { get; set; }
        public string trailerURL { get; set; }
        public Genre genre { get; set; }
    }
}
