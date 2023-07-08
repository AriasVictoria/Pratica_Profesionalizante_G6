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
    public partial class BajaProveedor : Form
    {
        Principal principal = new Principal();
        public BajaProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor ProveedorEliminado = new Proveedor();

            ProveedorEliminado.NombreProvedor = ProveedorEliminado.NombreProvedor;
            ProveedorEliminado.ApellidoProvedor = ProveedorEliminado.ApellidoProvedor;

            principal.BajaProveedor(ProveedorEliminado);

            MessageBox.Show("Proveedor eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedor ModificarProveedor = new Proveedor();

            ModificarProveedor.NombreProvedor = ModificarProveedor.NombreProvedor;
            ModificarProveedor.ApellidoProvedor = ModificarProveedor.ApellidoProvedor;

            principal.ModificarProveedor(ModificarProveedor);

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
