using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    class CustomerRepository
    {
        public void Add(Customer customer)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Customers.Add(customer);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Customer> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Customers.ToList();
            }
        }

        public Customer Read(int customerID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Customers.ToList().FirstOrDefault(item => item.Id == customerID);
            }
        }

        public void Update(Customer customer)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var customerDB in ctx.Customers.ToList())
                {
                    if (customer.Id == customerDB.Id)
                    {
                        customerDB.FirstName = customer.FirstName;
                        customerDB.LastName = customer.LastName;
                        customerDB.Email = customer.Email;
                        customerDB.Adress = customer.Adress;
                        ctx.SaveChanges();
                    }
                }
            }
        }

        public void Delete(Customer customer)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var customerDB in ctx.Customers.ToList())
                {
                    if (customer.Id == customerDB.Id)
                    {
                        ctx.Customers.Remove(customerDB);
                        ctx.SaveChanges();
                    }
                }
            }
        }

    }
}
