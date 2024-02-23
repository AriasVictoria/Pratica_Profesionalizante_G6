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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Froms_Candy
{
    public partial class Detalle_Pedido : Form
    {
        Principal principal = new Principal();
        public Detalle_Pedido()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetallePedido seleccionado = (DetallePedido)dataGridView1.CurrentRow.DataBoundItem;

            principal.EliminarDetallePedido(seleccionado);

            MessageBox.Show("Eliminado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<DetallePedido> producto = context.DetallePedidos.ToList();
                dataGridView1.DataSource = producto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetallePedido seleccionado = (DetallePedido)dataGridView1.CurrentRow.DataBoundItem;

            DetallePedido pedido = new DetallePedido();

            pedido.Fecha_Pedido = DateTime.Parse(dateTimePicker1.Text);
            pedido.NombreProducto = textBox2.Text;
            pedido.tipo_producto = textBox5.Text;
            pedido.Cantidad_Producto = int.Parse(textBox3.Text);
            pedido.Precio_Producto = int.Parse(textBox6.Text);

            principal.ActualizarDetallePedido(pedido, seleccionado);

            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<DetallePedido> pedido1 = context.DetallePedidos.ToList();
                dataGridView1.DataSource = pedido1;
            }

        }

        private void Detalle_Pedido_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                List<DetallePedido> detalles = context.DetallePedidos.ToList();
                dataGridView1.DataSource = detalles;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                DetallePedido pedido = new DetallePedido();
                pedido.Fecha_Pedido = DateTime.Parse(dateTimePicker1.Text);
                pedido.NombreProducto = textBox2.Text;
                pedido.tipo_producto = textBox3.Text;
                pedido.Precio_Producto = int.Parse(textBox3.Text);
                pedido.Cantidad_Producto = int.Parse(textBox6.Text);

                principal.AltaDetallePedido(pedido);

                MessageBox.Show("Pedido registrado con exito");

                BindingSource aBind = new BindingSource();
                aBind.DataSource = pedido;
                dataGridView1.DataSource = aBind;

                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DetallePedido seleccionado = (DetallePedido)dataGridView1.CurrentRow.DataBoundItem;

            DetallePedido pedido = new DetallePedido();

            pedido.Fecha_Pedido = DateTime.Parse(dateTimePicker1.Text);
            pedido.NombreProducto = textBox2.Text;
            pedido.tipo_producto = textBox3.Text;
            pedido.Precio_Producto = int.Parse(textBox5.Text);
            pedido.Cantidad_Producto = int.Parse(textBox6.Text);

            principal.ActualizarDetallePedido(pedido, seleccionado);

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new  BaseDeDatos())
            {
                List<DetallePedido> detalles = context.DetallePedidos.ToList();

                dataGridView1.DataSource = detalles;
            }
        }
    }
}
