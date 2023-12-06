using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Administradores
    {
        public int Id { get; set; }
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }
        public string contrasenia { get; set; }
       /* public string A
        {
            get { return "Nombre: " + NombreAdministrador + ", Apellido: " + ApellidoAdministrador + ", Contraseña: " + contraseña; }
        }
       */
    }
}
