using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class BaseDatos : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Proveedores> proveedores { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Administradores> Administradores { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Usuarios> Usuarios{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=VARIAS\\SQLEXPRESS;database=Kiosco_Base;trusted_connection=true;Encrypt=False");
        }
       
    }
}
