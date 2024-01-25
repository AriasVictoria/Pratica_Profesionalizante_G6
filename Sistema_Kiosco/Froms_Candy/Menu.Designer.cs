namespace Froms_Candy
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            ingresarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            prodcutosToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            detallePedidoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarUsuarioToolStripMenuItem, prodcutosToolStripMenuItem, proveedoresToolStripMenuItem, detallePedidoToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mENUToolStripMenuItem.ForeColor = Color.DarkOrchid;
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(63, 22);
            mENUToolStripMenuItem.Text = "MENU";
            // 
            // ingresarUsuarioToolStripMenuItem
            // 
            ingresarUsuarioToolStripMenuItem.BackColor = SystemColors.Control;
            ingresarUsuarioToolStripMenuItem.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            ingresarUsuarioToolStripMenuItem.Name = "ingresarUsuarioToolStripMenuItem";
            ingresarUsuarioToolStripMenuItem.Size = new Size(180, 24);
            ingresarUsuarioToolStripMenuItem.Text = "Ingresar Usuario";
            ingresarUsuarioToolStripMenuItem.Click += ingresarUsuarioToolStripMenuItem_Click;
            // 
            // prodcutosToolStripMenuItem
            // 
            prodcutosToolStripMenuItem.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            prodcutosToolStripMenuItem.Name = "prodcutosToolStripMenuItem";
            prodcutosToolStripMenuItem.Size = new Size(180, 24);
            prodcutosToolStripMenuItem.Text = "Productos";
            prodcutosToolStripMenuItem.Click += prodcutosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 24);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // detallePedidoToolStripMenuItem
            // 
            detallePedidoToolStripMenuItem.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            detallePedidoToolStripMenuItem.Name = "detallePedidoToolStripMenuItem";
            detallePedidoToolStripMenuItem.Size = new Size(180, 24);
            detallePedidoToolStripMenuItem.Text = "Detalle Pedido";
            detallePedidoToolStripMenuItem.Click += detallePedidoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(308, 159);
            label1.Name = "label1";
            label1.Size = new Size(205, 60);
            label1.TabIndex = 1;
            label1.Text = "KIOSCO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(348, 219);
            label2.Name = "label2";
            label2.Size = new Size(113, 42);
            label2.TabIndex = 2;
            label2.Text = "candy";
            label2.Click += label2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem ingresarUsuarioToolStripMenuItem;
        private ToolStripMenuItem prodcutosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem detallePedidoToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}