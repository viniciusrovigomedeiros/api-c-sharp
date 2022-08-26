using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.context
{
    public class WarrenContext : DbContext
    {
        #region Props

        #endregion
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Planta> Planta { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localHost;Port= 5433; Database=postgres;  UserId=postgres; password=123456");
        }

    }
}
