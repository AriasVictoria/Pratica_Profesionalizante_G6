using Back;
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

namespace Kiosco_Nuevo.Proveedor
{
    public partial class PProveedor : Form
    {
        Principal principal = new Principal();
        public PProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void PProveedor_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                List<Back.Proveedores> proveedor2 = context.proveedores.ToList();

                dataGridView1.DataSource = proveedor2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back.Proveedores proveedor1 = new Back.Proveedores();

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

        private void button2_Click(object sender, EventArgs e)
        {
            Back.Proveedores seleccionado = (Back.Proveedores)dataGridView1.CurrentRow.DataBoundItem;

            Back.Proveedores proveedor1 = new Back.Proveedores();

            proveedor1.Id = seleccionado.Id;
            proveedor1.cuit = textBox1.Text;
            proveedor1.NombreProvedor = textBox2.Text;
            proveedor1.ApellidoProvedor = textBox3.Text;

            principal.ActucalizarProveedor(proveedor1, seleccionado);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDatos())
            {
                List<Back.Proveedores> proveedor = context.proveedores.ToList();
                dataGridView1.DataSource = proveedor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back.Proveedores seleccionado = (Back.Proveedores)dataGridView1.CurrentRow.DataBoundItem;

            principal.EliminarProveedor(seleccionado);

            MessageBox.Show("Eliminado con exito ");

            BindingSource aBind = new BindingSource();
            //aBind.Remove(seleccionado);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            using (var context = new BaseDatos())
            {
                List<Back.Proveedores> proveedor = context.proveedores.ToList();
                dataGridView1.DataSource = proveedor;
            }
        }
    }
}
