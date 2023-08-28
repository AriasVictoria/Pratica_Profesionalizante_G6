using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class Vendedor
    {
        public string NombreVendedor { get; set; }
        public string ApellidoVendedor { get; set; }
        public string contraseñaV { get; set; }
        public string V
        {
            get { return "Nombre: " + NombreVendedor + ", Aoellido: " + ApellidoVendedor + ", Contraseña: " + contraseñaV; }
        }
    }
}
