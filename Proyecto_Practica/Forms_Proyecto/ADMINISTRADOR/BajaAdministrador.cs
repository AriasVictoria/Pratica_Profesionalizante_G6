using Proyecto_Programacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_Proyecto
{
    public partial class BajaAdministrador : Form
    {
        Principal principal = new Principal();
        public BajaAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrador seleccionado = (Administrador)listBox1.SelectedItem;

            principal.BajaAdministrador(seleccionado);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "A";
            listBox1.DataSource = principal.ListaAdministrador;

            MessageBox.Show("Administrador eliminado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrador seleccionado = (Administrador)listBox1.SelectedItem;

            Administrador administrador1 = new Administrador();

            administrador1.NombreAdministrador = textBox1.Text;
            administrador1.ApellidoAdministrador = textBox2.Text;
            administrador1.contraseña = textBox3.Text;

            principal.ModificarAdministrador(administrador1, seleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "A";
            listBox1.DataSource = principal.ListaAdministrador;
            MessageBox.Show("Modificado con exito ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrador administrador1 = new Administrador();

            administrador1.NombreAdministrador = textBox1.Text;
            administrador1.ApellidoAdministrador = textBox2.Text;
            administrador1.contraseña = textBox3.Text;

            principal.AltaAdministrador(administrador1);


            listBox1.DataSource = null;
            listBox1.DisplayMember = "A";
            listBox1.DataSource = principal.ListaAdministrador;
            MessageBox.Show("Admiinistrador guardado");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void BajaAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
