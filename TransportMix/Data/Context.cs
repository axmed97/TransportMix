using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportMix.Models;

namespace TransportMix.Data
{
    public class Context:IdentityDbContext<AppUser>
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
                
        }
        public DbSet<News> News { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Emailnfos> Emailnfos { get; set; }
        public DbSet<AutoSalon> AutoSalons { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<AutoService> AutoServices { get; set; }
        public DbSet<Master> Masters { get; set; }
    }
}
