using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopMaar.Core.Domain;

namespace ShopMaar.Data
{
    public class ShopMaarContext : DbContext
    {
        public ShopMaarContext(DbContextOptions<ShopMaarContext> options) : base(options){ }

        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToDatabase> FilesToDatabase { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileToApi> FilesToApi { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
