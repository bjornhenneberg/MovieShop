using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class OrderRepository
    {
        public void Add(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Orders.Add(order);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Order> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Orders.Include("Customer").Include("Movies").ToList();
            }
        }

        public Order Read(int orderID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Orders.ToList().FirstOrDefault(item => item.Id == orderID);
            }
        }

        public void Update(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var orderDB in ctx.Orders.ToList())
                {
                    if (order.Id == orderDB.Id)
                    {
                        orderDB.Customer = order.Customer;
                        orderDB.Movies = order.Movies;
                        orderDB.Date = order.Date;
                        ctx.SaveChanges();
                    }
                }
            }
        }

        public void Delete(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var orderDB in ctx.Orders.ToList())
                {
                    if (order.Id == orderDB.Id)
                    {
                        ctx.Orders.Remove(orderDB);
                        ctx.SaveChanges();
                    }
                }
            }
        }

    }
}

