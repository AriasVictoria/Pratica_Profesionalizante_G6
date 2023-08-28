using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int Precio { get; set; }
        public int stock { get; set; }
        public string P
        {
            get { return "id: " + Id + ", nombre: " + NombreProducto + ", precio: " + Precio + "stock: " + stock; }
        }
    }
}
