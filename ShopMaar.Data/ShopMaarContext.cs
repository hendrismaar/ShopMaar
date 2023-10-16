using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopMaar.Core.Domain.Spaceship;

namespace ShopMaar.Data
{
    public class ShopMaarContext : DbContext
    {
        public ShopMaarContext(DbContextOptions<ShopMaarContext> options) : base(options){ }

        public DbSet<Spaceship> Spaceships { get; set; }
    }
}
