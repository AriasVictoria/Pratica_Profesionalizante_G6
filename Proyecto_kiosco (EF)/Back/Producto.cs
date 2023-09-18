using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int Precio { get; set; }
        public int stock { get; set; }
        public Proveedor producto_proveedor { get; set; }
        /*public string P
        {
            get { return "id: " + Id + ", nombre: " + NombreProducto + ", precio: " + Precio + "stock: " + stock; }
        }
        */
    }
}
