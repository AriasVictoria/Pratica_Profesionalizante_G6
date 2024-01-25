namespace Kiosco_Nuevo
{
    partial class MENU
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
            mENÚToolStripMenuItem = new ToolStripMenuItem();
            registraseToolStripMenuItem = new ToolStripMenuItem();
            proveedorToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            productosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENÚToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENÚToolStripMenuItem
            // 
            mENÚToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registraseToolStripMenuItem, productosToolStripMenuItem, proveedorToolStripMenuItem, pedidoToolStripMenuItem });
            mENÚToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            mENÚToolStripMenuItem.ForeColor = Color.HotPink;
            mENÚToolStripMenuItem.Name = "mENÚToolStripMenuItem";
            mENÚToolStripMenuItem.Size = new Size(84, 29);
            mENÚToolStripMenuItem.Text = "MENÚ";
            // 
            // registraseToolStripMenuItem
            // 
            registraseToolStripMenuItem.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registraseToolStripMenuItem.Name = "registraseToolStripMenuItem";
            registraseToolStripMenuItem.Size = new Size(180, 22);
            registraseToolStripMenuItem.Text = "Ingresar Usuario";
            registraseToolStripMenuItem.Click += registraseToolStripMenuItem_Click;
            // 
            // proveedorToolStripMenuItem
            // 
            proveedorToolStripMenuItem.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            proveedorToolStripMenuItem.Size = new Size(180, 22);
            proveedorToolStripMenuItem.Text = "Proveedor";
            proveedorToolStripMenuItem.Click += proveedorToolStripMenuItem_Click;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(180, 22);
            pedidoToolStripMenuItem.Text = "Detalle Pedido";
            pedidoToolStripMenuItem.Click += pedidoToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._84b901c993a93434541265c5973ca643;
            pictureBox1.Location = new Point(280, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 260);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // MENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "MENU";
            Text = "Form1";
            Load += MENU_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENÚToolStripMenuItem;
        private ToolStripMenuItem proveedorToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem registraseToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
    }
}