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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_DragOver(object sender, DragEventArgs e)
        {
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            
        }

        private void llblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread HiloSesion = new Thread(Inicio);
            HiloSesion.Start();
        }
        ClsModulos ObjModulo = new ClsModulos();
        public void Inicio()
        {
            //this.Invoke(new Action(() => dataGridView1.DataSource = ObjModulo.Consultar("Helmer")));
            DataTable TablaSesion = ObjModulo.Consultar(txtUsuario.Text);
            if (TablaSesion.Rows.Count > 0)
            {
                if (txtContraseña.Text == TablaSesion.Rows[0][1].ToString())
                {
                    if (TablaSesion.Rows[0][2].ToString() == "0")
                    {
                        FrmMenu ObjMenu = new FrmMenu();
                        this.Invoke(new Action(() => this.Hide()));
                        this.Invoke(new Action(() => ObjMenu.Visible = true));
                    }
                    else
                    {
                        MessageBox.Show("Status inactivo");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarse ObjRegistrarse = new FrmRegistrarse(this);
            ObjRegistrarse.Show();
            this.Hide();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Thread HiloSesion = new Thread(Inicio);
                HiloSesion.Start();
            }
            if (e.KeyChar == 27)
            {
                if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void FrmInicio_KeyPress(object sender, KeyPressEventArgs e)
        {            
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Thread HiloSesion = new Thread(Inicio);
                HiloSesion.Start();
            }
            if (e.KeyChar == 27)
            {
                if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRestablecerContraseña VenRestablecer = new FrmRestablecerContraseña(this);
            VenRestablecer.Show();
            this.Hide();
        }
    }
}
