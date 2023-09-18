using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proyecto
{
    public class Pedido 
    {
        public double MontoFinal { get; set; }
        public double Precio_Producto { get; set; }
        public Producto pedido { get; set; }
        public string PD
        {
            get { return " Monto: " + MontoFinal + ", precio: " + Precio_Producto; }
        }
    }
}
