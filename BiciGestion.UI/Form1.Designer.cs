namespace BiciGestion.UI
{
    partial class Form1
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
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            lblDni = new Label();
            lblImporte = new Label();
            lblFecha = new Label();
            txtDni = new TextBox();
            txtImporte = new TextBox();
            dtpFecha = new DateTimePicker();
            btnListar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvAlquileres = new DataGridView();
            btnAgregarBorrador = new Button();
            btnConfirmarBorrador = new Button();
            dgvBorrador = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrador).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Urbana ", "Montaña", "Electrica" });
            cmbTipo.Location = new Point(110, 29);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(200, 23);
            cmbTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(10, 37);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(78, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo bicicleta";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(506, 40);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(63, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "Dni cliente";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(12, 82);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(76, 15);
            lblImporte.TabIndex = 3;
            lblImporte.Text = "Importe total";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(506, 80);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(590, 32);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(200, 23);
            txtDni.TabIndex = 6;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(110, 74);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(200, 23);
            txtImporte.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(590, 74);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 480);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(382, 480);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(715, 480);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlquileres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(12, 310);
            dgvAlquileres.MultiSelect = false;
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileres.Size = new Size(778, 150);
            dgvAlquileres.TabIndex = 14;
            // 
            // btnAgregarBorrador
            // 
            btnAgregarBorrador.Location = new Point(12, 128);
            btnAgregarBorrador.Name = "btnAgregarBorrador";
            btnAgregarBorrador.Size = new Size(147, 23);
            btnAgregarBorrador.TabIndex = 15;
            btnAgregarBorrador.Text = "Agregar al borrador";
            btnAgregarBorrador.UseVisualStyleBackColor = true;
            btnAgregarBorrador.Click += btnAgregarBorrador_Click;
            // 
            // btnConfirmarBorrador
            // 
            btnConfirmarBorrador.Location = new Point(655, 128);
            btnConfirmarBorrador.Name = "btnConfirmarBorrador";
            btnConfirmarBorrador.Size = new Size(135, 23);
            btnConfirmarBorrador.TabIndex = 16;
            btnConfirmarBorrador.Text = "Confirmar alquileres";
            btnConfirmarBorrador.UseVisualStyleBackColor = true;
            btnConfirmarBorrador.Click += btnConfirmarBorrador_Click;
            // 
            // dgvBorrador
            // 
            dgvBorrador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrador.Location = new Point(12, 176);
            dgvBorrador.Name = "dgvBorrador";
            dgvBorrador.Size = new Size(778, 116);
            dgvBorrador.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 515);
            Controls.Add(dgvBorrador);
            Controls.Add(btnConfirmarBorrador);
            Controls.Add(btnAgregarBorrador);
            Controls.Add(dgvAlquileres);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnListar);
            Controls.Add(dtpFecha);
            Controls.Add(txtImporte);
            Controls.Add(txtDni);
            Controls.Add(lblFecha);
            Controls.Add(lblImporte);
            Controls.Add(lblDni);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(800, 400);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Label lblTipo;
        private Label lblDni;
        private Label lblImporte;
        private Label lblFecha;
        private TextBox txtDni;
        private TextBox txtImporte;
        private DateTimePicker dtpFecha;
        private Button btnListar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvAlquileres;
        private Button btnAgregarBorrador;
        private Button btnConfirmarBorrador;
        private DataGridView dgvBorrador;
    }
}
