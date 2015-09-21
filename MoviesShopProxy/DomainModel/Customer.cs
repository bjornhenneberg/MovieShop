using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.DomainModel
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adress Adress { get; set; }
        public string Email { get; set; }
    }
}
