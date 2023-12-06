using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class DetallePedido
    {
        public Pedidos Id { get; set; }
        public Productos Id_Producto { get; set; }
        [Key]
        public string codigo_barra { get; set; }
        public string NombreProducto { get; set; }
        public string tipo_producto { get; set; }
        public int Cantidad_Producto { get; set; }
        public int Precio_Producto { get; set; }
        public int MontoFinal { get; set; }
        public DateTime Fecha_Pedido { get; set; }


    }
}
