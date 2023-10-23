using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Vendedores
    {
        [Key]
        public int numerolegajo { get; set; }
        public string NombreVendedor { get; set; }
        public string ApellidoVendedor { get; set; }
        public string contraseñaV { get; set; }

        /*public string V
        {
            get { return ", Numero legajo:" + numerolegajo + "Nombre: " + NombreVendedor + ", Apellido: " + ApellidoVendedor + ", Contraseña: " + contraseñaV; }
        }
        */
    }
}
