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
    public partial class Productos : Form
    {
        Principal principal = new Principal();


        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();

            producto1.Id = int.Parse(textBox1.Text);
            producto1.NombreProducto = textBox2.Text;
            producto1.Precio = int.Parse(textBox3.Text);
            producto1.stock = int.Parse(textBox4.Text);

            principal.AltaProdcuto(producto1);
           

            listBox1.DataSource = null;
            listBox1.DisplayMember = "P";
            listBox1.DataSource = principal.ListaProducto;
            MessageBox.Show("Producto guardado");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)listBox1.SelectedItem;

            Producto producto1 = new Producto();

            producto1.Id = int.Parse(textBox1.Text);
            producto1.NombreProducto = textBox2.Text;
            producto1.Precio = int.Parse(textBox3.Text);
            producto1.stock = int.Parse(textBox4.Text);

            principal.ModificarProdcuto(producto1, seleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "P";
            listBox1.DataSource = principal.ListaProducto;
            MessageBox.Show("Modificado con exito ");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)listBox1.SelectedItem;

            principal.BajaProdcuto(seleccionado);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "P";
            listBox1.DataSource = principal.ListaProducto;

            MessageBox.Show("Producto eliminado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 from = new Form1();
            from.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
