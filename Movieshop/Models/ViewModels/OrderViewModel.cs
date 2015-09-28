using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {

        }

        public Order order { get; set; }
        public Customer customer { get; set; }
        public Movie movie { get; set; }

    }
}