using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RentACar.Models;

namespace RentACar.DAL
{
    class RentContext : DbContext
    {
        public RentContext() : base("RentACarDb")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels{ get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
