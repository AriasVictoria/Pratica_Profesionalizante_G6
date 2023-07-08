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
    public partial class AltaPedido : Form
    {
        Principal principal = new Principal();
        public AltaPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();

            pedido.MontoFinal = pedido.MontoFinal;
            pedido.Precio_Producto = pedido.Precio_Producto;
            pedido.Tipo_Producto = pedido.Tipo_Producto;

            principal.AltaPedido(pedido);

            MessageBox.Show("Agregado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
