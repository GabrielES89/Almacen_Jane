namespace Almacen_Jane_Software
{
    partial class FrmRegistrarse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.llblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.llblCerrar = new System.Windows.Forms.LinkLabel();
            this.lblNotaMatricula = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotaContraseña = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Almacen_Jane_Software.Properties.Resources.aaaaa;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(417, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 68);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrarse";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(12, 117);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(114, 21);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 157);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(89, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(12, 189);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(129, 21);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(169, 118);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(322, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(169, 157);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(322, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(169, 188);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(322, 20);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // llblRegistrarse
            // 
            this.llblRegistrarse.ActiveLinkColor = System.Drawing.Color.White;
            this.llblRegistrarse.AutoSize = true;
            this.llblRegistrarse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegistrarse.LinkColor = System.Drawing.Color.Black;
            this.llblRegistrarse.Location = new System.Drawing.Point(286, 256);
            this.llblRegistrarse.Name = "llblRegistrarse";
            this.llblRegistrarse.Size = new System.Drawing.Size(107, 23);
            this.llblRegistrarse.TabIndex = 4;
            this.llblRegistrarse.TabStop = true;
            this.llblRegistrarse.Text = "Registrarse";
            this.llblRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegistrarse_LinkClicked);
            // 
            // llblCerrar
            // 
            this.llblCerrar.ActiveLinkColor = System.Drawing.Color.White;
            this.llblCerrar.AutoSize = true;
            this.llblCerrar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCerrar.LinkColor = System.Drawing.Color.Black;
            this.llblCerrar.Location = new System.Drawing.Point(413, 256);
            this.llblCerrar.Name = "llblCerrar";
            this.llblCerrar.Size = new System.Drawing.Size(68, 23);
            this.llblCerrar.TabIndex = 5;
            this.llblCerrar.TabStop = true;
            this.llblCerrar.Text = "Cerrar";
            this.llblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCerrar_LinkClicked);
            // 
            // lblNotaMatricula
            // 
            this.lblNotaMatricula.AutoSize = true;
            this.lblNotaMatricula.Location = new System.Drawing.Point(166, 141);
            this.lblNotaMatricula.Name = "lblNotaMatricula";
            this.lblNotaMatricula.Size = new System.Drawing.Size(0, 13);
            this.lblNotaMatricula.TabIndex = 9;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(169, 222);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(322, 20);
            this.txtConfirmarContraseña.TabIndex = 3;
            this.txtConfirmarContraseña.TextChanged += new System.EventHandler(this.txtConfirmarContraseña_TextChanged);
            this.txtConfirmarContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirmar \r\nContraseña\r\n";
            // 
            // lblNotaContraseña
            // 
            this.lblNotaContraseña.AutoSize = true;
            this.lblNotaContraseña.Location = new System.Drawing.Point(166, 245);
            this.lblNotaContraseña.Name = "lblNotaContraseña";
            this.lblNotaContraseña.Size = new System.Drawing.Size(0, 13);
            this.lblNotaContraseña.TabIndex = 12;
            // 
            // FrmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(503, 288);
            this.Controls.Add(this.lblNotaContraseña);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotaMatricula);
            this.Controls.Add(this.llblCerrar);
            this.Controls.Add(this.llblRegistrarse);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarse";
            this.MaximumSizeChanged += new System.EventHandler(this.FrmRegistrarse_MaximumSizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistrarse_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmRegistrarse_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel llblRegistrarse;
        private System.Windows.Forms.LinkLabel llblCerrar;
        private System.Windows.Forms.Label lblNotaMatricula;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotaContraseña;
    }
}