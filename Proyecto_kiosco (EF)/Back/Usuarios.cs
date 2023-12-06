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

        public static bool ValidarUsuario(string nombre, string apellido, string contrasenia, string tipo)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Kiosco_Base;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Nombre=@Nombre AND Apellido=@Apellido AND Contrasena=@Contrasena AND TipoUsuario=@TipoUsuario", conn);
            cmd.Parameters.AddWithValue("Nombre", nombre);
            cmd.Parameters.AddWithValue("Apellido", apellido);
            cmd.Parameters.AddWithValue("Contrasena", contrasenia);
            cmd.Parameters.AddWithValue("TipoUsuario", tipo);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
