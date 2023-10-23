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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kiosco_Nuevo.Vendedor
{
    public partial class PantallaVendedor : Form
    {
        Principal principal = new Principal();
        public PantallaVendedor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back.Vendedores seleccionado = (Back.Vendedores)dataGridView1.CurrentRow.DataBoundItem;

            Back.Vendedores vendedor1 = new Back.Vendedores();

            vendedor1.numerolegajo = int.Parse(textBox1.Text);
            vendedor1.NombreVendedor = textBox2.Text;
            vendedor1.ApellidoVendedor = textBox3.Text;
            vendedor1.contraseñaV = textBox4.Text;

            principal.ActucalizarVendedor(seleccionado);

            BindingSource aBind = new BindingSource();
            aBind.Add(vendedor1);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Modificado con exito ");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Back.Vendedores seleccionado = (Back.Vendedores)dataGridView1.CurrentRow.DataBoundItem;
            principal.EliminarVendedor(seleccionado);

            BindingSource aBind = new BindingSource();
            aBind.Remove(seleccionado);
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;

            MessageBox.Show("Eliminado con exito ");
        }

        private void PantallaVendedor_Load(object sender, EventArgs e)
        {
            using (var context = new BaseDatos())
            {
                List<Back.Vendedores> vendedor2 = context.Vendedores.ToList();

                dataGridView1.DataSource = vendedor2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back.Vendedores vendedor1 = new Back.Vendedores();

            vendedor1.numerolegajo = int.Parse(textBox1.Text);
            vendedor1.NombreVendedor = textBox2.Text;
            vendedor1.ApellidoVendedor = textBox3.Text;
            vendedor1.contraseñaV = textBox4.Text;

            principal.AltaVendedor(vendedor1);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = vendedor1;
            dataGridView1.DataSource = aBind;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
