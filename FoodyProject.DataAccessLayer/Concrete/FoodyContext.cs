﻿using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DataAccessLayer.Concrete
{
    public class FoodyContext :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J62NR14; Initial Catalog=FoodyDb1; integrated Security=true; TrustServerCertificate = true");
        }
       
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<MoneyCase> MoneyCases { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
