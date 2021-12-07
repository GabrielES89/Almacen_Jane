using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Almacen_Jane_Software
{
    class ClsModulos:ClsConexion
    {
        public DataTable Consultar(string Usuario)
        {
            string Comandos = "SELECT T_U.Nombre, T_U.Contraseña, T_E.Status FROM tb_usuarios AS T_U INNER JOIN tb_empleados AS T_E ON T_U.Id_Empleado = T_E.Id_Empleado WHERE T_U.Nombre = '" + Usuario + "'";
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Contraseña");
            Tabla.Columns.Add("Status");
            MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
            Comando.CommandTimeout = 60;
            MySqlDataReader Reader;
            try
            {
                Databaseconexion.Open();
                Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Tabla.Rows.Add(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2));

                    }
                }
                Databaseconexion.Close();
                return Tabla;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable Consultas(int Query)
        {
            DataTable Tabla = new DataTable();
            string Comandos = "";
            try
            {
                switch (Query)
                {
                    case 0:
                        Comandos = "SELECT Nombres, Apellido_P, Apellido_M, Telefono, Correo, Direccion, Puesto, Status, Matricula FROM `empleados`";
                        break;
                    case 1:
                        Comandos = "SELECT Nombre, Descripcion, Cantidad FROM `productos`";
                        break;
                    case 2:
                        Comandos = "SELECT T_P.Nombre, T_A.Codigo_Scan, T_A.Fecha_Registro FROM `tb_almacen` as T_A INNER JOIN productos as T_P ON T_A.Id_Producto = T_P.Id_Producto";
                        break;
                    case 3:
                        Comandos = "SELECT T_Prod.Nombre, T_E.Cantidad, T_E.Fecha, CONCAT(T_Emple.Apellido_P, ' ', T_Emple.Apellido_M, ' ', T_Emple.Nombres) as Empleado, T_Prov.Nombre as Proveedor FROM `entrada` as T_E INNER JOIN proveedor as T_Prov ON T_E.Id_Proveedor = T_Prov.Id_Proveedor INNER JOIN empleados as T_Emple ON T_E.Id_Empleado = T_Emple.Id_Empleado INNER JOIN productos as T_Prod ON T_E.Id_Producto = T_Prod.Id_Producto";
                        break;
                    case 4:
                        Comandos = "SELECT T_Prod.Nombre, T_S.Cantidad, T_S.Fecha, CONCAT(T_Emple.Apellido_P, ' ', T_Emple.Apellido_M, ' ', T_Emple.Nombres) as Empleado FROM `Salida` as T_S INNER JOIN empleados as T_Emple ON T_S.Id_Empleado = T_Emple.Id_Empleado INNER JOIN productos as T_Prod ON T_S.Id_Producto = T_Prod.Id_Producto";
                        break;
                    case 5:
                        Comandos = "SELECT T_P.Nombre, T_A.Codigo_Scan, T_A.Fecha_Registro FROM `tb_almacen` as T_A INNER JOIN productos as T_P ON T_A.Id_Producto = T_P.Id_Producto";
                        break;
                    case 6:
                        Comandos = "SELECT T_P_A.Proceso_almacen, T_A.Codigo_Scan, T_B_A.Fecha_Bitacora as Fecha, T_E.Matricula, T_C.Nombre_Completo as Cliente, T_B_A.Notas FROM `tb_bitacora_almacen` as T_B_A INNER JOIN tb_almacen as T_A ON T_B_A.Id_Almacen = T_A.Id_Almacen INNER JOIN tb_proceso_almacen as T_P_A ON T_B_A.Id_Proceso_Almacen = T_P_A.Id_Proceso_Almacen INNER JOIN empleados as T_E ON T_B_A.Id_Empleado = T_E.Id_Empleado INNER JOIN tb_clientes as T_C ON T_B_A.Id_Cliente = T_C.Id_Cliente";
                        break;
                    case 8:
                        Comandos = "SELECT `Nombre`, `Telefono`, `Correo`, `Direccion` FROM `proveedor`";
                        break;
                    case 9:
                        Comandos = "SELECT `Nombre_Completo`, `Telefono`, `Correo_Electronico`, `Direccion` FROM `tb_clientes`";
                        break;
                    case 10:
                        Comandos = "SELECT `Nombre`, `Privilegios`FROM `usuarios`";
                        break;
                    default:
                        break;
                }
                MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
                MySqlDataAdapter Adaptador = new MySqlDataAdapter(Comando);
                Adaptador.Fill(Tabla);
            }
            catch (Exception)
            {
            }
            return Tabla;
        }
        public DataTable ConsultarProveedor()
        {
            DataTable Tabla = new DataTable();
            string Comandos = "";
            try
            {
                Comandos = "SELECT Id_Proveedor, Nombre FROM `proveedor`";
                MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
                MySqlDataAdapter Adaptador = new MySqlDataAdapter(Comando);
                Adaptador.Fill(Tabla);
            }
            catch (Exception)
            {

            }
            return Tabla;
        }
        public DataTable ConsultarProductos(string Id_Productos)
        {
            DataTable Tabla = new DataTable();
            string Comandos = "";
            try
            {
                Comandos = "SELECT T_Prod.Nombre, T_Prod.Marca, T_Prod.Modelo, T_Prod.Parte FROM proveedor as T_Prov INNER JOIN entrada as T_Entr on T_Prov.Id_Proveedor = T_Entr.Id_Proveedor INNER JOIN productos as T_Prod on T_Entr.Id_Producto = T_Prod.Id_Producto WHERE T_Prov.Id_Proveedor = '" + Id_Productos +"'";
                MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
                MySqlDataAdapter Adaptador = new MySqlDataAdapter(Comando);
                Adaptador.Fill(Tabla);
            }
            catch (Exception)
            {

            }
            return Tabla;
        }
        public DataTable ConsultarMatricula(string Matricula)
        {
            string Comandos = "Select T_U.Nombre, T_E.Matricula, T_E.Status, T_E.Id_Empleado FROM empleados as T_E LEFT JOIN usuarios as T_U ON T_E.Id_Empleado = T_U.Id_Empleado WHERE T_E.Matricula = '" + Matricula + "'";
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Matricula");
            Tabla.Columns.Add("Status");
            Tabla.Columns.Add("Id_Empleado");
            MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
            Comando.CommandTimeout = 60;
            MySqlDataReader Reader;
            try
            {
                Databaseconexion.Open();
                Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        string Uno = Reader.GetValue(0).ToString(), Dos = Reader.GetValue(1).ToString(), Tres = Reader.GetValue(2).ToString();
                        Tabla.Rows.Add(Reader.GetValue(0).ToString(), Reader.GetValue(1).ToString(), Reader.GetValue(2).ToString(), Reader.GetValue(3).ToString());

                    }
                }
                Databaseconexion.Close();
                return Tabla;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void InsertarFactura(string Folio_Factura, string Fecha, double SubTotal, double IVA, double Total)
        {
            string Comandos = "INSERT INTO `tb_factura_almacen`(`folio_factura`, `fecha_compra`, `subtotal`, `iva`, `total`) VALUES ('" + Folio_Factura + "','" + Fecha + "','" + SubTotal + "','" + IVA + "','" + Total + "')";
            MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
            Comando.CommandTimeout = 60;
            MySqlDataReader Reader;
            Databaseconexion.Open();
            Reader = Comando.ExecuteReader();
            Databaseconexion.Close();
        }
        public void InsertarDetalleFactura(string Id_Factura_Almacen, string Nombre, string Marca, string Parte, string Modelo, string Precio_Unitario, string Cantidad, string Importe)
        {
            string Comandos = "INSERT INTO `tb_factura_detalle_almacen`(`id_factura_almacen`, `nombre`, `marca`, `parte`, `modelo`, `precio_unitario`, `cantidad`, `importe`) VALUES ('" + Id_Factura_Almacen + "','" + Nombre + "','" + Marca + "','" + Parte + "','" + Modelo + "','" + Precio_Unitario + "','" + Cantidad + "','" + Importe + "')";
            MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
            Comando.CommandTimeout = 60;
            MySqlDataReader Reader;
            Databaseconexion.Open();
            Reader = Comando.ExecuteReader();
            Databaseconexion.Close();
        }
        public string Id_Factura()
        {
            string Comandos = "SELECT id_factura_almacen FROM `tb_factura_almacen` ORDER BY id_factura_almacen DESC limit 1";
            MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
            Comando.CommandTimeout = 60;
            MySqlDataReader Reader;
            Databaseconexion.Open();
            Reader = Comando.ExecuteReader();
            Reader.Read();
            string ID = Reader.GetValue(0).ToString();
            Databaseconexion.Close();
            return ID;
        }
        public string CrearUsuario(string Usuario, string Contraseña, int Id_Empleado)
        {
            try
            {
                string Comandos = "INSERT INTO `usuarios`(`Nombre`, `Contraseña`, `Privilegios`, `Id_Empleado`) VALUES ('" + Usuario + "','" + Contraseña + "','Basico','" + Id_Empleado + "')";
                MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
                Comando.CommandTimeout = 60;
                MySqlDataReader Reader;
                Databaseconexion.Open();
                Reader = Comando.ExecuteReader();
                Databaseconexion.Close();
                return "Usuario registrado";
            }
            catch (Exception)
            {
                return "Algo salio mal revise sus datos por favor";
            }
        }
    }
}
