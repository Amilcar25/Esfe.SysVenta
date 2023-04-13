namespace Esfe.SysVenta.UI
{
    partial class PrincipalWF
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
            menuStrip1 = new MenuStrip();
            compraYVentaToolStripMenuItem = new ToolStripMenuItem();
            compraToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { compraYVentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(823, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // compraYVentaToolStripMenuItem
            // 
            compraYVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { compraToolStripMenuItem, ventaToolStripMenuItem });
            compraYVentaToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            compraYVentaToolStripMenuItem.Name = "compraYVentaToolStripMenuItem";
            compraYVentaToolStripMenuItem.Size = new Size(265, 29);
            compraYVentaToolStripMenuItem.Text = "Compra y Venta de Artículos";
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(228, 28);
            compraToolStripMenuItem.Text = "Comprar Arículos";
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(228, 28);
            ventaToolStripMenuItem.Text = "Vender Artículos";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(429, 30);
            label1.Name = "label1";
            label1.Size = new Size(394, 72);
            label1.TabIndex = 2;
            label1.Text = "Sistema De Ventas";
            // 
            // PrincipalWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 556);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PrincipalWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem compraYVentaToolStripMenuItem;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private Label label1;
    }
}