using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClase
{
    public class Pedido : Producto
    {
        public double final { get; set; } 
        public double precio_producto {get ; set;}
        public string tipo_producto { get; set;}   
    }
}
