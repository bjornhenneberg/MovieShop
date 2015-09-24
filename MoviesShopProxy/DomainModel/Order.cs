﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.DomainModel
{
    [Table("Order")]

    public class Order
    {
        [Key]
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Movie> Movies { get; set; }
        public DateTime Date { get; set; }
    }
}
