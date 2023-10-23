using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Proveedores
    {
        [Key]
        public int Id { get; set; }
        public string cuit { get; set; }
        public string NombreProvedor { get; set; }
        public string ApellidoProvedor { get; set; }
        /*public string PV
        {
            get { return ", nombre: " + NombreProvedor + ", Apellido: " + ApellidoProvedor; }
        }
        */
    }
}
