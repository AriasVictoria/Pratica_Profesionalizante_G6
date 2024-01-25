namespace Froms_Candy
{
    partial class Pantalla_Usuario
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
            dataGridView1 = new DataGridView();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDuenioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDuenioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contraseniaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueñoBindingSource = new BindingSource(components);
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dueñoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dNIDataGridViewTextBoxColumn, nombreDuenioDataGridViewTextBoxColumn, apellidoDuenioDataGridViewTextBoxColumn, contraseniaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dueñoBindingSource;
            dataGridView1.Location = new Point(56, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 0;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // nombreDuenioDataGridViewTextBoxColumn
            // 
            nombreDuenioDataGridViewTextBoxColumn.DataPropertyName = "NombreDuenio";
            nombreDuenioDataGridViewTextBoxColumn.HeaderText = "NombreDuenio";
            nombreDuenioDataGridViewTextBoxColumn.Name = "nombreDuenioDataGridViewTextBoxColumn";
            // 
            // apellidoDuenioDataGridViewTextBoxColumn
            // 
            apellidoDuenioDataGridViewTextBoxColumn.DataPropertyName = "ApellidoDuenio";
            apellidoDuenioDataGridViewTextBoxColumn.HeaderText = "ApellidoDuenio";
            apellidoDuenioDataGridViewTextBoxColumn.Name = "apellidoDuenioDataGridViewTextBoxColumn";
            // 
            // contraseniaDataGridViewTextBoxColumn
            // 
            contraseniaDataGridViewTextBoxColumn.DataPropertyName = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.HeaderText = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
            // 
            // dueñoBindingSource
            // 
            dueñoBindingSource.DataSource = typeof(Kiosco_Candy.Dueño);
            // 
            // button4
            // 
            button4.BackColor = Color.Violet;
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(686, 69);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 25;
            button4.Text = "BAJA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(686, 134);
            button1.Name = "button1";
            button1.Size = new Size(84, 30);
            button1.TabIndex = 26;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 234);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 27;
            label1.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 281);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 28;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 330);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 29;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 376);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 30;
            label4.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(303, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(303, 373);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 34;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(686, 202);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 35;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(729, 29);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 37;
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
            label6.TabIndex = 36;
            label6.Text = "KIOSCO";
            // 
            // Pantalla_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlText;
            Name = "Pantalla_Usuario";
            Text = "Pantalla_Usuario";
            Load += Pantalla_Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dueñoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource dueñoBindingSource;
        private Button button4;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDuenioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDuenioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private Label label5;
        private Label label6;
    }
}