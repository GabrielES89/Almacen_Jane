using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Almacen_Jane_Software
{
    class ClsCorreo:ClsConexion
    {
        public string MandarCorreo(string Matricula)
        {
            System.Net.Mail.MailMessage ObjMensaje = new System.Net.Mail.MailMessage();
            ObjMensaje.To.Add("GabrielEBV89@gmail.com");
            ObjMensaje.Subject = "Codigo contraseña";
            ObjMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            ObjMensaje.Bcc.Add("GabrielEBV89@gmail.com");

            string Codico = Codigo();
            ObjMensaje.Body = "Codigo de recuperación: " + Codico;
            MandarCodigo(Codico, Matricula);
            ObjMensaje.BodyEncoding = System.Text.Encoding.UTF8;
            ObjMensaje.IsBodyHtml = true;
            ObjMensaje.From = new System.Net.Mail.MailAddress("GabrielEBV89@gmail.com");

            System.Net.Mail.SmtpClient Cliente = new System.Net.Mail.SmtpClient();
            Cliente.Credentials = new System.Net.NetworkCredential("GabrielEBV89@gmail.com", "Good-Gabriel");
            Cliente.Port = 587;
            Cliente.EnableSsl = true;

            Cliente.Host = "smtp.gmail.com";

            try
            {
                Cliente.Send(ObjMensaje);
                return "Correo enviado";
            }
            catch (Exception)
            {
                return "Error al enviar";
            }
        }
        public string Codigo()
        {
            Random ObjRandom = new Random();
            string Resultado = "";
            for (int i = 0; i < 6; i++)
            {
                int NumOLet = ObjRandom.Next(0, 2);
                if (NumOLet == 1)
                {
                    Resultado += ObjRandom.Next(9);
                }
                else
                {
                    int aux = ObjRandom.Next(65, 123);
                    while (aux > 90 && aux < 97)
                    {
                        aux = ObjRandom.Next(65, 123);
                    }
                    Resultado += Convert.ToChar(aux);
                }
            }
            return Resultado;
        }
        public string MandarCodigo(string Codigo, string Matricula)
        {
            try
            {
                string Comandos = "UPDATE `empleados` SET `Codigo_Recuperar` = '" + Codigo + "' WHERE Matricula = '" + Matricula + "'";
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
        public string MandarCodigo(string Codigo, int Id_Empleado)
        {
            try
            {
                string Comandos = "UPDATE `empleados` SET `Codigo_Recuperar` = '" + Codigo + "' WHERE Id_Empleado = '" + Id_Empleado + "'";
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
        public string CambiarContraseña(string Contraseña, int Id_Empleado)
        {
            try
            {
                string Comandos = "UPDATE `usuarios` SET `Contraseña` = '" + Contraseña + "' WHERE Id_Empleado = '" + Id_Empleado + "'";
                MySqlCommand Comando = new MySqlCommand(Comandos, Databaseconexion);
                Comando.CommandTimeout = 60;
                MySqlDataReader Reader;
                Databaseconexion.Open();
                Reader = Comando.ExecuteReader();
                Databaseconexion.Close();
                return "Contraseña cambiada";
            }
            catch (Exception)
            {
                return "Algo salio mal revise sus datos por favor";
            }
        }
        public DataTable ConsultarCodigo(int Id_Empleado)
        {
            string Comandos = "Select Id_Empleado, Codigo_Recuperar FROM empleados WHERE Id_Empleado = '" + Id_Empleado + "'";
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("Id_Empleado");
            Tabla.Columns.Add("Codigo");
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
                        Tabla.Rows.Add(Reader.GetValue(0).ToString(), Reader.GetValue(1).ToString());

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
    }
}
