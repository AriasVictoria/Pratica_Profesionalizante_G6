namespace Forms_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINISTRADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pEDIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENDEDORToolStripMenuItem,
            this.aDMINISTRADORToolStripMenuItem,
            this.pROVEEDORToolStripMenuItem,
            this.pRODUCTOToolStripMenuItem,
            this.pEDIDOToolStripMenuItem});
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // vENDEDORToolStripMenuItem
            // 
            this.vENDEDORToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.vENDEDORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajaToolStripMenuItem});
            this.vENDEDORToolStripMenuItem.Name = "vENDEDORToolStripMenuItem";
            this.vENDEDORToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vENDEDORToolStripMenuItem.Text = "VENDEDOR";
            this.vENDEDORToolStripMenuItem.Click += new System.EventHandler(this.vENDEDORToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.bajaToolStripMenuItem.Text = "ABM";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // aDMINISTRADORToolStripMenuItem
            // 
            this.aDMINISTRADORToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aDMINISTRADORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajaToolStripMenuItem1});
            this.aDMINISTRADORToolStripMenuItem.Name = "aDMINISTRADORToolStripMenuItem";
            this.aDMINISTRADORToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aDMINISTRADORToolStripMenuItem.Text = "ADMINISTRADOR";
            // 
            // bajaToolStripMenuItem1
            // 
            this.bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            this.bajaToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.bajaToolStripMenuItem1.Text = "ABM";
            this.bajaToolStripMenuItem1.Click += new System.EventHandler(this.bajaToolStripMenuItem1_Click);
            // 
            // pROVEEDORToolStripMenuItem
            // 
            this.pROVEEDORToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pROVEEDORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajaToolStripMenuItem2});
            this.pROVEEDORToolStripMenuItem.Name = "pROVEEDORToolStripMenuItem";
            this.pROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pROVEEDORToolStripMenuItem.Text = "PROVEEDOR";
            // 
            // bajaToolStripMenuItem2
            // 
            this.bajaToolStripMenuItem2.Name = "bajaToolStripMenuItem2";
            this.bajaToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.bajaToolStripMenuItem2.Text = "ABM";
            this.bajaToolStripMenuItem2.Click += new System.EventHandler(this.bajaToolStripMenuItem2_Click);
            // 
            // pRODUCTOToolStripMenuItem
            // 
            this.pRODUCTOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pRODUCTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajaToolStripMenuItem3});
            this.pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            this.pRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pRODUCTOToolStripMenuItem.Text = "PRODUCTO";
            this.pRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem3
            // 
            this.bajaToolStripMenuItem3.Name = "bajaToolStripMenuItem3";
            this.bajaToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.bajaToolStripMenuItem3.Text = "ABM";
            this.bajaToolStripMenuItem3.Click += new System.EventHandler(this.bajaToolStripMenuItem3_Click);
            // 
            // pEDIDOToolStripMenuItem
            // 
            this.pEDIDOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pEDIDOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajaToolStripMenuItem4});
            this.pEDIDOToolStripMenuItem.Name = "pEDIDOToolStripMenuItem";
            this.pEDIDOToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pEDIDOToolStripMenuItem.Text = "PEDIDO";
            // 
            // bajaToolStripMenuItem4
            // 
            this.bajaToolStripMenuItem4.Name = "bajaToolStripMenuItem4";
            this.bajaToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.bajaToolStripMenuItem4.Text = "ABM";
            this.bajaToolStripMenuItem4.Click += new System.EventHandler(this.bajaToolStripMenuItem4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem4;
    }
}

