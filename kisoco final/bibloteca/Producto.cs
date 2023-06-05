using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClase
{
    public class Producto
    {
        public int Id { get; set; }
        public string nombrep { get; set; }
        public string codigo_barra { get; set; }
        public int precio_producto { get; set; }
        public string tipo_producto { get; set; }
        public int stock { get; set; }
    }
}
