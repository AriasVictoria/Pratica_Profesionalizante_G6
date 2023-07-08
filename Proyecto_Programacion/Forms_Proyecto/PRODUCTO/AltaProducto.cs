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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alta();
            this.Close();
        }
        private void alta()
        {
            Producto Nuevo = new Producto();
            Nuevo.Id = int.Parse(textBox1.Text);
            Nuevo.NombreProducto = textBox2.Text;
            Nuevo.Precio= int.Parse(textBox3.Text);

            Producto.dameProducto().Add(Nuevo);
        }
    }
}
