namespace Esfe.SysVenta.UI
{
    partial class ArticuloWF
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
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            label3 = new Label();
            txtNombreArti = new TextBox();
            txtPrecioUni = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPrecioUni).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(413, 38);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR NUEVO ARTICULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre del articulo:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(292, 224);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(179, 41);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 3;
            label3.Text = "Precio unitario:       $";
            // 
            // txtNombreArti
            // 
            txtNombreArti.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreArti.Location = new Point(203, 120);
            txtNombreArti.Margin = new Padding(3, 4, 3, 4);
            txtNombreArti.Name = "txtNombreArti";
            txtNombreArti.Size = new Size(246, 32);
            txtNombreArti.TabIndex = 4;
            txtNombreArti.TextChanged += textBox1_TextChanged;
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.DecimalPlaces = 2;
            txtPrecioUni.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioUni.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtPrecioUni.Location = new Point(203, 178);
            txtPrecioUni.Margin = new Padding(3, 4, 3, 4);
            txtPrecioUni.Maximum = new decimal(new int[] { 10000, 0, 0, 65536 });
            txtPrecioUni.Minimum = new decimal(new int[] { 10, 0, 0, 131072 });
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(246, 32);
            txtPrecioUni.TabIndex = 5;
            txtPrecioUni.Value = new decimal(new int[] { 10, 0, 0, 131072 });
            // 
            // ArticuloWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 285);
            Controls.Add(txtPrecioUni);
            Controls.Add(txtNombreArti);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ArticuloWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar nuevo Artículo";
            ((System.ComponentModel.ISupportInitialize)txtPrecioUni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private Label label3;
        private TextBox txtNombreArti;
        private NumericUpDown txtPrecioUni;
    }
}