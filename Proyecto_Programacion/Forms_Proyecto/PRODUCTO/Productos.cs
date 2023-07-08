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

namespace Forms_Proyecto
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaProducto mifor = new AltaProducto();
            mifor.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Producto.dameProducto();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Producto.dameProducto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto Seleccionado = (Producto)dataGridView1.CurrentRow.DataBoundItem;
            if (Seleccionado != null)
            {
                var confirmar = MessageBox.Show("Seguro que queres borar");
                if (confirmar != DialogResult.OK)
                {
                    Producto.removeThisMarca(Seleccionado);
                }
                MessageBox.Show("Me elejiste: " + Seleccionado.ToString());
            }
            else
            {
                MessageBox.Show("No hay elegidos");
            }
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = Producto.dameProducto();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
