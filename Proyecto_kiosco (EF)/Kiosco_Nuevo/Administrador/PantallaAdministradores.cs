using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosco_Nuevo.Administrador
{
    public partial class PantallaAdministradores : Form
    {
        Principal principal = new Principal();
        public PantallaAdministradores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back.Administradores administrador2 = new Back.Administradores();

            administrador2.Id_Administrador = int.Parse(textBox1.Text);
            administrador2.NombreAdministrador = textBox2.Text;
            administrador2.ApellidoAdministrador = textBox3.Text;
            administrador2.contraseña = textBox4.Text;

            principal.AltaAdmnistradores(administrador2);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = administrador2;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("agregado con exito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back.Administradores seleccionado = (Back.Administradores)dataGridView1.CurrentRow.DataBoundItem;
            principal.EliminarAdministrador(seleccionado);

            BindingSource aBind = new BindingSource();
            aBind.Remove(seleccionado);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            MessageBox.Show("Eliminado con exito ");
        }

        private void PantallaAdministradores_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                List<Back.Administradores> administrador1 = context.Administradores.ToList();

                dataGridView1.DataSource = administrador1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back.Administradores seleccionado = (Back.Administradores)dataGridView1.CurrentRow.DataBoundItem;

            Back.Administradores administrador2 = new Back.Administradores();

            administrador2.Id_Administrador = int.Parse(textBox1.Text);
            administrador2.NombreAdministrador = textBox2.Text;
            administrador2.ApellidoAdministrador = textBox3.Text;
            administrador2.contraseña = textBox4.Text;

            principal.ActucalizarAdministrador(administrador2);

            BindingSource aBind = new BindingSource();
            aBind.Add(administrador2);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Modificado con exito ");
        }
    }
}
