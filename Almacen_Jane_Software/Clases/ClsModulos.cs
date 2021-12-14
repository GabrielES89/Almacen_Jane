using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Almacen_Jane_Software.Clases
{
    class ClsModulos:ClsConexion
    {
        public DataTable Consultar(string Usuario)
        {
            string Comandos = "SELECT T_U.nombre, T_U.contraseña, T_E.status FROM tb_usuarios AS T_U INNER JOIN tb_empleados AS T_E ON T_U.id_empleado = T_E.id_empleado WHERE T_U.nombre = '" + Usuario + "'";
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
                        Comandos = "SELECT T_E.id_empleado as Identificador, T_E.nombres as Nombres, T_E.apellido_p as Apellido_paterno, T_E.apellido_m as Apellido_materno, T_E.telefono as Telefono, T_E.correo as Correo, T_E.direccion as Dirección, T_E.puesto as Puesto, T_S_E.status_empleado as Estatus, T_E.matricula FROM `tb_empleados` as T_E INNER JOIN tb_status_empleado as T_S_E on T_E.status = T_S_E.id_status_empleado ";
                        break;
                    case 1:
                        Comandos = "SELECT Id_Producto as Identificador, Nombre, Marca, Modelo, Parte, Descripcion, Cantidad FROM `tb_productos`";
                        break;
                    case 2:
                        Comandos = "SELECT T_E.id_entrada as Identificador, T_Prod.nombre, T_E.cantidad, T_E.fecha, CONCAT(T_Emple.apellido_p, ' ', T_Emple.apellido_m, ' ', T_Emple.nombres) as Empleado, T_Prov.nombre as Proveedor FROM `tb_entrada` as T_E INNER JOIN tb_proveedor as T_Prov ON T_E.id_proveedor = T_Prov.id_proveedor INNER JOIN tb_empleados as T_Emple ON T_E.id_empleado = T_Emple.id_empleado INNER JOIN tb_productos as T_Prod ON T_E.id_producto = T_Prod.id_producto";
                        break;
                    case 3:
                        Comandos = "SELECT T_S.id_salida as Identificador, T_Prod.nombre, T_S.cantidad, T_S.fecha, CONCAT(T_Emple.apellido_p, ' ', T_Emple.apellido_m, ' ', T_Emple.nombres) as Empleado FROM `tb_salida` as T_S INNER JOIN tb_empleados as T_Emple ON T_S.id_empleado = T_Emple.id_empleado INNER JOIN tb_productos as T_Prod ON T_S.id_producto = T_Prod.id_producto";
                        break;
                    case 4:
                        Comandos = "SELECT T_A.id_almacen as Identificador, T_P.nombre, T_A.codigo_scan, T_A.fecha_registro FROM `tb_almacen` as T_A INNER JOIN tb_productos as T_P ON T_A.id_producto = T_P.id_producto";
                        break;
                    case 5:
                        Comandos = "SELECT T_B_A.id_bitacora_almacen as Identificador, T_P_A.proceso_almacen, T_A.codigo_scan, T_B_A.fecha_bitacora as Fecha, T_E.matricula, T_C.nombre_completo as Cliente, T_B_A.notas FROM `tb_bitacora_almacen` as T_B_A INNER JOIN tb_almacen as T_A ON T_B_A.id_almacen = T_A.id_almacen INNER JOIN tb_proceso_almacen as T_P_A ON T_B_A.id_proceso_almacen = T_P_A.id_proceso_almacen INNER JOIN tb_empleados as T_E ON T_B_A.id_empleado = T_E.id_empleado INNER JOIN tb_clientes as T_C ON T_B_A.id_cliente = T_C.id_cliente";
                        break;
                    case 6:
                        Comandos = "SELECT 	id_proceso_almacen as Identificador, proceso_almacen FROM `tb_proceso_almacen`";
                        break;
                    case 7:
                        Comandos = "SELECT id_proveedor as Identificador, `nombre`, `telefono`, `correo`, `direccion` FROM `tb_proveedor`";
                        break;
                    case 8:
                        Comandos = "SELECT id_cliente as Identificador, `nombre_completo`, `telefono`, `correo_electronico`, `direccion` FROM `tb_clientes`";
                        break;
                    case 9:
                        Comandos = "SELECT T_U.id_usuario as Identificador, T_E.matricula as Matricula, T_U.nombre as Usuario, T_U.contraseña as Contraseña, T_U.privilegios as Privilegios FROM `tb_usuarios` as T_U INNER JOIN tb_empleados as T_E on T_U.id_empleado = T_E.id_empleado";
                        break;
                    case 10:
                        Comandos = "SELECT T_P.Nombre, T_A.Codigo_Scan, T_A.Fecha_Registro FROM `tb_almacen` as T_A INNER JOIN tb_productos as T_P ON T_A.id_producto = T_P.id_producto";
                        break;
                    case 11:
                        Comandos = "SELECT * FROM `tb_status_empleado`";
                        break;
                    case 12:
                        Comandos = "SELECT id_empleado, CONCAT(apellido_p, ' ', apellido_m, ' ', nombres) as Empleado FROM tb_empleados GROUP BY CONCAT(apellido_p, ' ', apellido_m, ' ', nombres)";
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
                Comandos = "SELECT id_proveedor, nombre FROM `tb_proveedor`";
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
                Comandos = "SELECT T_Prod.nombre, T_Prod.marca, T_Prod.modelo, T_Prod.parte FROM tb_proveedor as T_Prov INNER JOIN tb_entrada as T_Entr on T_Prov.id_proveedor = T_Entr.id_proveedor INNER JOIN tb_productos as T_Prod on T_Entr.id_producto = T_Prod.id_producto WHERE T_Prov.id_proveedor = '" + Id_Productos +"'";
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
            string Comandos = "Select T_U.nombre, T_E.matricula, T_E.status, T_E.id_empleado FROM tb_empleados as T_E LEFT JOIN tb_usuarios as T_U ON T_E.id_empleado = T_U.id_empleado WHERE T_E.matricula = '" + Matricula + "'";
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
                string Comandos = "INSERT INTO `tb_usuarios`(`nombre`, `contraseña`, `privilegios`, `id_empleado`) VALUES ('" + Usuario + "','" + Contraseña + "','Basico','" + Id_Empleado + "')";
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
