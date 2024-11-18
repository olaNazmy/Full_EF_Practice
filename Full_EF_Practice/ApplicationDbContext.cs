using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using System.Reflection.Metadata;
using Full_EF_Practice.Models;
using Full_EF_Practice.Configurations;

namespace Full_EF_Practice
{
    public class ApplicationDbContext : DbContext
    {
        //override on Configuring
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        
        options.UseSqlServer(@"Data Source=OLA;Initial Catalog=EF_FullPractice;Integrated Security=True;Trust Server Certificate=True;");

        //override on modelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());

            //Same as above
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogEntityTypeConfiguration).Assembly);
        }

        //Add Blog Model
        public DbSet<Blog> Blogs { set; get; }

    }
 }

