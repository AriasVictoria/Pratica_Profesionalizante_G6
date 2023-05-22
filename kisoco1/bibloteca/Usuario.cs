using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClase
{
    public abstract class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }    
        public string contraseña { get; set; }
        public string tipo { get; set;}
        public abstract string validarUsuario();
       
    }
}
