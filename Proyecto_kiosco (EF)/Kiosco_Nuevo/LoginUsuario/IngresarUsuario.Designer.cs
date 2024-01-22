namespace Kiosco_Nuevo.LoginUsuario
{
    partial class IngresarUsuario
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(376, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 152);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 9;
            label4.Text = "Contraseña usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 96);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(347, 222);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 13;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(336, 308);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarme como usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(647, 72);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 15;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // IngresarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresarUsuario";
            Text = "IngresarUsuario";
            Load += IngresarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button button4;
    }
}