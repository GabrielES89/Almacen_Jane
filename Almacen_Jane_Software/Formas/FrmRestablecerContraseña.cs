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
    public partial class FrmRestablecerContraseña : Form
    {
        FrmInicio Inicio;
        ClsModulos Modulos = new ClsModulos();
        int Id_Empleado, x = 0;
        public FrmRestablecerContraseña(FrmInicio Inicio)
        {
            InitializeComponent();
            this.Inicio = Inicio;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread HiloCorreo = new Thread(Correo);
            HiloCorreo.Start();
        }
        public void Correo()
        {
            ClsCorreo ObjCorreo = new ClsCorreo();
            this.Invoke(new Action(() => MessageBox.Show(ObjCorreo.MandarCorreo(txtMatricula.Text))));
            FrmCambiarContraseña VentanaCambiarContra = new FrmCambiarContraseña(Inicio, Id_Empleado);
            this.Invoke(new Action(() => VentanaCambiarContra.Show()));
            this.Invoke(new Action(() => this.Close()));
        }
        public void RevisarMatricula()
        {
            DataTable TablaMatricula = new DataTable();
            TablaMatricula = Modulos.ConsultarMatricula(txtMatricula.Text);
            if (TablaMatricula.Rows.Count > 0)
            {
                if (TablaMatricula.Rows[0]["Matricula"].ToString() == txtMatricula.Text)
                {
                    if (TablaMatricula.Rows[0]["Nombre"].ToString() != "")
                    {
                        this.Invoke(new Action(() => lblNotaMatricula.Text = "Matricula acceptada"));
                        lblNotaMatricula.ForeColor = Color.Green;
                        Id_Empleado = Convert.ToInt32(TablaMatricula.Rows[0]["Id_Empleado"].ToString());
                    }
                    else
                    {
                        if (TablaMatricula.Rows[0]["Status"].ToString() == "Activo")
                        {
                            this.Invoke(new Action(() => lblNotaMatricula.Text = "Matricula sin usuario"));
                            lblNotaMatricula.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.Invoke(new Action(() => lblNotaMatricula.Text = "Empleado dado de baja"));
                            lblNotaMatricula.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                if (txtMatricula.Text == "")
                {
                    this.Invoke(new Action(() => lblNotaMatricula.Text = ""));
                }
                else
                {
                    this.Invoke(new Action(() => lblNotaMatricula.Text = "Matricula no existe"));
                    lblNotaMatricula.ForeColor = Color.Red;
                }
            }
            x = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (x == 0)
            {
                Thread HiloMatricula = new Thread(RevisarMatricula);
                HiloMatricula.Start();
                x = 1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
