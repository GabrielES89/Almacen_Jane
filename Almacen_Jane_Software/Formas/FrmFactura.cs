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
    public partial class FrmFactura : Form
    {
        string Prov = "";
        string NoFac = "";
        string Nombre = "";
        string Marca = "";
        string Modelo = "";
        string Parte = "";
        string Cantidad = "";
        string P_Unitario = "";
        ClsModulos ObjModulos = new ClsModulos();
        DataTable Tabla_Proveedor = new DataTable();
        DataTable Tabla_Nombre = new DataTable();
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            cbProveedor.Text = "Proveedor";
            cbProveedor.ForeColor = Color.Gray;
            txtNoFactura.Text = "No. Factura";
            txtNoFactura.ForeColor = Color.Gray;
            cbNombre.Text = "Nombre";
            cbNombre.ForeColor = Color.Gray;
            txtMarca.Text = "Marca";
            txtMarca.ForeColor = Color.Gray;
            txtModelo.Text = "Modelo";
            txtModelo.ForeColor = Color.Gray;
            txtParte.Text = "Parte";
            txtParte.ForeColor = Color.Gray;
            txtCantidad.Text = "Cantidad";
            txtCantidad.ForeColor = Color.Gray;
            txtP_Unitario.Text = "P. Unitario";
            txtP_Unitario.ForeColor = Color.Gray;
            Tabla_Proveedor = ObjModulos.ConsultarProveedor();
            for (int i = 0; i < Tabla_Proveedor.Rows.Count; i++)
            {
                cbProveedor.Items.Add(Tabla_Proveedor.Rows[i][1].ToString());
            }
        }

        private void cbProveedor_Leave(object sender, EventArgs e)
        {
            Prov = cbProveedor.Text;
            if (Prov.Equals("Proveedor"))
            {
                cbProveedor.Text = "Proveedor";
                cbProveedor.ForeColor = Color.Gray;
            }
            else
            {
                if (Prov.Equals(""))
                {
                    cbProveedor.Text = "Proveedor";
                    cbProveedor.ForeColor = Color.Gray;
                }
                else
                {
                    cbProveedor.Text = Prov;
                    cbProveedor.ForeColor = Color.Black;
                }
            }
        }

        private void cbProveedor_Enter(object sender, EventArgs e)
        {
        }

        private void txtNoFactura_Enter(object sender, EventArgs e)
        {

        }

        private void txtNoFactura_Leave(object sender, EventArgs e)
        {
            NoFac = txtNoFactura.Text;
            if (NoFac.Equals("No. Factura"))
            {
                txtNoFactura.Text = "No. Factura";
                txtNoFactura.ForeColor = Color.Gray;
            }
            else
            {
                if (NoFac.Equals(""))
                {
                    txtNoFactura.Text = "No. Factura";
                    txtNoFactura.ForeColor = Color.Gray;
                }
                else
                {
                    txtNoFactura.Text = NoFac;
                    txtNoFactura.ForeColor = Color.Black;
                }
            }
        }

        private void cbNombre_Leave(object sender, EventArgs e)
        {
            Nombre = cbNombre.Text;
            if (Nombre.Equals("Nombre"))
            {
                cbNombre.Text = "Nombre";
                cbNombre.ForeColor = Color.Gray;
            }
            else
            {
                if (Nombre.Equals(""))
                {
                    cbNombre.Text = "Nombre";
                    cbNombre.ForeColor = Color.Gray;
                }
                else
                {
                    cbNombre.Text = Nombre;
                    cbNombre.ForeColor = Color.Black;
                }
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            Marca = txtMarca.Text;
            if (Marca.Equals("Marca"))
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.Gray;
            }
            else
            {
                if (Marca.Equals(""))
                {
                    txtMarca.Text = "Marca";
                    txtMarca.ForeColor = Color.Gray;
                }
                else
                {
                    txtMarca.Text = Marca;
                    txtMarca.ForeColor = Color.Black;
                }
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            Modelo = txtModelo.Text;
            if (Modelo.Equals("Modelo"))
            {
                txtModelo.Text = "Modelo";
                txtModelo.ForeColor = Color.Gray;
            }
            else
            {
                if (Modelo.Equals(""))
                {
                    txtModelo.Text = "Modelo";
                    txtModelo.ForeColor = Color.Gray;
                }
                else
                {
                    txtModelo.Text = Modelo;
                    txtModelo.ForeColor = Color.Black;
                }
            }
        }

        private void txtParte_Leave(object sender, EventArgs e)
        {
            Parte = txtParte.Text;
            if (Parte.Equals("Parte"))
            {
                txtParte.Text = "Parte";
                txtParte.ForeColor = Color.Gray;
            }
            else
            {
                if (Parte.Equals(""))
                {
                    txtParte.Text = "Parte";
                    txtParte.ForeColor = Color.Gray;
                }
                else
                {
                    txtParte.Text = Parte;
                    txtParte.ForeColor = Color.Black;
                }
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            Cantidad = txtCantidad.Text;
            if (Cantidad.Equals("Cantidad"))
            {
                txtCantidad.Text = "Cantidad";
                txtCantidad.ForeColor = Color.Gray;
            }
            else
            {
                if (Cantidad.Equals(""))
                {
                    txtCantidad.Text = "Cantidad";
                    txtCantidad.ForeColor = Color.Gray;
                }
                else
                {
                    txtCantidad.Text = Cantidad;
                    txtCantidad.ForeColor = Color.Black;
                }
            }
        }

        private void txtP_Unitario_Leave(object sender, EventArgs e)
        {
            P_Unitario = txtP_Unitario.Text;
            if (P_Unitario.Equals("P. Unitario"))
            {
                txtP_Unitario.Text = "P. Unitario";
                txtP_Unitario.ForeColor = Color.Gray;
            }
            else
            {
                if (P_Unitario.Equals(""))
                {
                    txtP_Unitario.Text = "P. Unitario";
                    txtP_Unitario.ForeColor = Color.Gray;
                }
                else
                {
                    txtP_Unitario.Text = P_Unitario;
                    txtP_Unitario.ForeColor = Color.Black;
                }
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tabla_Nombre = ObjModulos.ConsultarProductos(Tabla_Proveedor.Rows[cbProveedor.SelectedIndex][0].ToString());
            for (int i = 0; i < Tabla_Nombre.Rows.Count; i++)
            {
                cbNombre.Items.Add(Tabla_Nombre.Rows[i][0].ToString());
            }
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabla_Nombre.Rows.Count; i++)
            {
                string pal = Tabla_Nombre.Rows[i][0].ToString();
                if (Tabla_Nombre.Rows[i][0].ToString() == cbNombre.Text)
                {
                    txtMarca.Text = Tabla_Nombre.Rows[i][1].ToString();
                    txtModelo.Text = Tabla_Nombre.Rows[i][2].ToString();
                    txtParte.Text = Tabla_Nombre.Rows[i][3].ToString();
                }
            }
        }
        double Subtotal = 0;
        double IVA;
        double Total;
        double Importe = 0;
        private void lklblAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Importe = Convert.ToDouble(txtP_Unitario.Text) * Convert.ToDouble(txtCantidad.Text);
            dataGridView1.Rows.Add(cbNombre.Text, txtMarca.Text, txtModelo.Text, txtParte.Text,txtCantidad.Text, Convert.ToDouble(txtP_Unitario.Text).ToString("N2"), Importe);
            Subtotal += Importe;
            lblSubtotal.Text = "SUBTOTAL " + Subtotal.ToString("N2");
            IVA = Subtotal * 0.16;
            lblIVA.Text = "IVA " + IVA.ToString("N2");
            Total = IVA + Subtotal;
            lblTotal.Text =  "TOTAL " + Total.ToString("N2");
        }

        private void txtP_Unitario_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtP_Unitario.Text == "P. Unitario")
            {
                txtP_Unitario.SelectAll();
            }
        }

        private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.SelectAll();
            }
        }

        private void txtParte_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtParte.Text == "Parte")
            {
                txtParte.SelectAll();
            }
        }

        private void txtModelo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtModelo.Text == "Modelo")
            {
                txtModelo.SelectAll();
            }
        }

        private void txtMarca_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.SelectAll();
            }
        }

        private void txtNoFactura_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNoFactura.Text == "No. Factura")
            {
                txtNoFactura.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ObjFecha = DateTime.Now;
            string Fecha = ObjFecha.ToString("yyyy-MM-dd HH:mm:ss");
            ObjModulos.InsertarFactura(txtNoFactura.Text, Fecha, Subtotal, IVA, Total);
            string Id_Factura = ObjModulos.Id_Factura();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ObjModulos.InsertarDetalleFactura(Id_Factura, dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[3, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), dataGridView1[5, i].Value.ToString(), dataGridView1[4, i].Value.ToString(), dataGridView1[6, i].Value.ToString());
            }
            dataGridView1.Rows.Clear();
            lblSubtotal.Text = "";
            lblIVA.Text = "";
            lblTotal.Text = "";
            Subtotal = 0;
            IVA = 0;
            Total = 0;
        }
    }
}
