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

            administrador2.NombreAdministrador = textBoxNombre.Text;
            administrador2.ApellidoAdministrador = textBoxApellido.Text;
            administrador2.contrasenia = textBoxContrasenia.Text;

            principal.AltaAdmnistradores(administrador2);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = administrador2;
            dataGridView1.DataSource = aBind;

            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxContrasenia.Clear();
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

            MessageBox.Show("Eliminado con exito ");
            BindingSource aBind = new BindingSource();
            //aBind.Remove(seleccionado);
            dataGridView1.DataSource = aBind;
            using (var context = new BaseDatos())
            {
                List<Back.Administradores> administrador1 = context.Administradores.ToList();

                dataGridView1.DataSource = administrador1;
            }
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

            administrador2.Id = seleccionado.Id;
            administrador2.NombreAdministrador = textBoxNombre.Text;
            administrador2.ApellidoAdministrador = textBoxApellido.Text;
            administrador2.contrasenia = textBoxContrasenia.Text;

            principal.ActucalizarAdministrador(administrador2, seleccionado);

            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxContrasenia.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;
            using (var context = new BaseDatos())
            {
                List<Back.Administradores> administrador1 = context.Administradores.ToList();

                dataGridView1.DataSource = administrador1;
            }
        }
    }
}
