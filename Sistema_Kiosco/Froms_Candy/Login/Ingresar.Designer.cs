namespace Froms_Candy
{
    partial class Ingresar
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
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(720, 29);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 4;
            label2.Text = "candy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(703, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "KIOSCO";
            // 
            // button4
            // 
            button4.BackColor = Color.Violet;
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(608, 79);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 23;
            button4.Text = "VOLVER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(331, 256);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 22;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(372, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 188);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 18;
            label4.Text = "Contraseña usuario";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(326, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 15);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarme como usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 37);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 25;
            label6.Text = "Dni";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(372, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 139);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 28;
            label5.Text = "Apellido usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 86);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 27;
            label3.Text = "Nombre usuario";
            // 
            // Ingresar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ingresar";
            Text = "Ingresar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button4;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
    }
}