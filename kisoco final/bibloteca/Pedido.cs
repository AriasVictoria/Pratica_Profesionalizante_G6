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
        public string lpedido { get; set; }
        public int cantidad { get; set; }
        public double calcularMonto()
        {
            return final * cantidad;
        }
    }
}
