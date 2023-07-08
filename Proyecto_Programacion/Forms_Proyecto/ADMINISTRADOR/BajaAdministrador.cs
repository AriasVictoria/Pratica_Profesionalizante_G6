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
    public partial class BajaAdministrador : Form
    {
        Principal principal = new Principal();
        public BajaAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrador AdministradorEliminado = new Administrador();

            AdministradorEliminado.NombreAdministrador = AdministradorEliminado.NombreAdministrador;
            AdministradorEliminado.ApellidoAdministrador = AdministradorEliminado.ApellidoAdministrador;
            AdministradorEliminado.contraseña = AdministradorEliminado.contraseña;

            principal.BajaAdministrador(AdministradorEliminado);

            MessageBox.Show("Administrador eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrador AdmnistradorModificado = new Administrador();

            AdmnistradorModificado.NombreAdministrador = AdmnistradorModificado.NombreAdministrador;
            AdmnistradorModificado.ApellidoAdministrador = AdmnistradorModificado.ApellidoAdministrador;
            AdmnistradorModificado.contraseña = AdmnistradorModificado.contraseña;

            principal.ModificarAdministrador(AdmnistradorModificado);

            MessageBox.Show("modificado con exito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
