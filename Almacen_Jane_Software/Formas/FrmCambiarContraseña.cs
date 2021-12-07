using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Almacen_Jane_Software
{
    public partial class FrmCambiarContraseña : Form
    {
        ClsCorreo ClaseCorreos = new ClsCorreo();
        FrmInicio Inicio;
        int Id_Empleado;
        public FrmCambiarContraseña(FrmInicio Inicio, int Id_Empleado)
        {
            InitializeComponent();
            this.Inicio = Inicio;
            this.Id_Empleado = Id_Empleado;
        }

        private void llblVerificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread HiloVerificar = new Thread(Verificar);
            HiloVerificar.Start();
        }
        public void Verificar()
        {
            
            DataTable Tabla = ClaseCorreos.ConsultarCodigo(Id_Empleado);
            if (Tabla.Rows[0]["Codigo"].ToString() == txtCodigo.Text)
            {
                this.Invoke(new Action(() => txtCodigo.Enabled = false));
                this.Invoke(new Action(() => llblVerificar.Visible = false));
                this.Invoke(new Action(() => this.Height = 301));
            }
            else
            {
                this.Invoke(new Action(() => MessageBox.Show("Codigo incorrecto")));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.Text == txtConfirmarContraseña.Text)
            {
                lblNotaContraseña.Text = "Contraseñas coinciden";
                lblNotaContraseña.ForeColor = Color.Green;
            }
            else
            {
                lblNotaContraseña.Text = "Contraseñas no coinciden";
                lblNotaContraseña.ForeColor = Color.Red;
            }
            if (txtConfirmarContraseña.Text == "" || txtNuevaContraseña.Text == "")
            {
                lblNotaContraseña.Text = "";
            }
        }

        private void FrmCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void llblRestablecerContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClaseCorreos.CambiarContraseña(txtConfirmarContraseña.Text, Id_Empleado);
            ClaseCorreos.MandarCodigo("",Id_Empleado);
        }
    }
}
