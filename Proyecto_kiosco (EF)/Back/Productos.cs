using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Productos
    {
        [Key]
        public int Id_Producto { get; set; }
        public string NombreProducto { get; set; }
        public int stock { get; set; }
        public Proveedores NombreProvedor { get; set; }
        public string tipo_producto { get; set; }
        public static List<string> Tipo_producto()
        {
            List<string> milista = new List<string>();

            milista.Add("Golosina");
            milista.Add("Lacteos");
            milista.Add("Canasta Familiar");
            return milista;
        }
        public static List<Productos> BaseProducto;
        
        public static List<Productos> darmeProducto()
        {
            List<Productos> listita = new List<Productos>();

            if (BaseProducto == null)
            {
                BaseProducto = new List<Productos>();

                Productos producto1 = new Productos();
                producto1.NombreProducto = "Caramelo";
                producto1.tipo_producto = "Golosina";
                BaseProducto.Add(producto1);

                Productos producto2 = new Productos();
                producto2.NombreProducto = "Leche";
                producto2.tipo_producto = "Lacteo";
                BaseProducto.Add(producto2);

                Productos producto3 = new Productos();
                producto3.NombreProducto = "Masitas";
                producto3.tipo_producto = "Canasta familiar";
                BaseProducto.Add(producto3);

            }
            return BaseProducto;

        }
    }
}
