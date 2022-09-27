namespace pryBazanSP1Ventas
{
    partial class frmConsultar
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
            this.tabConsultas = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.clientesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVendedor = new System.Windows.Forms.TabPage();
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.vendedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrarComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.facturaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabConsultas.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.tabClientes);
            this.tabConsultas.Controls.Add(this.tabVendedor);
            this.tabConsultas.Controls.Add(this.tabVentas);
            this.tabConsultas.Location = new System.Drawing.Point(12, 12);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.SelectedIndex = 0;
            this.tabConsultas.Size = new System.Drawing.Size(946, 376);
            this.tabConsultas.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.dgvCliente);
            this.tabClientes.Location = new System.Drawing.Point(4, 40);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(938, 332);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientesId,
            this.ClienteNombre});
            this.dgvCliente.Location = new System.Drawing.Point(147, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(664, 279);
            this.dgvCliente.TabIndex = 0;
            // 
            // clientesId
            // 
            this.clientesId.HeaderText = "Clientes ID";
            this.clientesId.MinimumWidth = 6;
            this.clientesId.Name = "clientesId";
            this.clientesId.ReadOnly = true;
            this.clientesId.Width = 250;
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.HeaderText = "Clientes Nombres";
            this.ClienteNombre.MinimumWidth = 6;
            this.ClienteNombre.Name = "ClienteNombre";
            this.ClienteNombre.ReadOnly = true;
            this.ClienteNombre.Width = 350;
            // 
            // tabVendedor
            // 
            this.tabVendedor.Controls.Add(this.dgvVendedor);
            this.tabVendedor.Location = new System.Drawing.Point(4, 40);
            this.tabVendedor.Name = "tabVendedor";
            this.tabVendedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendedor.Size = new System.Drawing.Size(938, 332);
            this.tabVendedor.TabIndex = 2;
            this.tabVendedor.Text = "Vendedores";
            this.tabVendedor.UseVisualStyleBackColor = true;
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.AllowUserToAddRows = false;
            this.dgvVendedor.AllowUserToDeleteRows = false;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendedorId,
            this.vendedorNombre,
            this.activo,
            this.cobrarComision});
            this.dgvVendedor.Location = new System.Drawing.Point(39, 23);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.ReadOnly = true;
            this.dgvVendedor.RowHeadersWidth = 51;
            this.dgvVendedor.RowTemplate.Height = 24;
            this.dgvVendedor.Size = new System.Drawing.Size(871, 278);
            this.dgvVendedor.TabIndex = 0;
            // 
            // vendedorId
            // 
            this.vendedorId.HeaderText = "Vendedor ID";
            this.vendedorId.MinimumWidth = 6;
            this.vendedorId.Name = "vendedorId";
            this.vendedorId.ReadOnly = true;
            this.vendedorId.Width = 200;
            // 
            // vendedorNombre
            // 
            this.vendedorNombre.HeaderText = "Vendedor Nombre";
            this.vendedorNombre.MinimumWidth = 6;
            this.vendedorNombre.Name = "vendedorNombre";
            this.vendedorNombre.ReadOnly = true;
            this.vendedorNombre.Width = 280;
            // 
            // activo
            // 
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 125;
            // 
            // cobrarComision
            // 
            this.cobrarComision.HeaderText = "Cobrar Comisión";
            this.cobrarComision.MinimumWidth = 6;
            this.cobrarComision.Name = "cobrarComision";
            this.cobrarComision.ReadOnly = true;
            this.cobrarComision.Width = 260;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.dgvVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 40);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(938, 332);
            this.tabVentas.TabIndex = 3;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaTipo,
            this.facturaNumero,
            this.fecha,
            this.clienteId,
            this.idVendedor,
            this.monto});
            this.dgvVentas.Location = new System.Drawing.Point(37, 19);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(859, 291);
            this.dgvVentas.TabIndex = 0;
            // 
            // facturaTipo
            // 
            this.facturaTipo.HeaderText = "Factura Tipo";
            this.facturaTipo.MinimumWidth = 6;
            this.facturaTipo.Name = "facturaTipo";
            this.facturaTipo.ReadOnly = true;
            this.facturaTipo.Width = 125;
            // 
            // facturaNumero
            // 
            this.facturaNumero.HeaderText = "Factura Numero";
            this.facturaNumero.MinimumWidth = 6;
            this.facturaNumero.Name = "facturaNumero";
            this.facturaNumero.ReadOnly = true;
            this.facturaNumero.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // clienteId
            // 
            this.clienteId.HeaderText = "Cliente ID";
            this.clienteId.MinimumWidth = 6;
            this.clienteId.Name = "clienteId";
            this.clienteId.ReadOnly = true;
            this.clienteId.Width = 125;
            // 
            // idVendedor
            // 
            this.idVendedor.HeaderText = "Vendedor ID";
            this.idVendedor.MinimumWidth = 6;
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.ReadOnly = true;
            this.idVendedor.Width = 150;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(813, 394);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 44);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabConsultas);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmConsultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            this.tabConsultas.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabVendedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConsultas;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.TabPage tabVendedor;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobrarComision;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}