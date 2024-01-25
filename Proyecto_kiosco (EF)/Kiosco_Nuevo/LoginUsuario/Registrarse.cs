using Back;
using Kiosco_Nuevo.LoginUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco_Nuevo
{
    public partial class Registrarse : Form
    {
        Principal principal = new Principal();

        public Registrarse()
        {
            InitializeComponent();
        }
        private void butRegistro_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            principal.AltaUsuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            using (var context = new BaseDatos())
            {
                var usuario = context.usuarios.FirstOrDefault(u => u.nombre == textBox1.Text);

                if (usuario != null && usuario.contrasenia == textBox3.Text)
                {
                    if (textBox4.Text == "vendedor")
                    {
                        usuario.tipo = textBox4.Text;
                    }
                    else
                    {
                        if (textBox4.Text == "administrador")
                        {
                            usuario.tipo = textBox4.Text;
                        }
                        else
                        {
                            MessageBox.Show("El tipo ingresado es incorrecto");
                        }
                    }

                }
                context.SaveChanges();
                MessageBox.Show("Usuario registrado con exito");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            */

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            IngresarUsuario usuario = new IngresarUsuario();
            usuario.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
