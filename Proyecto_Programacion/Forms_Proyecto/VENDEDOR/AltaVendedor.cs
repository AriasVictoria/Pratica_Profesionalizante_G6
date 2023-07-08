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
    public partial class AltaVendedor : Form
    {
        Principal principal = new Principal();
        public AltaVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.NombreVendedor = vendedor.NombreVendedor;
            vendedor.ApellidoVendedor = vendedor.ApellidoVendedor;
            vendedor.contraseñaV = vendedor.contraseñaV;

            principal.AltaVendedor(vendedor);

            MessageBox.Show("Agregado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void AltaVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
