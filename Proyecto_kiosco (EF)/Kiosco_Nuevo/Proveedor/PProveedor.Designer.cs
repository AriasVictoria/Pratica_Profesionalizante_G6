namespace Kiosco_Nuevo.Proveedor
{
    partial class PProveedor
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            cuitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProvedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoProvedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            label4 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 221);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 20;
            label3.Text = "Apellido Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 166);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 115);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 18;
            label1.Text = "Cuit";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(687, 293);
            button4.Name = "button4";
            button4.Size = new Size(85, 31);
            button4.TabIndex = 17;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(572, 295);
            button3.Name = "button3";
            button3.Size = new Size(79, 31);
            button3.TabIndex = 16;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(464, 293);
            button2.Name = "button2";
            button2.Size = new Size(79, 31);
            button2.TabIndex = 15;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(356, 295);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 14;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, cuitDataGridViewTextBoxColumn, nombreProvedorDataGridViewTextBoxColumn, apellidoProvedorDataGridViewTextBoxColumn });
            dataGridView1.DataSource = proveedorBindingSource;
            dataGridView1.Location = new Point(343, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(445, 168);
            dataGridView1.TabIndex = 25;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            cuitDataGridViewTextBoxColumn.HeaderText = "cuit";
            cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // nombreProvedorDataGridViewTextBoxColumn
            // 
            nombreProvedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProvedor";
            nombreProvedorDataGridViewTextBoxColumn.HeaderText = "NombreProvedor";
            nombreProvedorDataGridViewTextBoxColumn.Name = "nombreProvedorDataGridViewTextBoxColumn";
            // 
            // apellidoProvedorDataGridViewTextBoxColumn
            // 
            apellidoProvedorDataGridViewTextBoxColumn.DataPropertyName = "ApellidoProvedor";
            apellidoProvedorDataGridViewTextBoxColumn.HeaderText = "ApellidoProvedor";
            apellidoProvedorDataGridViewTextBoxColumn.Name = "apellidoProvedorDataGridViewTextBoxColumn";
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(Back.Proveedores);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 65);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 26;
            label4.Text = "Id";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 27;
            // 
            // PProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PProveedor";
            Text = "PantallaProveedor";
            Load += PProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource proveedorBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProvedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoProvedorDataGridViewTextBoxColumn;
        private Label label4;
        private TextBox textBox4;
    }
}