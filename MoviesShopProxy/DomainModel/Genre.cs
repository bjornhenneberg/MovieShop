using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesShopProxy.DomainModel
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}