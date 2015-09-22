using System.Collections.Generic;

namespace MoviesShopProxy.DomainModel
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}