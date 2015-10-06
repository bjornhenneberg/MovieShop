using MoviesShopProxy.DomainModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopUser.Models
{
    public class OrderLine
    {
        [Key, Column(Order = 0)]
        public int Order_Id { get; set; }
        public int Amount { get; set; }
        [Key, Column(Order = 1)]
        public Movie Movie { get; set; }
    }
}