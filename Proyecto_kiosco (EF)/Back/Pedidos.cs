using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Pedidos
    {
        public int Id { get; set; }
        public Vendedores NombreVendedor { get; set; }


        /*public string PD
        {
            get { return " Monto: " + MontoFinal + ", precio: " + Precio_Producto; }
        }
        */
    }
}
