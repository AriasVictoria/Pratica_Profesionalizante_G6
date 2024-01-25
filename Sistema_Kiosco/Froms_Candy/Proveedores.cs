using Kiosco_Candy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Froms_Candy
{
    public partial class Proveedores : Form
    {
        Principal principal = new Principal();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proveedor proveedor1 = new Proveedor();

            proveedor1.cuit = int.Parse(textBox1.Text);
            proveedor1.NombreProvedor = textBox2.Text;
            proveedor1.ApellidoProvedor = textBox3.Text;

            principal.AltaProveedor(proveedor1);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = proveedor1;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("agregado con exito");
        }
    }
}
