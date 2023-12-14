namespace Kiosco_Nuevo.Administrador
{
    partial class PantallaAdministradores
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
            textBoxContrasenia = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Id_Administrador = new DataGridViewTextBoxColumn();
            nombreAdministradorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoAdministradorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administradorBindingSource = new BindingSource(components);
            contrasenia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Location = new Point(178, 150);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(100, 23);
            textBoxContrasenia.TabIndex = 24;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(178, 99);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(100, 23);
            textBoxApellido.TabIndex = 23;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(176, 52);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 107);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 20;
            label3.Text = "Apellido Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 55);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre Administrador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 153);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 18;
            label1.Text = "Contraseña";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(672, 266);
            button4.Name = "button4";
            button4.Size = new Size(85, 32);
            button4.TabIndex = 17;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(549, 266);
            button3.Name = "button3";
            button3.Size = new Size(82, 32);
            button3.TabIndex = 16;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(421, 266);
            button2.Name = "button2";
            button2.Size = new Size(86, 32);
            button2.TabIndex = 15;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 266);
            button1.Name = "button1";
            button1.Size = new Size(79, 32);
            button1.TabIndex = 14;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Administrador, nombreAdministradorDataGridViewTextBoxColumn, apellidoAdministradorDataGridViewTextBoxColumn, contrasenia });
            dataGridView1.DataSource = administradorBindingSource;
            dataGridView1.Location = new Point(319, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 150);
            dataGridView1.TabIndex = 25;
            // 
            // Id_Administrador
            // 
            Id_Administrador.DataPropertyName = "Id_Administrador";
            Id_Administrador.HeaderText = "Id_Administrador";
            Id_Administrador.Name = "Id_Administrador";
            // 
            // nombreAdministradorDataGridViewTextBoxColumn
            // 
            nombreAdministradorDataGridViewTextBoxColumn.DataPropertyName = "NombreAdministrador";
            nombreAdministradorDataGridViewTextBoxColumn.HeaderText = "NombreAdministrador";
            nombreAdministradorDataGridViewTextBoxColumn.Name = "nombreAdministradorDataGridViewTextBoxColumn";
            // 
            // apellidoAdministradorDataGridViewTextBoxColumn
            // 
            apellidoAdministradorDataGridViewTextBoxColumn.DataPropertyName = "ApellidoAdministrador";
            apellidoAdministradorDataGridViewTextBoxColumn.HeaderText = "ApellidoAdministrador";
            apellidoAdministradorDataGridViewTextBoxColumn.Name = "apellidoAdministradorDataGridViewTextBoxColumn";
            // 
            // administradorBindingSource
            // 
            administradorBindingSource.DataSource = typeof(Back.Administradores);
            // 
            // contrasenia
            // 
            contrasenia.DataPropertyName = "contrasenia";
            contrasenia.HeaderText = "contrasenia";
            contrasenia.Name = "contrasenia";
            // 
            // PantallaAdministradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxContrasenia);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PantallaAdministradores";
            Text = "PantallaAdministrador";
            Load += PantallaAdministradores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxContrasenia;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource administradorBindingSource;
        private DataGridViewTextBoxColumn Id_Administrador;
        private DataGridViewTextBoxColumn nombreAdministradorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoAdministradorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contrasenia;
    }
}