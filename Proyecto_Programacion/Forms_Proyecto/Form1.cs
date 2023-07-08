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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaVendedor altavendedor = new AltaVendedor();
            altavendedor.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaVendedor bajavendedor = new BajaVendedor();
            bajavendedor.Show();
            this.Hide();
        }

        private void modificarcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaVendedor modificarvendedor = new BajaVendedor();
            modificarvendedor.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaAdministrador altaAdministrador = new AltaAdministrador();
            altaAdministrador.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BajaAdministrador bajaAdministrador = new BajaAdministrador();
            bajaAdministrador.Show();
            this.Hide();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaAdministrador modificaradministrador = new BajaAdministrador();
            modificaradministrador.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaProveedor altaProveedor= new AltaProveedor();
            altaProveedor.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BajaProveedor bajaProveedor = new BajaProveedor();
            bajaProveedor.Show();
            this.Hide();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BajaProveedor modificarProveedor = new BajaProveedor();
            modificarProveedor.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Productos altaProductos = new Productos();
            altaProductos.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Productos bajaProductos = new Productos();
            bajaProductos.Show();
            this.Hide();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Productos modificarProductos = new Productos();
            modificarProductos.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AltaPedido altaPedido = new AltaPedido();
            altaPedido.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BajaPedido bajaPedido = new BajaPedido();
            bajaPedido.Show();
            this.Hide();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BajaPedido modificarPedido = new BajaPedido();
            modificarPedido.Show();
            this.Hide();
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
