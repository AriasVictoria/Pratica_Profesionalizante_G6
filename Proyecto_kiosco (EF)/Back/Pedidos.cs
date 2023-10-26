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
        [Key]
        public int Id { get; set; }
        public double Precio_Producto { get; set; }
        public double MontoFinal { get; set; }
        
        /*public string PD
        {
            get { return " Monto: " + MontoFinal + ", precio: " + Precio_Producto; }
        }
        */
    }
}
