using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int Precio { get; set; }
        public int strock { get; set; }

        public static List<Producto> BaseProductos;
        public static void removeThisMarca(Producto eliminarProducto)
        {
            dameProducto().Remove(eliminarProducto);
        }

        public static List<Producto> dameProducto()
        {
            List<Producto> ListaProductos = new List<Producto>();

            if (BaseProductos == null)
            {
                BaseProductos = new List<Producto>();

                Producto producto1 = new Producto();
                producto1.Id = 1;
                producto1.NombreProducto = "Mayonesa";
                producto1.Precio = 590;
                BaseProductos.Add(producto1);

                Producto producto2 = new Producto();
                producto2.Id = 2;
                producto2.NombreProducto = "Aceite";
                producto2.Precio = 680;
                BaseProductos.Add(producto2);

                Producto producto3 = new Producto();
                producto3.Id = 4;
                producto3.NombreProducto = "Gaseosa";
                producto3.Precio = 750;
                BaseProductos.Add(producto3);

                Producto producto4 = new Producto();
                producto4.Id = 4;
                producto4.NombreProducto = "Caramelos";
                producto4.Precio = 20;
                BaseProductos.Add(producto4);

            }
            return BaseProductos;
        }
    }
}
