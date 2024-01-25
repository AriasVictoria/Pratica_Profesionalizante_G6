using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosco_Candy
{
    public  class BaseDeDatos : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Dueño> Dueños { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=VARIAS\\SQLEXPRESS;database=Kiosco;trusted_connection=true;Encrypt=False");
        }

    }
}
