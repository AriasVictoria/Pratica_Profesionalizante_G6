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
    public partial class BajaPedido : Form
    {
        Principal principal = new Principal();
        public BajaPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido1 = (Pedido)listBox1.SelectedItem;

            principal.BajaPedido(pedido1);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "PD";
            listBox1.DataSource = principal.ListaPedido;

            MessageBox.Show("Pedido eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido seleccionado = (Pedido)listBox1.SelectedItem;

            Pedido pedido1 = new Pedido();

            pedido1.MontoFinal = int.Parse(textBox1.Text);
            pedido1.Precio_Producto =int.Parse( textBox2.Text);
            pedido1.Tipo_Producto = comboBox1.Text;

            principal.ModificarPedido(pedido1, seleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "PD";
            listBox1.DataSource = principal.ListaPedido;
            MessageBox.Show("Modificado con exito ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pedido Pedido1 = new Pedido();

            Pedido1.MontoFinal = int.Parse(textBox1.Text);
            Pedido1.Precio_Producto = int.Parse(textBox2.Text);
            Pedido1.Tipo_Producto = comboBox1.Text;

            principal.AltaPedido(Pedido1);


            listBox1.DataSource = null;
            listBox1.DisplayMember = "PD";
            listBox1.DataSource = principal.ListaPedido;
            MessageBox.Show("Pedido guardado");

            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
