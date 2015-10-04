using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            GetAddresses = new List<Adress>();
        }
        public Customer Customer { get; set; }
        public List<Adress> GetAddresses { get; set; }
    }
}