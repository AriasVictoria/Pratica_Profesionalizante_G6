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
    public partial class AltaProveedor : Form
    {
        Principal principal = new Principal();
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            proveedor.NombreProvedor = proveedor.NombreProvedor;
            proveedor.ApellidoProvedor = proveedor.ApellidoProvedor;

            principal.AltaProveedor(proveedor);

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
