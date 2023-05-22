using LogicaClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibloteca
{
    public class Vendedor : Usuario
    {
        public int Id { get; set; }
        public string Nombre_vendedor { get; set; }
        public Usuario usuariovendedor{ get; set; }
        public override string validarUsuario()
        {
            return "hecho";
        }
    }
}
