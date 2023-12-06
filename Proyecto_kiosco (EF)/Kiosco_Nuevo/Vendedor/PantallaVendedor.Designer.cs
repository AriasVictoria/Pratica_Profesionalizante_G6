namespace Kiosco_Nuevo.Vendedor
{
    partial class PantallaVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxnombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxContrasenia = new TextBox();
            dataGridView1 = new DataGridView();
            numerolegajo = new DataGridViewTextBoxColumn();
            nombreVendedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoVendedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendedorBindingSource = new BindingSource(components);
            vendedorBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendedorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendedorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(345, 279);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 0;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(458, 279);
            button2.Name = "button2";
            button2.Size = new Size(92, 30);
            button2.TabIndex = 2;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(566, 279);
            button3.Name = "button3";
            button3.Size = new Size(93, 32);
            button3.TabIndex = 3;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(678, 279);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 4;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre Vendedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 122);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido Vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 169);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(143, 67);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(100, 23);
            textBoxnombre.TabIndex = 10;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(145, 114);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(100, 23);
            textBoxApellido.TabIndex = 11;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Location = new Point(145, 165);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(100, 23);
            textBoxContrasenia.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numerolegajo, nombreVendedorDataGridViewTextBoxColumn, apellidoVendedorDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vendedorBindingSource;
            dataGridView1.Location = new Point(331, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(457, 178);
            dataGridView1.TabIndex = 13;
            // 
            // numerolegajo
            // 
            numerolegajo.DataPropertyName = "numerolegajo";
            numerolegajo.HeaderText = "numerolegajo";
            numerolegajo.Name = "numerolegajo";
            // 
            // nombreVendedorDataGridViewTextBoxColumn
            // 
            nombreVendedorDataGridViewTextBoxColumn.DataPropertyName = "NombreVendedor";
            nombreVendedorDataGridViewTextBoxColumn.HeaderText = "NombreVendedor";
            nombreVendedorDataGridViewTextBoxColumn.Name = "nombreVendedorDataGridViewTextBoxColumn";
            // 
            // apellidoVendedorDataGridViewTextBoxColumn
            // 
            apellidoVendedorDataGridViewTextBoxColumn.DataPropertyName = "ApellidoVendedor";
            apellidoVendedorDataGridViewTextBoxColumn.HeaderText = "ApellidoVendedor";
            apellidoVendedorDataGridViewTextBoxColumn.Name = "apellidoVendedorDataGridViewTextBoxColumn";
            // 
            // vendedorBindingSource
            // 
            vendedorBindingSource.DataSource = typeof(Back.Vendedores);
            // 
            // vendedorBindingSource1
            // 
            vendedorBindingSource1.DataSource = typeof(Back.Vendedores);
            // 
            // PantallaVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxContrasenia);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxnombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PantallaVendedor";
            Text = "PantallaVendedor";
            Load += PantallaVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendedorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendedorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxnombre;
        private TextBox textBoxApellido;
        private TextBox textBoxContrasenia;
        private DataGridView dataGridView1;
        private BindingSource vendedorBindingSource;
        private BindingSource vendedorBindingSource1;
        private DataGridViewTextBoxColumn numerolegajo;
        private DataGridViewTextBoxColumn nombreVendedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoVendedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseñaVDataGridViewTextBoxColumn;
    }
}