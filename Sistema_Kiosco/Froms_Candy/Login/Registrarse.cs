using Kiosco_Candy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Froms_Candy.Login
{
    public partial class Registrarse : Form
    {
        Principal principal = new Principal();
        public Registrarse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var context = new BaseDeDatos())
            {
                string usuarioIngresado = textBox1.Text;
                Dueño? usuarioEncontrado = context.Dueños.FirstOrDefault(c => c.NombreDuenio == usuarioIngresado);
                if (usuarioEncontrado == null)
                {
                    Dueño dueño = new Dueño();

                    dueño.DNI = int.Parse(textBox4.Text);
                    dueño.NombreDuenio = textBox1.Text;
                    dueño.ApellidoDuenio = textBox2.Text;
                    dueño.Contrasenia = textBox3.Text;

                    principal.AltaDueño(dueño);

                    MessageBox.Show("Se ha registrado con éxito");

                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya existe, intente con otro");
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingresar usuario = new Ingresar();
            usuario.Show();
            this.Hide();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
