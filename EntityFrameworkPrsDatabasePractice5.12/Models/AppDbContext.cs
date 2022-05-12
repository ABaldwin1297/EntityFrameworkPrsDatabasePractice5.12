using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace EntityFrameworkPrsDatabasePractice5._12.Models {
    public class AppDbContext : DbContext {

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestLine> RequestLines { get; set; } = null!;


        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;"
                        + "database=MiniPrsDb;"
                        + "trustServerCertificate=true;"
                        + "trusted_connection=true;";
            builder.UseSqlServer(connStr);
        }
    }
}
