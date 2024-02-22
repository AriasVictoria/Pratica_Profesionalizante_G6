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
    public partial class Producto : Form
    {
        Principal principal = new Principal();
        public Producto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                Productos Productos = new Productos();
                Proveedor proveedor = new Proveedor();

                Productos.NombreProducto = textBox1.Text;
                Productos.tipo_producto = textBox2.Text;
                Productos.stock = int.Parse(textBox3.Text);
                proveedor.NombreProvedor = textBox4.Text;

                principal.AltaProductos(Productos);
                principal.AltaProveedor(proveedor);


                BindingSource aBind = new BindingSource();
                aBind.DataSource = Productos;
                dataGridView1.DataSource = aBind;

                MessageBox.Show("agregado con exito");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                context.SaveChanges();
            }


        }
        private void button4_Click(object sender, EventArgs e)
        { 
            Productos seleccionado = (Productos)dataGridView1.CurrentRow.DataBoundItem;

            principal.EliminarProducto(seleccionado);

            MessageBox.Show("Eliminado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<Productos> producto = context.Productos.ToList();
                dataGridView1.DataSource = producto;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos seleccionado = (Productos)dataGridView1.CurrentRow.DataBoundItem;

            Productos productos = new Productos();
            Proveedor proveedor = new Proveedor();

            productos.NombreProducto = textBox1.Text;
            productos.tipo_producto = textBox2.Text;
            productos.stock = int.Parse(textBox3.Text);
            proveedor.NombreProvedor = textBox4.Text;

            principal.ActucalizarProducto(productos, seleccionado);

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
                List<Proveedor> proveedores = context.Proveedor.ToList();
                dataGridView1.DataSource = proveedores;
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                List<Productos> producto = context.Productos.ToList();
                dataGridView1.DataSource = producto;
            }
        }
    }
}
