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
        public Dueño UsuarioDueño{ get; set; }
    }
}
