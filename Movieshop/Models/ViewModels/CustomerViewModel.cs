using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> customers { get; set; }
        public List<Adress> adresses { get; set; }
    }
}