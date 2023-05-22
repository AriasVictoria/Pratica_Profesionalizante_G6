using LogicaClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibloteca
{
    public class Dueño : Usuario
    {
        public int id{ get; set; }
        public string nombre_dueño { get; set; }    
        public Usuario usuariodueño { get; set; }
        public override string validarUsuario()
        {
            return "hecho";
        }
    }
}
