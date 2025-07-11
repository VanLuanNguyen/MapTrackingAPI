using MapTrackingAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MapTrackingAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Device> Devices { get; set; }
    }
}
