namespace General.GUI.GUIGestiones
{
    partial class PacientesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalEmpleados = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Insertar,
            this.toolStripSeparator1,
            this.Modificar,
            this.toolStripSeparator2,
            this.Eliminar,
            this.txtFiltro,
            this.toolStripLabel2});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(41, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(904, 48);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(87, 45);
            this.Insertar.Text = "Agregar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(97, 45);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 45);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltro.Size = new System.Drawing.Size(249, 48);
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 45);
            this.toolStripLabel2.Text = "Buscar";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeColumns = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeight = 30;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Paciente,
            this.Pac_Nombre,
            this.Pac_Apellido,
            this.Pac_FechaNacimiento,
            this.Pac_Genero,
            this.Pac_telefono,
            this.Pac_CorreoElectronico,
            this.Pac_Direccion});
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.Location = new System.Drawing.Point(41, 61);
            this.dgvPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(904, 456);
            this.dgvPacientes.TabIndex = 6;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TotalEmpleados});
            this.statusStrip1.Location = new System.Drawing.Point(64, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(185, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel1.Text = "Número de Pacientes:";
            // 
            // TotalEmpleados
            // 
            this.TotalEmpleados.Name = "TotalEmpleados";
            this.TotalEmpleados.Size = new System.Drawing.Size(17, 20);
            this.TotalEmpleados.Text = "0";
            this.TotalEmpleados.Click += new System.EventHandler(this.TotalEmpleados_Click);
            // 
            // ID_Paciente
            // 
            this.ID_Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Paciente.DataPropertyName = "ID_Paciente";
            this.ID_Paciente.HeaderText = "ID_Paciente";
            this.ID_Paciente.MinimumWidth = 6;
            this.ID_Paciente.Name = "ID_Paciente";
            this.ID_Paciente.ReadOnly = true;
            // 
            // Pac_Nombre
            // 
            this.Pac_Nombre.DataPropertyName = "Pac_Nombre";
            this.Pac_Nombre.HeaderText = "Nombre";
            this.Pac_Nombre.MinimumWidth = 6;
            this.Pac_Nombre.Name = "Pac_Nombre";
            this.Pac_Nombre.ReadOnly = true;
            // 
            // Pac_Apellido
            // 
            this.Pac_Apellido.DataPropertyName = "Pac_Apellido";
            this.Pac_Apellido.HeaderText = "Apellido";
            this.Pac_Apellido.MinimumWidth = 6;
            this.Pac_Apellido.Name = "Pac_Apellido";
            this.Pac_Apellido.ReadOnly = true;
            // 
            // Pac_FechaNacimiento
            // 
            this.Pac_FechaNacimiento.DataPropertyName = "Pac_FechaNacimiento";
            this.Pac_FechaNacimiento.HeaderText = "FechaNacimiento";
            this.Pac_FechaNacimiento.MinimumWidth = 6;
            this.Pac_FechaNacimiento.Name = "Pac_FechaNacimiento";
            this.Pac_FechaNacimiento.ReadOnly = true;
            // 
            // Pac_Genero
            // 
            this.Pac_Genero.DataPropertyName = "Pac_Genero";
            this.Pac_Genero.HeaderText = "Genero";
            this.Pac_Genero.MinimumWidth = 6;
            this.Pac_Genero.Name = "Pac_Genero";
            this.Pac_Genero.ReadOnly = true;
            // 
            // Pac_telefono
            // 
            this.Pac_telefono.DataPropertyName = "Pac_telefono";
            this.Pac_telefono.HeaderText = "telefono";
            this.Pac_telefono.MinimumWidth = 6;
            this.Pac_telefono.Name = "Pac_telefono";
            this.Pac_telefono.ReadOnly = true;
            // 
            // Pac_CorreoElectronico
            // 
            this.Pac_CorreoElectronico.DataPropertyName = "Pac_CorreoElectronico";
            this.Pac_CorreoElectronico.HeaderText = "CorreoElectronico";
            this.Pac_CorreoElectronico.MinimumWidth = 6;
            this.Pac_CorreoElectronico.Name = "Pac_CorreoElectronico";
            this.Pac_CorreoElectronico.ReadOnly = true;
            // 
            // Pac_Direccion
            // 
            this.Pac_Direccion.DataPropertyName = "Pac_Direccion";
            this.Pac_Direccion.HeaderText = "Direccion";
            this.Pac_Direccion.MinimumWidth = 6;
            this.Pac_Direccion.Name = "Pac_Direccion";
            this.Pac_Direccion.ReadOnly = true;
            // 
            // PacientesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(985, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PacientesGestion";
            this.Text = "PacientesGestion";
            this.Load += new System.EventHandler(this.PacientesGestion_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TotalEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pac_Direccion;
    }
}