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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            proveedor1.cuit = textBox1.Text;
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

        private void Proveedores_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDeDatos())
            {
                List<Proveedor> proveedores = context.Proveedor.ToList();
                dataGridView1.DataSource = proveedores;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proveedor seleccionado = (Proveedor)dataGridView1.CurrentRow.DataBoundItem;

            principal.EliminarProveedor(seleccionado);

            MessageBox.Show("Eliminado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<Proveedor> proveedores = context.Proveedor.ToList();
                dataGridView1.DataSource = proveedores;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor seleccionado = (Proveedor)dataGridView1.CurrentRow.DataBoundItem;

            Proveedor proveedor1 = new Proveedor();

            proveedor1.cuit = textBox1.Text;
            proveedor1.NombreProvedor = textBox2.Text;
            proveedor1.ApellidoProvedor = textBox3.Text;

            principal.ActucalizarProveedor(proveedor1, seleccionado);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDeDatos())
            {
                List<Proveedor> proveedores = context.Proveedor.ToList();
                dataGridView1.DataSource = proveedores;
            }
        }
    }
}
