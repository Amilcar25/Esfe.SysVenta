namespace Esfe.SysVenta.UI
{
    partial class VentaWF
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
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCancelarVenta = new Button();
            btnGuardarVeta = new Button();
            txtDescripcion = new ComboBox();
            txtCantidad = new NumericUpDown();
            txtPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(32, 61);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(326, 32);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(32, 141);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(326, 32);
            txtDireccion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 111);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 2;
            label2.Text = "Dirección del Cliente";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(32, 221);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(326, 32);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 4;
            label3.Text = "Télefono del Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(382, 31);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 6;
            label4.Text = "Descripción del articulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(382, 111);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 8;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(382, 191);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 10;
            label6.Text = "Precio Unitario";
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.BackColor = Color.LightCoral;
            btnCancelarVenta.FlatStyle = FlatStyle.Flat;
            btnCancelarVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarVenta.Location = new Point(32, 315);
            btnCancelarVenta.Margin = new Padding(3, 4, 3, 4);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(327, 64);
            btnCancelarVenta.TabIndex = 12;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // btnGuardarVeta
            // 
            btnGuardarVeta.BackColor = Color.LightGreen;
            btnGuardarVeta.FlatStyle = FlatStyle.Flat;
            btnGuardarVeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarVeta.Location = new Point(382, 315);
            btnGuardarVeta.Margin = new Padding(3, 4, 3, 4);
            btnGuardarVeta.Name = "btnGuardarVeta";
            btnGuardarVeta.Size = new Size(327, 64);
            btnGuardarVeta.TabIndex = 13;
            btnGuardarVeta.Text = "Guardar Venta";
            btnGuardarVeta.UseVisualStyleBackColor = false;
            btnGuardarVeta.Click += btnGuardarVeta_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.FormattingEnabled = true;
            txtDescripcion.Location = new Point(383, 61);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(326, 33);
            txtDescripcion.TabIndex = 14;
            txtDescripcion.SelectedIndexChanged += txtDescripcion_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(383, 142);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(326, 32);
            txtCantidad.TabIndex = 15;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.DecimalPlaces = 2;
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtPrecio.Location = new Point(383, 222);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 65536 });
            txtPrecio.Minimum = new decimal(new int[] { 10, 0, 0, 131072 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.RightToLeft = RightToLeft.No;
            txtPrecio.Size = new Size(326, 32);
            txtPrecio.TabIndex = 16;
            txtPrecio.Value = new decimal(new int[] { 10, 0, 0, 131072 });
            // 
            // VentaWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 464);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtDescripcion);
            Controls.Add(btnGuardarVeta);
            Controls.Add(btnCancelarVenta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VentaWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentaUI";
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCancelarVenta;
        private Button btnGuardarVeta;
        private ComboBox txtDescripcion;
        private NumericUpDown txtCantidad;
        private NumericUpDown txtPrecio;
    }
}