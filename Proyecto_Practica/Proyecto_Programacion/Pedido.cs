using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class Pedido : Producto
    {
        public double MontoFinal { get; set; }
        public double Precio_Producto { get; set; }
        public string Tipo_Producto { get; set; }
        public string PD
        {
            get { return " Monto: " + MontoFinal + ", precio: " + Precio_Producto + "Tipo: " + Tipo_Producto; }
        }
    }
}
