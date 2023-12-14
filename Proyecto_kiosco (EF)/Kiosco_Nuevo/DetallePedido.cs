using Back;
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
    public partial class DetallePedido : Form
    {
        Principal principal = new Principal();
        public DetallePedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back.DetallePedido detalle = new Back.DetallePedido();

            detalle.Fecha_Pedido = DateTime.Parse(textBox1.Text);
            detalle.NombreProducto = textBox2.Text;
            detalle.Cantidad_Producto = int.Parse(textBox3.Text);
            detalle.Precio_Producto = int.Parse(textBox4.Text);
            detalle.tipo_producto = comboBox1.Text;

            principal.AltaDetallePedido(detalle);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = detalle;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back.DetallePedido seleccionado = (Back.DetallePedido)dataGridView1.CurrentRow.DataBoundItem;

            Back.DetallePedido detalle = new Back.DetallePedido();

            detalle.Fecha_Pedido = DateTime.Parse(textBox1.Text);
            detalle.NombreProducto = textBox2.Text;
            detalle.Cantidad_Producto = int.Parse(textBox3.Text);
            detalle.Precio_Producto = int.Parse(textBox4.Text);
            detalle.tipo_producto = comboBox1.Text;

            principal.ActualizarDetallePedido(detalle, seleccionado);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;
            using (var context = new BaseDatos())
            {
                List<Back.DetallePedido> detallep = context.DetallePedidos.ToList();

                dataGridView1.DataSource = detallep;
            }

        }

        private void DetallePedido_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                List<Back.DetallePedido> detallep = context.DetallePedidos.ToList();
                dataGridView1.DataSource = detallep;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back.DetallePedido seleccionado = (Back.DetallePedido)dataGridView1.CurrentRow.DataBoundItem;
            principal.EliminarDetallePedido(seleccionado);

            MessageBox.Show("Eliminado con exito ");
            BindingSource aBind = new BindingSource();
            dataGridView1.DataSource = aBind;
            using (var context = new BaseDatos())
            {
                List<Back.DetallePedido> detallep = context.DetallePedidos.ToList();

                dataGridView1.DataSource = detallep;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
