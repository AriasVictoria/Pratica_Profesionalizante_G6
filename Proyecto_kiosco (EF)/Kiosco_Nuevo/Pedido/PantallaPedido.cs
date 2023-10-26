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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosco_Nuevo.Pedido
{
    public partial class PantallaPedido : Form
    {
        Principal principal = new Principal();
        public PantallaPedido()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void PantallaPedido_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                List<Back.Pedidos> pedido2 = context.Pedidos.ToList();
                dataGridView1.DataSource = pedido2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back.Pedidos pedido1 = new Back.Pedidos();

            pedido1.Precio_Producto = int.Parse(textBox5.Text);
            pedido1.MontoFinal = int.Parse(textBox6.Text);

            principal.AltaPedido(pedido1);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = pedido1;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back.Pedidos seleccionado = (Back.Pedidos)dataGridView1.CurrentRow.DataBoundItem;

            Back.Pedidos pedido1 = new Back.Pedidos();

            pedido1.Id = seleccionado.Id;
            pedido1.Precio_Producto = int.Parse(textBox5.Text);
            pedido1.MontoFinal = int.Parse(textBox6.Text);

            principal.ActucalizarPedido(pedido1, seleccionado);

            textBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.Add(pedido1);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDatos())
            {
                List<Back.Pedidos> pedido2 = context.Pedidos.ToList();
                dataGridView1.DataSource = pedido2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back.Pedidos seleccionado = (Back.Pedidos)dataGridView1.CurrentRow.DataBoundItem;
            principal.EliminarPedido(seleccionado);

            MessageBox.Show("Eliminado con exito ");

            BindingSource aBind = new BindingSource();
            //aBind.Remove(seleccionado);
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDatos())
            {
                List<Back.Pedidos> pedido2 = context.Pedidos.ToList();
                dataGridView1.DataSource = pedido2;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
