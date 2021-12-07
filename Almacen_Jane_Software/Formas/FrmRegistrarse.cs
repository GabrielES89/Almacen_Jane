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
    public partial class FrmRegistrarse : Form
    {
        FrmInicio Inicio;
        ClsModulos Modulos = new ClsModulos();
        int Id_Empleado;
        public FrmRegistrarse(FrmInicio Inicio)
        {
            InitializeComponent();
            this.Inicio = Inicio;
        }

        private void FrmRegistrarse_SizeChanged(object sender, EventArgs e)
        {
        }

        private void FrmRegistrarse_MaximumSizeChanged(object sender, EventArgs e)
        {
        }

        private void FrmRegistrarse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicio.Show();
        }

        private void llblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblNotaMatricula.ForeColor == Color.Green && lblNotaContraseña.ForeColor == Color.Green)
            {
                Thread HiloCrearUsuario = new Thread(CrearUsuario);
                HiloCrearUsuario.Start();
            }
            else
            {
                MessageBox.Show("Revise bien sus datos");
            }
        }
        public void CrearUsuario ()
        {
            this.Invoke(new Action (() => MessageBox.Show(Modulos.CrearUsuario(txtUsuario.Text, txtContraseña.Text, Id_Empleado))));
            this.Invoke(new Action(() => txtMatricula.Text = ""));
            this.Invoke(new Action(() => txtUsuario.Text = ""));
            this.Invoke(new Action(() => txtContraseña.Text = ""));
            this.Invoke(new Action(() => txtConfirmarContraseña.Text = ""));
            this.Invoke(new Action(() => txtMatricula.Focus()));
        }
        int x = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (x == 0)
            {
                Thread HiloMatricula = new Thread(RevisarMatricula);
                HiloMatricula.Start();
                x = 1;
            }
           
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
                        this.Invoke(new Action(() => lblNotaMatricula.Text = "Matricula ya registrada"));
                        lblNotaMatricula.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (TablaMatricula.Rows[0]["Status"].ToString() == "Activo")
                        {
                            this.Invoke(new Action(() => lblNotaMatricula.Text = "Matricula acceptada"));
                            lblNotaMatricula.ForeColor = Color.Green;
                            Id_Empleado = Convert.ToInt32(TablaMatricula.Rows[0]["Id_Empleado"].ToString());
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

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                lblNotaContraseña.Text = "Contraseñas coinciden";
                lblNotaContraseña.ForeColor = Color.Green;
            }
            else
            {
                lblNotaContraseña.Text = "Contraseñas no coinciden";
                lblNotaContraseña.ForeColor = Color.Red;
            }
            if (txtConfirmarContraseña.Text == ""|| txtContraseña.Text == "")
            {
                lblNotaContraseña.Text = "";
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (lblNotaMatricula.ForeColor == Color.Green && lblNotaContraseña.ForeColor == Color.Green)
                {
                    Thread HiloCrearUsuario = new Thread(CrearUsuario);
                    HiloCrearUsuario.Start();
                }
                else
                {
                    MessageBox.Show("Revise bien sus datos");
                }
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (lblNotaMatricula.ForeColor == Color.Green && lblNotaContraseña.ForeColor == Color.Green)
                {
                    Thread HiloCrearUsuario = new Thread(CrearUsuario);
                    HiloCrearUsuario.Start();
                }
                else
                {
                    MessageBox.Show("Revise bien sus datos");
                }
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (lblNotaMatricula.ForeColor == Color.Green && lblNotaContraseña.ForeColor == Color.Green)
                {
                    Thread HiloCrearUsuario = new Thread(CrearUsuario);
                    HiloCrearUsuario.Start();
                }
                else
                {
                    MessageBox.Show("Revise bien sus datos");
                }
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (lblNotaMatricula.ForeColor == Color.Green && lblNotaContraseña.ForeColor == Color.Green)
                {
                    Thread HiloCrearUsuario = new Thread(CrearUsuario);
                    HiloCrearUsuario.Start();
                }
                else
                {
                    MessageBox.Show("Revise bien sus datos");
                }
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

    }
}
