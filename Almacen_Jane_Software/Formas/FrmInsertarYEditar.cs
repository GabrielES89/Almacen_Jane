using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen_Jane_Software
{
    public partial class FrmInsertarYEditar : Form
    {
        int x, y;
        public FrmInsertarYEditar(int x, int y)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
        }
        public Action Abrir;
        private void FrmInsertarYEditar_Load(object sender, EventArgs e)
        {
            switch (x)
            {
                case 0:
                    Cambios(x, y);
                    break;
                case 1:
                    Cambios(x, y);
                    break;
                default:
                    break;
            }
        }
        public void Cambios(int Aux, int Mod0Ins)
        {
            lblCampo1.Visible = false;
            lblCampo2.Visible = false;
            lblCampo3.Visible = false;
            lblCampo4.Visible = false;
            lblCampo5.Visible = false;
            lblCampo6.Visible = false;
            lblCampo7.Visible = false;
            lblCampo8.Visible = false;
            lblCampo9.Visible = false;
            lblCampo10.Visible = false;
            txtCampo1.Visible = false;
            txtCampo2.Visible = false;
            txtCampo3.Visible = false;
            txtCampo4.Visible = false;
            txtCampo5.Visible = false;
            txtCampo6.Visible = false;
            txtCampo7.Visible = false;
            txtCampo8.Visible = false;
            txtCampo9.Visible = false;
            txtCampo10.Visible = false;
            btnInsertar.Visible = true;
            PanelCampos.Visible = true;
            switch (Aux)
            {
                case 0:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Matricula";
                            lblCampo1.Visible = true;
                            lblCampo2.Text = "Nombres";
                            lblCampo2.Visible = true;
                            lblCampo3.Text = "Apellido paterno";
                            lblCampo3.Visible = true;
                            lblCampo4.Text = "Apellido materno";
                            lblCampo4.Visible = true;
                            lblCampo5.Text = "Telefono";
                            lblCampo5.Visible = true;
                            lblCampo6.Text = "Correo";
                            lblCampo6.Visible = true;
                            lblCampo7.Text = "Direccíón";
                            lblCampo7.Visible = true;
                            lblCampo8.Text = "Puesto";
                            lblCampo8.Visible = true;
                            lblCampo9.Text = "Status";
                            lblCampo9.Visible = true;
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            txtCampo2.Visible = true;
                            txtCampo3.Visible = true;
                            txtCampo4.Visible = true;
                            txtCampo5.Visible = true;
                            txtCampo6.Visible = true;
                            txtCampo7.Visible = true;
                            txtCampo8.Visible = true;
                            txtCampo9.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Id_Empleado";
                            lblCampo1.Visible = true;
                            lblCampo2.Text = "Nombres";
                            lblCampo2.Visible = true;
                            lblCampo3.Text = "Apellido paterno";
                            lblCampo3.Visible = true;
                            lblCampo4.Text = "Apellido materno";
                            lblCampo4.Visible = true;
                            lblCampo5.Text = "Telefono";
                            lblCampo5.Visible = true;
                            lblCampo6.Text = "Correo";
                            lblCampo6.Visible = true;
                            lblCampo7.Text = "Direccíón";
                            lblCampo7.Visible = true;
                            lblCampo8.Text = "Puesto";
                            lblCampo8.Visible = true;
                            lblCampo9.Text = "Status";
                            lblCampo9.Visible = true;
                            lblCampo10.Text = "Matricula";
                            lblCampo10.Visible = true;
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            txtCampo2.Visible = true;
                            txtCampo3.Visible = true;
                            txtCampo4.Visible = true;
                            txtCampo5.Visible = true;
                            txtCampo6.Visible = true;
                            txtCampo7.Visible = true;
                            txtCampo8.Visible = true;
                            txtCampo9.Visible = true;
                            txtCampo10.Visible = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Nombre";
                            lblCampo1.Visible = true;
                            lblCampo2.Text = "Descripción";
                            lblCampo2.Visible = true;
                            lblCampo3.Text = "Cantidad";
                            lblCampo3.Visible = true;
                            txtCampo1.Visible = true;
                            txtCampo2.Visible = true;
                            txtCampo3.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Id_Producto";
                            lblCampo1.Visible = true;
                            lblCampo2.Text = "Nombre";
                            lblCampo2.Visible = true;
                            lblCampo3.Text = "Descripción";
                            lblCampo3.Visible = true;
                            lblCampo4.Text = "Cantidad";
                            lblCampo4.Visible = true;
                            txtCampo1.Visible = true;
                            txtCampo2.Visible = true;
                            txtCampo3.Visible = true;
                            txtCampo4.Visible = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    break;
            }
        }

        private void FrmInsertarYEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Abrir();
        }
    }
}
