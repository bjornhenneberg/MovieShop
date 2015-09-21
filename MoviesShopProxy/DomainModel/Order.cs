using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.DomainModel
{
    class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Movie> Movies { get; set; }
        public DateTime Date { get; set; }
    }
}
