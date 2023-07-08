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
    public partial class BajaVendedor : Form
    {
        Principal principal = new Principal();
        public BajaVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedor VendedorEliminado = new Vendedor();

            VendedorEliminado.NombreVendedor = VendedorEliminado.NombreVendedor;
            VendedorEliminado.ApellidoVendedor = VendedorEliminado.ApellidoVendedor;
            VendedorEliminado.contraseñaV = VendedorEliminado.contraseñaV;

            principal.BajaVendedor(VendedorEliminado);

            MessageBox.Show("Vendedor eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedor VendedorModificado = new Vendedor();

            VendedorModificado.NombreVendedor = VendedorModificado.NombreVendedor;
            VendedorModificado.ApellidoVendedor = VendedorModificado.ApellidoVendedor;
            VendedorModificado.contraseñaV = VendedorModificado.contraseñaV;

            principal.ModificarVendedor(VendedorModificado);

            MessageBox.Show("modificado con exito");
        }

        private void BajaVendedor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
