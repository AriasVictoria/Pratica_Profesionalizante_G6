namespace Kiosco_Nuevo.Pedido
{
    partial class PantallaPedido
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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pedidoBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            precioProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoFinalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pedidoBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(151, 177);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 48;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 106);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 45;
            label6.Text = "Precio ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 180);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 44;
            label5.Text = "Monto Final";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 37;
            label1.Text = "Id";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 128);
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(686, 281);
            button4.Name = "button4";
            button4.Size = new Size(92, 31);
            button4.TabIndex = 36;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(566, 281);
            button3.Name = "button3";
            button3.Size = new Size(100, 31);
            button3.TabIndex = 35;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(449, 281);
            button2.Name = "button2";
            button2.Size = new Size(95, 31);
            button2.TabIndex = 34;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(332, 281);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 33;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pedidoBindingSource
            // 
            pedidoBindingSource.DataSource = typeof(Back.Pedidos);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, precioProductoDataGridViewTextBoxColumn, montoFinalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pedidoBindingSource1;
            dataGridView1.Location = new Point(332, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(445, 147);
            dataGridView1.TabIndex = 50;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            precioProductoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Producto";
            precioProductoDataGridViewTextBoxColumn.HeaderText = "Precio_Producto";
            precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            // 
            // montoFinalDataGridViewTextBoxColumn
            // 
            montoFinalDataGridViewTextBoxColumn.DataPropertyName = "MontoFinal";
            montoFinalDataGridViewTextBoxColumn.HeaderText = "MontoFinal";
            montoFinalDataGridViewTextBoxColumn.Name = "montoFinalDataGridViewTextBoxColumn";
            // 
            // pedidoBindingSource1
            // 
            pedidoBindingSource1.DataSource = typeof(Back.Pedidos);
            // 
            // PantallaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PantallaPedido";
            Text = "PantallaPedido";
            Load += PantallaPedido_Load;
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private BindingSource pedidoBindingSource;
        private DataGridView dataGridView1;
        private BindingSource pedidoBindingSource1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoFinalDataGridViewTextBoxColumn;
    }
}