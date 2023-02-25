using Core.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Cities> cities { get; set; }
        public DbSet<Newsletter> newsletters { get; set; }

    }
}
