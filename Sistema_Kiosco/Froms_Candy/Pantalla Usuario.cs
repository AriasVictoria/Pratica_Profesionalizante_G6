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
    public partial class Pantalla_Usuario : Form
    {
        Principal principal = new Principal();
        public Pantalla_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dueño seleccionado = (Dueño)dataGridView1.CurrentRow.DataBoundItem;

            principal.EliminarDueño(seleccionado);

            MessageBox.Show("Eliminado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<Dueño> dueño = context.Dueños.ToList();
                dataGridView1.DataSource = dueño;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dueño seleccionado = (Dueño)dataGridView1.CurrentRow.DataBoundItem;

            Dueño duenio = new Dueño();

            duenio.DNI = int.Parse(textBox1.Text);
            duenio.NombreDuenio = textBox2.Text;
            duenio.ApellidoDuenio = textBox3.Text;
            duenio.Contrasenia = textBox4.Text;

            principal.ActualizarDueño(duenio, seleccionado);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<Dueño> dueño1 = context.Dueños.ToList();
                dataGridView1.DataSource = dueño1;
            }
        }

        private void Pantalla_Usuario_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                List<Dueño> dueño1 = context.Dueños.ToList();
                dataGridView1.DataSource = dueño1;
            }
        }
    }
}
