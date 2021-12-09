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
        int x, y, Fila;
        DataTable Tabla = new DataTable();
        public FrmInsertarYEditar(int x, int y, DataTable Tabla, int Fila)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
            this.Tabla = Tabla;
            this.Fila = Fila;
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
                case 2:
                    Cambios(x, y);
                    break;
                case 3:
                    Cambios(x, y);
                    break;
                case 4:
                    Cambios(x, y);
                    break;
                case 5:
                    Cambios(x, y);
                    break;
                case 6:
                    Cambios(x, y);
                    break;
                case 7:
                    Cambios(x, y);
                    break;
                case 8:
                    Cambios(x, y);
                    break;
                case 9:
                    Cambios(x, y);
                    break;
                default:
                    break;
            }
        }
        ClsModulos ObjModulos = new ClsModulos();
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
            cbCampo9.Visible = false;
            btnInsertar.Visible = true;
            PanelCampos.Visible = true;
            if (Mod0Ins == 1)
            {
                btnInsertar.Text = "Actualizar";
            }
            switch (Aux)
            {
                case 0:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Matricula";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
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
                            txtCampo1.Visible = true;
                            txtCampo1.Text = Tabla.Rows[Fila]["Identificador"].ToString();
                            txtCampo1.Enabled = false;
                            lblCampo2.Text = "Nombres";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            txtCampo2.Text = Tabla.Rows[Fila]["Nombres"].ToString();
                            lblCampo3.Text = "Apellido paterno";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            txtCampo3.Text = Tabla.Rows[Fila]["Apellido_paterno"].ToString();
                            lblCampo4.Text = "Apellido materno";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            txtCampo4.Text = Tabla.Rows[Fila]["Apellido_materno"].ToString();
                            lblCampo5.Text = "Telefono";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            txtCampo5.Text = Tabla.Rows[Fila]["Telefono"].ToString();
                            lblCampo6.Text = "Correo";
                            lblCampo6.Visible = true;
                            txtCampo6.Visible = true;
                            txtCampo6.Text = Tabla.Rows[Fila]["Correo"].ToString();
                            lblCampo7.Text = "Direccíón";
                            lblCampo7.Visible = true;
                            txtCampo7.Visible = true;
                            txtCampo7.Text = Tabla.Rows[Fila]["Dirección"].ToString();
                            lblCampo8.Text = "Puesto";
                            lblCampo8.Visible = true;
                            txtCampo8.Visible = true;
                            txtCampo8.Text = Tabla.Rows[Fila]["Puesto"].ToString();
                            lblCampo9.Text = "Status";
                            lblCampo9.Visible = true;
                            cbCampo9.Visible = true;
                            DataTable TablaStatusEmpleados = ObjModulos.Consultas(11);
                            for (int i = 0; i < TablaStatusEmpleados.Rows.Count; i++)
                            {
                                cbCampo9.Items.Add(TablaStatusEmpleados.Rows[i][0].ToString());
                            }
                            cbCampo9.Text = Tabla.Rows[Fila]["Estatus"].ToString();
                            lblCampo10.Text = "Matricula";
                            lblCampo10.Visible = true;
                            txtCampo10.Visible = true;
                            txtCampo10.Text = Tabla.Rows[Fila]["Matricula"].ToString();
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
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Marca";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Modelo";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Parte";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Descripción";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            lblCampo6.Text = "Cantidad";
                            lblCampo6.Visible = true;
                            txtCampo6.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Id_Producto";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            txtCampo1.Text = Tabla.Rows[Fila][0].ToString();
                            txtCampo1.Enabled = false;
                            lblCampo2.Text = "Nombre";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            txtCampo2.Text = Tabla.Rows[Fila][1].ToString();
                            lblCampo3.Text = "Descripción";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            txtCampo3.Text = Tabla.Rows[Fila][2].ToString();
                            lblCampo4.Text = "Cantidad";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            txtCampo4.Text = Tabla.Rows[Fila][3].ToString();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Producto";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Cantidad";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Fecha";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Empleado";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Proveedor";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Producto";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Cantidad";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Fecha";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Empleado";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            lblCampo6.Text = "Proveedor";
                            lblCampo6.Visible = true;
                            txtCampo6.Visible = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Producto";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Cantidad";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Fecha";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Empleado";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Producto";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Cantidad";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Fecha";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Empleado";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Producto";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Codigo scan";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Fecha";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Producto";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Codigo scan";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Fecha";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            break;
                    }
                    break;
                case 5:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Proceso";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Codigo scan";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Fecha";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Matricula";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Cliente";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            lblCampo6.Text = "Notas";
                            lblCampo6.Visible = true;
                            txtCampo6.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Proceso";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Codigo scan";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Fecha";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Matricula";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            lblCampo6.Text = "Cliente";
                            lblCampo6.Visible = true;
                            txtCampo6.Visible = true;
                            lblCampo7.Text = "Notas";
                            lblCampo7.Visible = true;
                            txtCampo7.Visible = true;
                            break;
                    }
                    break;
                case 6:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Proceso";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Proceso";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            break;
                    }
                    break;
                case 7:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Nombre";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Telefono";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Correo";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Dirección";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Nombre";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Telefono";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Correo";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Dirección";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            break;
                    }
                    break;
                case 8:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Nombre";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Telefono";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Correo";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Dirección";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Nombre";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Telefono";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Correo";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Dirección";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            break;
                    }
                    break;
                case 9:
                    switch (Mod0Ins)
                    {
                        case 0:
                            lblCampo1.Text = "Matricula";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Usuario";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Contraseña";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Privilegios";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            break;
                        case 1:
                            lblCampo1.Text = "Identificador";
                            lblCampo1.Visible = true;
                            txtCampo1.Visible = true;
                            lblCampo2.Text = "Usuario";
                            lblCampo2.Visible = true;
                            txtCampo2.Visible = true;
                            lblCampo3.Text = "Contraseña";
                            lblCampo3.Visible = true;
                            txtCampo3.Visible = true;
                            lblCampo4.Text = "Privilegios";
                            lblCampo4.Visible = true;
                            txtCampo4.Visible = true;
                            lblCampo5.Text = "Matricula";
                            lblCampo5.Visible = true;
                            txtCampo5.Visible = true;
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void FrmInsertarYEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Abrir();
        }
    }
}
