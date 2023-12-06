using Back;
using Kiosco_Nuevo.Administrador;
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
        private void ingresoUsuario(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                var usuario = context.Vendedores.FirstOrDefault(u => u.NombreVendedor == textBoxnombre.Text, 
                    u => u.ApellidoVendedor == textBoxApellido.Text);

                if (usuario != null && usuario.contrasenina == textBoxContrasenia.Text)
                {
                    if (usuario.tipo == "vendedor")
                    {
                        PantallaVendedor form = new PantallaVendedor();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        PantallaAdministradores form = new PantallaAdministradores();
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos");
                }
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxContrasenia.Clear();
            }

        }
    }
}