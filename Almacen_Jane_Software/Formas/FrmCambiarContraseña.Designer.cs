namespace Almacen_Jane_Software
{
    partial class FrmCambiarContraseña
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
            this.llblRestablecerContra = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.llblVerificar = new System.Windows.Forms.LinkLabel();
            this.lblNotaContraseña = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblRestablecerContra
            // 
            this.llblRestablecerContra.AutoSize = true;
            this.llblRestablecerContra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRestablecerContra.Location = new System.Drawing.Point(187, 230);
            this.llblRestablecerContra.Name = "llblRestablecerContra";
            this.llblRestablecerContra.Size = new System.Drawing.Size(106, 18);
            this.llblRestablecerContra.TabIndex = 11;
            this.llblRestablecerContra.TabStop = true;
            this.llblRestablecerContra.Text = "Restablecer";
            this.llblRestablecerContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRestablecerContra_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 81);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recuperar contraseña por correo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(174, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(47, 104);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 24);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(174, 143);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(130, 20);
            this.txtNuevaContraseña.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nueva contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(174, 177);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(130, 20);
            this.txtConfirmarContraseña.TabIndex = 15;
            this.txtConfirmarContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirmar contraseña";
            // 
            // llblVerificar
            // 
            this.llblVerificar.AutoSize = true;
            this.llblVerificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblVerificar.Location = new System.Drawing.Point(322, 110);
            this.llblVerificar.Name = "llblVerificar";
            this.llblVerificar.Size = new System.Drawing.Size(76, 18);
            this.llblVerificar.TabIndex = 16;
            this.llblVerificar.TabStop = true;
            this.llblVerificar.Text = "Verificar";
            this.llblVerificar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblVerificar_LinkClicked);
            // 
            // lblNotaContraseña
            // 
            this.lblNotaContraseña.AutoSize = true;
            this.lblNotaContraseña.Location = new System.Drawing.Point(176, 200);
            this.lblNotaContraseña.Name = "lblNotaContraseña";
            this.lblNotaContraseña.Size = new System.Drawing.Size(0, 13);
            this.lblNotaContraseña.TabIndex = 17;
            // 
            // FrmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 263);
            this.Controls.Add(this.lblNotaContraseña);
            this.Controls.Add(this.llblVerificar);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llblRestablecerContra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCambiarContraseña";
            this.Text = "FrmCambiarContraseña";
            this.Load += new System.EventHandler(this.FrmCambiarContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblRestablecerContra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llblVerificar;
        private System.Windows.Forms.Label lblNotaContraseña;
    }
}