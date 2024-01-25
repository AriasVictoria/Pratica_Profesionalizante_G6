using Back;
using Kiosco_Nuevo.LoginUsuario;
using Kiosco_Nuevo.Proveedor;

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

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProveedor proveedor = new PProveedor();
            proveedor.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetallePedido detalle = new DetallePedido();
            detalle.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void registraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarUsuario ingresar = new IngresarUsuario();
            ingresar.Show();
            this.Hide();
        }
    }
}
