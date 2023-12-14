using Back;
using Kiosco_Nuevo.Administrador;
using Kiosco_Nuevo.Vendedor;
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
            using (var context = new BaseDatos())
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    Usuarios usuarios = new Usuarios(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    if (usuarios != null && usuarios.contrasenia == textBox3.Text)
                    {
                        if (textBox4.Text == "Vendedor")
                        {
                            usuarios.tipo = textBox4.Text;
                        }
                        else
                        {
                            if (textBox4.Text == "Administrador")
                            {
                                usuarios.tipo = textBox4.Text;
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
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                var usuario = context.usuarios.FirstOrDefault(u => u.nombre == textBox1.Text);
                var usuario2 = context.usuarios.FirstOrDefault(u => u.apellido == textBox2.Text);

                if (usuario != null && usuario.contrasenia == textBox3.Text)
                {
                    if (usuario.tipo == "vendedor")
                    {
                        PantallaVendedor form = new PantallaVendedor();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        PantallaAdministradores form = new PantallaAdministradores();
                        form.Show();
                        this.Hide();
                    }
                    MessageBox.Show("El usuario o contraseña son incorrectos");
                }
                textBox1.Clear();
                textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
