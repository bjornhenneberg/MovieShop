using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models
{
    public class ShoppingCart
    {
        public List<OrderLine> lines { get; set; }
        public DateTime Created { get; set; }
        public void AddLine(OrderLine line)
        {
            lines.Add(line);
        }
        public void RemoveLine(OrderLine line)
        {
            lines.Remove(line);
        }
    }
}