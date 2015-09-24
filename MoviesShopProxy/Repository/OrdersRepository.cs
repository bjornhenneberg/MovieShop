using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    class OrdersRepository
    {
        public void Add(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Order.Add(order);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Order> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Orders.ToList();
            }
        }

        public Order Read(int orderID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Order.ToList().FirstOrDefault(item => item.Id == orderID);
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
}
