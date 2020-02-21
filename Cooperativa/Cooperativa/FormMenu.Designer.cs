namespace Cooperativa
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
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.saldoToolStripMenuItem,
            this.maToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.estadoToolStripMenuItem.Text = "Saldo disponible";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.estadoToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.transaccionesToolStripMenuItem.Text = "No Cuenta";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositosToolStripMenuItem,
            this.retirosToolStripMenuItem});
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.saldoToolStripMenuItem.Text = "Transacciones";
            this.saldoToolStripMenuItem.Click += new System.EventHandler(this.saldoToolStripMenuItem_Click);
            // 
            // depositosToolStripMenuItem
            // 
            this.depositosToolStripMenuItem.Name = "depositosToolStripMenuItem";
            this.depositosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depositosToolStripMenuItem.Text = "Depositos";
            this.depositosToolStripMenuItem.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
            // 
            // retirosToolStripMenuItem
            // 
            this.retirosToolStripMenuItem.Name = "retirosToolStripMenuItem";
            this.retirosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retirosToolStripMenuItem.Text = "retiros";
            this.retirosToolStripMenuItem.Click += new System.EventHandler(this.retirosToolStripMenuItem_Click);
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.maToolStripMenuItem.Text = "Login";
            this.maToolStripMenuItem.Click += new System.EventHandler(this.maToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
    }
}

