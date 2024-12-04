using dress_rent.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dress_rent.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CriticismEntity> criticismlist { get; set; }
        public DbSet<CustomerEntity> customerlist { get; set; }
        public DbSet<DressEntity> dresslist { get; set; }
        public DbSet<Order_DetailsEntity> order_detailslist { get; set; }
        public DbSet<orderEntity> orderlist { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}



