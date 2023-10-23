using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosco_Nuevo.Producto
{
    public partial class PantallaProductos : Form
    {

        Principal principal = new Principal();
        public PantallaProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Back.Productos producto = new Back.Productos();
            
            producto.Id = int.Parse(textBox6.Text);
            producto.NombreProducto = textBox2.Text;
            producto.Precio = int.Parse(textBox5.Text);
            producto.stock = int.Parse(textBox3.Text);

            principal.AltaProducto(producto);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = producto;
            dataGridView1.DataSource = aBind;

            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void PantallaProductos_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                List<Back.Productos> productos = context.Productos.ToList();
                dataGridView1.DataSource = productos;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back.Productos seleccionado = (Back.Productos)dataGridView1.CurrentRow.DataBoundItem;

            Back.Productos producto1 = new Back.Productos();
            Back.Proveedores proveedores = new Back.Proveedores();

            producto1.Id = int.Parse(textBox6.Text);
            producto1.NombreProducto = textBox2.Text;
            producto1.Precio = int.Parse(textBox5.Text);
            producto1.stock = int.Parse(textBox3.Text);

            principal.ActucalizarProducto(seleccionado);

            BindingSource aBind = new BindingSource();
            aBind.Add(producto1);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Modificado con exito ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back.Productos seleccionado = (Back.Productos)dataGridView1.CurrentRow.DataBoundItem;
            principal.EliminarProducto(seleccionado);

            BindingSource aBind = new BindingSource();
            aBind.Remove(seleccionado);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            MessageBox.Show("Eliminado con exito ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
