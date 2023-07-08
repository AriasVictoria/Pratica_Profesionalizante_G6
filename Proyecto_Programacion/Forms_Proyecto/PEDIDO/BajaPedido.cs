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
            Pedido PedidoEliminado = new Pedido();

            PedidoEliminado.MontoFinal = PedidoEliminado.MontoFinal;
            PedidoEliminado.Precio_Producto = PedidoEliminado.Precio_Producto;
            PedidoEliminado.Tipo_Producto = PedidoEliminado.Tipo_Producto;

            principal.BajaPedido(PedidoEliminado);

            MessageBox.Show("Pedido eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido PedidorModificado = new Pedido();

            PedidorModificado.MontoFinal = PedidorModificado.MontoFinal;
            PedidorModificado.Precio_Producto = PedidorModificado.Precio_Producto;
            PedidorModificado.Tipo_Producto = PedidorModificado.Tipo_Producto;

            principal.ModificarPedido(PedidorModificado);

            MessageBox.Show("modificado con exito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
