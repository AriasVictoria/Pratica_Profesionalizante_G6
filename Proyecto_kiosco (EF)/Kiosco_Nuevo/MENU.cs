using Kiosco_Nuevo.Administrador;
using Kiosco_Nuevo.Pedido;
using Kiosco_Nuevo.Producto;
using Kiosco_Nuevo.Proveedor;
using Kiosco_Nuevo.Vendedor;

namespace Kiosco_Nuevo
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaVendedor vendedor = new PantallaVendedor();
            vendedor.Show();
            this.Hide();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaAdministradores admnistrador = new PantallaAdministradores();
            admnistrador.Show();
            this.Hide();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProveedor proveedor = new PProveedor();
            proveedor.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaProductos productos = new PantallaProductos();
            productos.Show();
            this.Hide();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaPedido pedido = new PantallaPedido();
            pedido.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}