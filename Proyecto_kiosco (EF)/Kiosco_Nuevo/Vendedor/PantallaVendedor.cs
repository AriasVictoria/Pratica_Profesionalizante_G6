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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            vendedor1.numerolegajo = seleccionado.numerolegajo;
            vendedor1.NombreVendedor = textBoxnombre.Text;
            vendedor1.ApellidoVendedor = textBoxApellido.Text;
            vendedor1.contrasenia = textBoxContrasenia.Text;

            principal.ActucalizarVendedor(vendedor1, seleccionado);


            textBoxnombre.Clear();
            textBoxApellido.Clear();
            textBoxContrasenia.Clear();

            MessageBox.Show("Modificado con exito ");

            BindingSource aBind = new BindingSource();
            aBind.EndEdit();
            dataGridView1.DataSource = aBind;
            using (var context = new BaseDatos())
            {
                List<Back.Vendedores> vendedor2 = context.Vendedores.ToList();

                dataGridView1.DataSource = vendedor2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Back.Vendedores seleccionado = (Back.Vendedores)dataGridView1.CurrentRow.DataBoundItem;
            principal.EliminarVendedor(seleccionado);

            MessageBox.Show("Eliminado con exito ");
            BindingSource aBind = new BindingSource();
            //aBind.Remove(seleccionado);
            dataGridView1.DataSource = aBind;
            using (var context = new BaseDatos())
            {
                List<Back.Vendedores> vendedor2 = context.Vendedores.ToList();

                dataGridView1.DataSource = vendedor2;
            }
        }

        private void PantallaVendedor_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back.Vendedores vendedor1 = new Back.Vendedores();

            vendedor1.NombreVendedor = textBoxnombre.Text;
            vendedor1.ApellidoVendedor = textBoxApellido.Text;
            vendedor1.contrasenia = textBoxContrasenia.Text;

            principal.AltaVendedor(vendedor1);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = vendedor1;
            dataGridView1.DataSource = aBind;

            textBoxnombre.Clear();
            textBoxApellido.Clear();
            textBoxContrasenia.Clear();
        }
    }
}
