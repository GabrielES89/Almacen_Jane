namespace Almacen_Jane_Software
{
    partial class FrmFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtParte = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtP_Unitario = new System.Windows.Forms.TextBox();
            this.lklblAgregar = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Parte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_P_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.txtNoFactura);
            this.panel2.Controls.Add(this.cbProveedor);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 120);
            this.panel2.TabIndex = 1;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(12, 71);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(121, 20);
            this.txtNoFactura.TabIndex = 1;
            this.txtNoFactura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNoFactura_MouseClick);
            this.txtNoFactura.Enter += new System.EventHandler(this.txtNoFactura_Enter);
            this.txtNoFactura.Leave += new System.EventHandler(this.txtNoFactura_Leave);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DisplayMember = "Aaa";
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(12, 25);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbProveedor.TabIndex = 0;
            this.cbProveedor.Tag = "";
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            this.cbProveedor.Enter += new System.EventHandler(this.cbProveedor_Enter);
            this.cbProveedor.Leave += new System.EventHandler(this.cbProveedor_Leave);
            // 
            // cbNombre
            // 
            this.cbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNombre.DisplayMember = "Aaa";
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            ""});
            this.cbNombre.Location = new System.Drawing.Point(6, 23);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(170, 21);
            this.cbNombre.TabIndex = 2;
            this.cbNombre.Tag = "";
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            this.cbNombre.Leave += new System.EventHandler(this.cbNombre_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Location = new System.Drawing.Point(182, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(170, 20);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMarca_MouseClick);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Location = new System.Drawing.Point(358, 23);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(170, 20);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtModelo_MouseClick);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtParte
            // 
            this.txtParte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParte.Location = new System.Drawing.Point(534, 23);
            this.txtParte.Name = "txtParte";
            this.txtParte.Size = new System.Drawing.Size(170, 20);
            this.txtParte.TabIndex = 5;
            this.txtParte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtParte_MouseClick);
            this.txtParte.Leave += new System.EventHandler(this.txtParte_Leave);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(710, 23);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(170, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCantidad_MouseClick);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtP_Unitario
            // 
            this.txtP_Unitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Unitario.Location = new System.Drawing.Point(886, 23);
            this.txtP_Unitario.Name = "txtP_Unitario";
            this.txtP_Unitario.Size = new System.Drawing.Size(170, 20);
            this.txtP_Unitario.TabIndex = 7;
            this.txtP_Unitario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtP_Unitario_MouseClick);
            this.txtP_Unitario.Leave += new System.EventHandler(this.txtP_Unitario_Leave);
            // 
            // lklblAgregar
            // 
            this.lklblAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklblAgregar.AutoSize = true;
            this.lklblAgregar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblAgregar.Location = new System.Drawing.Point(1080, 18);
            this.lklblAgregar.Name = "lklblAgregar";
            this.lklblAgregar.Size = new System.Drawing.Size(83, 23);
            this.lklblAgregar.TabIndex = 8;
            this.lklblAgregar.TabStop = true;
            this.lklblAgregar.Text = "Agregar";
            this.lklblAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblAgregar_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMarca);
            this.panel3.Controls.Add(this.lklblAgregar);
            this.panel3.Controls.Add(this.cbNombre);
            this.panel3.Controls.Add(this.txtP_Unitario);
            this.panel3.Controls.Add(this.txtModelo);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.txtParte);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1166, 78);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Nombre,
            this.C_Marca,
            this.C_Modelo,
            this.C_Parte,
            this.C_Cantidad,
            this.C_P_Unitario,
            this.C_Importe});
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1166, 175);
            this.dataGridView1.TabIndex = 11;
            // 
            // C_Nombre
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Nombre.DefaultCellStyle = dataGridViewCellStyle8;
            this.C_Nombre.HeaderText = "Nombre";
            this.C_Nombre.Name = "C_Nombre";
            // 
            // C_Marca
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Marca.DefaultCellStyle = dataGridViewCellStyle9;
            this.C_Marca.HeaderText = "Marca";
            this.C_Marca.Name = "C_Marca";
            // 
            // C_Modelo
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Modelo.DefaultCellStyle = dataGridViewCellStyle10;
            this.C_Modelo.HeaderText = "Modelo";
            this.C_Modelo.Name = "C_Modelo";
            // 
            // C_Parte
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Parte.DefaultCellStyle = dataGridViewCellStyle11;
            this.C_Parte.HeaderText = "Parte";
            this.C_Parte.Name = "C_Parte";
            // 
            // C_Cantidad
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Cantidad.DefaultCellStyle = dataGridViewCellStyle12;
            this.C_Cantidad.HeaderText = "Cantidad";
            this.C_Cantidad.Name = "C_Cantidad";
            // 
            // C_P_Unitario
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_P_Unitario.DefaultCellStyle = dataGridViewCellStyle13;
            this.C_P_Unitario.HeaderText = "P.Unitario";
            this.C_P_Unitario.Name = "C_P_Unitario";
            // 
            // C_Importe
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Importe.DefaultCellStyle = dataGridViewCellStyle14;
            this.C_Importe.HeaderText = "Importe";
            this.C_Importe.Name = "C_Importe";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(1021, 376);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubtotal.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1021, 428);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 13;
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(1021, 402);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(0, 13);
            this.lblIVA.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Image = global::Almacen_Jane_Software.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(12, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(67, 62);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = global::Almacen_Jane_Software.Properties.Resources.aaaaa;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(538, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 104);
            this.panel1.TabIndex = 0;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtParte;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtP_Unitario;
        private System.Windows.Forms.LinkLabel lklblAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Parte;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_P_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Importe;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Button btnGuardar;
    }
}