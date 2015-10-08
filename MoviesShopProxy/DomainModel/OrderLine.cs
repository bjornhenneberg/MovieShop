using MoviesShopProxy.DomainModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopUser.Models
{
    public class OrderLine
    {
        [Key]
        public int Order_Id { get; set; }

        public int Amount { get; set; }
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
    }
}