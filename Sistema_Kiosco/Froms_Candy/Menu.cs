using Kiosco_Candy;

namespace Froms_Candy
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Hide();
        }

        private void prodcutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto productos = new Producto();
            productos.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.Show();
            this.Hide();
        }

        private void detallePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Pedido pedido = new Detalle_Pedido();
            pedido.Show();
            this.Hide();
        }
    }
}