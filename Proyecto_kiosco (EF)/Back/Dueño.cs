using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Dueño
    {
        [Key]
        public int DNI { get; set; }
        public int NombreDuenio { get; set; }
        public string ApellidoDuenio { get; set; }
        public string Contrasenia { get; set; }

    }
}
