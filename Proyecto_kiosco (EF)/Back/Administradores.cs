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
        [Key]
        public int Id_Administrador { get; set; }
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }
        public string contraseña { get; set; }
       /* public string A
        {
            get { return "Nombre: " + NombreAdministrador + ", Apellido: " + ApellidoAdministrador + ", Contraseña: " + contraseña; }
        }
       */
    }
}
