namespace Kiosco_Nuevo
{
    partial class DetallePedido
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            numeropedido = new DataGridViewTextBoxColumn();
            fechaPedidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cantidadProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detallePedidoBindingSource = new BindingSource(components);
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detallePedidoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 68);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Porducto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 106);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 27);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 68);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(462, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(462, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Golosina", "Lacteos", "Canasta Familiar " });
            comboBox1.Location = new Point(194, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numeropedido, fechaPedidoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, cantidadProductoDataGridViewTextBoxColumn, precioProductoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = detallePedidoBindingSource;
            dataGridView1.Location = new Point(106, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(662, 150);
            dataGridView1.TabIndex = 10;
            // 
            // numeropedido
            // 
            numeropedido.DataPropertyName = "numeropedido";
            numeropedido.HeaderText = "numeropedido";
            numeropedido.Name = "numeropedido";
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Pedido";
            fechaPedidoDataGridViewTextBoxColumn.HeaderText = "Fecha_Pedido";
            fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewTextBoxColumn2.HeaderText = "Tipo Producto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cantidadProductoDataGridViewTextBoxColumn
            // 
            cantidadProductoDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Producto";
            cantidadProductoDataGridViewTextBoxColumn.HeaderText = "Cantidad_Producto";
            cantidadProductoDataGridViewTextBoxColumn.Name = "cantidadProductoDataGridViewTextBoxColumn";
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            precioProductoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Producto";
            precioProductoDataGridViewTextBoxColumn.HeaderText = "Precio_Producto";
            precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            // 
            // detallePedidoBindingSource
            // 
            detallePedidoBindingSource.DataSource = typeof(Back.DetallePedido);
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(540, 341);
            button4.Name = "button4";
            button4.Size = new Size(85, 32);
            button4.TabIndex = 21;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(417, 341);
            button3.Name = "button3";
            button3.Size = new Size(82, 32);
            button3.TabIndex = 20;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(289, 341);
            button2.Name = "button2";
            button2.Size = new Size(86, 32);
            button2.TabIndex = 19;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(161, 341);
            button1.Name = "button1";
            button1.Size = new Size(79, 32);
            button1.TabIndex = 18;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DetallePedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 396);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetallePedido";
            Text = "DetallePedido_";
            Load += DetallePedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)detallePedidoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private BindingSource detallePedidoBindingSource;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn numeropedido;
        private DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
    }
}