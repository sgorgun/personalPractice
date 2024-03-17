﻿using ContosoPizza.Models;
using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;


namespace ContosoPizza.Data
{
    public class ContosoPizzaContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Connection string here");
        }
    }
}