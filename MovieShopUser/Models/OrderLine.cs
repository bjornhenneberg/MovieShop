using MoviesShopProxy.DomainModel;

namespace MovieShopUser.Models
{
    public class OrderLine
    {
        public int Amount { get; set; }
        public Movie Movie { get; set; }
    }
}