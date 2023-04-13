namespace Esfe.SysVenta.UI
{
    partial class MainWf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWf));
            gridDatosVentas = new DataGridView();
            label1 = new Label();
            addVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)gridDatosVentas).BeginInit();
            SuspendLayout();
            // 
            // gridDatosVentas
            // 
            gridDatosVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridDatosVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridDatosVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatosVentas.Location = new Point(16, 107);
            gridDatosVentas.Margin = new Padding(3, 4, 3, 4);
            gridDatosVentas.Name = "gridDatosVentas";
            gridDatosVentas.RowHeadersWidth = 51;
            gridDatosVentas.RowTemplate.Height = 25;
            gridDatosVentas.Size = new Size(862, 437);
            gridDatosVentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(374, 72);
            label1.TabIndex = 1;
            label1.Text = "Listado de Ventas";
            // 
            // addVenta
            // 
            addVenta.Cursor = Cursors.Hand;
            addVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addVenta.Image = (Image)resources.GetObject("addVenta.Image");
            addVenta.ImageAlign = ContentAlignment.MiddleRight;
            addVenta.Location = new Point(666, 18);
            addVenta.Margin = new Padding(3, 4, 3, 4);
            addVenta.Name = "addVenta";
            addVenta.Size = new Size(212, 71);
            addVenta.TabIndex = 2;
            addVenta.Text = "Nueva venta";
            addVenta.TextAlign = ContentAlignment.MiddleLeft;
            addVenta.UseVisualStyleBackColor = true;
            addVenta.Click += addVenta_Click;
            // 
            // MainWf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 571);
            Controls.Add(addVenta);
            Controls.Add(label1);
            Controls.Add(gridDatosVentas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainWf";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema De Ventas";
            ((System.ComponentModel.ISupportInitialize)gridDatosVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button addVenta;
        public DataGridView gridDatosVentas;
    }
}