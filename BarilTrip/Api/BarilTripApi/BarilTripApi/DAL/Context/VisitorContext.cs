using BarilTripApi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BarilTripApi.DAL.Context
{
    public class VisitorContext: DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=OZTURK;initial catalog=BarilTripDbApi;integrated security=true;");
        }

        public DbSet<Visitor> Visitors  { get; set; }
    }
}
