namespace Froms_Candy
{
    partial class Proveedores
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
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            cuitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProvedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoProvedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(729, 29);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 39;
            label5.Text = "candy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkViolet;
            label6.Location = new Point(712, 9);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 38;
            label6.Text = "KIOSCO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 42;
            label3.Text = "Apellido Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 101);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 41;
            label2.Text = "Nombre Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 54);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 40;
            label1.Text = "Cuit";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cuitDataGridViewTextBoxColumn, nombreProvedorDataGridViewTextBoxColumn, apellidoProvedorDataGridViewTextBoxColumn });
            dataGridView1.DataSource = proveedorBindingSource;
            dataGridView1.Location = new Point(300, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(390, 112);
            dataGridView1.TabIndex = 46;
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
            proveedorBindingSource.DataSource = typeof(Kiosco_Candy.Proveedor);
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(640, 275);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 49;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(496, 275);
            button1.Name = "button1";
            button1.Size = new Size(84, 30);
            button1.TabIndex = 48;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Violet;
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(353, 275);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 47;
            button4.Text = "BAJA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Violet;
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(216, 275);
            button3.Name = "button3";
            button3.Size = new Size(84, 30);
            button3.TabIndex = 50;
            button3.Text = "ALTA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProvedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoProvedorDataGridViewTextBoxColumn;
        private BindingSource proveedorBindingSource;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}