using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proyecto
{
    public class Proveedor
    {
        public int cuit { get; set; }
        public string NombreProvedor { get; set; }  
        public string ApellidoProvedor { get; set; }
        public string PV
        {
            get { return  ", nombre: " + NombreProvedor + ", Apellido: " + ApellidoProvedor ; }
        }
    }
}
