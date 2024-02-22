namespace Froms_Candy
{
    partial class Detalle_Pedido
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            fechaPedidoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nombreProductoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tipoproductoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Precio_Producto = new DataGridViewTextBoxColumn();
            cantidadProductoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            detallePedidoBindingSource1 = new BindingSource(components);
            detallePedidoBindingSource = new BindingSource(components);
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            numeropedidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaPedidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDuenioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoproductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detallePedidoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detallePedidoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(729, 29);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 41;
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
            label6.TabIndex = 40;
            label6.Text = "KIOSCO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(530, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 62);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 45;
            label4.Text = "Cantidad Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 103);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 44;
            label3.Text = "Tipo Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 65);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 43;
            label2.Text = "Nombre Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 24);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 42;
            label7.Text = "Fecha Pedido";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaPedidoDataGridViewTextBoxColumn1, nombreProductoDataGridViewTextBoxColumn1, tipoproductoDataGridViewTextBoxColumn1, Precio_Producto, cantidadProductoDataGridViewTextBoxColumn1, Column1 });
            dataGridView1.DataSource = detallePedidoBindingSource1;
            dataGridView1.Location = new Point(26, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(748, 150);
            dataGridView1.TabIndex = 52;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fechaPedidoDataGridViewTextBoxColumn1
            // 
            fechaPedidoDataGridViewTextBoxColumn1.DataPropertyName = "Fecha_Pedido";
            fechaPedidoDataGridViewTextBoxColumn1.HeaderText = "Fecha_Pedido";
            fechaPedidoDataGridViewTextBoxColumn1.Name = "fechaPedidoDataGridViewTextBoxColumn1";
            // 
            // nombreProductoDataGridViewTextBoxColumn1
            // 
            nombreProductoDataGridViewTextBoxColumn1.DataPropertyName = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn1.HeaderText = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn1.Name = "nombreProductoDataGridViewTextBoxColumn1";
            // 
            // tipoproductoDataGridViewTextBoxColumn1
            // 
            tipoproductoDataGridViewTextBoxColumn1.DataPropertyName = "tipo_producto";
            tipoproductoDataGridViewTextBoxColumn1.HeaderText = "tipo_producto";
            tipoproductoDataGridViewTextBoxColumn1.Name = "tipoproductoDataGridViewTextBoxColumn1";
            // 
            // Precio_Producto
            // 
            Precio_Producto.DataPropertyName = "Precio_Producto";
            Precio_Producto.HeaderText = "Precio_Producto";
            Precio_Producto.Name = "Precio_Producto";
            // 
            // cantidadProductoDataGridViewTextBoxColumn1
            // 
            cantidadProductoDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad_Producto";
            cantidadProductoDataGridViewTextBoxColumn1.HeaderText = "Cantidad_Producto";
            cantidadProductoDataGridViewTextBoxColumn1.Name = "cantidadProductoDataGridViewTextBoxColumn1";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Monto_Final";
            Column1.Name = "Column1";
            // 
            // detallePedidoBindingSource1
            // 
            detallePedidoBindingSource1.DataSource = typeof(Kiosco_Candy.DetallePedido);
            // 
            // detallePedidoBindingSource
            // 
            detallePedidoBindingSource.DataSource = typeof(Kiosco_Candy.DetallePedido);
            // 
            // button3
            // 
            button3.BackColor = Color.Violet;
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(141, 354);
            button3.Name = "button3";
            button3.Size = new Size(84, 30);
            button3.TabIndex = 56;
            button3.Text = "ALTA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(565, 354);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 55;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(421, 354);
            button1.Name = "button1";
            button1.Size = new Size(84, 30);
            button1.TabIndex = 54;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Violet;
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(278, 354);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 53;
            button4.Text = "BAJA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // numeropedidoDataGridViewTextBoxColumn
            // 
            numeropedidoDataGridViewTextBoxColumn.DataPropertyName = "numeropedido";
            numeropedidoDataGridViewTextBoxColumn.HeaderText = "numeropedido";
            numeropedidoDataGridViewTextBoxColumn.Name = "numeropedidoDataGridViewTextBoxColumn";
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Pedido";
            fechaPedidoDataGridViewTextBoxColumn.HeaderText = "Fecha_Pedido";
            fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            // 
            // nombreDuenioDataGridViewTextBoxColumn
            // 
            nombreDuenioDataGridViewTextBoxColumn.DataPropertyName = "NombreDuenio";
            nombreDuenioDataGridViewTextBoxColumn.HeaderText = "NombreDuenio";
            nombreDuenioDataGridViewTextBoxColumn.Name = "nombreDuenioDataGridViewTextBoxColumn";
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            // 
            // cantidadProductoDataGridViewTextBoxColumn
            // 
            cantidadProductoDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Producto";
            cantidadProductoDataGridViewTextBoxColumn.HeaderText = "Cantidad_Producto";
            cantidadProductoDataGridViewTextBoxColumn.Name = "cantidadProductoDataGridViewTextBoxColumn";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(257, 103);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 57;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(530, 21);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 23);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 58;
            label8.Text = "Precio Producto";
            // 
            // Detalle_Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "Detalle_Pedido";
            Text = "Detalle_Pedido";
            Load += Detalle_Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)detallePedidoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)detallePedidoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private DataGridView dataGridView1;
        private BindingSource detallePedidoBindingSource;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private BindingSource detallePedidoBindingSource1;
        private DataGridViewTextBoxColumn numeropedidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDuenioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Precio_Producto;
        private DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBox6;
        private Label label8;
    }
}