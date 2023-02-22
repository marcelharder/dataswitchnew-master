using api.Model;
using api.Model.maria_models;
using Microsoft.EntityFrameworkCore;

namespace dataswitch.Model.maria_models
{
    public class MariaContext : BaseContext
    {
        public MariaContext(DbContextOptions<MariaContext> options) : base(options)
        {
        }

        public DbSet<Class_Procedure> Procedures { get; set; }
        public DbSet<Class_Patient> Patients { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}