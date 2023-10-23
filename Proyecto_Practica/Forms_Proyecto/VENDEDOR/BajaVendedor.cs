﻿using BD_Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Proyecto
{
    public partial class BajaVendedor : Form
    {
        Principal principal = new Principal();
        public BajaVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedor seleccionado = (Vendedor)listBox1.SelectedItem;

            principal.BajaVendedor(seleccionado);

            listBox1.DataSource = null;
            listBox1.DisplayMember = "V";
            listBox1.DataSource = principal.ListaVendedor;;

            MessageBox.Show("Vendedor eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedor seleccionado = (Vendedor)listBox1.SelectedItem;

            Vendedor vendedor1 = new Vendedor();
            vendedor1.NombreVendedor = textBox1.Text;
            vendedor1.ApellidoVendedor = textBox2.Text;
            vendedor1.contraseñaV = textBox3.Text;
            vendedor1.numerolegajo = int.Parse(textBox4.Text);


            principal.ModificarVendedor(vendedor1, seleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "V";
            listBox1.DataSource = principal.ListaVendedor;
            MessageBox.Show("Modificado con exito ");
        }

        private void BajaVendedor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vendedor vendedor1 = new Vendedor();

            vendedor1.NombreVendedor = textBox1.Text;
            vendedor1.ApellidoVendedor = textBox2.Text;
            vendedor1.contraseñaV = textBox3.Text;
            vendedor1.numerolegajo = int.Parse(textBox4.Text);  

            principal.AltaVendedor(vendedor1);


            listBox1.DataSource = null;
            listBox1.DisplayMember = "V";
            listBox1.DataSource = principal.ListaVendedor;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Agregado con exito");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int numero))
            {
                // Si no se puede convertir a un número entero, mostrar un mensaje de error
                MessageBox.Show("Ingrese un número entero válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus(); // Devuelve el foco al TextBox
                e.Cancel = true; // Evita que el foco se mueva al siguiente control
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string input = textBox1.Text;
            if (!Regex.IsMatch(input, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Ingrese solo letras (sin números ni caracteres especiales).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                e.Cancel = true;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string input = textBox2.Text;
            if (!Regex.IsMatch(input, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Ingrese solo letras (sin números ni caracteres especiales).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                e.Cancel = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string input = textBox3.Text;
            if (!Regex.IsMatch(input, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Ingrese solo letras (sin números ni caracteres especiales).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                e.Cancel = true;
            }
        }
    }
}