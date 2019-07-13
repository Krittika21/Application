using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Models
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.User> User { get; set; }
        public DbSet<WebApplication1.Models.TestDetails> TestDetails { get; set; }
        public DbSet<TestType> TestType { get; set; }
        public DbSet<UserTestMapping> UserTestMapping { get; set; }
        public DbSet<TestTypeMapping> TestTypeMapping { get; set; }
    }
}