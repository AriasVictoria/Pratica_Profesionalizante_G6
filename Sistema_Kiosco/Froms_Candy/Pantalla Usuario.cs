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

            Dueño dueño = new Dueño();

            dueño.DNI = seleccionado.DNI;
            dueño.NombreDuenio = textBox1.Text;
            dueño.ApellidoDuenio = textBox2.Text;
            dueño.Contrasenia = textBox3.Text;

            principal.ActualizarDueño(dueño, seleccionado);

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

        }
    }
}
