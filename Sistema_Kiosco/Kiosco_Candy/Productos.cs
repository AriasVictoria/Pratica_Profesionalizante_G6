using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosco_Candy
{
    public class Productos
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int stock { get; set; }
        public Proveedor NombreProvedor { get; set; }
        public string tipo_producto { get; set; }

        
    }
}
