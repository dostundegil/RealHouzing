using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Concrate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-QEJG79H\\MSSQLSERVER01;initial catalog=RealHouzingApiDB;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Featues> Featuess { get; set; }
        public DbSet<ContactUs> ContactUss { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PropertyFeatures> PropertyFeatures { get; set; }
        public DbSet<ProductPropertyFeatures> ProductPropertyFeaturess { get; set; }
    }
}
