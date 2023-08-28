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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            
            
            Proveedor proveedor1 = (Proveedor)listBox1.SelectedItem;

            principal.BajaProveedor(proveedor1);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "PV";
            listBox1.DataSource = principal.ListaProveedor;

            MessageBox.Show("Proveedor eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedor seleccionado = (Proveedor)listBox1.SelectedItem;

            Proveedor Proveedor1 = new Proveedor();

            Proveedor1.NombreProvedor = textBox1.Text;
            Proveedor1.ApellidoProvedor = textBox2.Text;
            

            principal.ModificarProveedor(Proveedor1, seleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "PV";
            listBox1.DataSource = principal.ListaProveedor;
            MessageBox.Show("Modificado con exito ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proveedor Proveedor1 = new Proveedor();

            Proveedor1.NombreProvedor = textBox1.Text;
            Proveedor1.ApellidoProvedor = textBox2.Text;


            principal.AltaProveedor(Proveedor1);


            listBox1.DataSource = null;
            listBox1.DisplayMember = "PV";
            listBox1.DataSource = principal.ListaProveedor;
            MessageBox.Show("Provedor guardado");

            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
