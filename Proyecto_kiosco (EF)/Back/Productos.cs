using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Productos
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int Precio { get; set; }
        public int stock { get; set; }
        public string tipo_producto { get; set; }

        public static List<Productos> BaseProducto;
        public static void removeThisProducto(Productos ProductoBorrar)
        {
            darmeProducto().Remove(ProductoBorrar);
        }
        public static List<Productos> darmeProducto()
        {
            List<Productos> listita = new List<Productos>();

            if (BaseProducto == null)
            {
                BaseProducto = new List<Productos>();

                Productos producto1 = new Productos();
                producto1.Id = 1;
                producto1.NombreProducto = "Caramelo";
                producto1.Precio = 10;
                producto1.stock = 20;
                producto1.tipo_producto = "Dulces";
                BaseProducto.Add(producto1);

                Productos producto2 = new Productos();
                producto2.Id = 2;
                producto2.NombreProducto = "Leche";
                producto2.Precio = 250;
                producto2.stock = 25;
                producto2.tipo_producto = "Lacteo";
                BaseProducto.Add(producto2);

                Productos producto3 = new Productos();
                producto3.Id = 3;
                producto3.NombreProducto = "Masitas";
                producto3.Precio = 180;
                producto3.stock = 15;
                producto3.tipo_producto = "Canasta familiar";
                BaseProducto.Add(producto3);

            }
            return BaseProducto;
        }
    }
}
