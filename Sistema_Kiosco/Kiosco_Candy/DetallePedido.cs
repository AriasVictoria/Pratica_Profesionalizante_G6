using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosco_Candy
{
    public class DetallePedido
    {
        public Productos Id { get; set; }
        public Dueño NombreDuenio { get; set; }
        [Key]
        public int numeropedido { get; set; }
        public string NombreProducto { get; set; }
        public string tipo_producto { get; set; }
        public int Cantidad_Producto { get; set; }
        public int Precio_Producto { get; set; }
        public DateTime Fecha_Pedido { get; set; }
    }
}
