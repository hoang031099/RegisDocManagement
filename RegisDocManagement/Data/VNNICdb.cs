using RegisDocManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace RegisDocManagement.Data
{
    public class VNNICdb : DbContext
    {
        protected readonly IConfiguration Configuration;

        public VNNICdb()
        {

        }
        public VNNICdb(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<RegistrarCompany> RegistrarCompanies { get; set; }
        public DbSet<RegistrarUser> RegistrarUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RegistrationDocument> RegistrationDocuments { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
