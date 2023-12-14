using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Usuarios
    {
        public string Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contrasenia { get; set; }
        public string tipo { get; set; }
        public Usuarios(string nombre, string apellido, string contrasenia, string tipo) 
        { 
            this.nombre = nombre;
            this.apellido = apellido;
            this.contrasenia = contrasenia;
            this.tipo = tipo;
        }

    }
}
