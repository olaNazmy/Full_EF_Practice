using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;

namespace Full_EF_Practice
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        
        options.UseSqlServer(@"Data Source=OLA;Initial Catalog=EF_FullPractice;Integrated Security=True;Trust Server Certificate=True;");

            //add dbset
            public DbSet<Employee> Employees { get; set; }
    }
 }

