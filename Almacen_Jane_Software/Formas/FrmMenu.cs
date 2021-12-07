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
    public partial class FrmMenu : Form
    {
        ClsModulos ClaseModulos = new ClsModulos();
        int x = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Leave(object sender, EventArgs e)
        {

        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInicio ObjInicio = new FrmInicio();
            ObjInicio.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }
        public void Consltar()
        {
            this.Invoke(new Action(() => dataGridView1.Visible = true));
            switch (x)
            {
                case 0:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 1:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 2:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 3:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 4:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 5:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 6:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 8:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 9:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                case 10:
                    this.Invoke(new Action(() => dataGridView1.DataSource = ClaseModulos.Consultas(x)));
                    break;
                default:
                    break;
            }
            this.Invoke(new Action(() => dataGridView1.Columns["Editar"].DisplayIndex = dataGridView1.Columns.Count - 1));
        }

        private void btnDInsertar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDEditar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            x = 5;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            x = 3;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            x = 4;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }

        private void btnBitacoras_Click(object sender, EventArgs e)
        {
            x = 6;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            x = 8;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            x = 9;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            x = 10;
            Thread Hilo = new Thread(Consltar);
            Hilo.Start();
        }
        public void Abriri()
        {
            this.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (e.RowIndex == i && e.ColumnIndex == 0)
                {
                    Llamar(1);
                }
            }
        }
        public void Llamar(int y)
        {
            FrmInsertarYEditar ObjVentanaIYE = new FrmInsertarYEditar(x, y);
            ObjVentanaIYE.Abrir = Abriri;
            ObjVentanaIYE.Show();
            this.Enabled = false;
        }
    }
}
