using Froms_Candy.Login;
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

namespace Froms_Candy
{
    public partial class Ingresar : Form
    {
        Principal principal = new Principal();
        public Ingresar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                string UsuarioIngresado = textBox1.Text;
                string ContraseniaIngresada = textBox3.Text;

                Dueño? Dueñoencontrador = context.Dueños.FirstOrDefault(a => a.NombreDuenio == UsuarioIngresado);
                if (Dueñoencontrador != null)
                {
                    if (ContraseniaIngresada == Dueñoencontrador.Contrasenia)
                    {
                        Pantalla_Usuario dueño = new Pantalla_Usuario();
                        dueño.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos, intente nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intente nuevamente");
                }
            }
            
            /*
            using (var context = new BaseDeDatos())
            {
                var usuario = context.Dueños.FirstOrDefault(u => u.DNI == int.Parse(textBox4.Text));

                if (usuario != null && usuario.Contrasenia == textBox3.Text)
                {
                    Pantalla_Usuario form = new Pantalla_Usuario();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();
            }
            */
        }
    }
}
