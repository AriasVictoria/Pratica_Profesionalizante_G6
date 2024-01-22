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

namespace Kiosco_Nuevo.LoginUsuario
{
    public partial class IngresarUsuario : Form
    {
        Principal principal = new Principal();
        public IngresarUsuario()
        {
            InitializeComponent();
        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
